// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.

// Console.Write("Cate numere sunt in sirul de numere? ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] seq = GetSeq(n);
int[] seq = {5, 4};
PrintSeq(seq);

if (IsMonotone(seq)) {
    Console.WriteLine("\nSirul de numere este monoton");
}
else {
    Console.WriteLine("\nSirul de numere nu este monoton");
}

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
// TODO De verificat functionalitate
static bool IsMonotone(int[] arr)
{
    bool isMonotone = false;
    int len = arr.Length;
    
    switch (len) {
        case <= 2:
            return true;
        case 3:
            if (arr[0] <= arr[1] && arr[2] >= arr[0]) {
                return true;
            }
            return false;
        case > 3:
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= arr[i + 1]) {
                    return true;
                }
            }
            return false;
    }

    if (arr.Length == 1 || arr.Length == 2) {
        return true;
    }
    // cazurile pentru crescatoare
    else if (arr.Length == 3)
    {
        if (arr[0] <= arr[1] && arr[2] >= arr[0]) {
            return true;
        }
        else {
            return false;
        }
    }
    else
    {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] >= arr[i + 1]) {
                return true;
            }
        }
    }
    // cazurile pentru descrescatoare
    if (arr.Length == 3)
    {
        if (arr[0] >= arr[1] && arr[2] <= arr[0]) {
            return true;
        }
        else {
            return false;
        }
    }
    else
    {
        for (int i = arr.Length - 1; i >= 0; i--) {
            if (arr[i] <= arr[i - 1]) {
                return true;
            }
        }
    }
    return isMonotone;
}