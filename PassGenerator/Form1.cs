using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PassGenerator
{
    public partial class MainForm : Form
    {
        const string pool = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789#@$*";
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(45, 45, 48);
        }


        private void btnValidate_Click(object sender, EventArgs e)
        {
            getRandomizer(txtBxSeed.Text);
           
        }
        private string setHashedString(string userInput)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(userInput);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        private void getRandomizer(String hashedInput)
        {
            int randomSeed = hashedInput.GetHashCode();
            string finalPass ="";
            Random randomizer = new Random(randomSeed);
            for (int i = 0; i < sizePass.Value; i++)
            {
               finalPass += pool[randomizer.Next(i, pool.Length)];
            }
            txtFinalPass.Text = finalPass;
        }
    }
}
