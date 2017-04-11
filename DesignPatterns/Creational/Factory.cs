using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public interface IPeople
    {
        string GetName();
    }

    public class Villagers: IPeople
    {
        public string GetName()
        {
            return "Village Guy";
        }
    }

    public class CityPeople : IPeople
    {
        public string GetName()
        {
            return "City Guy";
        }
    }

    public enum PeopleType
    { 
        RURAL,
        URBAN
    }

    public class Factory
    {
        public IPeople GetPeople(PeopleType type)
        {
            IPeople people = null;
            switch (type)
            {
                case PeopleType.RURAL: people = new Villagers(); break;
                case PeopleType.URBAN: people = new CityPeople(); break;
                default: break;
            }

            return people;
        }
    }
}
