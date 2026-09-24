# Tylevo HeliCrash

**Core v2.6.0 targets solo SPT 4.1.5.** This is the standalone `Tylevo/HeliCrash-SPT` project, using the plugin ID `com.tylevo.helicrash`. The Fika Sync add-on has not been ported for this release; this Core build refuses to load when Fika is detected. Bosses, guards, and their AI are planned separately and are not included.

## What it does

The mod places a UH-60 Blackhawk crash site at a random configured location after raid loading. The helicopter has smoke, interactive doors, a navigation obstacle, and an optional loot crate. The crate uses SPT's airdrop loot generation, so changes to that loot pool also affect the crate. The default crash chance is 10%; crash and loot chances are configurable from 0% to 100%. `HeliCrashLocations.json` contains the map locations and can be edited without changing its existing format.

## Install

1. Use a **solo SPT 4.1.5** installation.
2. If Arys Reloaded is already installed, remove its `BepInEx/plugins/SamSWAT.HeliCrash.ArysReloaded/` folder before installing Tylevo HeliCrash. Keep its config file if you want to transfer settings manually.
3. Install [UnityToolkit 2.0.2 for SPT 4.1.5](https://sp-mod.com/mod/1426/unitytoolkit) into that installation according to its instructions. UnityToolkit is a separate, required dependency and is not bundled with HeliCrash.
4. Extract `Tylevo.HeliCrash.CORE-v2.6.0-SPT4.1.5.7z` into the SPT installation root, preserving its `BepInEx/plugins/Tylevo.HeliCrash/` layout. The folder should contain `Tylevo.HeliCrash.Core.dll`, `HeliCrashLocations.json`, `Locales.jsonc`, `sikorsky_uh60_blackhawk.bundle`, license, and release notes.
5. Start a solo raid. After the first launch, adjust `BepInEx/config/com.tylevo.helicrash.cfg` or use BepInEx ConfigurationManager, if installed. The advanced **Spawn All Crash Sites** setting is intended for location debugging.

The setting keys and `HeliCrashLocations.json` format remain the same, but the new plugin ID creates a new config file. Previous Arys Reloaded settings do not transfer automatically; copy the values you want from its old config into `com.tylevo.helicrash.cfg` after the first launch.

Do not install the older Fika Sync DLL with this release. Co-op crash-site synchronization is outside the scope of Core v2.6.0.

## Build Core from source

Requirements: the .NET SDK, an SPT 4.1.5 installation with UnityToolkit 2.0.2 installed, and 7-Zip if creating a release archive. Build the **Core project**, not the solution, because the Fika project has not been ported.

1. Clone the repository, including its shared configuration submodule: `git submodule update --init --recursive`.
2. Create the ignored local file `SharedConfiguration/Shared.User.props` with the SPT installation path, including the trailing backslash:

   ```xml
   <Project>
     <PropertyGroup>
       <SptDir>D:\SPT4.1.5\</SptDir>
     </PropertyGroup>
   </Project>
   ```

3. Extract `sikorsky_uh60_blackhawk.bundle` from `mod/SamSWAT.HeliCrash/Assets.7z` into `project/HeliCrash.Core/CopyToOutput/` beside the location and locale files.
4. Build the Core project:

   ```powershell
   dotnet build project/HeliCrash.Core/HeliCrash.Core.csproj -c "SPT-4.1 Release" -p:CreateReleaseArchive=true
   ```

The archive is written to `Distributions/Tylevo.HeliCrash.CORE-v2.6.0-SPT4.1.5.7z`. Building does not copy files into the SPT installation by default. To deploy to the configured local installation explicitly, add `-p:DeployToSpt=true` to the build command.

## Credits and license

SamSWAT created the [original Helicopter Crash Sites mod](https://dev.sp-tarkov.com/SamSWAT/HelicopterCrashSites), and Arys created Arys Reloaded. Tylevo HeliCrash is a separate continuation that retains their attribution. The repository's [Creative Commons Attribution-NonCommercial 4.0 license](LICENSE) applies.
