// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.

Console.Write("Cate numere sunt in sirul de numere? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] seq = GetSeq(n);
PrintSeq(seq);

int cnt = GetEqualElements(seq);
Console.WriteLine($"\n{cnt} elemente din secventa sunt egale cu pozitia pe care apar");

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

static int GetEqualElements(int[] arr)
{
    int cnt = 0;

    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == i) {
            cnt++;
        }
    }
    return cnt;
}