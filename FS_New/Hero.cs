using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingSimulator
{
    public class Hero
    {
        string name;
        string surname;
        string nickname;
        int age;
        int weight;
        int strenth;

        /// <summary>
        /// Initializes fields with default minimal data
        /// </summary>
        public Hero()
        {
            age = 18;
            weight = 40;
            strenth = 1;
        }

        public override string ToString()
        {
            return nickname;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Strength
        {
            get { return strenth; }
            set { strenth = value; }
        }
    }
}
