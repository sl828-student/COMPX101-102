using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_redo
{
    public class Forest
    {
        //Declare list at class scope
        private List<Tree> _trees;
        /// <summary>
        /// Constructor, initilises and creates new forest object which contains a list of tree
        /// </summary>
        public Forest()
        {
            _trees = new List<Tree>();
        }
        /// <summary>
        /// Method adds a new tree to the tree list of the object
        /// </summary>
        /// <param name="x">is the x postion of the tree</param>
        /// <param name="y">is the y postion of the tree</param>
        /// <param name="size">is the size of the foliage of the treee</param>
        public void AddTree(int x, int y, int size)
        {
            Tree t = new Tree(x, y, size);
            _trees.Add(t);
        }
        /// <summary>
        /// Method draws all trees in the object list using the drawtree method in the tree class, is passes graphics
        /// </summary>
        /// <param name="graphics"></param>
        public void DrawForest(Graphics graphics)
        {
            foreach (Tree t in _trees)
            {
                t.DrawTree(graphics);
            }
        }
        /// <summary>
        /// method saves the forest that is currently in the tree list 
        /// </summary>
        /// <param name="filename"></param>
        public void SaveForest(string filename)
        {
            StreamWriter write = new StreamWriter(filename);
            foreach(Tree t in _trees)
            {
                write.WriteLine(t.ToCsvString());
            }
            write.Close();
        }
        /// <summary>
        /// Method splits csv file into parts that are then passed into the forest list
        /// </summary>
        /// <param name="filename"></param>
        public void LoadForest(string filename)
        {
            StreamReader read = new StreamReader(filename);
            while(!read.EndOfStream) 
            {
                string line = read.ReadLine();
                string[] parts = line.Split(',');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                int size = int.Parse(parts[2]);

                _trees.Add(new Tree(x, y, size));
            }
        }
        /// <summary>
        /// Grows a random tree in the treelist 
        /// </summary>
        /// <param name="amount"></param>
        public void GrowForest(int amount)
        {
            if (_trees.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(_trees.Count);
                _trees[index].GrowTree(amount);
            }
        }
    }
}
