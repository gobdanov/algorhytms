main();
void main()
{
    Console.WriteLine("введите длину массива: ");
    int lenn = Convert.ToInt32(Console.ReadLine());
    int[] massive = new int[lenn];
    for (int i = 0; i <= lenn - 1; i++)
    {
        Console.WriteLine($"введите {i + 1}-ое число массива осталось {lenn - i}");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("массив:");
    Console.Write("[");
    for (int i = 0; i <= massive.Length - 1; i++)
    {
        if (i == massive.Length - 1)
        {

            Console.Write($"{massive[i]}");
        }
        else
            Console.Write($"{massive[i]},");
    }
    Console.WriteLine("]");
    //методы сортировки
    Console.WriteLine("метод findsmth");
    int a = algorthytms.perebor_findsmth(massive, 12);
    Console.WriteLine(a);
    int[] b = algorthytms.sort(massive);
    foreach (int ab in b)
    {
        Console.Write(ab);
    }
}
static class algorthytms
{
    public static int[] sort(int[] list)
    {
        int temp;
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == list.Length-1)
            {
                break;
            }
            else {
                if (list[i] > list[i + 1])
                {
                    temp = list[i];
                    list[i + 1] = list[i];
                    list[i] = temp;
                    continue;
                }
                else continue;
            }
            return list;
        }
        return [];
    }

    public static int perebor_findsmth(int[] list, int finder)
    {
        for (int i = 0; i < list.Length; i++) 
        {
            if (list[i] == finder)
            {
                return i;
            }
        }
        return -1;
    }
    public static void binary_findsmth(int[] list, int finder)
    {
        
    }
}
