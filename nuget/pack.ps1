$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\src\FizzBuzzer\bin\Release\FizzBuzzer.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\FizzBuzzer.nuspec)
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\FizzBuzzer.compiled.nuspec

& $root\nuget\NuGet.exe pack $root\nuget\FizzBuzzer.compiled.nuspec -Symbols
