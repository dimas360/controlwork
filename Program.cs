using static System.Console;
Clear();

string[] array_in = new string[5] {"123", "23", "hello", "world", "res"};
string[] array_out = new string[array_in.Length];
void SecondArrayWithIF(string[] array_in, string[] array_out)
{
    int count = 0;
    for (int i = 0; i < array_in.Length; i++)
    {
    if(array_in[i].Length <= 3)
        {
        array_out[count] = array_in[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array_in, array_out);
PrintArray(array_out);