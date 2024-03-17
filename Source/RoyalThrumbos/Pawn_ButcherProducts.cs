using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace RoyalThrumbos;

[HarmonyPatch(typeof(Pawn), "ButcherProducts")]
public static class Pawn_ButcherProducts
{
    public static IEnumerable<Thing> Postfix(IEnumerable<Thing> values, Pawn __instance)
    {
        foreach (var value in values)
        {
            if (value.def.defName == "RoyalThrumbo_HornMale" && __instance.gender == Gender.Female)
            {
                yield return ThingMaker.MakeThing(Main.FemaleHorn);
                continue;
            }

            yield return value;
        }
    }
}