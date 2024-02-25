using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_9__panel_kulanımı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            webBrowser1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = listBox1.SelectedItem.ToString();
            webBrowser1.Navigate(selectedValue);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ilk sekme oluştur.
            YeniSekmeEkle();
            InitializeComboBox();

        }
        private void InitializeComboBox()
        {
            // ComboBox'a siteleri ekle
            toolStripComboBox1.Items.Add("https://www.google.com");
            toolStripComboBox1.Items.Add("https://www.yandex.com");
            toolStripComboBox1.Items.Add("https://www.youtube.com");

            // Varsayılan olarak ilk siteyi seç
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }   
 
        private void button6_Click_1(object sender, EventArgs e)
        {
            // Butona basıldığında ListBox'un görünürlüğünü değiştir
            listBox1.Visible = !listBox1.Visible;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
            //git butonuna basıldında seçilen sekmeyi aç
            string selectedSite = toolStripComboBox1.SelectedItem.ToString();
            webBrowser1.Navigate(selectedSite);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //bi önceki sayfaya getirir
            webBrowser1.GoBack();           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //sayfayı yeniler
            webBrowser1.Refresh();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // Butona basıldığında ListBox'un görünürlüğünü değiştir
            
            listBox1.Visible = !listBox1.Visible;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //önceden girip geri bastığın sayfaya götürür
            webBrowser1.GoForward();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //listbox 1 i görünür yapar
            listBox2.Visible = !listBox2.Visible;

            string site = toolStripTextBox1.Text;

            // Boş bir giriş yapılmışsa eklemeyi önle
            if (!string.IsNullOrEmpty(site))
            {
                listBox2.Items.Add(site);
                toolStripTextBox1.Clear();  // Giriş kutusunu temizle
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            listBox2.Visible = !listBox1.Visible;
        }
        private void YeniSekmeEkle()
        {
            
            TabPage yeniSekme = new TabPage();
            tabControl1.TabPages.Add(yeniSekme);
            
            WebBrowser yeniWebBrowser = new WebBrowser();
            yeniWebBrowser.Dock = DockStyle.Fill;

            yeniSekme.Text = "Yeni Sekme";

            yeniSekme.Controls.Add(yeniWebBrowser);
            
            yeniWebBrowser.Navigate("https://www.google.com");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            YeniSekmeEkle();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {            
            int aktifSekmeIndex = tabControl1.SelectedIndex;

            // Son sekme varsa ve silme butonuna basılıyorsa
            if (tabControl1.TabPages.Count > 1 && aktifSekmeIndex >= 0)
            {
                // sekmeyi kaldır
                tabControl1.TabPages.RemoveAt(aktifSekmeIndex);
            }
        }
    }
}
