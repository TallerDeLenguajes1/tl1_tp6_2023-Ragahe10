// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a= 10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);


// //EJERCICIO 1

// int num, aux = 0, aux2; 
// bool resp;

// Console.Write("Ingrese un numero ");
// resp = int.TryParse(Console.ReadLine(), out num);

// if(resp){
//     if(num > 0){
//         aux2 = num; 
//         if(num > 9){
//             while(num != 0){
//                 aux = aux*10 + num%10;
//                 num = num/10;
//             }
//         }else{
//             aux = aux2;
//         }
//         Console.WriteLine("El numero "+aux2+" con sus digitos invertidos es: "+ aux);
//     }else{
//         Console.WriteLine("El numero "+num+" no es mayor que cero");
//     }
// }else{
//     Console.WriteLine("No es numero");
// }
// //FIN EJERCICIO 1

//EJERCICIO 3
float num, num2;
bool resp;

Console.Write("Ingrese un numero: ");
resp = float.TryParse(Console.ReadLine(), out num);

if (resp)
{
    Console.WriteLine("El Numero: " + num);
    Console.WriteLine(" ~ |"+num+"| = "+ Math.Abs(num));
    Console.WriteLine(" ~"+num+"al cuadrado es "+ Math.Pow(num,2));
    Console.WriteLine(" ~La raiz cuadrada de "+num+" es "+ Math.Sqrt(num));
    Console.WriteLine(" ~seno("+num+") = "+ Math.Sin(num));
    Console.WriteLine(" ~coseno("+num+") = "+ Math.Cos(num));
    Console.WriteLine(" ~Parte entera de "+num+" es "+ Math.Truncate(num));
}
Console.Write("Ingrese  numero 1: ");
resp = float.TryParse(Console.ReadLine(), out num);
if(resp){
    Console.Write("Ingrese numero 2: ");
    resp = float.TryParse(Console.ReadLine(), out num2);
    if(resp){
        if(num>num2){
            Console.WriteLine("El máximo es: "+num);
            Console.WriteLine("El mpinimo es: "+num2);
        }else{
            Console.WriteLine("El máximo es: "+num2);
            Console.WriteLine("El mpinimo es: "+num);
        }
    }else{
        Console.WriteLine("No es número");
    }
}else{
    Console.WriteLine("No es número");
}



//FIN EJERCICIO 3