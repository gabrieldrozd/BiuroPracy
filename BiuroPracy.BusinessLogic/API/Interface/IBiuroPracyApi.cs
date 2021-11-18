using BiuroPracy.BusinessLogic.Communication;
using BiuroPracy.BusinessLogic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPracy.BusinessLogic.API.Interface
{
    public interface IBiuroPracyApi
    {
        void TestNHibernate();

        /// <summary>
        /// Metoda pobierająca dane z tabeli Profession
        /// </summary>
        /// <returns>Zwaraca listę Id - Name</returns>
        ListIdNamePairServiceResponse GetProfessions();

        /// <summary>
        /// Metoda pobierająca dane z tabeli Contracts
        /// </summary>
        /// <returns>Zwaraca listę Id - Name</returns>
        ListIdNamePairServiceResponse GetContracts();

        /// <summary>
        /// Metoda pobierająca dane z tabeli Cities
        /// </summary>
        /// <returns>Zwaraca listę Id - Name</returns>
        ListIdNamePairServiceResponse GetCities();

        /// <summary>
        /// Metoda pobierająca dane z tabeli Countries
        /// </summary>
        /// <returns>Zwaraca listę Id - Name</returns>  
        ListIdNamePairServiceResponse GetCountries();

        ServiceResponse AddEmployee(EmployeeDto employee)
    }
}
