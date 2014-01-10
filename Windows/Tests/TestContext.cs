using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NUnit.Framework;
using SeMo;

namespace Tests
{
    [TestFixture]
    public class TestContext
    {
        protected IKernel Kernel;

        public TestContext()
        {
            Kernel = new StandardKernel();
            Injection.CreateBindings(Kernel);
        }
    }
}
