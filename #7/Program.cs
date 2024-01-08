// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.

Console.Write("Cate numere sunt in sirul de numere? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] seq = GetSeq(n);
PrintSeq(seq);

int largest = seq[0];
int smallest = seq[0];
for (int i = 0; i < n; i++)
{
    if (seq[i] > largest) {
        largest = seq[i];
    }
    if (seq[i] < smallest) {
        smallest = seq[i];
    }
}
Console.WriteLine($"\nCea mai mica valoare din secventa de numere este: {smallest}");
Console.WriteLine($"Cea mai mare valoare din secventa de numere este: {largest}");

static int[] GetSeq(int n)
{
    Random num = new Random();
    int[] nums = new int[n];
    
    for (int i = 0; i < n; i++) {
        nums[i] = num.Next(-9, 9);
    }
    return nums;
}
static void PrintSeq(int[] arr)
{
    Console.WriteLine("Numere din sir: ");

    foreach (int number in arr) {
        Console.Write(number + " ");
    }
}