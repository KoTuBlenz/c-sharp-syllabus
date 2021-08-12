using System;
using System.Collections.Generic;
namespace Exercise1
{
    class Program
    {
        private static List<Product> productList = new List<Product>() {
            new Product("Logitech mouse", 70.00 , 14),
            new Product("iPhone 5s", 999.99, 3),
            new Product("Epson EB-U05", 440.46, 1)};
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to \"Random Shop\"\n" +
                "List of products:");
                PrintList();
                Console.WriteLine("Choose one of the options:\n" +
                    "1. Add product to list\n" +
                    "2. Edit product from the list\n" +
                    "0. Exit the program");
                switch ((int)CheckUserInput())
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            

        }
        static void EditProduct()
        {
            Console.Clear();
            PrintList();
            Console.WriteLine("Choose product to edit by its index");
            int index = (int)CheckUserInput();
            if(index > productList.Count)
            {
                Console.WriteLine("Product with such index was not found");
                return;
            }
            Console.Clear();
            Product productToEdit = productList[index-1];
            productToEdit.PrintProduct();
            Console.WriteLine("\nChoose one of the options:\n" +
                    "1. Edit price\n" +
                    "2. Edit amount\n" +
                    "0. Back to main menu");
            switch ((int)CheckUserInput())
            {
                case 1:
                    Console.WriteLine("Enter new price");
                    productToEdit.ChangePrice(CheckUserInput());
                    Console.WriteLine("Price was changed!");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Enter new amount");
                    productToEdit.ChangeAmount((int)CheckUserInput());
                    Console.WriteLine("Amount was changed!");
                    Console.ReadKey();
                    break;
                default:
                    return;
            }
        }
        static double CheckUserInput()
        {
            while (true)
            {
                if(double.TryParse(Console.ReadLine(), out double x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
        static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter products name");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product price");
            double productPrice = CheckUserInput();
            Console.WriteLine("Enter amount of product");
            int productAmount = (int)CheckUserInput();
            productList.Add(new Product(productName, productPrice, productAmount));
        }
        static void PrintList()
        {
            int i = 1;
            foreach(Product product in productList)
            {
                Console.Write($"| #{i} |");
                product.PrintProduct();
                i++;
            }
        }
       
    }
    class Product
    {
        private string _name;
        private double _price;
        private int _amount;
        public Product(string name, double price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
        }
        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }
        public void ChangeAmount (int newAmount)
        {
            _amount = newAmount;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"\"{_name}\", {String.Format("{0:0.00}", _price)} EUR, amount {_amount}");
        }
    }
}
