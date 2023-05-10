using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13_Collextion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "d:\\test\\Text1.txt"; // Укажем путь 
            var ListText = new List<Contact>();
            var LinkedListText = new LinkedList<Contact>();
            var timer = new Stopwatch();
            timer.Start();
            if (File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                    {
                        //Console.WriteLine(str);
                        ListText.Add(new Contact(str));
                    }
                }
                timer.Stop();
                //var timerList = timer.ElapsedMilliseconds;
                Console.WriteLine("Время выполнения List: {0}", timer.ElapsedMilliseconds);
                timer.Restart();

                using (StreamReader sr = File.OpenText(filePath))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                    {
                        //Console.WriteLine(str);
                        LinkedListText.AddLast(new Contact(str));
                    }
                }
                timer.Stop();
                //var timerLinkedList = timer.ElapsedMilliseconds;
                
                Console.WriteLine("Время выполнения LinkedList: {0}", timer.ElapsedMilliseconds);
                Console.ReadLine();
            }
        }
    }
}

