using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question4
    {
        public void Runner()
        {
            Team team = new Team();
            team.Name = "Alpha";
            team.Members = new List<string>();
            team.Members.Add("Ravi");
            team.Members.Add("Asha");

            Console.WriteLine("Original team : ");
            PrintStruct(team);

            var copy = team;
            copy.Name = "Beta";
            copy.Members.Add("kiran");
            Console.WriteLine("After update");
            Console.WriteLine("Original: ");
            PrintStruct(team);
            Console.WriteLine("Copy: ");
            PrintStruct(copy);

            //above I updated copy but original team gets update
            // we need to deep copy it 

            Team t3 = new Team(team);
            t3.Members.Add("xyz");
            Console.WriteLine("third copy after member update: ");
            PrintStruct(team);
            PrintStruct(t3);

        }

        public void PrintStruct(Team t)
        {
            Console.WriteLine("Name : "+t.Name+" Members : "+string.Join(',',t.Members));
        }
        
    }

    public struct Team
    {
        public string Name;
        public List<String> Members;

        public Team(Team other)
        {
           this.Name = other.Name;
           List<String> mem = new List<String>(other.Members);
           this.Members = mem;
        }
    }
}
