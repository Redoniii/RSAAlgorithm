using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAAlgoritmi
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

        private void Form1_Load(object sender, EventArgs e)
        {
            GjeneroRSAParameTeRi();
        }
        private void GjeneroRSAParameTeRi()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsaParametratPerfshirePrivatet = rsa.ExportParameters(true);
            rsaParametratPerjashtuarPrivatet = rsa.ExportParameters(false);
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i < rsaParametratPerfshirePrivatet.P.Length; i++)
            {
                sb.Append(string.Format("{0,2:X2}", rsaParametratPerfshirePrivatet.P[i]));
            }
            txtP.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0; i < rsaParametratPerfshirePrivatet.Q.Length; i++)
            {
                sb.Append(string.Format("{0,2:X2}", rsaParametratPerfshirePrivatet.Q[i]));
            }
            txtQ.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0; i < rsaParametratPerfshirePrivatet.Exponent.Length; i++)
            {
                sb.Append(string.Format("{0,2:X2}", rsaParametratPerfshirePrivatet.Exponent[i]));
            }
            txtE.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0; i < rsaParametratPerfshirePrivatet.D.Length; i++)
            {
                sb.Append(string.Format("{0,2:X2}", rsaParametratPerfshirePrivatet.D[i]));
            }
            txtD.Text = sb.ToString();
        }
        RSAParameters rsaParametratPerjashtuarPrivatet;
        RSAParameters rsaParametratPerfshirePrivatet;
        byte[] BajtatEKriptuar;

        private void button1_Click(object sender, EventArgs e)
        {
            GjeneroRSAParameTeRi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsaParametratPerjashtuarPrivatet);

            byte[] plainbytes = Encoding.UTF8.GetBytes(txttekstiperkriptim.Text);

            BajtatEKriptuar = rsa.Encrypt(plainbytes, false);


            txttekstiikriptuar.Text = Encoding.UTF8.GetString(BajtatEKriptuar);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < BajtatEKriptuar.Length; i++)
            {
                sb.Append(string.Format("{0,2:X2}", BajtatEKriptuar[i]));
            }
            txtbytearray.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(rsaParametratPerfshirePrivatet);
            byte[] BajtatEPakritptuar = RSA.Decrypt(BajtatEKriptuar, false);

            txttekstiidekriptuar.Text = Encoding.UTF8.GetString(BajtatEPakritptuar);


        }
    }
}
