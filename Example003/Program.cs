/*int[] array = {17, 2, 34, 42, 5, 5, 6, 78};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
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

int[] array = new int[10]; // new int[10] - создай новый массив с 10-ю элементами

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 45);
Console.WriteLine(pos);
