using System.Formats.Asn1;
using EspacioCalculadora;
string? input;
bool parseoBool1;
int opcion = 0;
Calculadora cal=new Calculadora();  //cal objeto q yo quiero crear  
Console.WriteLine("Numero :");
input = Console.ReadLine();
parseoBool1 = float.TryParse(input, out float numero);
do {
  Console.WriteLine("Elija la operacion a realizar:\n");
  Console.WriteLine("1. Suma\n");
  Console.WriteLine("2. Resta\n");
  Console.WriteLine("3. Multiplicacion\n");
  Console.WriteLine("4. Division\n");
  Console.WriteLine("5. Limpiar\n");
  Console.WriteLine("6. Salir\n");

  if(parseoBool1)
  {
   Console.WriteLine("Ingrese la operacion:\n");
   input = Console.ReadLine();
   parseoBool1 = int.TryParse(input, out opcion);
   
   if(opcion <6 && opcion >0)
   {
    switch(opcion)
    {
      case 1: 
          cal.Suma(numero);
          Console.WriteLine(cal.Resultado);
          break;
      case 2: 
          cal.Resta(numero);
          Console.WriteLine(cal.Resultado);
          break;
      case 3:
          cal.Multiplicacion(numero);
          Console.WriteLine(cal.Resultado);
          break;
      case 4:
          cal.Division(numero);
          Console.WriteLine(cal.Resultado);
          break;
      default:
          Console.WriteLine("Opcion no valida");
          break;
    }
   }

  }
}while(opcion != 6);