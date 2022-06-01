using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary
{
    public class RoundRobin : ITournamentType
    {
        public List<string> NextRound(int[] amountOfPlayers)
        {
            Random rng = new Random();
            List<string> result = new List<string>();

           int n = amountOfPlayers.Length;
            while(n > 1)
            {
                int k = rng.Next(n--);
                (amountOfPlayers[k], amountOfPlayers[n]) = (amountOfPlayers[n], amountOfPlayers[k]);
            }


            foreach(int player in amountOfPlayers)
            {
                int p1 = player;
                for (int i = 0; i < amountOfPlayers.Length; i++)
                {
                    if (amountOfPlayers[i] != p1)
                    {
                        int p2 = amountOfPlayers[i];
                        result.Add($"INSERT INTO ds_match(`TournamentID`, `Player1`, `Player2`)" +
                            $"Values (@tournamentID,{p1},{p2})");
                    }
                }
            }

            return result;

        }

        public List<string> StartRound(int[] playerCount)
        {
            Random rng = new Random();
            List<string> result = new List<string>();

            int n = playerCount.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                (playerCount[k], playerCount[n]) = (playerCount[n], playerCount[k]);
            }


            for(int i=0;i<playerCount.Length;i++)
            {
                int p1 = playerCount[i];
                for (int k = 0; k < playerCount.Length; k++)
                {
                    if (playerCount[k] != p1 && k>i)
                    {
                        int p2 = playerCount[k];
                        result.Add($"INSERT IGNORE INTO ds_match(`TournamentID`, `Player1`, `Player2`)" +
                            $"Values (@tournamentID,{p1},{p2}); ");
                    }
                }                
            }

            return result;
        }
    }
}
