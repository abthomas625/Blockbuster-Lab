using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}, Genre: {Category}, Run Time: {RunTime}");
        }
        public void PrintScenes(List<string> Scenes)
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(i + " " + Scenes[i]);
            }
        }
        public abstract void Play();
        public abstract void Rewind();
    }
}
