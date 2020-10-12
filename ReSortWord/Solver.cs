using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ReSortWord
{
    class Solver
    {
        private string Stop { get; set; }
        private int len;
        public List<string> Tab { get; set; }
        public List<string> Result;
        public Solver(string start, string stop)
        {
            Stop = stop;
            Tab = new List<string> { start };
            len = start.Length;
        }
        public void Find()
        {
            string last = Tab[Tab.Count - 1];
            if (last == Stop)
            {
                if (Result == null || Tab.Count < Result.Count)
                    Result = Tab.GetRange(0, Tab.Count);
            }
            else
            {
                for (int pos = 1; pos < len; pos++)
                {
                    char[] chr = last.ToCharArray();
                    (chr[0], chr[pos]) = (chr[pos], chr[0]);
                    string line = string.Join("", chr);
                    HashSet<string> set = new HashSet<string>(Tab);
                    if (!set.Contains(line))
                    {
                        Tab.Add(line);
                        Find();
                        Tab.RemoveAt(Tab.Count - 1);
                    }
                }
            }
        }
    }
}
