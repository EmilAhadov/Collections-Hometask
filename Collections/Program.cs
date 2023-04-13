using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Threading;

namespace Collections
{
    internal class Program
    {
        //-------------------------------------------------------------------------------------------------------
        //Task1
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

        static void Main(string[] args)
        {
            Queue<Document> documents = new Queue<Document>();
            Document document1 = new Document
            {
                Name = "a",
                pageAmount = 18
            };
            Document document2 = new Document
            {
                Name = "b",
                pageAmount = 23
            };
            Document document3 = new Document
            {
                Name = "c",
                pageAmount = 11
            };
            documents.Enqueue(document1);
            documents.Enqueue(document2);
            documents.Enqueue(document3);
            bool _continue = true;
            do
            {
                Console.WriteLine("What do you want to do:\n" +
                    "1.Create and Add document\n" +
                    "2.Print all documents");
                string action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        documents.Enqueue(CreateDocument());
                        break;
                    case "2":
                        PrintDocuments(documents);
                        _continue= false;
                        break;
                    default:
                        break;
                }

            } while (_continue);
        }

        class Document
        {
            public string Name { get; set; }
            public int pageAmount { get; set; }
        }
        static Document CreateDocument()
        {
            Document document = new Document();
            Console.Write("Please enter the document name: ");
            document.Name = Console.ReadLine();
            Console.Write("Please enter the document's pages: ");
            document.pageAmount = int.Parse(Console.ReadLine());
            return document;
        }
        static void PrintDocuments(Queue<Document> documents)
        {
            for(int i=0; i<documents.Count; i++)
            {

                Console.WriteLine($"{i+1}.document name: {documents.Peek().Name}\n" +
                    $"{i+1}.document's number of page: {documents.Peek().pageAmount}");
                documents.Dequeue();
            }

        }


        //-------------------------------------------------------------------------------------------------------
        //Task5

    }
}




