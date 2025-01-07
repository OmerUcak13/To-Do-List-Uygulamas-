using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("To-Do List Uygulaması");
                Console.WriteLine("1. Görev Ekle");
                Console.WriteLine("2. Görevleri Listele");
                Console.WriteLine("3. Görev Sil");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi yapın: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Eklemek istediğiniz görevi yazın: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Görev eklendi! Bir tuşa basarak devam edin...");
            Console.ReadKey();
        }

        static void ListTasks()
        {
            Console.WriteLine("\n--- Görev Listesi ---");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Henüz eklenmiş bir görev yok.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            Console.WriteLine("Bir tuşa basarak devam edin...");
            Console.ReadKey();
        }

        static void DeleteTask()
        {
            ListTasks();
            Console.Write("Silmek istediğiniz görevin numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
            {
                tasks.RemoveAt(taskIndex - 1);
                Console.WriteLine("Görev silindi! Bir tuşa basarak devam edin...");
            }
            else
            {
                Console.WriteLine("Geçersiz numara. Bir tuşa basarak devam edin...");
            }
            Console.ReadKey();
        }
    }
} 
