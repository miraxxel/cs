﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //устанавливаем.заголовок.консоли
            Console.Title = "Список.процессов";
            //изменяем.размер.буфера.консоли.и.окна.на.
            //необходимые.нам
            Console.WindowWidth = 40;
            Console.BufferWidth = 40;
            //получаем.список.процессов
            Process[] processes = Process.GetProcesses();
            //выводим.заголовок
            Console.WriteLine("  {0,-28}{1,-10}", "Имя.процесса: ", "PID: ");
            //для.каждого.процесса.выводим.имя.и.PID
            foreach (Process p in processes)
                Console.Write("  {0,-28}{1,-10}", p.ProcessName, p.Id);
        }
    }
}
