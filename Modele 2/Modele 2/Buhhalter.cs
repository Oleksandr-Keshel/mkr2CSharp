using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modele_2
{
    [Serializable] 
    internal class Buhhalter
    {
        public string Id { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }

        public Buhhalter(string id, string surname, string position, double salary, int experience)
        {
            Id = id;
            Surname = surname;
            Position = position;
            Salary = salary;
            Experience = experience;

        }
    }
}
