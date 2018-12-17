using System;
using System.Text;
using Nethereum.Signer;
using SelfKey.Login.Data.Models;

namespace SelfKey.Login.Api
{
    public static class Authenticator
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

        public static bool Verify(User user)
        {
            return MessageSigner.HashAndEcRecover(user.Proof.Nonce, user.Proof.Signature).Equals(user.Proof.Address, StringComparison.OrdinalIgnoreCase);
        }
    }
}
