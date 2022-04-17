// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
//Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
//входные данные:
//data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
//info = {2, 3, 3, 1 }
//выходные данные:
//1, 7, 0, 1



void FillArray(int[] array, int minValue, int maxValue)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(minValue, maxValue);
	}

}

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };

int[] info = {2, 3, 3, 1 };

List<int> namberList = new List<int>();
int index = 0;
for (int i = 0; i < info.Length; i++)
{
	int namber = 0;
	for (int j = 0; j < info[i]; j++)
	{
		namber += data[index] * Convert.ToInt32(Math.Pow(2, info[i] - j -1));
		index++;
	}
	namberList.Add(namber);
}

foreach (int namber in namberList)
{
	Console.Write($"{namber}, ");
}


