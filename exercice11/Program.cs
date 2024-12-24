using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


using System.Runtime.InteropServices;

using exercice11;
using exercice11.Classes;

Salarie Melanie = new Salarie(1, "Espionnage", "Mélanie", 45000);
Salarie Samuel = new Salarie(2, "Renseignements", "Samuel", 52000);
Salarie Lisa = new Salarie(3, "Informatique", "Lisa", 70000);

List<Salarie> listeSalariés = new List<Salarie>();
listeSalariés.Add(Samuel);
listeSalariés.Add(Lisa);
listeSalariés.Add(Melanie);

Melanie.AfficherSalaire();
Samuel.AfficherSalaire();
Lisa.AfficherSalaire();


Salarie.AfficherEntreprise(listeSalariés);