using System;
using System.ComponentModel;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static int ManageAddSubMenu(int Accumuled)
        {
            while (true)
            {
<<<<<<< Updated upstream
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número");
                Accumuled = Accumuled + number;
                System.Console.WriteLine("Llevas acumulado " + Accumuled);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
=======
                UserInterface.PrintAddMenu(); //cabecera de la suma


  
>>>>>>> Stashed changes
            }

        }
        public static void ManageAddMenu() //devuelve void porque es el controlador del menú de sumas, los manejadores no suelen devolver nada
        {
            bool finished = false;
            while (finished == false)
            {
                System.Console.Clear();
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduce el primer número");
                int number2 = ManageUtils.ReadInteger("Introduce el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);

                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadOption();

                if (option == 0)
                    break;

                else if (option == 2)
                    System.Console.Clear();

                else if (option == 1)
                {
                    int submenu_option = ManageAddSubMenu(result); //el resultado se acumulará y se remitirá a la variable Accumuled en la función que llamamos
                    if (submenu_option == 0)
                        return;
                }
            }

        }
        public static int ManageSubSubMenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintSubHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número ");
                Accumuled = Accumuled - number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
            }

        }
        public static void ManageSubMenu ()
        {
            while (true)
            {
                System.Console.Clear(); //límpia la pantalla
                UserInterface.PrintSubHeader(); //imprime la cabecera
                int number1 = ManageUtils.ReadInteger("Introduce el primer número");
                int number2 = ManageUtils.ReadInteger("Introduce el segundo número");
                int result = number1 - number2;
                System.Console.Write("El resultado es: " + result);

                UserInterface.PrintSubSubMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                    break;

                else if (option == 2)
                    System.Console.Clear();

                else if (option == 1)
                {
                    int submenu_option = ManageSubSubMenu(result); //el resultado se acumulará y se remitirá a la variable Accumuled en la función que llamamos
                    if (submenu_option == 0)
                        return;
                }
            }
        }
        public static int ManageMultSubMenu(int Accumuled)
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled = Accumuled * number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);

                UserInterface.PrintMultSubMenu();
                int option = UserInterface.ReadOption();
                switch (option)
                {
                    case 0:
                        return 0;
                    case 2:
                        return 2;
                }
            }

        }
        public static void ManageMultMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintMultHeader();
                int number1 = ManageUtils.ReadInteger("Escribe el primer número");
                int number2 = ManageUtils.ReadInteger("Escribe el segundo número");
                int result = number1 * number2;
                System.Console.WriteLine("El resultado es: " + result);

                UserInterface.PrintMultSubMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                    break;

                else if (option == 2)
                    System.Console.Clear();

                else if (option == 1) 
                {
                    int submenu_option = ManageMultSubMenu(result);
                    if (submenu_option == 0)
                        return;
                }


            }
        }


            public static void ManageMainMenu()//Función para controlar la interfaz del main menu, en vez de manage podría ser launch ya que en las aplicaciones grandes es lanzar algo
            {
                bool finished = false; //la variable finished es false
                while (finished == false)  //bucle infinito que devuelve un bool (true) - lógica de una aplicación
                {
                    UserInterface.PrintMainMenu(); //Imprime menú principal
                    int option = UserInterface.ReadOption(); //Almacenamos el valor del usuario, llamada a función de introducir valor

                    switch (option)
                    {
                        case -1: //si mete un error
                            System.Console.Clear(); //sirve para limpiar lo que hay en pantalla
                            System.Console.WriteLine("Opción no valida");
                            break;
                        case 1:
                            ManageAddMenu(); //En el caso 1 llamo a la función del controlador de sumas
                            break;
                        case 2:
                            ManageSubMenu();
                            break;
                        case 3:
                            ManageMultMenu();
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 0:
                            finished = true; //para salir del bucle while no podría poner un break, por ello es mejor decir que la condición del while deje de cumplirse poniendo que finished es true
                            break;
                    }

                }
            }


            static void Main(string[] args)
            {
                ManageMainMenu();

            }
        
    }
}
