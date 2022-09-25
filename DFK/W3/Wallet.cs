using System.Text;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.KeyStore;
using Nethereum.KeyStore.Model;
using Nethereum.Signer;
using Nethereum.Web3.Accounts;

namespace DFK.W3
{
    public static class Encrypt
    {
        public static string CreateAccount(string privateKey, string password)
        {
            var keyStoreService = new KeyStoreScryptService();
            var ecKey = new EthECKey(privateKey);
            var keyStore = keyStoreService.EncryptAndGenerateKeyStore(
                password,
                ecKey.GetPrivateKeyAsBytes(),
                ecKey.GetPublicAddress(),
                new ScryptParams { Dklen = 32, N = 32, R = 1, P = 8 });
            return keyStoreService.SerializeKeyStoreToJson(keyStore);
        }
        public static Account GetAccount(string password, string keyStore)
        {
            var keyStoreService = new KeyStoreScryptService();
            var privateKeyBytes = keyStoreService.DecryptKeyStoreFromJson(password, keyStore).ToHex(true);
            var account = new Account(privateKeyBytes);
            return account;
        }
    }
}