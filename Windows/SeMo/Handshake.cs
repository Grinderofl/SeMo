using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    /// <summary>
    /// Handshake sent between clients
    /// Steps
    /// 1) Encrypt From, To, and Timestamp with symmetric key
    /// 2) Create signature from data using local private key
    /// 3) Encrypt key with target public key
    /// 4) "To" receives it, decrypts Key with their private key, decrypts From and To, ensures the Signature verifies with "To"'s public key
    /// 5) "From" uses this key to send, "To" uses it to receive
    /// 6) "To" generates a new key on their end and uses that to send, wheras "From" uses it to receive
    /// 7) Timestamp is used to generate the IV for key
    /// </summary>
    public class Handshake
    {
        /// <summary>
        /// Key is triple-AES length (96 bytes)
        /// </summary>
        string Key { get; set; }
        string From { get; set; }
        string To { get; set; }
        string Timestamp { get; set; }
        string Signature { get; set; }
    }
}
