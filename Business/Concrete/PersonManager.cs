using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    /// <summary>
    /// Türkiye cumhuriyeti vatandaşlarının takibinin yapılmasını sağlayan sınıf.
    /// </summary>
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public IList<Person> GetList()
        {
            return null;
        }

        /// <summary>
        /// Uygulamamıza ilgili servisi entegre ettik.
        /// https://tckimlik.nvi.gov.tr/service/kpspublic.asmx adresinden yapılan servis isteği; verilen bilgiler hatalı ise false döndürecek.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirdYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
