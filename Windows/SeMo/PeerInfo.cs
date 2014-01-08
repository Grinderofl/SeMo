using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    [Serializable]
    public class PeerInfo// : ISerializable
    {
        /*protected PeerInfo(SerializationInfo info, StreamingContext context)
        {
            if(info == null)
                throw new ArgumentNullException("info");
            Hash = info.GetString("Hash");
            Data = info.GetString("Data");
        }*/

        public PeerInfo()
        {
            
        }
        /// <summary>
        /// Secure hash of username or email and password, used as a unique identifier
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// AES encrypted user data
        /// </summary>
        public string Data { get; set; }

        /*[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Hash", Hash);
            info.AddValue("Data", Data);
        }*/
    }
}
