using BiuroPracy.BusinessLogic.API.Interface;
using BiuroPracy.BusinessLogic.Communication;
using BiuroPracy.BusinessLogic.ModelDTO;
using BiuroPracy.BusinessLogic.NHibernate;
using BiuroPracy.Domain;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPracy.BusinessLogic.API
{
    public class BiuroPracyApi : BaseApi, IBiuroPracyApi
    {
        public ListIdNamePairServiceResponse GetCities()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var cities = session.Query<City>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();

                    return new ListIdNamePairServiceResponse()
                    {
                        Data = cities
                    };
                }
            }
            catch (Exception ex)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = string.Format($"{ex.StackTrace} {ex.Message}"),
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetContracts()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var contracts = session.Query<Contract>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();

                    return new ListIdNamePairServiceResponse()
                    {
                        Data = contracts
                    };
                }
            }
            catch (Exception ex)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = string.Format($"{ex.StackTrace} {ex.Message}"),
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetCountries()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var countries = session.Query<Country>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();

                    return new ListIdNamePairServiceResponse()
                    {
                        Data = countries
                    };
                }
            }
            catch (Exception ex)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = string.Format($"{ex.StackTrace} {ex.Message}"),
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetProfessions()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var professions = session.Query<Profession>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();
                    
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = professions
                    };
                }
            }
            catch (Exception ex)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = string.Format($"{ex.StackTrace} {ex.Message}"),
                    Success = false
                };
            }
        }

        public void TestNHibernate()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var profession = session.Get<Profession>(1);
                    }
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
