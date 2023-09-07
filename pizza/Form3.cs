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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void vejeteryanPizzaÇeşitleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void akdenizliToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            // burda akdenizliTollStripMenuItem_Click e basıldığında akdenizli pizzanın içindeki malzemeleri richTexBox da göstermek için yazdım 

            richTextBox1.Text = "(Fiesta) Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik...";
        }

        private void vejeteryaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // burda vejeteryaTollStripMenuItem_Click e basıldığında vejeterya pizzanın içindeki malzemeleri richTexBox da göstermek için yazdım 

            richTextBox1.Text= "(Vejeteryan) Pizza Sosu, Mozarella Peyniri, Mantar, Fırınlanmış Patlıcan, Siyah Zeytin, Kırmızı Köz Biber, Brokoli...";


        }

        private void temargaritaToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            // burda temargaritaTollStripMenuItem_Click e basıldığında termargarita pizzanın içindeki malzemleri richTexBox da göstermek için yazdım 

            richTextBox1.Text = "(Margarita) Pizza Sosu, Mozarella Peyniri, Domates...";
        }

        private void kuvurmalıPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  kuvurmalıPizzaTollStripMenuItem_Click e basıldığında kavurmalı pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "Pizza Sosu, Mozarella Peyniri, Kavurma, Mantar, Yeşil Biber, Soğan...";
        }

        private void pastırmalıPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  pastırmalıPizzaTollStripMenuItem_Click e basıldığında pastırmalı pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "Pizza Sosu, Mozarella Peyniri, Pastırma, Domates, Yeşil Biber, Mantar...";
        }

        private void kaburgalıPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  kaburgalıPizzaTollStripMenuItem_Click e basıldığında kaburgalı pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "Barbekü Sos, Mozarella Peyniri, Fırınlanmış Patlıcan, Füme Kaburga, Soğan, Mantar, Susam, Kekik...";
        }

        private void barbekülüTavukluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  barbekülüTavukluTollStripMenuItem_Click e basıldığında tavuklu barbekülü pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "Pizza Sosu/Barbekü Sos, Mozarella Peyniri, Tavuk Parçaları, Jalepeno, Kırmızı Köz Biber, Mısır, Siyah Zeytin...";
        }

        private void bolBolPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  bolBolTollStripMenuItem_Click e basıldığında bol bol pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "Pizza Sosu, Mozarella Peyniri, Dilim Sucuk, Küp Sucuk, Soğan, Yeşil Biber, Mantar, Siyah Zeytin, Mısır, Şerit Sosis, Kırmızı Közleme Biber, Susam...";
        }

        private void superSucukluPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  superSucukluPizzaTollStripMenuItem_Click e basıldığında super sucuklu pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "(Sucukçu) Pizza Sosu, Mozarella Peyniri, Küp Sucuk, Siyah Zeytin, Mantar, Kırmızı Köz Biber, Kekik..";
        }

        private void meksikalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // burda  meksikalıTollStripMenuItem_Click e basıldığında meksikalı pizzanın içindeki malzemeleri  richTexBox da göstermek için yazdım

            richTextBox1.Text = "(Mexico) Pizza Sosu, Mozarella Peyniri, Sucuk, Jalapeno Biber, Mısır, Küp Domates, Mantar, Kekik..";
        }

        private void button1_Click(object sender, EventArgs e)

        {
            // burda butona basıldığında progresbar ın %100 dolması için yazım
            progressBar1.Value = 100;

            //burda ise butona basıldığında siparişin yapılacağı  form a geçmek için yazdım

            Form1 form1 = new Form1();
            form1.Show();


            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

