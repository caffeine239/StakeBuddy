using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using StakeBuddy.Models;

public class StakeBuddyKeno : Strategy
{
    public override StakeOriginalGame DesignedForStakeOriginal
    {
        get
        {
            return StakeOriginalGame.Keno;
        }
    }

    public override string Name
    {
        get
        {
            return "Keno Default Auto Run";
        }
    }

    public override void Tick()
    {

    }
}
