using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konscious.Security.Cryptography;

namespace SAGA_EV3
{
    public static class Argon2Hasher
    {
        public static string HashPassword(string password)
        {


            Byte[] Salt = new Byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(Salt);
            }
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = Salt,
                DegreeOfParallelism = 8, // four cores
                Iterations = 4,
                MemorySize = 1024 * 64 // 64 MB
            };
            Byte[] hash = argon2.GetBytes(32);
            return Convert.ToBase64String(Salt) + ":" + Convert.ToBase64String(hash);

        }
        public static bool Verify(string password, string stored)
        {
            var parts = stored.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }
            Byte[] salt = Convert.FromBase64String(parts[0]);
            Byte[] expectedHash = Convert.FromBase64String(parts[1]);
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = 8,
                Iterations = 4,
                MemorySize = 1024 * 64
            };
            var hash_ingresado = argon2.GetBytes(32);
            return hash_ingresado.SequenceEqual(expectedHash);
        }

    }
}
