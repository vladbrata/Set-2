// Calculati suma si produsul numerelor de la 1 la n. 

Console.Write("Cate numere sunt in sirul de numere? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] seq = GetSeq(n);
PrintSeq(seq);

int product = GetProduct(seq);
int sum = GetSum(seq);


Console.WriteLine($"\nSuma numerelor din secventa este: {sum}");
Console.WriteLine($"Produsul numerelor din secventa este: {product}");

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
static int GetProduct(int[] arr)
{
    int product = 1;

    for (int i = 0; i < arr.Length; i++) {
        product *= arr[i];
    }
    return product;
}

static int GetSum(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++) {
        sum += arr[i];
    }
    return sum;
}