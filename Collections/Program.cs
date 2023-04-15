using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security;
using System.Threading;

namespace Collections
{
    internal class Program
    {
        //-------------------------------------------------------------------------------------------------------
        //Task1

        //static List<Contact> _contactList = new List<Contact>();

        //static void Main(string[] args)
        //{
        //    Contact contact1 = new Contact()
        //    {
        //        Name = "Emil",
        //        Number = "055-729-41-47"
        //    };
        //    Contact contact2 = new Contact()
        //    {
        //        Name = "Emin",
        //        Number = "055-729-41-48"
        //    };
        //    Contact contact3 = new Contact()
        //    {
        //        Name = "Elmin",
        //        Number = "055-729-42-47"
        //    };
        //    _contactList.Add(contact1);
        //    _contactList.Add(contact2);
        //    _contactList.Add(contact3);
        //    bool keepGoing = true;
        //    do
        //    {
        //        Console.WriteLine(" 1.Get Number\n 2.Add Number\n 3.Remove Number\n 4.Exit");

        //        string operation = Console.ReadLine();

        //        switch (operation)
        //        {
        //            case "1":
        //                GetNumber();
        //                break;
        //            case "2":
        //                AddNumber();
        //                break;
        //            case "3":
        //                RemoveNumber();
        //                break;
        //            case "4":
        //                keepGoing = false;
        //                break;
        //            default:
        //                break;

        //        }
        //    } while (keepGoing);

        //}

        //private static void AddNumber()
        //{
        //    Console.WriteLine("Nomreni daxil edin: ");
        //    string number = Console.ReadLine();
        //    Console.WriteLine("Adi daxil edin: ");
        //    string name = Console.ReadLine();
        //    Contact contact = new Contact()
        //    {
        //        Name = name,
        //        Number = number
        //    };
        //    _contactList.Add(contact);
        //}

        //private static void GetNumber()
        //{
        //    Console.WriteLine("Adi daxil edin: ");
        //    string name = Console.ReadLine();

        //    foreach (Contact contact in _contactList)
        //    {
        //        if(name ==  contact.Name)
        //        Console.WriteLine(contact.Number);
        //    }
        //}
        //private static void RemoveNumber()
        //{
        //Console.WriteLine("Adi daxil edin: ");
        //    string name = Console.ReadLine();
        //    for(int i =0; i<_contactList.Count; i++)
        //    {
        //        if (_contactList[i].Name == name)
        //        {
        //            _contactList.Remove(i);
        //        }
        //    }
        //}

        //class Contact
        //{
        //    public string Name { get; set; }
        //    public string Number { get; set; }
        //}

        //-------------------------------------------------------------------------------------------------------
        //Task2
        //static void Main(string[] args)
        //{
        //    Dictionary<string, int> WordsAndAmount = new Dictionary<string, int>();
        //    List<string> list = new List<string>();
        //    string sentence = "a a a b b b";
        //    string[] words = sentence.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (!list.Contains(words[i]))
        //        {
        //            list.Add(words[i]);
        //        }

        //    }
        //    int[] counts = new int[list.Count];
        //    int count = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        count = 0;
        //        for (int j = 0; j < words.Length; j++)
        //        {
        //            if (words[j] == list[i])
        //            {
        //                count++;
        //            }
        //        }
        //        counts[i] = count;
        //    }
        //    for (int i = 0; i < counts.Length; i++)
        //    {
        //        WordsAndAmount.Add(list[i], counts[i]);
        //    }
        //    foreach (KeyValuePair<string, int> pair in WordsAndAmount)
        //    {
        //        Console.WriteLine(pair.Key);
        //        Console.WriteLine(pair.Value);
        //    }
        //}
        //-------------------------------------------------------------------------------------------------------
        //Task3

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter the sentence");
        //    string currentText = Console.ReadLine();
        //    Stack<string> stack = new Stack<string>();
        //    string previousText = "";
        //    bool flag = true;
        //    do
        //    {
        //        Console.WriteLine("What do you want to do: \n" +
        //            "1.Add Current Text\n" +
        //            "2.Return changes\n" +
        //            "3.Exit");
        //        string action = Console.ReadLine();
        //        switch (action)
        //        {
        //            case "1":
        //                previousText = currentText;
        //                stack.Push(previousText);
        //                currentText += Console.ReadLine();
        //                break;
        //            case "2":
        //                previousText = currentText;
        //                currentText = stack.Peek();
        //                stack.Pop();
        //                stack.Push(previousText);
        //                break;
        //            case "3":
        //                flag = false;
        //                break;
        //            default:
        //                break;
        //        }
        //    } while (flag);
        //    Console.WriteLine(currentText);
        //}


        //-------------------------------------------------------------------------------------------------------
        //Task4

        //static void Main(string[] args)
        //{
        //    Queue<Document> documents = new Queue<Document>();
        //    Document document1 = new Document
        //    {
        //        Name = "a",
        //        pageAmount = 18
        //    };
        //    Document document2 = new Document
        //    {
        //        Name = "b",
        //        pageAmount = 23
        //    };
        //    Document document3 = new Document
        //    {
        //        Name = "c",
        //        pageAmount = 11
        //    };
        //    documents.Enqueue(document1);
        //    documents.Enqueue(document2);
        //    documents.Enqueue(document3);
        //    bool _continue = true;
        //    do
        //    {
        //        Console.WriteLine("What do you want to do:\n" +
        //            "1.Create and Add document\n" +
        //            "2.Print all documents");
        //        string action = Console.ReadLine();
        //        switch(action)
        //        {
        //            case "1":
        //                documents.Enqueue(CreateDocument());
        //                break;
        //            case "2":
        //                PrintDocuments(documents);
        //                _continue= false;
        //                break;
        //            default:
        //                break;
        //        }

        //    } while (_continue);
        //}

        //class Document
        //{
        //    public string Name { get; set; }
        //    public int pageAmount { get; set; }
        //}
        //static Document CreateDocument()
        //{
        //    Document document = new Document();
        //    Console.Write("Please enter the document name: ");
        //    document.Name = Console.ReadLine();
        //    Console.Write("Please enter the document's pages: ");
        //    document.pageAmount = int.Parse(Console.ReadLine());
        //    return document;
        //}

        //static void PrintDocuments(Queue<Document> documents)
        //{
        //    int temporaryCount = documents.Count;
        //    for(int i=0; i<temporaryCount; i++)
        //    {

        //        Console.WriteLine($"{i+1}.document name: {documents.Peek().Name}\n" +
        //            $"{i+1}.document's number of page: {documents.Peek().pageAmount}");
        //        documents.Dequeue();
        //    }

        //}


        //-------------------------------------------------------------------------------------------------------
        //Task5
        //static Dictionary<string, Product> productList = new Dictionary<string, Product>();
        //static List<Product> reprovisionedProducts = new List<Product>();
        //static void Main(string[] args)
        //{
        //    Product product1 = new Product()
        //    {
        //        Name = "Samsung Galaxy S23 Ultra",
        //        ProductPrice = 3500,
        //        ProductQuantity = 14,
        //        QuantityLimit = 10,
        //    };
        //    Product product2 = new Product()
        //    {
        //        Name = "Xiaomi Redmi 10C",
        //        ProductPrice = 380,
        //        ProductQuantity = 6,
        //        QuantityLimit = 4
        //    };
        //    Product product3 = new Product()
        //    {
        //        Name = "HUAWEI Nova Y70",
        //        ProductPrice = 500,
        //        ProductQuantity = 2,
        //        QuantityLimit = 8
        //    };
        //    productList.Add(product1.Name, product1);
        //    productList.Add(product2.Name, product2);
        //    productList.Add(product3.Name, product3);

        //    bool keepGoing = true;
        //    do
        //    {
        //        Console.WriteLine(" 1.Add product\n 2.Remove product\n 3.Update product\n 4.ShowEverything\n 5.Exit");
        //        string operation = Console.ReadLine();
        //        switch (operation)
        //        {
        //            case "1":
        //                AddProduct();
        //                break;
        //            case "2":
        //                RemoveProduct();
        //                break;
        //            case "3":
        //                Update();
        //                break;
        //            case "4":
        //                ShowEverything();
        //                break;
        //            case "5":
        //                keepGoing = false;
        //                break;
        //        }
        //    } while (keepGoing);
        //}
        //static void AddProduct()
        //{
        //    Console.Write("Please enter the product name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Please enter the product price: ");
        //    int.TryParse(Console.ReadLine(), out int price);
        //    Console.Write("Please enter the product amount: ");
        //    int.TryParse(Console.ReadLine(), out int amount);
        //    Console.Write("Please enter the product limit: ");
        //    int.TryParse(Console.ReadLine(), out int limit);
        //    Product product = new Product()
        //    {
        //        Name = name,
        //        ProductPrice= price,
        //        ProductQuantity= amount,
        //        QuantityLimit = limit
                
        //    };
        //    productList.Add(product.Name, product);
        //}
        //static void RemoveProduct()
        //{
        //    Console.WriteLine("Adi daxil edin: ");
        //    string name = Console.ReadLine();
        //    for (int i = 0; i < productList.Count; i++)
        //    {
        //        if (productList.ContainsKey(name)) 
        //        {
        //            productList.Remove(name);
        //        }
        //    }
        //}
        //static void Update()
        //{
        //    Console.Write("Please enter the product name: ");
        //    string name = Console.ReadLine();
        //    for (int i = 0; i < productList.Count; i++)
        //    {
        //        if (productList.ContainsKey(name))
        //        {
        //            Console.Write("Please enter the product price: ");
        //            int.TryParse(Console.ReadLine(), out int price);
        //            Console.Write("Please enter the product amount: ");
        //            int.TryParse(Console.ReadLine(), out int amount);
        //            Console.Write("Please enter the product limit: ");
        //            int.TryParse(Console.ReadLine(), out int limit);

        //            productList[name].ProductPrice = price;
        //            productList[name].ProductQuantity = amount;
        //            productList[name].QuantityLimit = limit;
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Product didn't found");
        //        }
        //    }
        //}
        //static void ShowEverything()
        //{
        //    foreach(var item in productList) 
        //    {
        //        Console.WriteLine($"Product name: {item.Key}\n Product price: {item.Value.ProductPrice}\n " +
        //            $"Product amount: {item.Value.ProductQuantity}\n Product that need to be reprovisioned: {Limit(item.Value)}");
        //        Console.WriteLine("-----------------------------------------------------");
        //    }
        //}
        //static bool Limit(Product product)
        //{
        //    if (product.ProductQuantity > product.QuantityLimit)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        reprovisionedProducts.Add(product);
        //        return false;
        //    }
            
        //}
        //class Product
        //{
        //    public string Name { get; set; }
        //    public int ProductPrice { get; set; }
        //    public int ProductQuantity { get; set; }
        //    public int QuantityLimit { get; set; }  
        //}
    }
}




