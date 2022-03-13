using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixSuns
{
    public class Phoenix //NBA team roster
    {
        public string name;
        public string surname;
        public int age;
        public int ppg;// ppg - point per game
        public int shirtNumber;
        public Phoenix(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public Phoenix(string name, string surname, int age, int ppg) : this(name, surname, age)
        {
            this.ppg = ppg;
        }
        public Phoenix(string name, string surname, int age, int ppg, int shirtNumber) : this(name, surname, age, ppg)
        {
            this.shirtNumber = shirtNumber;
        }

    }
}
