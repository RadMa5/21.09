
string[] lessThan(int maxl, string[] array)
{
    string newStr = String.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < maxl) { newStr = newStr + array[i] + ";"; }//";" is a separator
    }
    string[] newArr = newStr.Split(';');
    return newArr;
}
void arrayPrint(string[] array)
{
    foreach (string word in array) { Console.Write(word + " "); }
}
string[] arr = { "Hello", "World", "he", "llo", "Hello World", "h" };
arrayPrint(lessThan(3, arr));