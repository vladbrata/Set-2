// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.

Console.WriteLine("Cate numere sunt in sirul de numere?");
int n = Convert.ToInt32(Console.ReadLine());

int[] seq = GetSequence(n);
int numerePare = GetPairNumbers(seq);

Console.WriteLine("Numerele din sir: ");
foreach (int number in seq) {
    Console.Write(number + " ");
}

Console.WriteLine($"\nIn sirul de numere dat sunt {numerePare} numere pare!");

static int[] GetSequence(int n)
{
    Random num = new Random();
    int[] nums = new int[n];

    for (int i = 0; i < n; i++) {
        nums[i] = num.Next(1, 9);
    }
    return nums;
}
static int GetPairNumbers(int[] arr)
{
    int numerePare = 0;

    foreach (int number in arr) {
        if (number % 2 == 0)
            numerePare++;
    }
    return numerePare;
}