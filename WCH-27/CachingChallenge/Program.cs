using System;
using System.Linq;

namespace CachingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataAccess db = new DataAccess();
            DataAccessCache db = new DataAccessCache();

            //var people = db.SimulatedPersonListLookup();
            ////people.ForEach(x => Console.WriteLine(x.FirstName));

            //people = db.SimulatedPersonListLookup();

            //people = db.SimulatedPersonListLookup();

            //db.SimulatedPersonById(3);
            //db.SimulatedPersonById(3);
            //db.SimulatedPersonById(5);
            //db.SimulatedPersonById(5);
            //db.SimulatedPersonById(5);

            db.SimulatedPersonListByLastName("Corey");
            db.SimulatedPersonListByLastName("Corey");
            db.SimulatedPersonListByLastName("Jones");
            db.SimulatedPersonListByLastName("Corey");
            db.SimulatedPersonListByLastName("Jones");

            Console.ReadLine();
        }
    }
}
