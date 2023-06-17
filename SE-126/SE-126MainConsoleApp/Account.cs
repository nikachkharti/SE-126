namespace SE_126MainConsoleApp
{
    public class Account
    {
        private string accountNumber;
        private string currency;
        private decimal balance;


        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value.Length == 22)
                {
                    accountNumber = value;
                }
            }
        }

        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Length == 3)
                {
                    currency = value;
                }
            }
        }


        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }


    }
}
