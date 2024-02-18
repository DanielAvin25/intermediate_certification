string[] Array = new string[] { "Hello", "2", "world", ":-)" };
int count = 0;
foreach (string str in Array)
{
    if (str.Length <= 3)
    {
        count++;
    }
}
