using MelonLoader;
using HarmonyLib;
using Il2CppLE.UI.Minimap;

[assembly: MelonInfo(typeof(LEAntifog.Core), "LEAntifog", "1.1.0", "Insulinocytus", null)]
[assembly: MelonGame("Eleventh Hour Games", "Last Epoch")]

namespace LEAntifog
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
        }
    }

    [HarmonyPatch(typeof(Minimap), nameof(Minimap.Awake))]
    internal static class MinimapPatch
    {
        private static void Postfix(Minimap __instance)
        {
            __instance.RevealRadius = 999f;
        }
    }
}
