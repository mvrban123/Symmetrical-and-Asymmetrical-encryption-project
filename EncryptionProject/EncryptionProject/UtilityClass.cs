using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionProject
{
    class UtilityClass
    {
        #region Utility Functions
        public static string ReadFileData(string path)
        {
            string dataContent = null;
            try
            {
                dataContent = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom čitanja sadržaja datotoke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return dataContent;
        }

        public static string ReadDigitalSignature()
        {
            string dataContent = null;
            try
            {
                dataContent = File.ReadAllText("Digital_signature.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom čitanja digitalnog potpisa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return dataContent;
        }

        public static string CompareDigitalSignatures(byte[] dataToVerify, byte[] signedData, RSAParameters privateKey)
        {
            string status = null;
            try
            {

                if (RSACrypto.VerifySignedHash(dataToVerify, signedData, privateKey))
                {
                    status = "Digitalan potpis je ispravan!";
                }
                else
                {
                    status = "Digitalan potpis je neispravan! \n Došlo je do promjena u jednoj od izvornih datoteka!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom provjere digitalnog potpisa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status = "Greška!";
            }
            return status;
        }

        public static void CreateHashValue(byte[] encryptedData)
        {
            try
            {
                SHA256Managed sHA256 = new SHA256Managed();

                var hashValue = sHA256.ComputeHash(encryptedData);

                File.WriteAllText("Hash_value.txt", Convert.ToBase64String(hashValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom stvaranja sažetka poruke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public static void CreateDigitalSigniture(byte[] dataToSign, RSAParameters privateKey)
        {
            try
            {
                var digitalSignature = RSACrypto.HashAndSignBytes(dataToSign, privateKey);

                File.WriteAllText("Digital_signature.txt", Convert.ToBase64String(digitalSignature));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom stvaranja digitalnog potpisa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
