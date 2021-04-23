using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        /// <summary>
        /// Mernis sisteminde gerçek kişiye sahip olma durumuna göre maske dağıtımına karar veren metot.
        /// </summary>
        /// <param name="person"></param>
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }

            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");

            }
        }
    }
}
