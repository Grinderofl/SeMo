using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SeMo.Extensions;

namespace SeMo
{
    public class EncryptionManager
    {
        public string EncryptWithPublicKey(object data, string key)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            byte[] encrypted;
            var ser = new XmlSerializer(data.GetType());
            using (var ms = new MemoryStream())
            {
                ser.Serialize(ms, data);
                encrypted = rsa.EncryptValue(ms.ToArray());
            }
            return encrypted.ToBase64String();
        }

        public T DecryptWithPrivateKey<T>(string data, string key)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            var ser = new XmlSerializer(data.GetType());
            using (var ms = new MemoryStream())
            {
                var bytes = data.ToBytesFromBase64String();
                var decrypted = rsa.DecryptValue(bytes);
                ms.Write(decrypted, 0, decrypted.Length);
                ms.Seek(0, SeekOrigin.Begin);
                return (T) ser.Deserialize(ms);
            }
        }
    }
}
