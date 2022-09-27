using System;

namespace Onlinerestaurang
{
    class Customer : Users
    {
        private string customerName;
        private string customerAdress;
        private string phoneNumber;
        private string eMail;

        public Customer(string customerName, string customerAdress, string phoneNumber, string eMail)
        {
            this.customerName = customerName;
            this.customerAdress = customerAdress;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
        }


        public string ShowInfo()
        {
            return $"{customerName}\n {customerAdress}\n {phoneNumber}\n {eMail}";
        }
        public void AddoCart(string meal)
        {
            Console.WriteLine("You added " + meal);
        }

    }


}
