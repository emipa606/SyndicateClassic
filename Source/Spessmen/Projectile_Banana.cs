using RimWorld;
using Verse;

namespace Spessmen;

internal class Projectile_Banana : Projectile_Explosive
{
    private bool armed;

    private int live;

    protected override void Impact(Thing hitThing, bool blockedByShield = false)
    {
        landed = true;
    }

    protected override void Tick()
    {
        live++;
        if (live > 120)
        {
            armed = true;
        }

        if (live >= 1800)
        {
            base.Destroy();
        }

        if (armed && live < 1800)
        {
            if (Position.GetFirstPawn(Map) != null)
            {
                GenExplosion.DoExplosion(Position, Position.GetFirstPawn(Map).Map, 1f, DamageDefOf.Blunt, this, -1,
                    -1,
                    SoundDefOf.Pawn_Melee_Punch_HitPawn);
                base.Destroy();
            }
        }

        base.Tick();
    }
}