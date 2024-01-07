// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.

Console.Write("Cate numere sunt in sirul de numere? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] seq = GetSeq(n);
PrintSeq(seq);

Console.Write("\nIntroduce-ti un numar a: ");
int a = Convert.ToInt32(Console.ReadLine());
int pos = GetElementPosition(seq, a);
PrintPosition(a, pos);

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
static int GetElementPosition(int[] arr, int n)
{
    int index = 0;

    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == n)
        {
            index = arr[i];
            return index;
        }
    }
    return -1;
}
static void PrintPosition(int num, int pos)
{
    if (pos != -1) {
        Console.WriteLine($"Numarul {num} se afla pe pozitia {pos}");
    }
    else {
        Console.WriteLine($"Numarul {num} nu exista in secventa de numere");
    }
}