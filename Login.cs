using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakProjesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateCredentials(string username, string password)
        {
            string filePath = "kullanıcılar\\users.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if ((parts[0] == username && parts[1] == password))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = girisKullanicAdi.Text;
            string password = girisSifre.Text;

            if (ValidateCredentials(username, password))
            {
                Form1 anaForm = new Form1();
                anaForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
    }
}