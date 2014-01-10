using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NUnit.Framework;
using SeMo;
using SHA3;

namespace Tests
{
    public class WhenAttemptingToGenerateHash : TestContext
    {
        [Test]
        public void GeneratedHashShouldBeCorrect()
        {
            const string source = "";
            var bytes = Encoding.ASCII.GetBytes(source);
            var generator = Kernel.Get<HashAlgorithm>();
            var str = BitConverter.ToString(generator.ComputeHash(bytes)).Replace("-", "").ToLower();
            Assert.That(str, Is.EqualTo("0eab42de4c3ceb9235fc91acffe746b29c29a8c366b7c60e4e67c466f36a4304c00fa9caf9d87976ba469bcbe06713b435f091ef2769fb160cdab33d3670680e"));
        }
    }
}
