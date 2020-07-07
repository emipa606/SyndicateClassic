using System;
using Verse;

namespace Spessmen
{
	// Token: 0x02000005 RID: 5
	internal class HediffGiverSyndicateClass : HediffGiver
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002204 File Offset: 0x00000404
		public virtual bool CheckGiveEverySecond(Pawn pawn)
		{
			base.TryApply(pawn, null);
			return false;
		}
	}
}
