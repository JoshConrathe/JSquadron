using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection conn = new SqlConnection(@"Data Source=v00egd00002l.lec-admin.dmu.ac.uk;Initial Catalog=p2729217;User ID=p2729217;Password=hospitalHarD1209;Connect Timeout=30;Encrypt=True;");

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        conn.Open();
        PatientID.Text = " ";
        PatientName.Text = " ";
        PatientAddress.Text = " ";
        PatientHistory.Text = " ";
        PatientNumber.Text = " ";
        AdminID.Text = " ";
        PatientDBO.Text = " ";
        conn.Close();
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        conn.Open();
        PatientID.Text = " ";
        PatientName.Text = " ";
        PatientAddress.Text = " ";
        PatientHistory.Text = " ";
        PatientNumber.Text = " ";
        AdminID.Text = " ";
        PatientDBO.Text = " ";
        conn.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("Insert into Patient values ('" + PatientName.Text + "','" + PatientDBO.Text + "','" + PatientNumber.Text + "','" + PatientAddress.Text + "','" + PatientHistory.Text + "','" + AdminID.Text + "')", conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
        Response.Write("successful");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("delete  from Patient where PatientID= '" + Convert.ToInt32(PatientID.Text).ToString() + "'", conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
        Clear();
    }
    void Clear()
    {
        conn.Open();
        PatientID.Text = " ";
        PatientName.Text = " ";
        PatientAddress.Text = " ";
        PatientHistory.Text = " ";
        PatientNumber.Text = " ";
        AdminID.Text = " ";
        PatientDBO.Text = " ";
        conn.Close();
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand update = new SqlCommand("update Patient set name='" + PatientName.Text + "',dob='" + PatientDBO.Text + "',number='" + PatientNumber.Text + "',address='" + PatientAddress.Text + "',medhistory='" + PatientHistory.Text + "'where PatientID='" + PatientID.Text + "'", conn);
        update.ExecuteNonQuery();
        conn.Close();
        GridView1.DataBind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        conn.Open();
        string find = "select * from Patient where(PatientID like '%'+@PatientID+'%')";
        SqlCommand cmd = new SqlCommand(find, conn);
        cmd.Parameters.Add("PatientID", SqlDbType.NVarChar).Value = Search.Text;
        cmd.ExecuteNonQuery();
        SqlDataAdapter ad = new SqlDataAdapter();
        ad.SelectCommand = cmd;
        DataSet ds = new DataSet();
        ad.Fill(ds, "PatientID");
        GridView1.DataSourceID = null;
        GridView1.DataSource = ds;
        GridView1.DataBind();
        conn.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        PatientID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
        PatientName.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
        PatientDBO.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
        PatientNumber.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
        PatientAddress.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
        PatientHistory.Text = GridView1.SelectedRow.Cells[6].Text.ToString();
        AdminID.Text = GridView1.SelectedRow.Cells[7].Text.ToString();
    }
}