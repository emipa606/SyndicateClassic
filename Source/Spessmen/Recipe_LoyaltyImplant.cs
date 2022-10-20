using System.Collections.Generic;
using RimWorld;
using Verse;

namespace Spessmen;

internal class Recipe_LoyaltyImplant : Recipe_InstallImplant
{
    public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients,
        Bill bill)
    {
        if (billDoer != null)
        {
            if (CheckSurgeryFail(billDoer, pawn, ingredients, part, bill))
            {
                return;
            }

            TaleRecorder.RecordTale(TaleDefOf.DidSurgery, billDoer, pawn);
        }

        pawn.health.AddHediff(recipe.addsHediff, part);
        if (billDoer != null)
        {
            pawn.SetFaction(billDoer.Faction);
        }
    }
}