using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SeMo
{
    public class AuthorizationManager
    {
        private readonly DistributionManager _distributionManager;
        private readonly HashAlgorithm _hash;

        public AuthorizationManager(DistributionManager distributionManager, HashAlgorithm hash)
        {
            _distributionManager = distributionManager;
            _hash = hash;
        }

        public DataInfo Register(string username, string password)
        {
            var info = new PeerInfo()
            {
                Hash = BitConverter.ToString(_hash.ComputeHash(Encoding.UTF8.GetBytes(username + password)))
            };
            _distributionManager.DistributeAuthorizationData(info);
            throw new NotImplementedException();
        }

        public DataInfo Login(string username, string password)
        {
            var hash = BitConverter.ToString(_hash.ComputeHash(Encoding.UTF8.GetBytes(username + password)));
            var data = _distributionManager.RetrieveAuthorizationData(hash);
            throw new NotImplementedException();
        }

    }
}
