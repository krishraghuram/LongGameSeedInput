using HarmonyLib;
using StardewModdingAPI;
using StardewValley.Menus;

namespace LongGameSeedInput;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        var harmony = new Harmony(ModManifest.UniqueID);
        harmony.PatchAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdvancedGameOptions), nameof(AdvancedGameOptions.PopulateOptions))]
    public static void PopulateOptions_Postfix(AdvancedGameOptions __instance)
    {
        foreach (var option in __instance.options)
        {
            if (option is OptionsTextEntry textEntry &&
                textEntry.textBox.numbersOnly &&
                textEntry.textBox.textLimit == 9)
            {
                textEntry.textBox.textLimit = 20;
                break;
            }
        }
    }
}