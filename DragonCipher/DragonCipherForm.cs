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

namespace DragonCipher
{
    public partial class cipherForm : Form
    {
        private String inputFilename;
        public cipherForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgPlainFileLoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilename = dlgPlainFileLoad.FileName;
                if (Path.GetExtension(inputFilename) == "txt")
                {
                    inputPlainText.Text = File.ReadAllText(inputFilename);
                }
                else
                {
                    inputEncryptedText.Text = String.Join(" ", File.ReadAllBytes(inputFilename));
                }

            }
        }
        byte[] output;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputPlainText.Text))
            {
                MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputIV.Text))
            {
                MessageBox.Show("IV should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputKey.Text))
            {
                MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                byte[] input = Encoding.Unicode.GetBytes(inputPlainText.Text);
                output = new byte[input.Length];
                Dragon dragon = new Dragon(inputKey.Text, inputIV.Text);
                dragon.process_bytes(input, output);
                inputEncryptedText.Text = String.Join(" ", output);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputEncryptedText.Text))
            {
                MessageBox.Show("Input text should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputIV.Text))
            {
                MessageBox.Show("IV should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(inputKey.Text))
            {
                MessageBox.Show("Key word should be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String[] values = inputEncryptedText.Text.Split(' ');
                byte[] input = new byte[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    input[i] = Byte.Parse(values[i]);
                }
                byte[] output = new byte[input.Length];
                Dragon dragon = new Dragon(inputKey.Text, inputIV.Text);
                dragon.process_bytes(input, output);
                inputPlainText.Text = Encoding.Unicode.GetString(output);
            }
        }

        private void btnPlainLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgPlainFileLoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilename = dlgPlainFileLoad.FileName;
                inputPlainText.Text = File.ReadAllText(inputFilename);
            }
        }

        private void btnEncryptedLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgEncryptedFileLoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilename = dlgEncryptedFileLoad.FileName;
                inputEncryptedText.Text = String.Join(" ", File.ReadAllBytes(inputFilename));
            }
        }

        private void btnPlainSave_Click(object sender, EventArgs e)
        {
            if (dlgPlainFileSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlgPlainFileSave.FileName, inputPlainText.Text);
            }
        }

        private void btnEncryptedSave_Click(object sender, EventArgs e)
        {
            if (dlgEncryptedFileSave.ShowDialog() == DialogResult.OK)
            {
                String[] values = inputEncryptedText.Text.Split(' ');
                byte[] bytes = new byte[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    bytes[i] = Byte.Parse(values[i]);
                }
                File.WriteAllBytes(dlgEncryptedFileSave.FileName, bytes);
            }
        }

    }
}
