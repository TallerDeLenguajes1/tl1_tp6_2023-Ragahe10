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
// Console.WriteLine("Ingrese una frase o palabra:");
// string? cad1 = Console.ReadLine();
// if(cad1!= null){
//     Console.WriteLine("La longitud de: \'"+cad1+"\' es: "+cad1.Length);
//     Console.WriteLine("Ingrese otra frase o palabra:");
//     string? cad2 = Console.ReadLine();
//     if(cad2!= null){
//         cad2 = cad1 +" "+ cad2;
//         Console.WriteLine(cad2);
//         string subcad = cad2.Substring(3);
//         Console.WriteLine("subcadena: "+subcad);
//     }
// }

// bool result;
// int iter = 1, op;
// float num1, num2, resp;
// Console.WriteLine("--------CALCULADORA V1--------");
//     Console.WriteLine("OPERACIONES:");
//     Console.WriteLine("  ~ SUMAR........(1)");
//     Console.WriteLine("  ~ RESTAR.......(2)");
//     Console.WriteLine("  ~ MULTIPLICAR..(3)");
//     Console.WriteLine("  ~ DIVIDIR......(4)");
//     Console.WriteLine("Seleccione operación: ");
//     result = int.TryParse(Console.ReadLine(), out op);
//     if(result && (op>0 && op<5)){
//         Console.WriteLine("Ingrese dos numeros:");
//         if((float.TryParse(Console.ReadLine(), out num1)) && (float.TryParse(Console.ReadLine(), out num2))){
//             switch (op)
//             {
//                 case 1: resp = num1 + num2;
//                     cad1 = "La suma de "+num1+" y de "+num2+" es igual a: "+ resp;
//                     break;
//                 case 2: resp = num1 - num2;
//                     cad1 = "La resta de "+num1+" y de "+num2+" es igual a: "+ resp;
//                     break;
//                 case 3: resp = num1 * num2;
//                     cad1 = "El producto entre "+num1+" y "+num2+" es igual a: "+ resp;
//                     break;
//                 case 4: resp = num1 / num2;
//                     cad1 = "La division entre "+num1+" y "+num2+" es igual a: "+ resp;
//                     break;
//             }
//             Console.WriteLine(cad1);
//         }else{
//             Console.WriteLine("NO SE INGRESARON NUMEROS");
//         }
//     }else{
//         Console.WriteLine("OPERACION INVALIDA");
//     }
//     Console.WriteLine("------------------------------");
// foreach (char c in cad1)
// {
//     Console.WriteLine(c);
// }
// if(cad1.IndexOf("igual")!=-1){
//     Console.WriteLine("Se encotró la palabra \'igual\' en \'"+cad1+"\'");
// }else{
//     Console.WriteLine("No se encontró la palbra en la frase");
// }
// //codigo para contar la ocurrencias de una palabra en una frase
// // int contador = 0;
// // int posicion = cadena.IndexOf(palabraBuscada);

// // while (posicion != -1)
// // {
// //     contador++;
// //     posicion = cadena.IndexOf(palabraBuscada, posicion + 1);
// // }
// Console.WriteLine(cad1.ToLower());
// Console.WriteLine(cad1.ToUpper());

// Console.WriteLine("ingrese una frase (usar \',\')");
// string? cadena = Console.ReadLine();
// char delimitador =','; 
// if(cadena!=null){
//     string[] subcadenas = cadena.Split(delimitador);
//     foreach (string subcadena in subcadenas)
//     {
//         Console.WriteLine(subcadena);
//     }
// }

string? operacion = Console.ReadLine();
char operador = ' ';
string[] operadores;
float op1, op2, resultado = 0;
if(operacion != null){
    foreach(char l in operacion){
        if(l == '+' || l == '-' || l == '*' || l == '/'){
            operador = l;
        }
    }
    operadores = operacion.Split(operador);
    float.TryParse(operadores[0], out op1);
    float.TryParse(operadores[1], out op2);
    switch (operador)
    {
        case '+':
            resultado = op1 + op2;
            break;
        case '-':
            resultado = op1 - op2;
            break;
        case '*':
            resultado = op1 * op2;
            break;
        case '/':
            resultado = op1 / op2;
            break;
    }
    Console.WriteLine(operacion+" = "+resultado);
}
//FIN EJERCICIO 4