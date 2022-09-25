// Задача 7.
// Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие цифру 3.
// Вывести в консоль новый массив и количество удалённых элементов.


int[] array= new int[100];
int[] arrayNo3= new int[100];

int[] makeRandomArray1_100()
{
    int[] array= new int[100];
    Random random = new Random();

    for (int i=0;i<100;i++)
    {
        array[i] = random.Next(1,101);
    }
    return array;
}

void displayArray(int[] array, int len)
{
    for (int i=0;i<len;i++)
    {
        Console.Write("[{0:000}] ", i+1);
        Console.Write("{0:000}\t",array[i]);
        //Console.Write("["+(i+1)+"]  "+array[i]+"\t");
        if ((i+1)%10 == 0)
        {
            Console.WriteLine();
        }
    }
}

int getLen(int[] array)
{
    int result = 0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]>0)
        {
            result++;
        }
    }

    return result;
}

int isNumber3Absent(int value)
{
   int result = 0;

   if (
    (value%10 == 3)||
    (value/10%10 == 3) ||
    (value/100%10 == 3)
    )
    {
        result = 0;
    }
    else
    {
        result = 1;
    }
   return result;
}

int[] deleteNumber3(int[] array)
{
    int[] arrayResult= new int[100];
    for (int i=0, j=0;i<array.Length;i++)
    {
        if (isNumber3Absent(array[i])>0)
        {
            arrayResult[j] = array[i];
            j++;
        }
    }

    return arrayResult;
}

array = makeRandomArray1_100();
displayArray(array,100);

Console.WriteLine();

arrayNo3 = deleteNumber3(array);
int newLen = getLen(arrayNo3);
displayArray(arrayNo3,newLen);

Console.WriteLine("\n" + newLen);