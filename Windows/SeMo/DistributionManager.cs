using System;

namespace SeMo
{
    public class DistributionManager
    {
        public void DistributeAuthorizationData(PeerInfo info)
        {
            throw new NotImplementedException();
        }

        public string RetrieveAuthorizationData(string hash)
        {
            var data = new PeerInfo() {Data = "retrieved by hash"};
            return data.Data;
        }
    }
}