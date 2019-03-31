namespace CashDrawer.Core.Interfaces
{
    public interface IAlertService
    {
        void ShowToastShort(string message);
        void ShowToastLong(string message);
    }
}