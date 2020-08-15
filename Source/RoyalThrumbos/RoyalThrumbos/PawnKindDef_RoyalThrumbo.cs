using RimWorld;
using Verse;

namespace RoyalThrumbos
{
  [DefOf]
  public static class PawnKindDef_RoyalThrumbo
  {
    static PawnKindDef_RoyalThrumbo()
    {
      DefOfHelper.EnsureInitializedInCtor(typeof(PawnKindDef_RoyalThrumbo));
    }

    public static PawnKindDef RoyalThrumbo;
  }
}
