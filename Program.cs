
void lessThan(int maxl, string[] array)
{
    string newStr = String.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < maxl) { newStr = newStr + array[i] + ";"; }//";;" is a separator
    }
    string[] newArr = newStr.Split(';');
    foreach (string word in newArr) { Console.Write(word + " "); }
}
string[] arr = { "Hello", "World", "he", "llo", "Hello World", "h" };
lessThan(4, arr);