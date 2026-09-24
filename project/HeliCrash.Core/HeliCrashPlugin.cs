using System;
using BepInEx;
using BepInEx.Bootstrap;

namespace SamSWAT.HeliCrash.ArysReloaded;

[BepInPlugin(
    "com.tylevo.helicrash",
    "Tylevo HeliCrash",
    ModMetadata.VERSION
)]
[BepInDependency("com.SPT.core", ModMetadata.TARGET_SPT_VERSION)]
[BepInDependency("com.arys.unitytoolkit", "2.0.2")]
[BepInDependency("com.fika.core", BepInDependency.DependencyFlags.SoftDependency)]
[BepInDependency(
    "com.samswat.helicrash.arysreloaded",
    BepInDependency.DependencyFlags.SoftDependency
)]
public class HeliCrashPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        RejectUnsupportedInstall();

        new InitializeApplicationLifetimeScopePatch(this, Logger, gameObject).Enable();

        PostAwake?.Invoke();
        PostAwake = null;
    }

    private static void RejectUnsupportedInstall()
    {
        if (Chainloader.PluginInfos.ContainsKey("com.samswat.helicrash.arysreloaded"))
        {
            throw new NotSupportedException(
                "Tylevo HeliCrash replaces Arys Reloaded Core. Remove the older HeliCrash plugin before using this standalone release."
            );
        }

        if (Chainloader.PluginInfos.ContainsKey("com.fika.core"))
        {
            throw new NotSupportedException(
                "Tylevo HeliCrash 2.6.0 supports solo SPT 4.1.5 only. Fika Sync has not been ported; disable HeliCrash when using Fika."
            );
        }
    }

    public static event Action PostAwake;
}
