using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeTime
{
    public partial class Provinces : UserControl
    {
        public Provinces()
        {
            InitializeComponent();
        }

        private void ProvinceCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Provinces_Load(object sender, EventArgs e)
        {
            List<ProvinceClass> list = new List<ProvinceClass>();
            list.Add(new ProvinceClass() { ID = 1, Name = "Alberta" });
            list.Add(new ProvinceClass() { ID = 2, Name = "Ontario" });
            list.Add(new ProvinceClass() { ID = 3, Name = "Quebec" });
            list.Add(new ProvinceClass() { ID = 4, Name = "Northwest Terr" });
            list.Add(new ProvinceClass() { ID = 5, Name = "Yukon" });
            provinceCmb.DataSource = list;
            provinceCmb.ValueMember = "ID";
            provinceCmb.DisplayMember = "Name";
        }
        public ProvinceClass SelectedProvince
        {
            get
            {
                return (ProvinceClass)provinceCmb.SelectedItem;
            }
        }
    }
}
