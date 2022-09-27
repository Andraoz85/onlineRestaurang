namespace Onlinerestaurang
{
    internal class Payment
    {
        private string customerName;
        private string cardType;
        private int cardNumber;

        public Payment(string customerName, string cardType, int cardNumber)
        {
            this.customerName = customerName;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
        }

        public bool MakePayment()
        {
            return true;
        }


    }
}
