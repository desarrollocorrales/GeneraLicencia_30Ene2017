using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneraLicencia
{
    public partial class Genera13 : Form
    {
        public Genera13()
        {
            InitializeComponent();
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbCifrado.Text)) return;

                string cifrar = this.tbCifrado.Text.Trim();

                string desifrado = ROT13.Transform(cifrar);

                this.tbDecifrado.Text = desifrado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ROT13", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbDecifrado.Text)) this.tbCifrado.Text = string.Empty;

                string decifrar = this.tbDecifrado.Text.Trim();

                string desifrado = ROT13.Transform(decifrar);

                this.tbCifrado.Text = desifrado;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ROT13", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

    public static class ROT13
    {
        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        public static string Transform(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
