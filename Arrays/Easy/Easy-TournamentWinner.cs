using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

class TournamentWinner{

    public static void Controller(){
        List<List<string>> List = new List<List<string>>();
        List.Add(new List<string>(){"HTML", "Java"});
        List.Add(new List<string>(){"Java", "Python"});
        List.Add(new List<string>(){"Python", "HTML"});
        List.Add(new List<string>(){"C#", "Python"});
        List.Add(new List<string>(){"Java", "C#"});
        List.Add(new List<string>(){"C#", "HTML"});

        List<int> results = new List<int>(){0, 1, 1, 1, 0, 1};
        Console.WriteLine(BruteForce(List, results));
        Console.ReadLine();
    }

    public static string BruteForce(List<List<string>> competitions, List<int> results){
        
        /*
            Time Complexity = O(N) N --> the number of competitions in the tournament
            Space Complexity = O(K) K --> the number of teams in the tournament
        */
        
        int currentMaxScore = 0;
        string CurrentLeader = "";
        
        Dictionary<string, int> TeamPointCount = new(results.Count/2);
        
        for(int i = 0; i < results.Count; i++){
            string team_won = results[i] == 0 ? competitions[i][1] : competitions[i][0];       
            if(!TeamPointCount.ContainsKey(team_won)){
                TeamPointCount.Add(team_won, 1);
            }else{
                TeamPointCount[team_won] += 1;
            }

            if(TeamPointCount[team_won] > currentMaxScore){
                currentMaxScore = TeamPointCount[team_won];
                CurrentLeader = team_won;
            }
        }
        return CurrentLeader;
    }


}