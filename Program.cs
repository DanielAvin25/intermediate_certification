string[] Array = new string[] { "Hello", "2", "world", ":-)" };
int count = 0;
foreach (string str in Array)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] NewArray = new string[count];
int index = 0;
foreach (string str in Array)
{
    if (str.Length <= 3)
    {
        NewArray[index] = str;
        index++;
    }
}