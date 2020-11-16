# DeliExampleMod
This is an example mod for the Deli mod loading framework.
This example demonstrates the basic usage of the mod manifest, entrypoint, asset readers and asset loaders.

This repository also includes a PowerShell post-build action to package the mod into a valid archive, however it relies on PowerShell 7 or greater since the `Compress-Archive` cmdlet in PS5.1 does not produce compatible archives.

You'll find that creating code plugins in this format is extremely similar to BepInEx. The same loading method is used and Deli mods are passed BepInEx config and log sources. If you're porting a mod from BepInEx to Deli it shouldn't require many logical changes.