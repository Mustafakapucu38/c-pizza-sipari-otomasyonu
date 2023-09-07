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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // veri tabanını bağlamak için bu kodu kullandım 
            yemekEntities context = new yemekEntities();
            Table_Siparis table_Siparis = new Table_Siparis();

            // veri tabanında oluşturduğum tablodaki isim bölümüne texbox1 e girilen ismi göndermek için bu kodu kullandım
            table_Siparis.isim = textBox1.Text;

            // maskedtextbox1 e girilen telefon numarasını sql veri tabanında oluşturduğum tablodaki telefon bölüne göndermek için bu kodu kulladım
            table_Siparis.telefon = maskedTextBox1.Text;

            // textbox3 e girilen adresi sql veri tabanında oluşturduğum tablodaki adres  bölümüne  göndermek için bu kodu kulladım
            table_Siparis.adres = textBox3.Text;

            // combobox1 de seçilen pizza boyutunu sql veri tabanında oluşturduğum tablodaki pizzaboy bölümüne  göndermek için bu kodu kullandım
            table_Siparis.pizzaboy = comboBox1.Text;

            // combobox2 de seçilen içeceğin ismini sql veri tabanında oluşturduğum tablodaki içecek  bölümüne göndermek için bu kodu kullandım
            table_Siparis.icecek =  comboBox2.Text;

            //  combobox3 de seçilen pizza türünü sql veri tabanında oluşturduğum tablodaki pizzaturu  bölümüne göndermek için bu kodu kullandım 
            table_Siparis.pizzaturu = comboBox3.Text;

           
            // burda ise sipariş verilen tarihin sql  veri tabanında oluşturduğum tablodaki sipariş tarihine göndermek için buu kodu kullandım
            table_Siparis.siparistarihi = dateTimePicker1.Text;

            // numericupdown daki değeri int a dönüştürdüm ilk olarak çünkü veri tabanımdaki tabloda pizzaadeti ınt olarak seçmiştim.
            // ve seçilen değeri veri tabanındaki tabloda pizzaadeti kısmına göndermek için bu kodu kullandım
            table_Siparis.pizzadeti = Convert.ToInt32(numericUpDown1.Value);

            // eğer checkbox1 seçilirse checkbox1 deki text i veri tabanındaki tabloda çeşitler bölümüne göndermek için bu kodu kullandım
            if (checkBox1.Checked)
            {
                table_Siparis.cesitler = table_Siparis.cesitler + "," + checkBox1.Text;
            }
            
            // eğer checkbox2 seçilirse checkbox2 deki text i veri tabanındaki tabloda çeşitler bölümüne göndermek için bu kodu kullandım
            if (checkBox2.Checked)
            {
                table_Siparis.cesitler = table_Siparis.cesitler + "," + checkBox2.Text;
            }
           
            //eğer checkbox3 seçilirse checkbox3  deki text i veri tabanındaki tabloda çeşitler bölümüne göndermek için bu kodu kullandım
            if (checkBox3.Checked)
            {
                table_Siparis.cesitler = table_Siparis.cesitler + "," + checkBox3.Text;
            }

            // burda ise sipariş veren kişinin eğer radiobuton5 i şeçerse promosyon istemediğini 
            //radiobutton4 ü şeçerse promosyon istediğini sql veri tabanında promosyon bölümünde göstermek  için bu kodları kullandım
            if (radioButton5.Checked)
            {
                table_Siparis.promosyon = false;
            }
            else if (radioButton4.Checked)
            {
                table_Siparis.promosyon = true;
            }

            // burda butona basılınca diğer forma geçmek için bu kodu kullandım
            Form5 form5 = new Form5();
            form5.Show();

            // sipariş ver butonuna basılınca bu form kapansın diye bu kodu kullandım
            this.Hide();


            

            // girilen bilgilerin veri tabanına kaydedilmesi için bu kodu kullandım
            context.Table_Siparis.Add(table_Siparis);
            context.SaveChanges();





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
