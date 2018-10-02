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

namespace COLIN_Justine_Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Encrypt_Net_Click(object sender, EventArgs e)
        {
            string hash = CleCryptage.Text; //Récup la clé de hashage entrée par l'user
            byte[] data = UTF8Encoding.UTF8.GetBytes(TexteBase.Text); //transforme le texte en séquence d'octets (=> pour pouvoir passer deint à string facilement)
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())//md5 : méthode de chiffrement
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash)); //transforme la clé en bytes puis calcule la valeur de hachage
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    TexteCrypte.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }
        private void Btn_Des_Net_Click(object sender, EventArgs e)
        {
            string hash = CleCryptage.Text;

            byte[] data = Convert.FromBase64String(TexteCrypte.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    TexteDecrypte.Text = UTF8Encoding.UTF8.GetString(result);
                }
            }
        }
        private void Btn_Encryp_Perso_Click(object sender, EventArgs e)
        {
            TexteCrypte.Text = Vigenere.Encryption(TexteBase.Text, CleCryptage.Text);
        }
        private void Btn_Des_Perso_Click(object sender, EventArgs e)
        {
            TexteDecrypte.Text = Vigenere.Decryption(TexteCrypte.Text, CleCryptage.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
