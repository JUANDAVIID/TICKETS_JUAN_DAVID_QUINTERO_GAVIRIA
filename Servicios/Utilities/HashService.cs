using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Utilities
{
    public class HashService
    {
        public static string HashGenerator(string pValue)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] toHash = System.Text.Encoding.UTF8.GetBytes(pValue.ToString());
                var hash = sha1.ComputeHash(toHash);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
