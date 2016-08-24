using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommClient.CSharp.Forms
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

        private void button1_Click(object sender, EventArgs e)
        {

            Library.HTTP http = new Library.HTTP();
            Library.Information cost = new Library.Information();
            Library.Encryption encrypt = new Library.Encryption();
            if (checkBox1.Checked == true)
            {
                http.setURL(textBox3.Text, true);
            }
            else
            {
                http.setURL(textBox3.Text, false);
            }
            string[] ServerStyle = http.getStyle().Split(';');
            cost.Encrypttype = Convert.ToByte(ServerStyle[0]);
            cost.XMLUse = Convert.ToBoolean(ServerStyle[1]);

            string EncryptedPassword = encrypt.EncryptData(textBox2.Text);
            
            
            http.Login(textBox1.Text, EncryptedPassword);
        }
    }
}
