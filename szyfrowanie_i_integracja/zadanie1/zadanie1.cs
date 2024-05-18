using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            encryptionAlgorithmComboBox.Items.Add("AES");
            encryptionAlgorithmComboBox.Items.Add("DES");
            encryptionAlgorithmComboBox.SelectedIndex = 0; 

            
            encryptionTimer.Interval = 1000;
            decryptionTimer.Interval = 1000;
        }

        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                algorithm.GenerateKey();
                algorithm.GenerateIV();

                
                keyTextBox.Text = Convert.ToBase64String(algorithm.Key);
                ivTextBox.Text = Convert.ToBase64String(algorithm.IV);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                byte[] plaintext = Encoding.UTF8.GetBytes(plainTextBox.Text);

                
                using (ICryptoTransform encryptor = algorithm.CreateEncryptor())
                {
                    byte[] ciphertext = encryptor.TransformFinalBlock(plaintext, 0, plaintext.Length);

                    
                    encryptedAsciiTextBox.Text = BitConverter.ToString(ciphertext);
                    encryptedHexTextBox.Text = Convert.ToBase64String(ciphertext);
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                byte[] ciphertext = Convert.FromBase64String(encryptedHexTextBox.Text);

               
                using (ICryptoTransform decryptor = algorithm.CreateDecryptor())
                {
                    byte[] plaintext = decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);

                    
                    decryptedTextBox.Text = Encoding.UTF8.GetString(plaintext);
                }
            }
        }

        private SymmetricAlgorithm GetSelectedAlgorithm()
        {
            switch (encryptionAlgorithmComboBox.SelectedItem.ToString())
            {
                case "AES":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                default:
                    throw new ArgumentException("Nieobsługiwany algorytm szyfrowania");
            }
        }

        private void encryptionTimer_Tick(object sender, EventArgs e)
        {
            
            encryptionTimeLabel.Text = $"Czas szyfrowania: {encryptionTimer.ElapsedMilliseconds} ms";
        }

        private void decryptionTimer_Tick(object sender, EventArgs e)
        {
            
            decryptionTimeLabel.Text = $"Czas deszyfrowania: {decryptionTimer.ElapsedMilliseconds} ms";
        }
    }
}
