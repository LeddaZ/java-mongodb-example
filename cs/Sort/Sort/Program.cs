using System.Diagnostics;

Console.Title = "Selection sort";
Random rnd = new Random();
Stopwatch timer = new Stopwatch();
long nElementi = 999999999;
int[] array = new int[nElementi];
int min = int.MaxValue;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1000);
}
//Console.WriteLine("Array: " + string.Join(", ", array));
long startTime = Stopwatch.GetTimestamp();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
}
TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
Console.WriteLine("Minimo: " + min);
Console.WriteLine("Tempo impiegato: " + elapsedTime + " con " + array.Length + " elementi");
Console.ReadKey();
