// написать программу которая из имеющегося массива строк 
// формирует массив из строк длина которых меньше либо равна 3 символа. 
// При решении не рекомендуется использовать коллекциями, 
// лучше обойтись исключительно массивами.

string[] arrayString = new string[5] {"-2", "hello", "world", "res", ":-)"};
string[] arrayStr = new string[arrayString.Length];
void SecondArrayWithIF(string[] arrayString, string[] arrayStr)
{
    int count = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
    if(arrayString[i].Length <= 3)
        {
        arrayStr[count] = arrayString[i];
        count++;
        }
    }
}
void PrintArray (string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i] + ", ");     
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
SecondArrayWithIF(arrayString, arrayStr);
PrintArray(arrayStr);