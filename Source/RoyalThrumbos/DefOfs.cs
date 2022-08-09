using RimWorld;
using Verse;

namespace RoyalThrumbos;

[DefOf]
public static class PawnKindDef_RoyalThrumbo
{
    public static PawnKindDef RoyalThrumbo;

    static PawnKindDef_RoyalThrumbo()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(PawnKindDef_RoyalThrumbo));
    }
}

[DefOf]
public static class ThingDef_RoyalThrumbo
{
    public static ThingDef RoyalThrumbo;

    static ThingDef_RoyalThrumbo()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThingDef_RoyalThrumbo));
    }
}