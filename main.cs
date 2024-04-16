using System;

class Program
{
    private static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    public static void Main()
    {
        Console.WriteLine("Ingrese la frase a cifrar:");
        string msj = Console.ReadLine();


        while (string.IsNullOrEmpty(msj))
        {
            Console.WriteLine("Ingrese un mensaje no vacío:");
            msj = Console.ReadLine();
        }

        Console.WriteLine("Ingrese la cantidad de movimientos:");
        string indice = Console.ReadLine();

        while (string.IsNullOrEmpty(indice))
        {
            Console.WriteLine("Ingrese un a distancia no vacía:");
            indice = Console.ReadLine();
        }

      int indicenum = Convert.ToInt32 (indice);

        string msjCifrado = Cifrar(msj,indicenum);
        Console.WriteLine("Mensaje cifrado: " + msjCifrado);

        string msjDescifrado = Descifrar(msjCifrado,indicenum);
        Console.WriteLine("Mensaje descifrado: " + msjDescifrado);

    }

    private static string Cifrar(string msj, int distancia)
    {
        return Cesar(msj, distancia);
    }

    private static string Descifrar(string msjCifrado, int distancia)
    {
        return Cesar(msjCifrado, -distancia); 
    }


    private static string Cesar(string msj, int distancia)
    {
        string mensajeTransformado = "";

        foreach (char caracter in msj)
        {
            int indice = alfabeto.IndexOf(caracter);
            if (indice == -1)
            {
                // Caracter no encontrado en el alfabeto
                Console.WriteLine("Caracteres no encontrado");
            }
            else
            {
                // Aplicar cifrado o descifrado de Cesar segun la distancia especificada
                int nuevoIndice = (indice + distancia) % alfabeto.Length;
                if (nuevoIndice < 0)
                {
                    // Manejar indices negativos sumando la longitud del alfabeto
                    nuevoIndice += alfabeto.Length;
                }
                mensajeTransformado += alfabeto[nuevoIndice];
            }
        }

        return mensajeTransformado;
    }
}
