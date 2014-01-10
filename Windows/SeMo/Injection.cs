using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SHA3;

namespace SeMo
{
    public class Injection
    {
        public static void CreateBindings(IKernel kernel)
        {
            kernel.Bind<HashAlgorithm>().ToMethod(x => new SHA3Managed(512));
        }
    }
}
