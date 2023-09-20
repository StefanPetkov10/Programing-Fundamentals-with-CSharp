using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersPool = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] playerInfo = input
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string player = playerInfo[0];
                    string position = playerInfo[1];
                    int skill = int.Parse(playerInfo[2]);

                    if (!playersPool.ContainsKey(player))
                    {
                        playersPool[player] = new Dictionary<string, int>();
                        playersPool[player].Add(position, skill);
                    }
                    else if (!playersPool[player].ContainsKey(position))
                    {
                        playersPool[player][position] = skill;
                    }
                    else if (playersPool[player][position] < skill)
                    {
                        playersPool[player][position] = skill;
                    }
                }
                //---------------------------------------
                else if (input.Contains(" vs "))
                {
                    string[] playerFights = input
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string player1 = playerFights[0];
                    string player2 = playerFights[1];

                    if (playersPool.ContainsKey(player1) && playersPool.ContainsKey(player2))
                    {
                        string position = String.Empty;

                        foreach (var (position1, skill1) in playersPool[player1])
                        {
                            bool IsPositionsEquals = false;
                            foreach (var (position2, skill2) in playersPool[player2])
                            {
                                if (position1 == position2)
                                {
                                    position = position1;
                                    IsPositionsEquals = true;
                                    break;
                                }
                            }
                            if (IsPositionsEquals)
                            {
                                break;
                            }
                        }
                        if (position != "")
                        {
                            int skillsPlayer1 = playersPool[player1][position];
                            int skillsPlayer2 = playersPool[player2][position];
                            if (skillsPlayer1 > skillsPlayer2)
                            {
                                playersPool.Remove(player2);
                            }
                            else if (skillsPlayer2 > skillsPlayer1)
                            {
                                playersPool.Remove(player1);
                            }
                        }
                    }
                }
            }

            var newPlayersPool = playersPool
                .OrderByDescending(y => y.Value.Sum(x => x.Value))
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var (player, ps) in newPlayersPool)
            {
                Console.WriteLine($"{player}: {ps.Skip(0).Sum(x => x.Value)} skill");
                foreach (var (position, skill) in ps
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }
    }
}
