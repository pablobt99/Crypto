using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncripterDecripter
{
    class TDES
    {
        public String GenerarLlavesTripleDES()
        {
            try
            { 
                TripleDES tpd = TripleDES.Create();

                tpd.GenerateKey();
                //Console.WriteLine(Convert.ToBase64String(tpd.Key));
                return Convert.ToBase64String(tpd.Key);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return "";
        }
        public String encript(String texto, String llave)
        {
            byte[] iv = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            var nuevallave = MD5.Create().ComputeHash(Convert.FromBase64String(llave));
            //Console.WriteLine(tpd.KeySize);
            //tpd.IV = iv;
            using (TripleDES tpd = TripleDES.Create())
            {
                //Console.WriteLine(texto);
                tpd.Mode = CipherMode.ECB;
                ICryptoTransform encriptor = tpd.CreateEncryptor(nuevallave, iv);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encriptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                        var encriptado = msEncrypt.ToArray();
                        //Console.WriteLine(encrypted.Length);
                        //Console.WriteLine(Convert.ToBase64String(encrypted));
                        return Convert.ToBase64String(encriptado);

                    }
                }
            }
            
        }
        public String decript(String llave, String text)
        {
            byte[] texto = Convert.FromBase64String(text);
            byte[] formato = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            var llavenueva = MD5.Create().ComputeHash(Convert.FromBase64String(llave));
            String encriptado = null;
            using (TripleDES tpd = TripleDES.Create())
            {
                //Console.WriteLine(texto);
                tpd.Mode = CipherMode.ECB;
                ICryptoTransform encriptor = tpd.CreateDecryptor(llavenueva, formato);
                using (MemoryStream mensajeEncrypt = new MemoryStream(texto))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(mensajeEncrypt, encriptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader swEncrypt = new StreamReader(csEncrypt))
                        {
                            encriptado = swEncrypt.ReadToEnd();
                        }
                        //var encrypted = msEncrypt.ToArray();
                        //Console.WriteLine(encrypted.Length);
                        //Console.WriteLine(Convert.ToBase64String(encrypted));
                        return encriptado;

                    }
                }
            }
        }
        public static string Decrypt(string textToDecrypt, string llave)
        {
            TripleDESCryptoServiceProvider ProveedorEncriptacionTDES = new TripleDESCryptoServiceProvider();

            MD5CryptoServiceProvider ServicioHash = new MD5CryptoServiceProvider();

            byte[] byteKeyHash = ServicioHash.ComputeHash(Convert.FromBase64String(llave));

            byte[] iv = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            byte[] byteDecryptArray = Convert.FromBase64String(textToDecrypt);

            ServicioHash.Clear();

            ProveedorEncriptacionTDES.Key = byteKeyHash;
            ProveedorEncriptacionTDES.Mode = CipherMode.ECB; //CBC, CFB

            var myDecryptor = ProveedorEncriptacionTDES.CreateDecryptor(ProveedorEncriptacionTDES.Key, iv);
            var transformedArray = myDecryptor.TransformFinalBlock(byteDecryptArray, 0, byteDecryptArray.Length);

            string plaintext = UTF8Encoding.UTF8.GetString(transformedArray);

            ProveedorEncriptacionTDES.Clear();
            return plaintext;
        }

    }
}
