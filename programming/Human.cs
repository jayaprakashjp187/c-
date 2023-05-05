using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming
{
    internal class Human
    {
        public string name;
        public float height;
        public long phoneNumber;
        public void HumanDetails()
        {
            Console.WriteLine("name:{0} height:{1} phoneNumber:{2}", name, height, phoneNumber);
        }

    }
}
