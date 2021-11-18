using BiuroPracy.BusinessLogic.API;
using BiuroPracy.BusinessLogic.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiuroPracy.Controls
{
    public partial class PlaceOfResidenceControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitCountries()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetCountries();

            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }

            ddlCountry.DataSource = dataResponse.Data;
            ddlCountry.DataTextField = "Name";
            ddlCountry.DataValueField = "Id";
            ddlCountry.DataBind();
        }

        private void InitCities()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetCities();

            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }

            ddlCity.DataSource = dataResponse.Data;
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "Id";
            ddlCity.DataBind();
        }

        private void InitControl()
        {
            InitCountries();
            InitCities();
        }
    }
}