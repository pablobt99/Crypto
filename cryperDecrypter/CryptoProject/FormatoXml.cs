using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EncripterDecripter
{
    class FormatoXml
    {
        public XmlDocument LlavesRSAXml(String xml) 
        {
            Console.WriteLine(xml);
            XmlDocument doc = new XmlDocument();
            String tempString = xml;
            tempString = xml;
            Console.WriteLine(tempString);
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode root = doc.CreateElement("RSA");
            XmlNode key = doc.CreateElement("clave");
            key.InnerText = tempString;
            XmlNode keyPrivate = doc.CreateElement("clavePrivada");
            keyPrivate.InnerText = tempString;
            root.AppendChild(key);
            root.AppendChild(keyPrivate);
            doc.AppendChild(root);
            /*doc.LoadXml(xml);
            String path = "RSAKeyValue";
            XmlNodeList nodes = doc.SelectNodes(path);
            XmlNode nodePublic = doc.SelectSingleNode("RSAKeyValue/Modulus");
            XmlNode nodePrivate = doc.SelectSingleNode("RSAKeyValue/D");
            Console.WriteLine(nodes.Count);
            Console.WriteLine(nodePublic.InnerText);
            Console.WriteLine(nodePrivate.InnerText);
            //Console.WriteLine(nodes.Item(7).InnerText);*/
            return doc;
        }

        public XmlDocument LlaveTDES(String keyText) 
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode ruta = doc.CreateElement("TDES");
            XmlNode llave = doc.CreateElement("clave");
            llave.InnerText = keyText;
            ruta.AppendChild(llave);
            doc.AppendChild(ruta);
            return doc;
        }

        public void ExportXML(XmlDocument exportar, String nombre) 
        {
            String destino = nombre;
            XmlDocument doc = exportar;
            // Save the document to a file and auto-indent the output.
            using (XmlTextWriter writer = new XmlTextWriter(destino, null))
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
        }

        public XmlDocument ImportXML(String destino) {
            Console.WriteLine(destino);

            XmlDocument doc = new XmlDocument();
            doc.Load(destino);
            Console.WriteLine(doc.ToString());
            return doc;
        }

        public String GetLlaveTDES(XmlDocument doc) 
        {
            return doc.InnerText;
        }

        public String[] GetValoresRSA(XmlDocument doc) 
        {
            Console.WriteLine(doc.DocumentElement.OuterXml);
            String path = "RSA/clavePrivada";
            XmlNode nodes = doc.SelectSingleNode(path);
            Console.WriteLine(nodes.InnerText);
            XmlDocument newDoc = new XmlDocument();
            newDoc.LoadXml(nodes.InnerText);
            String keysPath = "RSAKeyValue";
            XmlNodeList keysnodes = newDoc.SelectNodes(keysPath);
            XmlNode nodePublic = newDoc.SelectSingleNode("RSAKeyValue/Modulus");
            XmlNode nodePrivate = newDoc.SelectSingleNode("RSAKeyValue/D");
            Console.WriteLine(nodePublic.InnerText);
            Console.WriteLine(nodePrivate.InnerText);

            String[] data = {nodePublic.InnerText, nodePrivate.InnerText, nodes.InnerText};
            return data;
        }

        public void ExportEncriptedText(String texto, String destino) 
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(destino);
                //Write a line of text
                sw.WriteLine(texto);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        
    }
}
