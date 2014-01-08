using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    public class StorageController
    {
        public PeerInfo RetrievePeerInfo(string hash)
        {
            throw new NotImplementedException();
        }

        public void SavePeerInfo(PeerInfo info)
        {
            throw new NotImplementedException();
        }

        public string RetrievePassword(string key)
        {
            throw new NotImplementedException();
        }

        public string SavePassword(string key, string password)
        {
            var storage = new SafeStorage()
            {
                Guid = key,
                Safe = password
            };
            throw new NotImplementedException();
        }
    }
}
