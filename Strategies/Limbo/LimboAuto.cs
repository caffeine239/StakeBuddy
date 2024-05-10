using StakeBuddy.Bots.CommonBot;

public class LimboAuto : Strategy
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
            return "Default Limbo Auto Play";
        }
    }
    public override void Init()
    {
        SetBetAmount(GetMainBotBetAmount());
        SetMultiplierTarget(GetMainMultiplierTarget());
    }
    public override void Tick()
    {
        SetBetAmount(GetMainBotBetAmount());
        SetMultiplierTarget(GetMainMultiplierTarget());

        bool wasWin;
        double result = (double)DoBet(out wasWin);
    }
}