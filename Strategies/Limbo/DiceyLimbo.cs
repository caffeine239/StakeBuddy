using StakeBuddy.Bots;
using StakeBuddy.Bots.CommonBot;
using System.Collections.Generic;

public class DiceyLimbo : Strategy
{
    DiceBot diceBot;
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
            return "Dicey Limbo";
        }
    }
    public override void Init()
    {
        SetBotBetAmount(GetMainBetAmount());
        SetBotMultiplierTarget(2);
        diceBot = GetInactiveBot("DiceBot");
        diceBot.SetCurrency();
    }
    public override void Tick()
    {
        bool wasWin;
        double result = (double)DoBet(out wasWin);
        int Losses = GetBot().LossCount;

        if (!wasWin && Losses > 1)
        {
            diceBot.BetAmount = GetBotBetAmount() * 2.05;
            diceBot.MultiplierTarget = 48;
            diceBot.DoBet(out wasWin);

            if (wasWin)
            {
                GetBot().LossCount = 0;
                diceBot.BetAmount = GetMainBetAmount();
                SetBotBetAmount(GetMainBetAmount());
            }
            else
            {
                SetBotBetAmount(diceBot.BetAmount * 2.05);
            }
        }
        else
        {
            SetBotBetAmount(GetMainBetAmount());
        }
    }
}
