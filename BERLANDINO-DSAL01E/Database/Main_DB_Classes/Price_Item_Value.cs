using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class Price_Item_Value
    {
        public String price, itemname, discount_amount;

        /* Codes for setting the value of the item name, item price, which are 
         to be stored inside the itemName and price variables */

        public void SetPriceItemValue(String item_name, String item_price)
        {
            itemname = item_name;
            price = item_price;
        }

        // Codes for getting the value of an item and using it as needed in the application
        public string GetItemName()
        {
            return itemname;
        }

        // Codes for getting the price of an item and using it as needed in the application
        public string GetPrice()
        {
            return price;
        }

        /* Cdoes for setting the value of the discount amount and item price, which are to be
         be stored inside the discount_amount and priceItem variables */
        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amt;
        }

        // Codes for getting the value of a price and using it as needed in the application
        public string GetPriceItem()
        {
            return price;
        }

        // Codes for getting the value of a discount_amount and using it as needed in the application
        public string GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
