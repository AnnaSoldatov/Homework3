// void Palindrome(){
//     Console.WriteLine("Enter the number from 10 000 to 99 999:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if(num < 10000 || num > 99999) Console.WriteLine("Enter the correct number");
//     else{
//         string num1 = Convert.ToString(num);
//             if (num1[0] == num1[4] && num1[1] == num1[3]) Console.WriteLine("This is a palindrome");
//             else{
//             Console.WriteLine("This is not a palindrome");
//             }
//     }    
// }

// Palindrome();



// double S(int x1, int y1, int z1, int x2, int y2, int z2){
//     int x = (x2 - x1)*(x2 - x1);
//     int y = (y2 - y1)*(y2 - y1);
//     int z = (z2 - z1)*(z2 - z1);
//     double result = Math.Sqrt(x + y + z);
//     return result;
// }

// Console.Write("Enter the first x: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the first y: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the first z: ");
// int c1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second x: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second y: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second z: ");
// int c2 = Convert.ToInt32(Console.ReadLine());

// double prod = S(a1, b1, c1, a2, b2, c2);
// Console.WriteLine("The result is " + prod);


void Coub(int a){
    int i = 1;
    while(i<=a){
        Console.Write(i*i*i + " ");
        i++;
    }
}

Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
if(num<=0) Console.WriteLine("Enter the correct number: ");
else Coub(num);