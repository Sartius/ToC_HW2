using System;
using System.Text;

namespace ToC_Report2
{
    public class ContextFreeString
    {
        // RULES
        public string[] S = { "SS", "A", "B","" };
        public string[] A = { "a" , "aa" };
        public string[] B = { "b", "bb" };

        public string DoContextFreeString(string a)
        {
            while(AnyNonTermRemain(a))
            {
                a = NonTerminalStringMaker(a);
            }
            return TerminalStringMaker(a);
        }

        public bool AnyNonTermRemain(string s)
        {
            foreach(var l in s)
            {
                if (l == 'S')
                    return true;
            }
            return false;
        }

        public string NonTerminalStringMaker(string s)
        {
            string a;
            Random r = new Random();
            StringBuilder buildString = new StringBuilder(s);
            for(int i = buildString.Length - 1; i >= 0;i--)
            {
                if (buildString[i] == 'S')
                {
                    int rInt = r.Next(0, 4);
                    switch (rInt)
                    {
                        case 0:
                            buildString.Remove(i, 1).Insert(i, S[rInt]);

                            break;
                        case 1:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, S[rInt]);
                            break;
                        case 2:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, S[rInt]);
                            break;
                        case 3:
                            buildString.Remove(i, 1);
                            break;
                        default:
                            break;
                    }

                }
                else
                    continue;
            }
            return buildString.ToString();
        }

        public string TerminalStringMaker(string s)
        {
            Random r = new Random();
            StringBuilder buildString = new StringBuilder(s);

            for (int i = 0; i < buildString.Length; i++)
            {
                if(buildString[i] == 'A')
                {
                    int rInt = r.Next(0, 2);
                    switch(rInt)
                    {
                        case 0:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, A[rInt]);
                            break;
                        case 1:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, A[rInt]);
                            break;
                        default:
                            break;
                    }
                }
                else if(buildString[i] == 'B')
                {
                    int rInt = r.Next(0, 2);
                    switch (rInt)
                    {
                        case 0:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, B[rInt]);
                            break;
                        case 1:
                            buildString.Remove(i, 1);
                            buildString.Insert(i, B[rInt]);
                            break;
                        default:
                            break;
                    }
                }

            }
            return buildString.ToString();
        }
    }
}
