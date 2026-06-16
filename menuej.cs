namespace menudeejercicios
{
    internal class menu
    {
        static void Main()
        {
            int opcion;

            do
            {
                Console.WriteLine("Menu de Ejercicios");
                Console.WriteLine("====================");                
                Console.WriteLine("Ejercicio 1 [1]");
                Console.WriteLine("Ejercicio 2 [2]");
                Console.WriteLine("Ejercicio 3 [3]");
                Console.WriteLine("Ejercicio 4 [4]");
                Console.WriteLine("Ejercicio 5 [5]");
                Console.WriteLine("Ejercicio 6 [6]");
                Console.WriteLine("Ejercicio 7 [7]");
                Console.WriteLine("Ejercicio 8 [8]");
                Console.WriteLine("Ejercicio 9 [9]");
                Console.WriteLine("Ejercicio 10 [10]");
                Console.WriteLine("Ejercicio 11 [11]");
                Console.WriteLine("Ejercicio 12 [12]");
                Console.WriteLine("Ejercicio 13 [13]");
                Console.WriteLine("Ejercicio 14 [14]");
                Console.WriteLine("====================");
                Console.WriteLine("Salir [0]");
                
                int.TryParse(Console.ReadLine(), out opcion);

                if (opcion == 1)
                {
                    Ej1();
                }

                if (opcion == 2)
                {
                    Ej2();
                }

                if (opcion == 3)
                {
                    Ej3();
                }

                if (opcion == 4)
                {
                    Ej4();
                }
                if (opcion == 5)
                {
                    Ej5();
                }
                if (opcion == 6)
                {
                    Ej6();
                }
                if (opcion == 7)
                {
                    Ej7();
                }
                if (opcion == 8)
                {
                    Ej8();
                }
                if (opcion == 9)
                {
                    Ej9();
                }
                if (opcion == 10)
                {
                    Ej10();
                }
                if (opcion == 11)
                {
                    Ej11();
                }
                if (opcion == 12)
                {
                    Ej12();
                }
                if (opcion == 13)
                {
                    Ej13();
                }
                if (opcion == 14)
                {
                    Ej14();
                }
            }
            while (opcion != 0);
        }
        static void Ej1()
        {
            Console.WriteLine("Escriba una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("La frase contiene: " + frase.Length + " caracteres");
        }
        static void Ej2()
        {
            Console.WriteLine("Escriba una frase: ");
            string frase = Console.ReadLine();
        
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());
            Console.WriteLine("La frase contiene: " + frase.Length + " caracteres");
        }
        static void Ej3()
        {
            Console.WriteLine("Escriba una frase: ");
            string frase = Console.ReadLine();
            int vocales = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u' || 
                frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
                {
                    vocales++;
                }
            }

            Console.WriteLine("La cantidad de vocales es: " + vocales);
        }
        static void Ej4()
        {
            try
            {
                Console.WriteLine("Escriba una palabra: ");
                string palabra = Console.ReadLine();

                Console.WriteLine("Primera letra: " + palabra[0]);
                Console.WriteLine("Ultima letra: " + palabra[palabra.Length - 1]);
            }
            catch
            {
                Console.WriteLine("Error ;(");
            }
        }
        static void Ej5()
        {
            try
            {
                Console.WriteLine("Escriba el primer numero: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                float resultado = num1 / num2;
                Console.WriteLine("El reesultado es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error ;( solo numeros enteros");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error ;( no se puede dividir por 0");
            }
        }
        static void Ej6()
        {
            try
            {
                Console.WriteLine("Escriba una palabra: ");
                string palabra = Console.ReadLine();
                Console.Write("Escriba una posicion: ");
                int posicion = int.Parse(Console.ReadLine());

                Console.WriteLine("Caracter: " + palabra[posicion]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error ;(");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error ;(");
            }
        }
        static void Ej7()
        {
            Console.WriteLine("Escriba una frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Escriba una palabra: ");
            string palabra = Console.ReadLine();

            if((frase.Contains(palabra)))
            {
                Console.WriteLine($"La palabra {palabra} se encuentra dentro de la frase: {frase}");
            }
        }
        static void Ej8()
        {
            try
            {
                Console.WriteLine("Escriba numeros separados por coma: ");
                string cadena = Console.ReadLine();
                string[] numeros = cadena.Split(',');
                int suma = 0;

                foreach (string numero in numeros)
                {
                    suma += int.Parse(numero);
                }

                Console.WriteLine("La suma es: " + suma);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: uno o más valores no son números válidos.");
            }
        }
        static void Ej9()
        {
            Console.WriteLine("Escribi una frase: ");
            string frase = Console.ReadLine();

            string palabra = "";

            for (int i = 0; i <= frase.Length; i++)
            {
                if (i == frase.Length || frase[i] == ' ')
                {
                    for (int j = palabra.Length - 1; j >= 0; j--)
                    {
                        Console.Write(palabra[j]);
                    }

                    Console.WriteLine(" ");
                    palabra = "";
                }
                else
                {
                    palabra += frase[i];
                }
            }
        }
        static void Ej10()
        {
            try
            {
                Console.WriteLine("Escriba una contraseña: ");
                string contraseña = Console.ReadLine();

                bool tieneNumero = false;

                for (int i = 0; i < contraseña.Length; i++)
                {
                    if (contraseña[i] >= '0' && contraseña[i] <= '9')
                    {
                        tieneNumero = true;
                    }
                }

                if (contraseña.Length < 8 || tieneNumero == false)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Contraseña valida");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres y un numero");
            }
        }
        static void Ej11()
        {
            try
            {
                Console.WriteLine("Escriba una edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad < 1 || edad > 120)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Edad valida");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error ;( la edad debe estar entre 1 y 120");
            }
        }
        static void Ej12()
        {
            try
            {
                string texto = null;
                Console.WriteLine(texto.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error ;( la variable no tiene ninguna cadena");
            }
        }
        static void Ej13()
        {
            try
            {
                Console.WriteLine("Escriba el primer numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                checked
                {
                    int suma = num1 + num2;
                    Console.WriteLine("La suma es: " + suma);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error ;( solo numeros enteros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error ;( la suma excede el rango para un int");
            }
        }
        static void Ej14()
        {
            try
            {
                Console.WriteLine("Escriba una frase: ");
                string frase = Console.ReadLine();

                if (frase == "")
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Cantidad de caracteres: " + frase.Length);

                string[] palabras = frase.Split(' ');
                Console.WriteLine("Cantidad de palabras: " + palabras.Length);

                int vocales = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u' ||
                        frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
                    {
                        vocales++;
                    }
                }
                Console.WriteLine("Cantidad de vocales: " + vocales);

                Console.Write("Escriba una posicion: ");
                int posicion = int.Parse(Console.ReadLine());
                Console.WriteLine("Caracter: " + frase[posicion]);

                Console.Write("Escriba un numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("100 / " + numero + " = " + (100 / numero));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error ;( debe ingresar un numero valido");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error ;( la posicion ingresada no existe");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error ;( no se puede dividir por cero");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error ;( la frase no puede estar vacia");
            }
        }

    }
}