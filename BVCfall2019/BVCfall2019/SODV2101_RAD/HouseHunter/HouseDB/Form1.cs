using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace HouseDB
{
    public partial class Form1 : Form
    {

        public String dbConnection;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void THouseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHouseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.houseHunterDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'houseHunterDBDataSet.THouse' table. You can move, or remove it, as needed.
            this.tHouseTableAdapter.Fill(this.houseHunterDBDataSet.THouse);
            dbConnection = ConfigurationManager.ConnectionStrings["HouseDB.Properties.Settings.HouseHunterDBConnectionString"].ConnectionString;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PopulateList();
        }



        private void PopulateList()
        {
            using (SqlConnection myConnection = new SqlConnection(dbConnection)) 
            using (SqlDataAdapter clientDataAdapter = new SqlDataAdapter("SELECT * FROM THouse", myConnection))
            {
                DataTable clientData = new DataTable();

                myConnection.Open();
                clientDataAdapter.Fill(clientData);
                myConnection.Close();


                for(int row =0;row<clientData.Rows.Count;row++)
                {
                    int id = (int)clientData.Rows[row]["Id"];
                    string name = (string)clientData.Rows[row]["Descrip"];
                    string address = (string)clientData.Rows[row]["Address"];

                    listBox.Items.Add($"{id,-10}{name,-3}{address}");
                }

            }
        }
    }
}
