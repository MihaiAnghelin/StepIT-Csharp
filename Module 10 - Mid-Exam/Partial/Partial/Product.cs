using System;
namespace Partial
{
    public class Product
    {
        private string name;
        private ProductType type;
        private ProductLabel label;
        private int price;

        public void SetInfo(string name, ProductType type, ProductLabel label, int price)
        {
            this.name = name;
            this.type = type;
            this.label = label;
            this.price = price;
        }

        public void GetInfo(ref string name, ref ProductType type, ref ProductLabel label, ref int price)
        {
            name = this.name;
            type = this.type;
            label = this.label;
            price = this.price;
        }

        public void Info(ref string str)
        {
            str += name + type + label + price;
        }

        public object GetValue(string str)
        {
            switch (str)
            {
                case "name":
                case "Name":
                    return name;
                case "type":
                case "Type":
                    return type;
                case "label":
                case "Label":
                    return label;
                case "price":
                case "Price":
                    return price;
                default:
                    return null;
            }
        }
    }
}
