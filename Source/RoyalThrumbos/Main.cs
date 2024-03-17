using System.Reflection;
using HarmonyLib;
using Verse;

namespace RoyalThrumbos;

[StaticConstructorOnStartup]
public static class Main
{
    public static readonly ThingDef FemaleHorn;

    static Main()
    {
        FemaleHorn = ThingDef.Named("RoyalThrumbo_HornFemale");
        new Harmony("Mlie.RoyalThrumbos").PatchAll(Assembly.GetExecutingAssembly());
    }
}