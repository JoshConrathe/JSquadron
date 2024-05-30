using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection conn = new SqlConnection(@"Data Source=v00egd00002l.lec-admin.dmu.ac.uk;Initial Catalog=p2729217;User ID=p2729217;Password=hospitalHarD1209;Connect Timeout=30;Encrypt=True;");

    protected void Submit_Click(object sender, EventArgs e)
    {
       
    }
}
