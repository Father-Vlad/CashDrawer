namespace CashDrawer.Core.Helper
{
    public class TimePresentation
    {
        #region Variables
        private static bool _isFirstPresentation = true;
        #endregion Variables

        #region Properties
        public static bool IsFirstPresentation
        {
            get
            {
                return _isFirstPresentation;
            }

            set
            {
                _isFirstPresentation = value;
            }
        }
        #endregion Properties
    }
}