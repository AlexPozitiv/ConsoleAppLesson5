using System;

string MaxOfTwo(string a, string b)
{
    int _a = Int32.Parse(a);
    int _b = Int32.Parse(b);
    int z = Math.Max(_a, _b);
    return ((z).ToString());
}
// static string MaxOfTwo(string a, string b, string c)
// {  // parametry referencyjne
//     int _a = Int32.Parse(a);
//     int _b = Int32.Parse(b);
//     int _c = Int32.Parse(c);
//     if(_a > _b && _a > _c)
//         return("a is max")
//     return (_b);
// }
string MinOfTwo(string a, string b)
{  // parametry referencyjne
    int _a = Int32.Parse(a);
    int _b = Int32.Parse(b);
    int z = Math.Min(_a, _b);
    return ((z).ToString());
}
bool TryOfSumIfOdd(string _a, string _b, out int sum)
{
    sum = Int32.Parse(_a) + Int32.Parse(_b);
    if (sum % 2 == 0)
        return true;
    else
        return false;
}
//  int TryOfSumIfOdd(int _a, int _b,  out int sum)
//     {
//         sum = Int32.Parse(_a) + Int32.Parse(_b);
//         if (sum % 2 == 0)
//             return true;
//         else
//             return false;
//     }

// static int TryOfSumIfOdd(string a, string b, string c, out int sum)
// {
//     sum = Int32.Parse(a) + Int32.Parse(b) + Int32.Parse(c);
//     if (sum % 2 == 0)
//         return 1;
//     else
//         return false;
// }


Console.WriteLine("MaxOfTwo");
Console.WriteLine("write first number");
string first = new string(Console.ReadLine());
Console.WriteLine("write second number");
string second = new string(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("first = {0}; second = {1}", first, second);


Console.WriteLine("MaxOfTwo = {0}", MaxOfTwo(first, second));
Console.WriteLine("MinOfTwo = {0}", MinOfTwo(first, second));

// int sum = 0;
bool resultt = TryOfSumIfOdd(first, second, out int sum);
Console.WriteLine("TryOfSumiSOdd {0} + {1}  = {2}", first, second, resultt);

//TryOfSumIfOdd mm = new TryOfSumIfOdd();









// Console.WriteLine("MaxOfTwo");
// Console.WriteLine("write first number");
// string first = new string(Console.ReadLine());
// Console.WriteLine("write second number");
// string second = new string(Console.ReadLine());
// Console.WriteLine("first = {0}; second = {1}", first, second);

// Console.WriteLine("MaxOfTwo = {0}", MaxOfTwo(first, second));
// Console.WriteLine("MinOfTwo = {0}", MinOfTwo(first, second));

// //bool resul = TryOfSumIfOdd(first,second, out int sum);
// int sum = 0;
// Console.WriteLine("TryOfSumiSOdd = {0}", TryOfSumIfOdd(first, second, out sum));

// Console.WriteLine("MaxOfTwo(({0}),"{1};") = {2}", first , second , MaxOfTwo(first,second));
// Console.ReadKey();