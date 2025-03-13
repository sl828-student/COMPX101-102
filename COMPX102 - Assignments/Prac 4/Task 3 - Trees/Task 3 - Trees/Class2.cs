using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3___Trees;

namespace Task_3___Trees
{
    public class Forest
    {
        private List<Tree> trees;

        public Forest()
        {
            trees = new List<Tree>();
        }

        /// <summary>
        /// add tree method which is passed x,y and foliage size
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        public void AddTree(int x, int y, int size)
        {
            Tree t = new Tree(x, y, size);
            trees.Add(t);
        }

        public void DrawForest(Graphics paper)
        {
            foreach (Tree tree in trees)
            {
                tree.DrawTree(paper);
            }
        }

        public void SaveForest(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (Tree tree in trees)
            {
                writer.WriteLine(tree.ToCsvString());
            }
            writer.Close();
        }

        public void loadForest(string filename)
        {
            StreamReader reader = File.OpenText(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] split = line.Split(',');

                AddTree(int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]));

            }
            reader.Close();
        }

        public void GrowForest(int amount)
        {
            if (trees.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(trees.Count);
                trees[index].GrowTree(amount);
            }
        }

    }


}
