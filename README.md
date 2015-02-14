PortableLog
===========

*Version 2 is underway. [Read more](https://github.com/anjdreas/PortableLog/wiki/PortableLog-v2) or get the [pre-release nuget](https://www.nuget.org/packages/PortableLog.Core/2.0.0-alpha2).*

--

Portable logging interface and adapters to the most common logging implementations. Heavily based on [common-logging](https://github.com/net-commons/common-logging), but with a couple of improvements:
* Move exception parameter first, better readability with ```params object[] args```
* ILogEx adds InfoEx, WarnEx and similar with [[CallingMemberName]](http://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx) to inject the method name
* [PortableLog.Core nuget](https://www.nuget.org/packages/PortableLog.Core) with ILog, ILogEx and ILogExFactory to pass in to log producers, such as the portable view models of a cross-platform app
* [PortableLog.NLog nuget](https://www.nuget.org/packages/PortableLog.NLog) with NLog adapter, to hook up in WPF, WinForms and WinStore. To my knowledge NLog does not yet work with Xamarin for iOS and Android, but adapters for other logging frameworks can easily be added. Pull requests are welcome.

Example
==
```csharp
public class MyClass
{
  private readonly ILogEx _log;
  
  public MyClass(ILogExFactory logFactory)
  {
    _log = logFactory.GetLogger<MyClass>();
  }
  
  public void MyMethod()
  {
    _log.TraceEx("On enter.");
    
    _log.Trace("MyMethod(): Can always log the old way, or skip logging the method name at all.");
    
    _log.InfoEx("Format arguments with 'params' keyword does not work too well ");
    _log.InfoEx("with [CallerMemberName], so you need to ");
    _log.InfoFormatEx("specify the args {0} {1}.", new object[]{"like", "this"});
    
    _log.InfoEx("That means you lose ReSharper intellisense on those args.");
    _log.InfoEx(string.Format("But you can always log like this if {0} prefer,", "you"));
    _log.InfoEx("or with an extension method for a {0} syntax.".With("shorter"));
    
    try 
    {
      // ...
    }
    catch (Exception e)
    {
      _log.ErrorFormat(e, "Exception arg is now {0} and not confused with format arguments.", "first");
    }
    
    _log.TraceEx("On exit.");
  }
}
```

Yields:
```
  MyClass.MyMethod: On enter.
  MyClass.MyMethod(): Can always log the old way, or skip logging the method name at all.
  MyClass.MyMethod: Format arguments with 'params' keyword does not work too well
  MyClass.MyMethod: with [CallerMemberName], so you need to 
  MyClass.MyMethod: specify the args like this.
  MyClass.MyMethod: That means you lose ReSharper intellisense on those args.
  MyClass.MyMethod: But you can always log like this if you prefer,
  MyClass.MyMethod: or with an extension method for a shorter syntax.
  MyClass.MyMethod: On exit.
```

StringExtensions
==
Copy this class to your project to use the With() extension. The StringFormatMethod attributes are just intellisense hints to the ReSharper plugin and can be removed.
```csharp
internal static class StringExtensions
{
    [JetBrains.Annotations.StringFormatMethod("format")]
    public static string With(this string format, IFormatProvider provider, params object[] args)
    {
        return string.Format(provider, format, args);
    }

    [JetBrains.Annotations.StringFormatMethod("format")]
    public static string With(this string format, params object[] args)
    {
        return string.Format(format, args);
    }
}
```
