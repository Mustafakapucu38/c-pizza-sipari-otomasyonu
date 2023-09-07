using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verileri çekmek için bu kodları kullandım
            yemekEntities entities = new yemekEntities();
            var list2 = entities.Table_Siparis.ToList();
          
            var bindingList = new BindingList<Table_Siparis>(list2);
            var source = new BindingSource(bindingList, null);
          
            dataGridView1.DataSource = source;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            // veri tabanını bağlamak için bu kodu kullandım
            yemekEntities entities = new yemekEntities();

            if (e.ColumnIndex == 0)
            {
                //silinen kaydın bulunması için bu kodları kullandım
                var id=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                var silinen = entities.Table_Siparis.FirstOrDefault(s => s.id == id);
                if (silinen != null)
                {
                    // burda silme işlemi yapmak için bu kodu kullandım
                    entities.Table_Siparis.Remove(silinen);
                    entities.SaveChanges();

                    //burda ise verileri geri çekmek için bu kodu kullandım
                    var list2 = entities.Table_Siparis.ToList();
                    var bindingList = new BindingList<Table_Siparis>(list2);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                }

            }
        }
    }



}


