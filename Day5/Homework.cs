int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] digitsToCount = new int[10];
foreach (char c in letters)
{
    int digit = c - '0';
    digitsToCount[digit]++;
    Console.WriteLine(digitsToCount[digit]);
}

for (int i = 0; i < digitsToCount.Length; i++)
{
    Console.WriteLine($"{i} => {digitsToCount[i]}");
}