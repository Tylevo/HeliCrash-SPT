# Core v2.6.0 — SPT 4.1.5

This release ports the solo HeliCrash Core plugin to SPT 4.1.5. It retains configurable crash locations and spawn/loot chances, the helicopter asset and smoke, interactive doors, the navigation obstacle, and the airdrop-derived loot crate. Existing configuration keys and `HeliCrashLocations.json` format remain in use.

**Required separate install:** [UnityToolkit 2.0.2 for SPT 4.1.5](https://sp-mod.com/mod/1426/unitytoolkit). It is not included in the Core archive.

Install the Core archive into the SPT root, preserving the `BepInEx` folder layout. Fika Sync has not been ported to SPT 4.1.5 and is not included. The Core plugin reports the unsupported Fika combination instead of running unsynchronized in co-op. The planned pilot, guards, loadouts, and AI are not part of this release.

Credits remain with SamSWAT for the original mod and Arys for Arys Reloaded. See [LICENSE](LICENSE) for the repository license.
