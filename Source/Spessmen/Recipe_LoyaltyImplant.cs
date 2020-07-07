using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace Spessmen
{
	// Token: 0x02000002 RID: 2
	internal class Recipe_LoyaltyImplant : Recipe_InstallImplant
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
		{

			if (billDoer != null)
			{
				if (base.CheckSurgeryFail(billDoer, pawn, ingredients, part, bill))
				{
					return;
				}
				TaleRecorder.RecordTale(TaleDefOf.DidSurgery, new object[]
				{
					billDoer,
					pawn
				});
			}
			pawn.health.AddHediff(this.recipe.addsHediff, part, null, null);
			pawn.SetFaction(billDoer.Faction, null);
		}
	}
}
