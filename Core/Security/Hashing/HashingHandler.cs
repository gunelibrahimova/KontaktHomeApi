﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Hashing
{
    public class HashingHandler
    {
        public string PasswordHash(string pass)
        {
            using SHA256 chSha = SHA256.Create();
            byte[] bytes = chSha.ComputeHash(Encoding.UTF8.GetBytes(pass));

            StringBuilder sp = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sp.Append(bytes[i].ToString("x2")); ;
            }
            return sp.ToString();
        }
    }
}
