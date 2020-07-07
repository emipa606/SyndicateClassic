using System;
using RimWorld;
using Verse;

namespace Spessmen
{
	// Token: 0x02000004 RID: 4
	internal class Syndicate_Implant_Hediff : HediffWithComps
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002150 File Offset: 0x00000350
		public override void Tick()
		{
			bool flag = this.pawn.health.summaryHealth.SummaryHealthPercent <= 0.5f;
			if (flag)
			{
				GenExplosion.DoExplosion(this.pawn.Position, this.pawn.Map, 1.5f, DamageDefOf.Bomb, this.pawn, -1, -1, null, null, null, null, null, 0f, 1, false, null, 0f, 1);
				this.pawn.Strip();
				this.pawn.health.DropBloodFilth();
				this.pawn.health.DropBloodFilth();
				this.pawn.Destroy(DestroyMode.Vanish);
			}
			base.Tick();
		}
	}
}
