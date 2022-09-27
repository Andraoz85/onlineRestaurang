using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlinerestaurang
{
    internal class Receipt
    {
        private int orderID;
        private string restaurantName;
        private string customerName;
        private string cardType;
        private string numberOfItems;
        private float tax;
        private float totalCost;

        public Receipt(int orderID, string restaurantName, string customerName, string cardType, string numberOfItems, float tax, float totalCost)
        {
            this.orderID = orderID;
            this.restaurantName = restaurantName;
            this.customerName = customerName;
            this.cardType = cardType;
            this.numberOfItems = numberOfItems;
            this.tax = tax;
            this.totalCost = totalCost;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Ditt kvitto!");
        }


    }
}
