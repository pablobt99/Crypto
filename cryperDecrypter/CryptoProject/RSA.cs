using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncripterDecripter
{
    class RSA
    {
        public byte[] EncriptadoRSA(byte[] DataAEncriptar, RSAParameters LlaveRSA, bool Pading)
        {
            try
            {
                byte[] InfoEncriptada;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(LlaveRSA);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    InfoEncriptada = RSA.Encrypt(DataAEncriptar, Pading);
                }
                return InfoEncriptada;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public byte[] RSADecrypt(byte[] InfoAEncriptar, RSAParameters LlaveRSA, bool Pading)
        {
            try
            {
                byte[] InfoDesencriptada;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(LlaveRSA);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    InfoDesencriptada = RSA.Decrypt(InfoAEncriptar, Pading);
                }
                return InfoDesencriptada;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return Encoding.UTF8.GetBytes("Error");
            }
        }
    }
}
