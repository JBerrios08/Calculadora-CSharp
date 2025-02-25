internal class Program
{
    private static void Main(string[] args)
    {
        // Aquí estoy mostrando las opciones disponibles
        Console.WriteLine("%%%%%% CALCULADORA %%%%%%");
        Console.Write("Seleccione una opción (1 - 5): ");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Elevar a la potencia");

        int opcion = Convert.ToInt32(Console.ReadLine());

        // Aquí estoy solicitando y almacenando los números ingresados
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        // Aquí estoy evaluando la opción seleccionada y realizando la operación
        if (opcion == 1)
        {
            resultado = num1 + num2; // Suma
        }
        else if (opcion == 2)
        {
            resultado = num1 - num2; // Resta
        }
        else if (opcion == 3)
        {
            resultado = num1 * num2; // Multiplicación
        }
        else if (opcion == 4)
        {
            // Aquí estoy verificando que el divisor no sea cero
            if (num2 != 0)
                resultado = num1 / num2; // División
            else
                Console.WriteLine("No se puede dividir por cero.");
        }
        else if (opcion == 5)
        {
            resultado = Math.Pow(num1, num2); // Potencia
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        // Aquí estoy mostrando el resultado
        Console.WriteLine("El resultado es: " + resultado);
    }
}
