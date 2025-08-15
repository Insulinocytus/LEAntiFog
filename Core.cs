using Il2Cpp;
using MelonLoader;
using Object = UnityEngine.Object;

[assembly: MelonInfo(typeof(LEAntifog.Core), "LEAntifog", "1.0.0", "Insulinocytus", null)]
[assembly: MelonGame("Eleventh Hour Games", "Last Epoch")]

namespace LEAntifog
{
    public class Core : MelonMod
    {
        MinimapFogOfWar fogComponent;

        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg($"{nameof(LEAntifog)} initialized.");
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            OverrideDiscoveryDistance();
        }

        void OverrideDiscoveryDistance()
        {
            if (fogComponent == null)
            {
                fogComponent = Object.FindFirstObjectByType(typeof(MinimapFogOfWar)) as MinimapFogOfWar;
                if (fogComponent != null)
                {
                    fogComponent.discoveryDistance = 999f;
                    return;
                }

                LoggerInstance.Error(
                    $"{nameof(MinimapFogOfWar)} component not found. Maybe this game version is not supported anymore. Please report it to the developer.");
            }
            else
            {
                fogComponent.discoveryDistance = 999f;
            }
        }
    }
}
