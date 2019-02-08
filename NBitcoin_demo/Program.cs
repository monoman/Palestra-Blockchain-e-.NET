using System;
using NBitcoin;

namespace NBitcoin_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = new Key();
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine($"publicKey: {publicKey}");
            Console.WriteLine($"publicKey.GetAddress(Network.Main): {publicKey.GetAddress(Network.Main)}"); 
            Console.WriteLine($"publicKey.GetAddress(Network.TestNet): {publicKey.GetAddress(Network.TestNet)}");
            var publicKeyHash = publicKey.Hash;
            Console.WriteLine($"publicKeyHash: {publicKeyHash}"); 
            var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            Console.WriteLine($"mainNetAddress: {mainNetAddress}"); 
            Console.WriteLine($"testNetAddress: {testNetAddress}");
            Console.ReadLine();
        }
    }
}
