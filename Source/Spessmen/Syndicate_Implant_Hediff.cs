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
            if (pawn.health.summaryHealth.SummaryHealthPercent <= 0.5f)
            {
                GenExplosion.DoExplosion(pawn.Position, pawn.Map, 1.5f, DamageDefOf.Bomb, pawn);
                pawn.Strip();
                pawn.health.DropBloodFilth();
                pawn.health.DropBloodFilth();
                pawn.Destroy();
            }

            base.Tick();
        }
    }
}