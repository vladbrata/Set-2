// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.

Console.Write("Cate numere sunt in sirul de numere? ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] seq = GetSeq(n);
 PrintSeq(seq);

 int negativeNums = GetNegativeNums(seq);
 int positiveNums = GetPositiveNums(seq);

 Console.WriteLine($"\nIn sirul de numere sunt {negativeNums} numere negative");
 Console.WriteLine($"In sirul de numere sunt {positiveNums} numere positive");

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

static int GetNegativeNums(int[] arr)
{
    int len = arr.Length;
    int cnt = 0;

    for (int i = 0; i < len; i++) {
        if (arr[i] < 0) {
            cnt++;
        }
    }
    return cnt;
}

static int GetPositiveNums(int[] arr)
{
    int len = arr.Length;
    int cnt = 0;

    for (int i = 0; i < len; i++) {
        if (arr[i] >= 0) {
            cnt++;
        }
    }
    return cnt;
}