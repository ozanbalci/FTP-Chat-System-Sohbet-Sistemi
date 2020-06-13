//*******************************************************************
//                                                                  *
// infinitywaredeveloper tarafında geliştirilidi // developed by    *
//                                                                  *
//*******************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // sistem ağına bağlanmana yarar // helps you connect to the system network

// // FTP Connect yönetemi ile çalışır // Works with FTP Connect management

///  FTP yötemi ile çalışıyor sistem giriş ve şifrenizi kullanarak sunucuya bağlanıyor ... /// orks with FTP method, the system connects to the server using your login and password ..


namespace chat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        WebClient ftp = new WebClient();

        string nick;

        private void Form1_Load(object sender, EventArgs e) // Form yükelemesi yapar ve yükleme sırasında altaki işlemler uygulanır ..
        {                                                  // Loads forms and the following operations are applied during the loading..
            textBox1.Enabled = true;
            button1.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            button2.Enabled = false;
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
           {
            if (textBox1.Text == "" || textBox1.Text == "ADMİN") // ADMİN Adı ile giriş yapılmasını önler // Prevents login with ADMIN Name
            {
            MessageBox.Show("Your Name İs Wrong", "Nick", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
            // Chat sistemi indirmeye başlar indirme ftp üzerinde olur // Chat system starts downloading, download is on ftp
            else
            {
                nick = Convert.ToString(textBox1.Text);
                textBox1.Enabled = false;
                button1.Enabled = false;
                richTextBox1.Enabled = true;
                richTextBox2.Enabled = true;
                button2.Enabled = true;

                try // HATA KONTUROLÜ
                {
                    ftp.Credentials = new NetworkCredential("Ftp Login Name", "Enter Ftp Password"); // ftp yolu hesap bilgileri ( "login , Password" ) ftp path account information
                    richTextBox1.Text = ftp.DownloadString("ftp://chatverti.com/panel.txt"); // ftp dosya yolu ( site yolu değildir ) ftp file path  (is not a site path)
                    timer1.Enabled = true;                 // örnek yol ' sample path
                }
               

                catch
                    {
                    MessageBox.Show("Incorrect admin channel is closed on the server", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // hata mesajını yükler // loads the error message
                    textBox1.Enabled = true;
                    button1.Enabled = true;
                    richTextBox1.Enabled = false;
                    richTextBox2.Enabled = false;
                    button2.Enabled = true;
                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    textBox1.Clear();
                }
                richTextBox1.SelectionStart = richTextBox1.Text.Length;// Richtextboxtaki verilerin sonunda gelindi // The data in Richtextbox is finally reached
                richTextBox1.ScrollToCaret();// Richtextboxtaki verilerin sonunda gelindi // The data in Richtextbox is finally reached
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(8);// progressbar geçikme süresini hesaplar gösterir // shows progressbar delay time
            if (progressBar1.Value == 100) // progressbar yüzde yüze gelirse chat yenilenir // If the progressbar comes to one hundred percent, the chat is renewed
            {
                timer1.Stop();
                progressBar1.Value = 0;
                try // HATA KONTUROLÜ
                {
                    ftp.Credentials = new NetworkCredential("Ftp Login Name", "Enter Ftp Password"); // ftp yolu hesap bilgileri ( "login , Password" ) ftp path account information
                    richTextBox1.Text = ftp.DownloadString("ftp://chatverti.com/panel.txt"); // ftp dosya yolu ( site yolu değildir ) ftp file path  (is not a site path)
                }                                          // örnek yol ' sample path

                catch
                {
                    MessageBox.Show("Sunucuda hatalı admin kanalı kapatılmış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);// hata mesajını yükler
                    textBox1.Enabled = true;
                    button1.Enabled = true;
                    richTextBox1.Enabled = false;
                    richTextBox2.Enabled = false;
                    button2.Enabled = false;
                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    textBox1.Clear();
                }
            }
            timer1.Start();      
        }

        private void button2_Click(object sender, EventArgs e)
            
        
        {
          try
            {
                ftp.Credentials = new NetworkCredential("Ftp Login Name", "Enter Ftp Password: kN3S");  // ftp yolu hesap bilgileri ( "login , Password" ) ftp path account information
                ftp.UploadString("ftp://chatverti.com/panel.txt", richTextBox1.Text + nick + " : " + richTextBox2.Text + "\n");  // Sizin yazdığınız yazıyı chat yükler // Uploads the text you wrote by chat
            }

            catch
            {
                MessageBox.Show("Sunucuda hatalı admin kanalı kapatılmış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);// hata mesajını yükler // loads the error message
                textBox1.Enabled = true;
                button1.Enabled = true;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                button2.Enabled = false;
                richTextBox1.Clear();
                richTextBox2.Clear();
                textBox1.Clear();
            }
            richTextBox2.Clear(); // clears messages // mesajları siler
            richTextBox1.SelectionStart = richTextBox1.Text.Length;// veri sonu // end of data
            richTextBox1.ScrollToCaret();// veri sonu // end of data
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
        {
                button2.PerformClick(); // Sizin yazdığınız yazıyı chat yükler // Uploads the text you wrote by chat
            }
    }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1.PerformClick(); // Enter bastığınız zaman yazıyı yükler // bastığınız zaman yazıyı yükler girin
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
           label3.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)); // RGB Label 
        }
    }
}