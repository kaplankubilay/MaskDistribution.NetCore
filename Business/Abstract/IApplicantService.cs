using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        IList<Person> GetList();

        bool CheckPerson(Person person);
    }
}
