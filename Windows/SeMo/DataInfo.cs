using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    public class DataInfo
    {
        /// <summary>
        /// Contact list
        /// Dictionary
        /// Key: Contact Alias
        /// Tuple: Contact public key, contact e-mail
        /// </summary>
        public Dictionary<string, Tuple<string, string>> Contacts { get; set; }

        /// <summary>
        /// Private key
        /// </summary>
        public string PrivateKey { get; set; }
    }
}
