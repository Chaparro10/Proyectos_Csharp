// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Declaracion de Arreglo
int[] numeros = { 1, 2, 3, 4, 5 };

 int ValorMaximoArreglo(int[] numeros)
{
    int valorMaximo =numeros[0];
    for (int i=0;i<numeros.Length;i++)
    {
        if (valorMaximo < numeros[i])
        {
            valorMaximo = numeros[i];
        }
    }
    return valorMaximo;
}

Console.WriteLine("El valor maximo es :" + ValorMaximoArreglo(numeros));


//PRUEBA INVERTIR CADENA
string InvierteCadena(String cadena)
{
    string cadenaInv = "";

    for (int i=cadena.Length-1;i>=0;i--)
    {
        cadenaInv += cadena[i];
    }
    return cadenaInv ;
}

string cadena = "gato1 perro gato";
Console.WriteLine("La cadena Invertida es :" + InvierteCadena(cadena));

//CUENTA NUMEROS EN CADENA
int CuentaNum(String cadena)
{
    // Utiliza una expresión regular para dividir la cadena en segmentos que no contienen dígitos
    string[] words = System.Text.RegularExpressions.Regex.Split(cadena, @"\d+");

    // Filtra los elementos no vacíos
    words = words.Where(word => !string.IsNullOrEmpty(word)).ToArray();

    // Devuelve la cantidad de segmentos que contienen solo dígitos
    return words.Length;
}

Console.WriteLine("La cadena tiene un total numeros :" + CuentaNum(cadena));

//Contador de palabras
int CuentaPalabras(String cadena)
{
    int contador = 0;
    // Elimina espacios en blanco adicionales al principio y al final
    cadena = cadena.Trim();

    // Divide la cadena en palabras utilizando espacios en blanco como separadores
    string[] words = cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    // Devuelve la cantidad de palabras
    contador = words.Length;

    return contador;
}

Console.WriteLine("Palabras que hay :" + CuentaPalabras(cadena));

//CONTADOR DE CARACTERES QUE TIENE UNA PALABRA
int CuentaCaracter(String cadena , char caracter)
{
    int n = 0;
    for (int i = 0; i < cadena.Length; i++)
    {
        char c = cadena[i];
        if (c == caracter)
        {
            n++;
        }
    }
    return n;
}
Console.WriteLine("Cantidad del Caracter :" + CuentaCaracter("Perro",'r'));

//PALABRAS QUE SE REPITEN EN UN ARRAY 
string RepiteEnArray(string[] cade)
{
    string resultado = "";

    for (int i = 0; i < cade.Length; i++)
    {
        for (int j = i + 1; j < cade.Length; j++)
        {
            if (cade[i] == cade[j])
            {
                if (!resultado.Contains(cade[i]))
                {
                    resultado += cade[i] + "-";
                }
            }
        }
    }

    return resultado.Trim();

}
String[] cade = { "Hola", "Mundo", "Aqui", "Estoy", "Hola","Mundo" };

Console.WriteLine("Se repite en Array :"+ RepiteEnArray(cade));

Console.ReadKey();
