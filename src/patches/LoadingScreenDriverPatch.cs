using Brix.NewUI.LoadingScreen;
using HarmonyLib;
using UnityEngine;

namespace CastleStory_BricktronCapture
{
    [HarmonyPatch(typeof(LoadingScreenDriver), "OnGameReady")]
    public class LoadingScreenDriverPatch
    {
        static void Prefix()
        {
            var bricktron = GameObject.Find("PersitantGOs").transform.Find("Factory/Test/Bricktron").gameObject;
            bricktron.GetComponent<CanCapture>().AllowedCaptureActions |= CanCapture.CaptureActions.Attack;
        }
    }
}
