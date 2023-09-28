using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_123
{
    internal class PerameterizedMethod /*: Method*/
    {
        public void PerameterizedMethodEX(string firstname, string secondname) 
        {
          if (firstname == null || secondname == null)
            {
                Console.WriteLine("Pleas Enter the Reqerment");
            }
          string fullName = firstname + " " + secondname;
            Console.WriteLine(fullName);
        }

        public void Callmethod()
        {
          Console.WriteLine("Enter The FIrstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter The secondname");
            string secondname = Console.ReadLine();
            PerameterizedMethodEX(firstname, secondname);
            //Sumoftwonumber();
        }
    }
}
