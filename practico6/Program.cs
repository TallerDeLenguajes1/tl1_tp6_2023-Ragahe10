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


//FIN EJERCICIO 3
//CALCULADORA FINAL
bool resp = true, result;
int iter = 1;
float num1, num2, op;
Console.WriteLine("--------CALCULADORA --------");

while(resp){
    Console.Write("Ingrese un numero: ");
resp = float.TryParse(Console.ReadLine(), out num1);

if (resp)
{
    Console.WriteLine("El Numero: " + num1);
    Console.WriteLine(" ~ |"+num1+"| = "+ Math.Abs(num1));
    Console.WriteLine(" ~"+num1+"al cuadrado es "+ Math.Pow(num1,2));
    Console.WriteLine(" ~La raiz cuadrada de "+num1+" es "+ Math.Sqrt(num1));
    Console.WriteLine(" ~seno("+num1+") = "+ Math.Sin(num1));
    Console.WriteLine(" ~coseno("+num1+") = "+ Math.Cos(num1));
    Console.WriteLine(" ~Parte entera de "+num1+" es "+ Math.Truncate(num1));
}
Console.Write("Ingrese  numero 1: ");
resp = float.TryParse(Console.ReadLine(), out num1);
if(resp){
    Console.Write("Ingrese numero 2: ");
    resp = float.TryParse(Console.ReadLine(), out num2);
    if(resp){
        if(num1>num2){
            Console.WriteLine("El máximo es: "+num1);
            Console.WriteLine("El mpinimo es: "+num2);
        }else{
            Console.WriteLine("El máximo es: "+num2);
            Console.WriteLine("El mpinimo es: "+num1);
        }
    }else{
        Console.WriteLine("No es número");
    }
}else{
    Console.WriteLine("No es número");
}
    Console.WriteLine("OPERACIONES:");
    Console.WriteLine("  ~ SUMAR........(1)");
    Console.WriteLine("  ~ RESTAR.......(2)");
    Console.WriteLine("  ~ MULTIPLICAR..(3)");
    Console.WriteLine("  ~ DIVIDIR......(4)");
    Console.WriteLine("Seleccione operación: ");
    result = float.TryParse(Console.ReadLine(), out op);
    Console.WriteLine("-------- ITER "+iter+"--------");
    if(result && (op>0 && op<5)){
        Console.WriteLine("Ingrese dos numeros:");
        if((float.TryParse(Console.ReadLine(), out num1)) && (float.TryParse(Console.ReadLine(), out num2))){
            switch (op)
            {
                case 1: op = num1 + num2;
                    break;
                case 2: op = num1 - num2;
                    break;
                case 3: op = num1 * num2;
                    break;
                case 4: op = num1 / num2;
                    break;
            }
            Console.WriteLine("RESPUESTA: "+op);
        }else{
            Console.WriteLine("NO SE INGRESARON NUMEROS");
        }
    }else{
        Console.WriteLine("OPERACION INVALIDA");
    }
    Console.WriteLine("------------------------------");
    iter++;
    Console.WriteLine("Desea seguir operando?(SI:1|NO:0)");
    result = float.TryParse(Console.ReadLine(), out op);
    if(!result || op==0){
        resp = false;
    }
}

