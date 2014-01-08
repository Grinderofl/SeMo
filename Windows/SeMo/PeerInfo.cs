using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    public class PeerInfo
    {
        /// <summary>
        /// Secure hash of username or email and password, used as a unique identifier
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// AES encrypted user data
        /// </summary>
        public string Data { get; set; }
    }
}
