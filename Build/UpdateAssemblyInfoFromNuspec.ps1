$updateAssemblyInfoScriptFile = "$PSScriptRoot\UpdateAssemblyInfo.ps1"

function UpdateAssemblyInfoFilesByNuspec([string] $nuspecFilePath, [string] $searchDir) {

    [ xml ]$nuspecXml = Get-Content -Path $nuspecFilePath

    # Split "1.2.3-alpha" into ["1.2.3", "alpha"]
    # Split "1.2.3" into ["1.2.3"]
    $semVerVersionParts = $nuspecXml.package.metadata.version.Split('-')
    $currentVersion = [Version]::Parse($semVerVersionParts[0])
    $postfix = if ($semVerVersionParts.Length -eq 2) { "-" + $semVerVersionParts[1]} else { "" }

    $major = $currentVersion.Major
    $minor = $currentVersion.Minor
    $patch = $currentVersion.Build 

    Invoke-Expression "$updateAssemblyInfoScriptFile $currentVersion $searchDir"
}

try {
    Write-Host "Updating assembly info files from nuspec."
    UpdateAssemblyInfoFilesByNuspec "$PSScriptRoot\PortableLog.Core.nuspec" "$PSScriptRoot\..\Src\PortableLog.Core"
    UpdateAssemblyInfoFilesByNuspec "$PSScriptRoot\PortableLog.NLog.nuspec" "$PSScriptRoot\..\Src\PortableLog.NLog"
}
catch {    
    $myError = $_.Exception.ToString()

    Write-Error "##teamcity[buildStatus text='Failed to update buildnumber: `n$myError' ]"
    exit 1
}