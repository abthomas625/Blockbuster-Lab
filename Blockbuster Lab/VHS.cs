using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; }
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes, int CurrentScene) : base(Title, Category, RunTime, Scenes)
        {
            
        }

        public override void Play()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string VHSscene = Scenes[CurrentScene];
                CurrentScene++;
                Console.WriteLine(VHSscene);
            }
        }
        public override void Rewind()
        {
            CurrentScene = 0;
            Console.WriteLine("\nMovie has been rewound.");
        }
    }
}
