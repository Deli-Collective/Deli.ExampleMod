# Unpack the arguments
$dir = $args[0]
$targetName = $args[1]

# The Compress-Archive cmdlet produces BROKEN zip archives on Powershell 5.1. Make sure we're running PS7
if ($PSVersionTable.PSVersion.Major -lt 7) {
    # If we have a newer version installed, run it again with that.
    if (Get-Command pwsh.exe -errorAction SilentlyContinue) {
        pwsh.exe .\BuildMod.ps1 $dir $targetName
    } else {
        Write-Output "Powershell 7 is not installed."
    }
} else {
    # Set our directory to the build directory
    Set-Location $dir
    
    # Setup the compression arguments
    $compress = @{
    # Include the manifest, compiled DLL and resources in the archive
        Path = "manifest.json", "$($targetName).dll", "Resources\"
        CompressionLevel = "Optimal"
        DestinationPath = "$($targetName).zip"
    }

    # Compress and overwrite the previous build
    Compress-Archive -Force @compress
}