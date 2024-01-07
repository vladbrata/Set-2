// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.

Console.Write("Cate numere sunt in sirul de numere? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] seq = GetSeq(n);
PrintSeq(seq);

bool isSorted = IsSorted(seq);
PrintIsSorted(isSorted);

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
static bool IsSorted(int[] arr)
{
    if (arr.Length == 2) {
        if (arr[0] < arr[1]) {
            return true;
        }
        else {
            return false;
        }
    }
    else if (arr.Length == 3) {
        if (arr[0] < arr[1] && arr[2] > arr[0]) {
            return true;
        }
        else {
            return false;
        }
    } 
    else {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > arr[i + 1]) {
                return false;
            }
        }
    }
    return true;
}

static void PrintIsSorted(bool isSorted)
{
    if (isSorted)
    {
        Console.WriteLine("\nSecventa de numere este sortata");
    }
    else
    {
        Console.WriteLine("\nSecventa de numere nu este sortata");
    }
}