using System;
using System.Text.RegularExpressions;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        int key = 3;
        public string Crypt(string message)
        {
            if (message == null)
                throw new ArgumentNullException();
            else
            {
                if (message.Length == 0) return String.Empty;

                char chr = message[0].ToString().ToLower()[0];

                var code = IsBasicLetter(chr) ? (char)(((chr - 'a' + key) % 26) + 'a') : chr;

                string v = code + Crypt(message.Substring(1));

                var teste = Regex.IsMatch(v, @"^[\sa-zA-Z0-9]+$") ? v : throw new ArgumentOutOfRangeException();

                return teste;
            }
            throw new NotImplementedException();
        }

        public string Decrypt(string cryptedMessage)
        {
            if (cryptedMessage == null)
                throw new ArgumentNullException();
            else
            {
                if (cryptedMessage.Length == 0) return String.Empty;
                char chr = cryptedMessage[0].ToString().ToLower()[0];
                var code = IsBasicLetter(chr) ? (char)('z' - (('z' - chr + key) % 26)) : chr;
                string v = code + Decrypt(cryptedMessage.Substring(1));

                var teste = Regex.IsMatch(v, @"^[\sa-zA-Z0-9]+$") ? v : throw new ArgumentOutOfRangeException();

                return teste;
            }
        }
        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}
