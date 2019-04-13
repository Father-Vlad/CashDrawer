namespace CashDrawer.Core.Models
{
    public class Wallet
    {
        public string WalletFirstLetter { get; set; }
        public string WalletCashPercent { get; set; }
        public string WalletCash { get; set; }

        public Wallet()
        {
        }

        public Wallet(string walletFirstLetter, string walletCashPercent, string walletCash)
        {
            WalletFirstLetter = walletFirstLetter;
            WalletCashPercent = walletCashPercent;
            WalletCash = walletCash;
        }
    }
}