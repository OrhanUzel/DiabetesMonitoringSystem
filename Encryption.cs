using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProLab3
{
    internal static class Encryption //ilgili fonksiyonların nesne oluşturlumaya gereksinim duyulmadan kullanılabilmesi için static olarak tanımlıyoruz
    {
        public static string createRandomSalt(int uzunluk = 32)
        {
            byte[] saltBytes = new byte[uzunluk];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }// encryptWithSHA512

        public static string encryptWithSHA512(string input)//tek bir yere indirgenebilir iki farklı classta olmasının yerine
        {


            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // hex formatında çıktı verme
                }
                return sb.ToString();
            }
        }

    }
}
