using System;
using System.Linq;

namespace Homework
{
    enum Color
    {
        Red,
        Black,
        White,
        Blue
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product watch1 = new Watch("Apple watch", 500, 10, 45);
            Product phone1 = new Phone("Apple 14", 1200, 2, Color.Red);

            Inventory inventory = new Inventory(new Product[] { watch1, phone1 });

            inventory.PrintInfo();

            Product watch2 = new Watch("Samsung watch", 400, 3, 42);

            inventory.AddProduct(watch2);

            Console.WriteLine(new String('-', 50));
            inventory.PrintInfo();


            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Searching product");
            Console.WriteLine(inventory.SearchProduct("Apple 14"));
            Console.WriteLine(new String('-', 50));

            Console.WriteLine("All Price - " + inventory.AllPrice());
        }
    }
    class Inventory
    {
        //List
        private Product[] Products = new Product[10];
        public Inventory(Product[] products)
        {
            Products = products;
        }
        public void PrintInfo()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
            }
        }
        public void AddProduct(Product newProduct)
        {
            Products = Products + newProduct;
        }
        public void RemoveProduct(Product product)
        {
            Products = Products - product;
            // hnaravorutyan depqum poqracnel zangvaci chapy
        }
        public Product SearchProduct(string productName)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] != null)
                    if (Products[i].Name == productName)
                        return Products[i];
            }
            return null;
        }
        public int AllPrice()
        {
            int sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] != null)
                {
                    for(int j = 0; j < Products[i].Count; j++)
                    {
                        sum+=Products[i].Price;
                    }
                }
            }
            return sum;
        }

    }
    class Watch : Product
    {
        public float Radius { get; set; }
        public Watch(string name, int price, int count, float radius) : base(name, price, count)
        {
            Radius = radius;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Radius = {Radius}";
        }
    }
    class Phone : Product
    {
        public Color Color { get; set; }
        public Phone(string name, int price, int count, Color color) : base(name, price, count)
        {
            Color = color;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Color {Color}";
        }

    }
    abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Product(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public override string ToString()
        {
            return $"Name {Name} - Price {Price} - Count {Count}";
        }
        public static Product[] operator +(Product[] products, Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    return products;
                }
            }
            Array.Resize(ref products, products.Length * 2);
            products[products.Length / 2] = product;
            return products;

        }
        public static Product[] operator -(Product[] products, Product product)
        {
            for (var i = 0; i < products.Length; i++)
            {
                if (products[i] == product)
                {
                    products[i] = null;
                    break;
                }
            }
            return products;
        }
    }
}
