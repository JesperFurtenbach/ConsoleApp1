using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Members      
    {
        public Members(int id, string name, string adress, string postnr, string postadress)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Postnr = postnr;
            Postadress = postadress;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAdress()
        {
            return Adress;
        }


        public int Id { get; }
        public string Name { get; }
        public string Adress { get; }
        public string Postnr { get; }
        public string Postadress { get; }
    }
}
