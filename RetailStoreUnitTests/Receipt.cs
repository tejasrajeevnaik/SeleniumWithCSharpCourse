using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class Receipt
    {
        #region Private variables
        private int receiptNumber;
        private int customerNumber;
        private int itemNumber;
        private int itemUnitPrice;
        private int itemQuantityPurchased;
        #endregion

        // Constructor
        public Receipt(int receiptNumber_C, DateTime dateOfPurchase_C, int customerNumber_C, string customerName_C, string customerAddress_C, long customerPhoneNumber_C, int itemNumber_C, string itemDescription_C, int itemUnitPrice_C, int itemQuantityPurchased_C)
        {
            ReceiptNumber = receiptNumber_C;
            DateOfPurchase = dateOfPurchase_C;
            CustomerNumber = customerNumber_C;
            CustomerName = customerName_C;
            CustomerAddress = customerAddress_C;
            CustomerPhoneNumber = customerPhoneNumber_C;
            ItemNumber = itemNumber_C;
            ItemDescription = itemDescription_C;
            ItemUnitPrice = itemUnitPrice_C;
            ItemQuantityPurchased = itemQuantityPurchased_C;
        }

        // Properties
        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    receiptNumber = 1;
                }
            }
        }

        public DateTime DateOfPurchase
        {
            get;
            set;
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
                else
                {
                    customerNumber = 1;
                }
            }
        }

        public string CustomerName
        {
            get;
            set;
        }

        public string CustomerAddress
        {
            get;
            set;
        }

        public long CustomerPhoneNumber
        {
            get;
            set;
        }

        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
                else
                {
                    itemNumber = 1;
                }
            }
        }

        public string ItemDescription
        {
            get;
            set;
        }

        public int ItemUnitPrice
        {
            get { return itemUnitPrice; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemUnitPrice = value;
                }
                else
                {
                    itemUnitPrice = 1;
                }
            }
        }

        public int ItemQuantityPurchased
        {
            get { return itemQuantityPurchased; }
            set
            {
                if (value > 0)
                {
                    itemQuantityPurchased = value;
                }
                else
                {
                    itemQuantityPurchased = 1;
                }
            }
        }

        // Methods
        public long GetTotalCost()
        {
            return ItemUnitPrice * ItemQuantityPurchased;
        }

        public override string ToString()
        {
            return $"Customer: {CustomerName}\nPhone number: {CustomerPhoneNumber}\nTotal purchases: ${GetTotalCost()}";
        }
    }
}
