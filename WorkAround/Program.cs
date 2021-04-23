using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Kubilay";
            person1.LastName = "Kaplan";
            person1.DateOfBirdYear = 1985;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
