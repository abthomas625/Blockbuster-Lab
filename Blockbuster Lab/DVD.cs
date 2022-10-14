using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            PrintScenes(Scenes);

            Console.WriteLine($"\nWhich scene would you like to watch? Please select from 0 to {Scenes.Count-1}");
            int scene = int.Parse(Console.ReadLine());
            Console.WriteLine(Scenes[scene]);
            
        }

        public override void Rewind()
        {
            
        }
    }
}
