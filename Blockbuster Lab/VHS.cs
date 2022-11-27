using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; } = 0;
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) 
            : base(Title, Category, RunTime, Scenes)
        {
            
        }

        public override void Play()
        {
            if(CurrentScene < Scenes.Count)
            {
                for(int i = 0; i < Scenes.Count; i++) 
                { 
                    string VHSscene = Scenes[CurrentScene];
                    CurrentScene++;
                    Console.WriteLine(VHSscene);
                }
            }
            else
            {
                Console.WriteLine("Look's like you forgot to be kind and rewind. Let me help you with that.");
                Rewind();
            }
        }
        public override void Rewind()
        {
            CurrentScene = 0;
            Console.WriteLine("\nMovie has been rewound.");
        }
    }
}
