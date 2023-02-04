// See https://aka.ms/new-console-template for more information
void NumberToConsole(int N){

  if (N > 1)
    Console.Write($"{N}, ");
  else
    Console.WriteLine($"{N}");

  if (N > 1)
    NumberToConsole(N-1);

}




Console.Write("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

NumberToConsole(N);
