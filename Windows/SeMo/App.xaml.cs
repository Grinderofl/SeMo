using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HashLib;

namespace SeMo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHash _hash;

        public App()
        {
            _hash = HashFactory.Crypto.SHA3.CreateKeccak512();
        }
    }
}
