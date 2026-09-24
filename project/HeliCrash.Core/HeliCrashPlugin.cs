using System;
using BepInEx;
using BepInEx.Bootstrap;

namespace SamSWAT.HeliCrash.ArysReloaded;

[BepInPlugin(
    "com.samswat.helicrash.arysreloaded",
    "SamSWAT's HeliCrash: Arys Reloaded - Core",
    ModMetadata.VERSION
)]
[BepInDependency("com.SPT.core", ModMetadata.TARGET_SPT_VERSION)]
[BepInDependency("com.arys.unitytoolkit", "2.0.2")]
[BepInDependency("com.fika.core", BepInDependency.DependencyFlags.SoftDependency)]
[BepInDependency(
    "com.samswat.helicrash.arysreloaded.fika",
    BepInDependency.DependencyFlags.SoftDependency
)]
public class HeliCrashPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        RejectUnsupportedFika();

        new InitializeApplicationLifetimeScopePatch(this, Logger, gameObject).Enable();

        PostAwake?.Invoke();
        PostAwake = null;
    }

    private static void RejectUnsupportedFika()
    {
        if (Chainloader.PluginInfos.ContainsKey("com.fika.core"))
        {
            throw new NotSupportedException(
                "HeliCrash Core 2.6.0 supports solo SPT 4.1.5 only. Fika Sync has not been ported; disable HeliCrash when using Fika."
            );
        }
    }

    public static event Action PostAwake;
}
