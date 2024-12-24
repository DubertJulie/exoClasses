using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace exercice11.Classes
{
    internal class Salarie
    {

        // attributs
        private int _matricule;
        private string _service;
        private string _name;
        private int _salary;

        // propriétés 
        public int Matricule { get { return _matricule; } set { _matricule = value; } }
        public string Service { get { return _service; } set { _service = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Salary { get { return _salary; } set { _salary = value; } }

        // constructeur 
        public Salarie(int matricule, string service, string name, int salary)
        {
            Matricule = matricule;
            Service = service;
            Name = name;
            Salary = salary;
        }



        public Salarie()
        {
            Matricule = 0;
            Service = "Comptabilité";
            Name = "John Doe";
            Salary = 999;
        }

        public void AfficherSalaire()
        {
            Console.WriteLine("Le salaire de " + Name + " est de " + Salary + " euros");
        }

        public static void AfficherEntreprise(List<Salarie> listeSalariés)
        {
            int SalaireTotal = 0;

            foreach (var item in listeSalariés)
            {
                SalaireTotal += item.Salary;
            }

            Console.WriteLine("Le salaire total est de " + SalaireTotal + "euros pour " + listeSalariés.Count + " employés");
            Console.WriteLine("Le salaire moyen est de " + SalaireTotal / listeSalariés.Count + " euros");
        }

    }
}
