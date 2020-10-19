using System;
//MVC --> Model view controller. En view va todo lo que se imprima y vea pantalla.
//Model es todo aquello que maneja mi aplicación (sumas, restas, sumatorio, etc)
//Controller es la clase Program -donde esta el main-.


namespace CalculadoraMadeInChina
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //bucle infinito que devuelve un bool (true)
            {
                UserInterface.PrintMainMenu();
                string option = System.Console.ReadLine();
                System.Console.WriteLine("Has elegido " + option);
            }
        }
    }
}
