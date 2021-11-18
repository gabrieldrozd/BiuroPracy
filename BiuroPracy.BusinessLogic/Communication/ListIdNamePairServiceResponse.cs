using BiuroPracy.BusinessLogic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPracy.BusinessLogic.Communication
{
    public class ListIdNamePairServiceResponse : ServiceResponse
    {
        public List<IdNamePair> Data { get; set; }
    }
}
