using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BiuroPracy.BusinessLogic.API.Interface;
using BiuroPracy.BusinessLogic.API;

namespace BiuroPracy.pages
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestNHibernate_Click(object sender, EventArgs e)
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            api.TestNHibernate();
        }
    }
}