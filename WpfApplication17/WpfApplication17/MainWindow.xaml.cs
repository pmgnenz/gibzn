using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace WpfApplication17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int lettersnum(char c)
        {
            switch (c)
            {
                case 'a':
                case 'A':
                    return 1;
                case 'b':
                case 'B':
                    return 2;
                case 'c':
                case 'C':
                    return 3;
                case 'd':
                case 'D':
                    return 4;
                case 'e':
                case 'E':
                    return 5;
                case 'f':
                case 'F':
                    return 6;
                case 'g':
                case 'G':
                    return 7;
                case 'h':
                case 'H':
                    return 8;
                case 'i':
                case 'I':
                    return 9;
                case 'j':
                case 'J':
                    return 10;
                case 'k':
                case 'K':
                    return 11;
                case 'l':
                case 'L':
                    return 12;
                case 'm':
                case 'M':
                    return 13;
                case 'n':
                case 'N':
                    return 14;
                case 'o':
                case 'O':
                    return 15;
                case 'p':
                case 'P':
                    return 16;
                case 'q':
                case 'Q':
                    return 17;
                case 'r':
                case 'R':
                    return 18;
                case 's':
                case 'S':
                    return 19;
                case 't':
                case 'T':
                    return 20;
                case 'u':
                case 'U':
                    return 21;
                case 'v':
                case 'V':
                    return 22;
                case 'w':
                case 'W':
                    return 23;
                case 'x':
                case 'X':
                    return 24;
                case 'y':
                case 'Y':
                    return 25;
                case 'z':
                case 'Z':
                
                    return 26;
                
                    
                default: return 0;
            }
        }
        string lower(char c)
        {
            switch (c)
            {

                case 'a':
                case 'A':
                    return "a";
                case 'b':
                case 'B':
                    return "b";
                case 'c':
                case 'C':
                    return "c";
                case 'd':
                case 'D':
                    return "d";
                case 'e':
                case 'E':
                    return "e";
                case 'f':
                case 'F':
                    return "f";
                case 'g':
                case 'G':
                    return "g";
                case 'h':
                case 'H':
                    return "h";
                case 'i':
                case 'I':
                    return "i";
                case 'j':
                case 'J':
                    return "j";
                case 'k':
                case 'K':
                    return "k";
                case 'l':
                case 'L':
                    return "l";
                case 'm':
                case 'M':
                    return "m";
                case 'n':
                case 'N':
                    return "n";
                case 'o':
                case 'O':
                    return "o";
                case 'p':
                case 'P':
                    return "p";
                case 'q':
                case 'Q':
                    return "q";
                case 'r':
                case 'R':
                    return "r";
                case 's':
                case 'S':
                    return "s";
                case 't':
                case 'T':
                    return "t";
                case 'u':
                case 'U':
                    return "u";
                case 'v':
                case 'V':
                    return "v";
                case 'w':
                case 'W':
                    return "w";
                case 'x':
                case 'X':
                    return "x";
                case 'y':
                case 'Y':
                    return "y";
                case 'z':
                case 'Z':
                    return "z";
                default:return (Convert.ToString(c));
            }
        }
        string upper(char c)
        {
            switch (c)
            {

                case 'a':
                case 'A':
                    return "A";
                case 'b':
                case 'B':
                    return "B";
                case 'c':
                case 'C':
                    return "C";
                case 'd':
                case 'D':
                    return "D";
                case 'e':
                case 'E':
                    return "E";
                case 'f':
                case 'F':
                    return "F";
                case 'g':
                case 'G':
                    return "G";
                case 'h':
                case 'H':
                    return "H";
                case 'i':
                case 'I':
                    return "I";
                case 'j':
                case 'J':
                    return "J";
                case 'k':
                case 'K':
                    return "K";
                case 'l':
                case 'L':
                    return "L";
                case 'm':
                case 'M':
                    return "M";
                case 'n':
                case 'N':
                    return "N";
                case 'o':
                case 'O':
                    return "O";
                case 'p':
                case 'P':
                    return "P";
                case 'q':
                case 'Q':
                    return "Q";
                case 'r':
                case 'R':
                    return "R";
                case 's':
                case 'S':
                    return "S";
                case 't':
                case 'T':
                    return "T";
                case 'u':
                case 'U':
                    return "U";
                case 'v':
                case 'V':
                    return "V";
                case 'w':
                case 'W':
                    return "W";
                case 'x':
                case 'X':
                    return "X";
                case 'y':
                case 'Y':
                    return "Y";
                case 'z':
                case 'Z':
                    return "Z";
                default: return (Convert.ToString(c));
            }
        }
            int length(string s)
        {
            int sum = 0;
            foreach (char y in s)
            {
                sum = sum + 1;
            }
            return sum;
        }
        bool contains(string s, string subs)
        {
            int sum = 0;
            int sum2 = 0;
            int n = 0;
            string z = "";
            foreach (char y in s)
            {
                sum = sum + 1;
            }
            foreach (char y in subs)
            {
                sum2 = sum2 + 1;
            }
            if (sum2 > 1)
            {
                for (int i = 0; i < sum; i++)
                {
                    if (s[i] == subs[0])
                    {
                        if (i < sum2)
                        {
                            z = z + s[i];
                        }
                    }

                }
            }
            if (z == subs)
            {
                return true;
            }
            else
                return false;
        }
        int indexOf(string s, string subs)
        {
            char y = subs[0];
            int i = 0;
            int sum = 0;
            foreach (char t in s)
            {
                sum = sum + 1;
            }
            while (i < sum)
            {
                if (y == s[i])
                {
                    break;
                }
                
                   
                i = i + 1;
            }
            if ( i == sum )
            {
                if (y != s[i-1])
                {
                    i = -1;
                }
            }
            return i;
        }
        string insertSubString(string s, string x, int pos)
        {
            string z = "";
            int n = 0;
            foreach(char y in s)
            { n = n + 1;
                z = z + y;
                if (n == pos)
                {
                    z = z + x;
                }
            }
            return z;
        }
        string replaceSubString(string s, string New , string old)
        {
            string p = "";
            string n ="";
            int z = 0;
            int i = 0;
            int b = 0;
            int r = 0;
            int u = 0;
            int m = 0;
            int sum = 0;
            int sum2 = 0;
            foreach (char e in s)
            {
                sum = sum + 1;
            }
            foreach (char w in New)
            {
                sum2 = sum2 + 1;
            }
            foreach (char t in old)
            {
                z = z + 1;
            }
            foreach (char a in s)
            {
                if (a == old[0])
                {
                    r = b;
                    u = b;
                    {
                        while (i < z)
                        {
                            p = p + s[r];
                            i = i + 1;
                            r = r + 1;
                        }
                    }

                }
                
                b = b + 1;
            }
            if (p == old)
            {
                while(m < sum )
                {
                    
                    if (m == u)
                    {
                        n = n + New;
                        m = m + z;

                    }
                    if (m < sum)
                    { n = n + s[m]; }
                    m = m + 1;
                }

            }
            if (p == "")
            {
                n = "";
            }
            return n;
        }
        string deleteSubString(string s, string subs)
        {
            string p = "";
            string n = "";
            int z = 0;
            int i = 0;
            int b = 0;
            int r = 0;
            int u = 0;
            int m = 0;
            int sum = 0;
            int sum2 = 0;
            foreach (char e in s)
            {
                sum = sum + 1;
            }
            foreach (char w in subs)
            {
                sum2 = sum2 + 1;
            }
            
            foreach (char a in s)
            {
                if (a == subs[0])
                {
                    r = b;
                    u = b;
                    {
                        while (i < sum2)
                        {
                            p = p + s[r];
                            i = i + 1;
                            r = r + 1;
                        }
                    }

                }

                b = b + 1;
            }
            if (p == subs)
            {
                while (m < sum)
                {

                    if (m == u)
                    {
                        n = n + "";
                        m = m + sum2;

                    }
                    if (m < sum)
                    { n = n + s[m]; }
                    m = m + 1;
                }

            }
            if (p == "")
            {
                n = s;
            }
            return n;

        }
        List <string> split(string s, char c)
        {
            string y = "";
            List<string> splits = new List<string> { };
            foreach(char u in s)
            { 
                if (c == u)
                {
                    splits.Add(y);
                    y = "";
                }
                if (u != c)
                { y = y + u; }
                else
                    y = y + "";
            }
            splits.Add(y);
            return splits;

        }
        int stringCompare(string s1, string s2)
        {
            
            int n = 0;
            int m = 0;
            int k = 0;
            List<int> n1 = new List<int> { };
            List<int> n2 = new List<int> { };

            foreach (char c in s1)
            {
                n1.Add(lettersnum(c));
            }
            foreach(char y in s2)
            {
                n2.Add(lettersnum(y));
            }
            foreach(int a in n1)
            {
                if( a == n2[k])
                {
                    n = 0;
                }
                if (a != n2[k])
                {
                    if (a > n2[k])
                    {
                        n = 1;
                        break;
                    }
                    else if (a < n2[k])
                    {
                        n = -1;
                        break;
                    }

                }
                k = k + 1;
                
            }
            return n;
                 
      
           

        }
        string toLower(string s)
        {
            string y = "";
            foreach(char c in s)
            {
                y = y + lower(c);
            }
            return y;
        }
        string toUpper(string s)
        {
            string y = "";
            foreach (char c in s)
            {
                y = y + upper(c);
            }
            return y;

        }




        private void button_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(length("xxx"), 3);
            ThinkLib.Tester.TestEq(length("money"), 5);
            ThinkLib.Tester.TestEq(length("views"), 5);
            ThinkLib.Tester.TestEq(length("university"), 10);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(contains("xxx" ,"xx"), true);
            ThinkLib.Tester.TestEq(contains("money" , "ney"), true);
            ThinkLib.Tester.TestEq(contains("views" , "sw"), false);
            ThinkLib.Tester.TestEq(contains("university", "ty"), true);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(indexOf("xxx", "x"), 0);
            ThinkLib.Tester.TestEq(indexOf("money", "ney"), 2);
            ThinkLib.Tester.TestEq(indexOf("views", "e" ),2);
            ThinkLib.Tester.TestEq(indexOf("university", "z"), -1);

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(insertSubString("xxxx", "y" , 3), "xxxyx");
            ThinkLib.Tester.TestEq(insertSubString("money", "ney", 2), "moneyney");
            ThinkLib.Tester.TestEq(insertSubString("views", "e" , 2), "vieews");
           
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(replaceSubString("xxyxx", "ooo", "y"), "xxoooxx");
            ThinkLib.Tester.TestEq(replaceSubString("money", "000", "ney"), "mo000");
            ThinkLib.Tester.TestEq(replaceSubString("views", "yx", "a"), "");
            ThinkLib.Tester.TestEq(replaceSubString("grammys", "ooo", "y"), "grammooos");
            ThinkLib.Tester.TestEq(replaceSubString("colour", "000", "ney"), "");
            ThinkLib.Tester.TestEq(replaceSubString("computer", "yx", "o"), "cyxmputer");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(deleteSubString("xxyxx", "y"), "xxxx");
            ThinkLib.Tester.TestEq(deleteSubString("money",  "ney"), "mo");
            ThinkLib.Tester.TestEq(deleteSubString("views",  "a"), "views");
            ThinkLib.Tester.TestEq(deleteSubString("grammys",  "y"), "gramms");
            ThinkLib.Tester.TestEq(deleteSubString("colour",  "ney"), "colour");
            ThinkLib.Tester.TestEq(deleteSubString("computer", "o"), "cmputer");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(split("x xx xxx", ' '),new List<string> { "x", "xx", "xxx" });
            ThinkLib.Tester.TestEq(split("i want a job", ' '), new List<string> { "i", "want", "a" , "job"});
            ThinkLib.Tester.TestEq(split("views", 'e'), new List<string> { "vi", "ws" } );
            ThinkLib.Tester.TestEq(split("grammys", 'y'), new List<string> { "gramm", "s"});
            ThinkLib.Tester.TestEq(split("colour this life", 'i'), new List<string> { "colour th", "s l", "fe" });
            ThinkLib.Tester.TestEq(split("colour this life", ' '), new List<string> { "colour", "this", "life" });

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(stringCompare("xxyxx", "xxyxx"), 0);
            ThinkLib.Tester.TestEq(stringCompare("money", "ney"), -1);
            ThinkLib.Tester.TestEq(stringCompare("views", "z"), -1);
            ThinkLib.Tester.TestEq(stringCompare("grammys", "y"), -1);
            
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(toLower("HeLLo"), "hello");
            ThinkLib.Tester.TestEq(toLower("MONEY"), "money");
            ThinkLib.Tester.TestEq(toLower("VIEWS34"), "views34");
            ThinkLib.Tester.TestEq(toLower(""), "");
            ThinkLib.Tester.TestEq(toLower("COL!!ur"), "col!!ur");
            ThinkLib.Tester.TestEq(toLower("computer"), "computer");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ThinkLib.Tester.TestEq(toUpper("HeLLo"), "HELLO");
            ThinkLib.Tester.TestEq(toUpper("MONEY"), "MONEY");
            ThinkLib.Tester.TestEq(toUpper("views34"), "VIEWS34");
            ThinkLib.Tester.TestEq(toUpper(""), "");
            ThinkLib.Tester.TestEq(toUpper("COL!!ur"), "COL!!UR");
            ThinkLib.Tester.TestEq(toUpper("compu ter"), "COMPU TER");

        }
    }
}
