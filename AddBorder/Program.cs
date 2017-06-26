using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] border = new string[] { "abc", "ded" };
            string[] result = addBorder(border);
        }

        static string[] addBorder(string[] picture)
        {
            int intMax = picture.OrderByDescending(x => x.Length).First().Length;
            List<string> lst = new List<string>();
            lst.Add(string.Concat(Enumerable.Repeat("*", intMax + 2)));
            for(int y=0; y< picture.Length; y++)
            {
                lst.Add("*" + picture[y] + "*");
            }
            lst.Add(string.Concat(Enumerable.Repeat("*", intMax + 2)));
            return lst.ToArray();
            //return null;
        }
    }
}
