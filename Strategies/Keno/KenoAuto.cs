using StakeBuddy.Bots.CommonBot;
using System.Collections.Generic;

public class KenoAuto : Strategy
{
    List<int> selectedNumbers = new List<int>();

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
            return "Default Keno Auto Play";
        }
    }
    public override void Init()
    {
        SetMainBetAmount(GetMainBetAmount());

        if (GetKenoNumbers().Count < 1)
        {
            selectedNumbers = GetRandomKenoNumbers();
            SetKenoNumbers(selectedNumbers);
        }
    }
    public override void Tick()
    {
        bool wasWin;
        List<int> result = (List<int>)DoBet(out wasWin);
    }
}
