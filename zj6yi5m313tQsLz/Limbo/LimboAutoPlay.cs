using StakeBuddy.Models;
using StakeBuddy.StakeBuddy.Helpers;

public class StakeBuddyLimboAuto : Strategy
{
    public override StakeOriginalGame DesignedForStakeOriginal
    {
        get
        {
            return StakeOriginalGame.Limbo;
        }
    }

    public override string Name
    {
        get
        {
            return "Stake Buddy Limbo Auto";
        }
    }

    public override void Tick()
    {

    }
}
