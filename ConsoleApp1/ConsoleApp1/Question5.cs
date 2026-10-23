using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question5
    {
        public void Runner()
        {
            List<StockItem> items=new List<StockItem>();
            items.Add(new StockItem("a", 10));
            items.Add(new StockItem("b", 20));
            items.Add(new StockItem("c", 20));

            Console.WriteLine("Original item : sku =  " + items[1].Sku +" qty : " + items[1].Qty);


            string skuToUpdate = "b";
            int add = 2;
            ReStock(items, skuToUpdate, add);
            Console.WriteLine("After update item : sku =  " + items[1].Sku + " qty : " + items[1].Qty);

            StockItem[] arr=
            {
                new StockItem("x", 10),
                new StockItem("y", 20),
                new StockItem("z", 30),
            };
            skuToUpdate = "z";
            add = 30;
            ReStockArray(arr, skuToUpdate, add);
            Console.WriteLine("After update arr : sku =  " + arr[2].Sku + " qty : " + arr[2].Qty);




        }


        public void ReStock(List<StockItem> items, string sku, int add)
        {
            //we cant upadte value of struct directly into for each 
            // bcz for each is read only loop we cant update inside it
            //structs are value types, meaning a indexer on a List<T>
            //returns a temporary copy of the struct rather than the actual
            //variable inside the list.
            //When you write items[i], you are not interacting with raw memory.
            //You are actually invoking a hidden C# property called an Indexer,
            //which translates behind the scenes into a method call like this:
            //so that we need to use conventional for loop
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Sku == sku)
                {
                    StockItem temp= items[i];
                    temp.Qty += add;
                    items[i] = temp;
                }
            }
        }

        public void ReStockArray(StockItem[] arr, string skuToUpdate, int add)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Sku == skuToUpdate)
                {
                    //here this will work
                    //When you write arr[i].Qty += add;, the C# compiler knows
                    //the exact memory address of that element. Instead of
                    //copying anything, it reaches directly inside the array's
                    //memory slot and modifies the Qty field right where it lives.
                    arr[i].Qty += add;
                }
            }
        }
    }

    public struct StockItem 
    { 
        public string Sku;
        public int Qty;

        public StockItem(string Sku, int Qty) { 
            this.Sku = Sku;
            this.Qty = Qty;
        }
    }
}
