using RimWorld;
using UnityEngine;
using Verse;

namespace RoyalThrumbos;

public class IncidentWorker_RoyalThrumboPass : IncidentWorker
{
    protected override bool CanFireNowSub(IncidentParms parms)
    {
        var map = (Map)parms.target;
        if (map.gameConditionManager.ConditionIsActive(GameConditionDefOf.ToxicFallout))
        {
            return false;
        }

        return map.mapTemperature.SeasonAndOutdoorTemperatureAcceptableFor(ThingDef_RoyalThrumbo.RoyalThrumbo) &&
               TryFindEntryCell(map, out _);
    }

    protected override bool TryExecuteWorker(IncidentParms parms)
    {
        var map = (Map)parms.target;
        if (!TryFindEntryCell(map, out var cell))
        {
            return false;
        }

        var RoyalThrumbo = PawnKindDef_RoyalThrumbo.RoyalThrumbo;
        var value = GenMath.RoundRandom(StorytellerUtility.DefaultThreatPointsNow(map) / RoyalThrumbo.combatPower);
        var max = Rand.RangeInclusive(3, 6);
        value = Mathf.Clamp(value, 2, max);
        var num2 = Rand.RangeInclusive(90000, 150000);
        if (!RCellFinder.TryFindRandomCellOutsideColonyNearTheCenterOfTheMap(cell, map, 10f, out var result))
        {
            result = IntVec3.Invalid;
        }

        Pawn pawn = null;
        for (var i = 0; i < value; i++)
        {
            var loc = CellFinder.RandomClosewalkCellNear(cell, map, 10);
            pawn = PawnGenerator.GeneratePawn(RoyalThrumbo);
            GenSpawn.Spawn(pawn, loc, map, Rot4.Random);
            pawn.mindState.exitMapAfterTick = Find.TickManager.TicksGame + num2;
            if (result.IsValid)
            {
                pawn.mindState.forcedGotoPosition = CellFinder.RandomClosewalkCellNear(result, map, 10);
            }
        }

        Find.LetterStack.ReceiveLetter("LetterLabelThrumboPasses".Translate(RoyalThrumbo.label).CapitalizeFirst(),
            "LetterThrumboPasses".Translate(RoyalThrumbo.label), LetterDefOf.PositiveEvent, pawn);
        return true;
    }

    private bool TryFindEntryCell(Map map, out IntVec3 cell)
    {
        return RCellFinder.TryFindRandomPawnEntryCell(out cell, map, CellFinder.EdgeRoadChance_Animal + 0.2f);
    }
}