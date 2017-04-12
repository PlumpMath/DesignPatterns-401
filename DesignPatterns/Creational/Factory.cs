using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Factory pattern deals with the instantiation of object without exposing the instantiation 
 * logic. In other words, a Factory is actually a creator of object which has common interface.
 *
 * In the code you can see I have created one interface called IPeople and implemented two 
 * classes from it as Villagers and CityPeople. Based on the type passed into the factory 
 * object, I am sending back the original concrete object as the Interface IPeople.
 */

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
