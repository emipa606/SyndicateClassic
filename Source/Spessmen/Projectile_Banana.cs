using RimWorld;
using Verse;

namespace Spessmen
{
    // Token: 0x02000003 RID: 3
    internal class Projectile_Banana : Projectile_Explosive
    {
        // Token: 0x04000002 RID: 2
        private bool armed;

        // Token: 0x04000001 RID: 1
        private int live;

        // Token: 0x06000003 RID: 3 RVA: 0x0000206A File Offset: 0x0000026A
        protected override void Impact(Thing hitThing)
        {
            landed = true;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002074 File Offset: 0x00000274
        public override void Tick()
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
}