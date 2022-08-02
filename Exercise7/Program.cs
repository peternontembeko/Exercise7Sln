using System;

namespace Exercise7
{
    internal class Invoice
    {
        private string description;
        private double price;
        private int quantity;

        public Invoice (string description,double amount,int quantity)
        {
            this.description = description;
            this.price = amount;
            this.quantity = quantity;
        }
        public string getDescription()
        {
            return description;
        }
        public double getPrice()
        {
            return price;
        }
        public double getQualinty()
        {
            return quantity;
        }
        public double calcSaleAmount()
        {
            double sale = price * quantity;
            return sale;
        }
        public double calcDiscount()
        {
            double discount = 0;
            if (quantity < 10)
            {
                discount = 0;
            }
            else if (quantity > 10 && quantity < 20)
            {
                discount = calcSaleAmount() * 0.05;

            }
            else if(quantity >= 20)
            {
                discount = calcSaleAmount() * 0.10;
            }
            return discount;
        }
    }

}
