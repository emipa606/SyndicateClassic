using RimWorld;
using Verse;

namespace Spessmen;

internal class Syndicate_Implant_Hediff : HediffWithComps
{
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