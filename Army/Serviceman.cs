using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Army
{
    public class Serviceman
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int NumMillitaryTicket;
        public string Rank;
        public int NumMillitaryUnit;
        public readonly DateTime Date;
        public readonly TypeOfService TypeOfService;

        public Serviceman(string name, string surname, int numMillitaryTicket, string rank, int numMillitaryUnit, string data, TypeOfService typeofservice)
        {
            Name = name;
            Surname = surname;
            NumMillitaryTicket = numMillitaryTicket;
            Rank = rank;
            NumMillitaryUnit = numMillitaryUnit;
            Date = DateTime.Parse(data);
            TypeOfService = typeofservice;
        }

        public string GetInfo()
        {
            var typeofservice = "";
            if (TypeOfService == TypeOfService.Contract)
                typeofservice = "контракт";
            if (TypeOfService == TypeOfService.Urgent)
                typeofservice = "срочное";
            return $"{Name} {Surname}. Номер билета {NumMillitaryTicket} Номер военной части {NumMillitaryTicket} Звание {Rank} Дата поступления на службу {Date} Тип службы {TypeOfService}.";
        }

    }
}