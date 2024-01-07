using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_exam
{
    internal class Sol2
    {
        private List<int> ints {  get; set; }

        public Sol2(string input)
        {
            ints = new List<int>();
            string[] split = input.Split(' ');
            foreach(string c in split)
            {
                ints.Add(Convert.ToInt32(c));
            }
        }
        public string Greedy()
        {
            ints.Sort();
            ints.Reverse();
            string greed = "";
            /*for(int i =0; i < 2; i++)
            {
                greed += ints[i];
            }*/
            greed = $"{ints[0]}{ints[1]}";
            return greed;
        }
    }
}
