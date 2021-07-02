using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionProject
{
    public partial class StartForm : Form
    {
        #region Attributes
        RSACryptoServiceProvider RSA;
        RSAParameters privateKey;
        RSAParameters publicKey;
        byte[] aesKey;
        byte[] aesIV;

        #endregion

        #region Constructor
        public StartForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            digitalSignatureStatusLabel.Visible = false;
            CreateRSAKEYS();
            CreateAESKeyAndIV();
            
        }

        #endregion

        #region LoadFunctions

        private void CreateRSAKEYS()
        {
            RSA = new RSACryptoServiceProvider(4096);
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);

            WriteKeysToFile();
        }

        private void WriteKeysToFile()
        {
            var stringWriter = new System.IO.StringWriter();

            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            xmlSerializer.Serialize(stringWriter, publicKey);
            File.WriteAllText("Public_Key.txt", stringWriter.ToString(), Encoding.Unicode);

            xmlSerializer.Serialize(stringWriter, privateKey);
            File.WriteAllText("Private_Key.txt", stringWriter.ToString());
        }

        private void CreateAESKeyAndIV()
        {
            using(Aes myAes = Aes.Create())
            {
                aesKey = myAes.Key;
                aesIV = myAes.IV;
            }
            File.WriteAllText("Secret_key.txt", Convert.ToBase64String(aesKey));
        }

        #endregion

        #region Button_Actions

        #region AsymmetricAlgorithActions
        private void filePickerButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.Contains(".txt"))
                {
                    MessageBox.Show("Morate odabrati tekstualnu datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                encryptionFilePathTextBox.Text = fileDialog.FileName;
            }
        }

        private void encryptFileButton_Click_1(object sender, EventArgs e)
        {
            digitalSignatureStatusLabel.Visible = false;
            string fileContent;

            if (!encryptionFilePathTextBox.Text.Contains(".txt"))
            {
                MessageBox.Show("Morate odabrati datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                fileContent = File.ReadAllText(encryptionFilePathTextBox.Text);

                byte[] encrytedContent = (RSACrypto.RSAEncrypt(System.Text.Encoding.Unicode.GetBytes(fileContent), publicKey, false));

                File.WriteAllText("Encrypted_data.txt", Convert.ToBase64String(encrytedContent));

                UtilityClass.CreateHashValue((encrytedContent));

                UtilityClass.CreateDigitalSigniture(encrytedContent, privateKey);

                encryptedDataTextBox.Text = "";
                decryptedDataTextBox.Text = "";

                encryptionFilePathTextBox.Text = "";
                decryptionFilePathTextBox.Text = "";

                MessageBox.Show("Enkripcija izvršena!", "Uspješna enkripcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void decryptionFilePathButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.Contains("Encrypted_data.txt"))
                {
                    MessageBox.Show("Morate odabrati datoteku sa nazivom Encrypted_data.txt!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                decryptionFilePathTextBox.Text = fileDialog.FileName;
            }
        }

        private void decryptFileButton_Click_1(object sender, EventArgs e)
        {
            digitalSignatureStatusLabel.Visible = false;
            string fileData;

            if (!decryptionFilePathTextBox.Text.Contains("Encrypted_data.txt"))
            {
                MessageBox.Show("Morate odabrati datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                fileData = UtilityClass.ReadFileData(decryptionFilePathTextBox.Text);

                encryptedDataTextBox.Text = fileData;

                byte[] dataContent = Convert.FromBase64String(fileData);

                byte[] decryptedData = (RSACrypto.RSADecrypt(dataContent, privateKey, false));

                byte[] digitalSignature = Convert.FromBase64String(UtilityClass.ReadDigitalSignature());

                decryptedDataTextBox.Text = System.Text.Encoding.Unicode.GetString(decryptedData);

                digitalSignatureStatusLabel.Text = UtilityClass.CompareDigitalSignatures(dataContent, digitalSignature, privateKey);
                digitalSignatureStatusLabel.Visible = true;

                encryptionFilePathTextBox.Text = "";
                decryptionFilePathTextBox.Text = "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Greška prilikom dekriptiranja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                digitalSignatureStatusLabel.Text = "Greška! Došlo je do promjene kriptiranog sadržaja ili digitalnog potpisa!";
                digitalSignatureStatusLabel.Visible = true;
                encryptionFilePathTextBox.Text = "";
                decryptionFilePathTextBox.Text = "";
                return;
            }
        }

        #endregion

        #region SymmetricAlgorithActions

        private void symmetricEncDataPicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.Contains(".txt"))
                {
                    MessageBox.Show("Morate odabrati tekstualnu datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                symmetricEncFilePath.Text = fileDialog.FileName;
            }
        }

        private void symmetricEncFileButton_Click(object sender, EventArgs e)
        {
            string fileContent;

            if (!symmetricEncFilePath.Text.Contains(".txt") || string.IsNullOrWhiteSpace(symmetricEncFilePath.Text))
            {
                MessageBox.Show("Morate odabrati tekstualnu datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                fileContent = File.ReadAllText(symmetricEncFilePath.Text);

                byte[] encrytedContent = AESCrypto.EncryptStringToBytes_Aes(fileContent, aesKey, aesIV);

                File.WriteAllText("Symmetrically_encrypted_data.txt", Convert.ToBase64String(encrytedContent));

                MessageBox.Show("Enkripcija izvršena!", "Uspješna enkripcija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                symmetricEncFilePath.Text = "";
                symmetricDencFilePath.Text = "";
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void symmetricDencDataPicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.Contains(".txt"))
                {
                    MessageBox.Show("Morate odabrati tekstualnu datoteku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                symmetricDencFilePath.Text = fileDialog.FileName;
            }
        }

        private void symmetricDencFileButton_Click(object sender, EventArgs e)
        {
            digitalSignatureStatusLabel.Visible = false;
            string fileData;

            if (!symmetricDencFilePath.Text.Contains("Symmetrically_encrypted_data.txt"))
            {
                MessageBox.Show("Morate odabrati datoteku sa nazivom Symmetrically_encrypted_data.txt!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                fileData = UtilityClass.ReadFileData(symmetricDencFilePath.Text);

                symmetricEncDataTextBox.Text = "";
                symmetricDencDataTextBox.Text = "";

                byte[] dataContent = Convert.FromBase64String(fileData);

                string decryptedData = AESCrypto.DecryptStringFromBytes_Aes(dataContent,aesKey,aesIV);

                symmetricDencDataTextBox.Text = decryptedData;
                symmetricEncDataTextBox.Text = fileData;

                symmetricEncFilePath.Text = "";
                symmetricDencFilePath.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dekriptiranja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                symmetricDencDataTextBox.Text = "";
                symmetricEncDataTextBox.Text = "";
                return;
            }
        }
        #endregion
        #endregion
    }
}
