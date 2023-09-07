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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // veri tabanını bağlamak için bu kodu kullandım
            yemekEntities entities = new yemekEntities();
            Table_Kisi kisi = entities.Table_Kisi.FirstOrDefault(x => x.email == email_textBox.Text && x.sifre == sifre_textBox.Text);


            // eğer bilgiler null değilse yani veri tabanındaki bilgilerle uyuşuyorsa form3 e geçecek ve sayfayı kapatacak bu yüzden  için bu kodları kullandım
            if (kisi != null)
            {
                

                Form3 form3 = new Form3();
                form3.Show();
              
                this.Hide();

            }
            // burda ise girilen e mail ve şifre yanlış ise email adresi veya şifre yanlış  yazısı  uyarı şeklinde label de kırmızı gözüksün diye bu kodu kullandım
            else
            {
                uyarı_label.Visible = true;
                uyarı_label.Text = "Email Adresi veya Şifre Yanlış";
                uyarı_label.ForeColor = Color.Red;
            }
        }

        private void Eklemeİslemi()
        {
            // veri tabanını bağlamak için yazdım
            yemekEntities entities = new yemekEntities();
            //table_kişi nin ismini kişi olarak yapmak için bunu yazdım
            Table_Kisi kisi = new Table_Kisi();
            //  email_ textbox ına girilen emaili vedri tabanındaki tabloda  eamail kısmına atadım
            kisi.email = email_textBox.Text;
            // şifre_textbox ına girilen şifreyi veri tabanındaki tabloda şifre kısmına atadım
            kisi.sifre = sifre_textBox.Text;

            // bilgileri kaydetmek için bu kodu kullandım
            entities.Table_Kisi.Add(kisi);
            entities.SaveChanges();
        }

        private void sifre_textBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void email_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  kullanıcının pizza şubelerini  görmek için butona bastığında şubelerin bulunduğu form a geçmesi için bu kodu kullandım
            Form4 form4 = new Form4();
            form4.Show();


        }
    }
}
