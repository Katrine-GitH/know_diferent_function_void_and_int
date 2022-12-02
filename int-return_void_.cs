void FillArray (int[] collection)
// заполнили рандомными числами индексы от 0 до 10
{
    int length = collection.Length;
    int index =0;
    while (index<length)
    {
        collection [index] = new Random().Next(1,10);
        //index=index+1
        index++;
    }

}

void PrintArray(int [] col)
// Зафиксировали индексы и запомнили за ними числа массива
{
    int count= col.Length;
    int position=0;
    while (position<count)
    {
        Console.WriteLine ($"col[{position}] = {col[position]}");
        position++;
    }
}
int IndexOf(int[]collection,int find)
// Запомнили первый индекс искомого числа
{
    int count =collection.Length;
    int index =0;
    int position=-1;
    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
//array[4] = 4;
//array [6] = 4;

Console.WriteLine("My array");
PrintArray(array);
Console.WriteLine();

int value = 4;
int pos = IndexOf(array,value);
Console.WriteLine($"pos: {pos} for value: {value}");