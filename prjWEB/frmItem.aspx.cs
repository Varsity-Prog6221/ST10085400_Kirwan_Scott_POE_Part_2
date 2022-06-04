using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWEB
{
    public partial class frmItem : System.Web.UI.Page
    {
        static string connection = "Data Source = localhost; Initial Catalog = ; Integrated Security = ";
        SqlConnection dbconn = new SqlConnection(connection);
        SqlCommand dbcom;
        SqlDataAdapter dbadapt;
        DataTable dbtable;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void getCategory()
        {

        }
    }
}