using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace EncripterDecripter
{
    public partial class Form1 : Form
    {
        TDES tdes;
        static String xml = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbAlgoritmos.SelectedIndex == 0)
            {
                tdes = new TDES();
                txtClave.Text = tdes.GenerarLlavesTripleDES().ToString();
            } 
            else if (cmbAlgoritmos.SelectedIndex == 1)
            {
                getRSAkeys();
            }
        }

        public void getRSAkeys() 
        {
            //Generate a public/private key pair.  
            System.Security.Cryptography.RSA rsa = System.Security.Cryptography.RSA.Create();
            //Save the public key information to an RSAParameters structure.  
            RSAParameters rsaKeyInfo = rsa.ExportParameters(true);
            xml = rsa.ToXmlString(true);
            //Console.WriteLine(xml);
            txtClave.Text = Convert.ToBase64String(rsaKeyInfo.D);
            txtClavePublica.Text = Convert.ToBase64String(rsaKeyInfo.Modulus);
        }

        public void encriptarRSA() 
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(xml);
            byte[] text = Encoding.ASCII.GetBytes(txtText.Text);
            byte[] result = rsa.Encrypt(text, false);
            txtResultado.Text = Convert.ToBase64String(result);
        }

        public void decriptRSA() 
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            RSAParameters key = rsa.ExportParameters(true);
            byte[] text = Convert.FromBase64String(txtTextoEncriptado.Text);
            byte[] resultado = new RSA().RSADecrypt(text, key, false);
            txtDesencriptado.Text = Encoding.Default.GetString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            if (cmbAlgoritmos.SelectedIndex == 0)
            {
                tdes = new TDES();
                txtResultado.Text = tdes.encript(txtText.Text, txtClave.Text);
            }
            else if (cmbAlgoritmos.SelectedIndex == 1)
            {
                encriptarRSA();
            }
            
        }

        private void btnDesecnriptar_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
            if (cmbAlgoritmos.SelectedIndex == 0)
            {
                tdes = new TDES();
                txtDesencriptado.Text = tdes.decript(txtClave.Text, txtTextoEncriptado.Text);
            }
            else if (cmbAlgoritmos.SelectedIndex == 1)
            {
                decriptRSA();
            }
            
        }

        private void btnExportKeys_Click(object sender, EventArgs e)
        {
            FormatoXml export = new FormatoXml();
            if (cmbAlgoritmos.SelectedIndex == 1)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML-File | *.xml";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    export.ExportXML(export.LlavesRSAXml(xml), save.FileName);
                }
            }
            else if (cmbAlgoritmos.SelectedIndex == 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML-File | *.xml";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    export.ExportXML(export.LlaveTDES(txtClave.Text), save.FileName);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormatoXml export = new FormatoXml();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text-File | *.txt";
            string returnValue = txtResultado.Text;
            if (cmbAlgoritmos.SelectedIndex == 1) {
                byte[] plainTextBytes = System.Text.Encoding.Default.GetBytes(txtResultado.Text);
                 returnValue = System.Convert.ToBase64String(plainTextBytes);
             }
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                export.ExportEncriptedText(returnValue, save.FileName);
            }
        }

        private void btnImportKeys_Click(object sender, EventArgs e)
        {
            FormatoXml import = new FormatoXml();
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(save.FileName);
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                   txtClave.Text = import.GetLlaveTDES(import.ImportXML(save.FileName));
                }
                else if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    String[] data = import.GetValoresRSA(import.ImportXML(save.FileName));
                    xml = data[2];
                    txtClave.Text = data[1];
                    txtClavePublica.Text = data[0];
                }
            }

        }

        private void btnImportText_Click(object sender, EventArgs e)
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "Text-File | *.txt";
            string decodedText = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(save.FileName);
                if (cmbAlgoritmos.SelectedIndex == 1)
                {
                    byte[] textAsBytes = Convert.FromBase64String(text);
                    decodedText = Encoding.UTF8.GetString(textAsBytes);
                } else 
                {
                    decodedText = text;
                }
                txtTextoEncriptado.Text = decodedText;
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
        }

        private void txtTextoEncriptado_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1000);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1000);
        }

        private void cmbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
