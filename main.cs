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

        string msjCifrado = Cifrar(msj);
        Console.WriteLine("Mensaje cifrado: " + msjCifrado);

        string mensajeDescifrado = Descifrar(msjCifrado);
        Console.WriteLine("Mensaje descifrado: " + mensajeDescifrado);

    }

    private static string Cifrar(string msj)
    {
        return Cesar(msj, 7);
    }

    private static string Descifrar(string msjCifrado)
    {
        return Cesar(msjCifrado, -7); // Usar una distancia de -7 para descifrar
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