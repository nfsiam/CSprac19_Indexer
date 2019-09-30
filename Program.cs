using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSprac19_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            School s = new School();

            //printing names using id
            Console.WriteLine(s[1]);
            Console.WriteLine(s[3]);

            //changing names through id
            s[1] = "Changed Siam";
            s[3] = "Changed Tamim";

            //printing names again after changing
            Console.WriteLine(s[1]);
            Console.WriteLine(s[3]);

            //printing department names using names
            Console.WriteLine(s["Habib"]);
            Console.WriteLine(s["Ahad"]);

            //changing department using name
            s["Habib"] = "BBA";
            s["Ahad"] = "CSE";

            //again printing department names using names
            Console.WriteLine(s["Habib"]);
            Console.WriteLine(s["Ahad"]);

            Console.ReadLine();
        }
    }
}
