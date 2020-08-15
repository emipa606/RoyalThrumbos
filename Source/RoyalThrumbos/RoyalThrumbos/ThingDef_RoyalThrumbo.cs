using RimWorld;
using Verse;

namespace RoyalThrumbos
{
  [DefOf]
  public static class ThingDef_RoyalThrumbo
  {
    static ThingDef_RoyalThrumbo()
    {
      DefOfHelper.EnsureInitializedInCtor(typeof(ThingDef_RoyalThrumbo));
    }

    public static ThingDef RoyalThrumbo;
  }
}