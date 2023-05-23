// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a= 10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);


//EJERCICIO 1

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
//FIN EJERCICIO 1

//EJERCICIO 4
Console.WriteLine("Ingrese una frase o palabra:");
string? cad1 = Console.ReadLine();
if(cad1!= null){
    Console.WriteLine("La longitud de: \'"+cad1+"\' es: "+cad1.Length);
    Console.WriteLine("Ingrese otra frase o palabra:");
    string? cad2 = Console.ReadLine();
    if(cad2!= null){
        cad2 = cad1 +" "+ cad2;
        Console.WriteLine(cad2);
        string subcad = cad2.Substring(3);
        Console.WriteLine("subcadena: "+subcad);
    }
}
//FIN EJERCICIO 4