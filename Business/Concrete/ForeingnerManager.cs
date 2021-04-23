using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    /// <summary>
    /// Yabancı uyruklu vatandaşların maske takibinin yapılmasını sağlayan sınıf.
    /// </summary>
    public class ForeingnerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
