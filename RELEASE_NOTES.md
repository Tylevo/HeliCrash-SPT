# Tylevo HeliCrash Core v2.6.0 — SPT 4.1.5

This standalone `Tylevo/HeliCrash-SPT` release ports the solo HeliCrash Core plugin to SPT 4.1.5 under plugin ID `com.tylevo.helicrash`. It retains configurable crash locations and spawn/loot chances, the helicopter asset and smoke, interactive doors, the navigation obstacle, and the airdrop-derived loot crate. Existing setting keys and `HeliCrashLocations.json` format remain in use.

**Required separate install:** [UnityToolkit 2.0.2 for SPT 4.1.5](https://sp-mod.com/mod/1426/unitytoolkit). It is not included in the Core archive.

Remove an existing `BepInEx/plugins/SamSWAT.HeliCrash.ArysReloaded/` installation before extracting `Tylevo.HeliCrash.CORE-v2.6.0-SPT4.1.5.7z` into the SPT root. The new files belong in `BepInEx/plugins/Tylevo.HeliCrash/`. The new plugin ID creates `BepInEx/config/com.tylevo.helicrash.cfg`, so transfer any old settings manually; they do not migrate automatically.

Fika Sync has not been ported to SPT 4.1.5 and is not included. The Core plugin reports the unsupported Fika combination instead of running unsynchronized in co-op. The planned pilot, guards, loadouts, and AI are not part of this release.

Credits remain with SamSWAT for the original mod and Arys for Arys Reloaded. See [LICENSE](LICENSE) for the repository license.
