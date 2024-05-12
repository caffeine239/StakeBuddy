using StakeBuddy.Bots.CommonBot;
using System.Collections.Generic;
using System.Linq;

public class KenoTopPicked : Strategy
{
    private Dictionary<int, int> numberFrequencies = new Dictionary<int, int>();
    int gamesPlayedSinceSwitch = 0;
    int switchOnGamesPlayed = 200;
    int kenoNumbersToPlay = 6;

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
            return "Keno Top Pick Play";
        }
    }
    public override void Init()
    {
        SetMainBetAmount(GetMainBetAmount());

        if (GetKenoNumbers().Count < 1)
        {
            SetKenoNumbers(GetRandomKenoNumbers().Take(kenoNumbersToPlay).ToList());
            GetKenoNumbers().Sort();
            Log($"Keno Random numbers are [{string.Join(", ", GetKenoNumbers())}]");
        }
    }
    public override void Tick()
    {
        bool wasWin;
        List<int> result = (List<int>)DoBet(out wasWin);

        foreach (var number in result)
        {
            if (numberFrequencies.ContainsKey(number))
            {
                numberFrequencies[number]++;
            }
            else
                numberFrequencies[number] = 1;
        }

        if (gamesPlayedSinceSwitch > switchOnGamesPlayed)
        {
            var sortedItems = numberFrequencies.OrderByDescending(pair => pair.Value)
                                                     .Select(pair => $"{pair.Key}:{pair.Value}")
                                                     .ToList();

            List<int> top10 = numberFrequencies.Select(pair => pair.Key).Take(kenoNumbersToPlay).ToList();

            SetKenoNumbers(top10);
            GetKenoNumbers().Sort();
            Log($"New Keno numbers are [{string.Join(", ", top10)}]");
            gamesPlayedSinceSwitch = 0;
            numberFrequencies.Clear();
            return;
        }

        gamesPlayedSinceSwitch++;
    }
}
