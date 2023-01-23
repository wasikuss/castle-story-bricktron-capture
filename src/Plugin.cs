using System;

using BepInEx;
using HarmonyLib;

namespace CastleStory_BricktronCapture
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("com.wasikuss.castlestory.bricktroncapture").PatchAll();
        }
    }
}
