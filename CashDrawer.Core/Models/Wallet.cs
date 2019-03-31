namespace CashDrawer.Core.Models
{
    public class Wallet
    {
        public string WalletFirstLetter { get; set; }

        public Wallet()
        {
        }

        public Wallet(string _walletFirstLetter)
        {
            WalletFirstLetter = _walletFirstLetter;
        }
    }
}