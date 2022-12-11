using static System.Console;
Clear();

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] array_in, int n) {
    string[] array_out = new string[CountLessThan(array_in, n)];

    for(int i = 0, j = 0; i < array_in.Length; i++) {
        if(array_in[i].Length <= n) {
            array_out[j] = array_in[i];
            j++;
        }
    }

    return array_out;
}
int CountLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}
string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}