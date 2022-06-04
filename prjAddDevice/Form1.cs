using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAddDevice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string connection = "Server=tcp:mydatabase01.database.windows.net,1433;Initial Catalog=MyDataBase;Persist Security Info=False;User ID=User1;Password=Kbs12sbK3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection MyDataBase = new SqlConnection(connection);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;


        private void button1_Click(object sender, EventArgs e)
        {
            MyDataBase.Open();

            string sql = "INSERT INTO Table_2 (DeviceDesc)" +
                "VALUES (@DeviceTypeDescription)";
            dbComm = new SqlCommand(sql, MyDataBase);
            dbComm.Parameters.AddWithValue("DeviceTypeDescription", textBox2.Text);

            int x = dbComm.ExecuteNonQuery();

            if (x>0)
            {
                MessageBox.Show(x + " Added");
            }
            MyDataBase.Close();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            MyDataBase.Open();

            string sql = "SELECT * FROM Table_2;";

            dbComm = new SqlCommand(sql, MyDataBase);

            dbAdapter = new SqlDataAdapter(dbComm);

            dt = new DataTable();

            dbAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            MyDataBase.Close();
        }

       

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["DeviceTypeID"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["DeviceTypeDescription"].Value.ToString();
            }

        }
    }
}
