using System;
using System.Text;
using Nethereum.Signer;

namespace SelfKey.Login.Api
{
    public static class Signer
    {
        private static readonly EthereumMessageSigner MessageSigner = new EthereumMessageSigner();

        public static string Sign(string message, string privateKey)
        {
            return MessageSigner.HashAndSign(message, privateKey);
        }

        public static string Sign(string message, EthECKey key)
        {
            return MessageSigner.HashAndSign(Encoding.UTF8.GetBytes(message), key);
        }

        public static bool Verify(string message, string signature, string address)
        {
            return MessageSigner.HashAndEcRecover(message, signature).Equals(address, StringComparison.OrdinalIgnoreCase);
        }
    }
}
