using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    abstract class ItemCalculator
    {
        protected Item item { get; private set; }
        public ItemCalculator(Item item)
        {
            this.item = item;
        }
        public abstract double calculateSubTotal();
    }
}
