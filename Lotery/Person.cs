using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotery
{
    class Person
    {
        private string name;
        private string numgrup;
        int points;
        public string Name
        {
            get { return name; }

        }

        public string NumGrup
        {
            get { return numgrup; }

        }
        public int Points
        {
            get { return points; }
            set { }
        }

        public Person(string name, string number, int point)
        {
            this.name = name;
            this.numgrup = number;
            this.points = point;
        
        }

    }
}
