using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace ProyectoLenguajes
{
    public partial class CRUDPlates : System.Web.UI.Page
    {

        private BussinessLogicLayer bll = new BussinessLogicLayer();
        private DataTable dataTable = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
  
        }


        private void load() {
            //dataTable = bll.getClientsList();
            GridViewPlates.DataSource = dataTable;
            GridViewPlates.DataBind();
        }

    }
}