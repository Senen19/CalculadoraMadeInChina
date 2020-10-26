using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageAddSubMenu(int Accumuled)
        {
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
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }

        }
        public static void ManageAddMenu() //devuelve void porque es el controlador del menú de sumas, los manejadores no suelen devolver nada
        {
            bool finished = false;
            while (finished == false)
            {
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
                    ManageAddSubMenu(result); //el resultado se acumulará y se remitirá a la variable Accumuled en la función que llamamos
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
                            break;
                        case 3:
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
