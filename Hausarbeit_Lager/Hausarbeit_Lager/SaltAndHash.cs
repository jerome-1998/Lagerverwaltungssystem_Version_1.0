using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Hausarbeit_Lager
{
    public class SaltAndHash
    {
        //salt und hash properties 
        public string salt { get; set; }
        public string hash { get; set; }

        //salt und hash konstruktor
        public SaltAndHash(string salt, string hash)
        {
            this.salt = salt;
            this.hash = hash;
        }
    }
}
