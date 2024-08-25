// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Write a program that calculates N!/K! for given N and K (1<K<N)

Console.Write("Enter the value for N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value for K: ");
int k = Convert.ToInt32(Console.ReadLine());

long nFactorial = 1;
int kFactorial = 1;

double result = 0;

int sumZeros = 0;

for(int i = n; i > 0; i--)
{
    
    nFactorial *= i;
    sumZeros += n / (int)Math.Pow(5, i);
    
}

Console.WriteLine($"{n}! is {nFactorial}, and ends with {sumZeros} zero(s)");
// for(int j = k; j > 0; j--)
// {
    
//     kFactorial *= j;

    
// }
// result = nFactorial / kFactorial;

// Console.WriteLine($"N! = {nFactorial}");
// Console.WriteLine($"K! = {kFactorial}");
// Console.WriteLine($"N!/K! = {result}");

// Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N)

// int n_k = n - k;

// for(int i = n; i > 0; i--)
// {
//     nFactorial *= i;
// }
// for(int j = k; j > 0; j--)
// {   
//     kFactorial *= j;
    
// }

// int n_kFactorial = 1;

// do
// {
//     n_kFactorial *= n_k;
//     n_k--;

// } while(n_k > 0);


//result = nFactorial / kFactorial;
// result = (nFactorial * kFactorial)/n_kFactorial;

// Console.WriteLine($"N! = {nFactorial}");
// Console.WriteLine($"K! = {kFactorial}");
// Console.WriteLine($"(N-K! = {n_kFactorial}");
// Console.WriteLine($"N!*K!/(N-K)! = {result}");


// In combinatorics, the Catalan numbers are calculated by the following => formula: Cn = ((2n)!/(n + 1)! n!)

int twoN = 2 * n;
int nPlusOne = n + 1;

long twoNFactorial = 1;
int nPlusOneFactorial = 1;

// do
// {
//     twoNFactorial *= twoN;
//     twoN--;

// }while(twoN > 0);

// do
// {
//     nPlusOneFactorial *= nPlusOne;
//     nPlusOne--;

// }while(nPlusOne > 0);


// result = twoNFactorial / nPlusOneFactorial;

// Console.WriteLine($"(2n)! = {twoNFactorial}");
// Console.WriteLine($"(n + 1)! = {nPlusOneFactorial}");

// Console.WriteLine($"(2n)!/(n + 1)! = {result}");