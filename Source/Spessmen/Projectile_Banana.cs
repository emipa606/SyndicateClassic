using System;
using RimWorld;
using Verse;

namespace Spessmen
{
	// Token: 0x02000003 RID: 3
	internal class Projectile_Banana : Projectile_Explosive
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000206A File Offset: 0x0000026A
		protected override void Impact(Thing hitThing)
		{
			this.landed = true;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002074 File Offset: 0x00000274
		public override void Tick()
		{
			this.live++;
			bool flag = this.live > 120;
			if (flag)
			{
				this.armed = true;
			}
			bool flag2 = this.live >= 1800;
			if (flag2)
			{
				base.Destroy(DestroyMode.Vanish);
			}
			bool flag3 = this.armed && this.live < 1800;
			if (flag3)
			{
				Pawn firstPawn = GridsUtility.GetFirstPawn(base.Position, base.Map);
				bool flag4 = firstPawn != null;
				if (flag4)
				{
					GenExplosion.DoExplosion(base.Position, firstPawn.Map, 1f, DamageDefOf.Blunt, this, -1, -1, SoundDefOf.Pawn_Melee_Punch_HitPawn, null, null, null, null, 0f, 1, false, null, 0f, 1);
					base.Destroy(DestroyMode.Vanish);
				}
			}
			base.Tick();
		}

		// Token: 0x04000001 RID: 1
		public int live = 0;

		// Token: 0x04000002 RID: 2
		public bool armed = false;
	}
}
