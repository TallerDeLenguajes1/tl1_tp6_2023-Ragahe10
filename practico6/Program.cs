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
// resp = int.TryParse(Console.ReadLine(), out num);//control para cargar números

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

//EJERCICIO 2
bool resp = true, result;
int iter = 1, op, num1, num2;
Console.WriteLine("--------CALCULADORA V1--------");

while(resp){
    Console.WriteLine("OPERACIONES:");
    Console.WriteLine("  ~ SUMAR........(1)");
    Console.WriteLine("  ~ RESTAR.......(2)");
    Console.WriteLine("  ~ MULTIPLICAR..(3)");
    Console.WriteLine("  ~ DIVIDIR......(4)");
    Console.WriteLine("Seleccione operación: ");
    result = int.TryParse(Console.ReadLine(), out op);
    Console.WriteLine("-------- ITER "+iter+"--------");
    if(result && (op>0 && op<5)){
        Console.WriteLine("Ingrese dos numeros:");
        if((int.TryParse(Console.ReadLine(), out num1)) && (int.TryParse(Console.ReadLine(), out num2))){
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
    result = int.TryParse(Console.ReadLine(), out op);
    if(!result || op==0){
        resp = false;
    }
}