using Verse;

namespace Spessmen;

internal class HediffGiverSyndicateClass : HediffGiver
{
    public virtual bool CheckGiveEverySecond(Pawn pawn)
    {
        TryApply(pawn);
        return false;
    }
}