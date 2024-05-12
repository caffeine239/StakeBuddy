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
        SetMainBetAmount(GetMainBetAmount());
        SetBotMultiplierTarget(GetLimboMultiplierTarget());
    }
    public override void Tick()
    {
        SetMainBetAmount(GetMainBetAmount());
        SetBotMultiplierTarget(GetLimboMultiplierTarget());

        bool wasWin;
        double result = (double)DoBet(out wasWin);
    }
}
