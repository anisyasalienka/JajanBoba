using System;

namespace JajanBoba
{
    public abstract class Topping : IMenu
    {
        public string name { get; set; }
        public int price { get; set; }
        public Topping()
        {
            this.price = 0;
            this.name = "";
        }

        public string Info()
        {
            return $"{this.name}\t{this.price}\n";
        }
    }
}
