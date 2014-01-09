using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using HashLib;

namespace SeMo
{
    public class AuthorizationManager
    {
        private readonly DistributionManager _distributionManager;
        private readonly IHash _hash;

        public AuthorizationManager(DistributionManager distributionManager, IHash hash)
        {
            _distributionManager = distributionManager;
            _hash = hash;
        }

        public void Register(string username, string password)
        {
            var info = new PeerInfo()
            {
                Hash = _hash.ComputeString(username + password).ToString()
            };
            _distributionManager.DistributeAuthorizationData(info);
        }
    }

    public class DistributionManager
    {
        public void DistributeAuthorizationData(PeerInfo info)
        {
            throw new NotImplementedException();
        }
    }
}
