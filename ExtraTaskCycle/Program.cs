// Расстояние между максимумами

// Элемент последовательности называется локальным максимумом, если он строго больше 
// предыдущего и последующего элемента последовательности. Первый и последний элемент
// последовательности не являются локальными максимумами.

// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется 
// определить наименьшее расстояние между двумя локальными максимумами последовательности
// натуральных чисел, завершающейся числом 0.
// 1 2 1 1 2 1 2 1 0 --> 2
// 1 2 3 0	--> 0

int [] array = new int [100];
int i = 0;
int n;

do
{
    n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
    i++;
}
while (n != 0);


int j = 1;
int [] arr_min = new int [100];
int e = 0;

while (j <= 98)
{
    
    if (array[j] > array[j+1] && array[j] > array[j-1])
    {
        arr_min[e] = j;
        e++;
    }
    j++;
}

int count = 0;
int [] diff = new int [50];
do
{
    diff[count] = Math.Abs(arr_min[count] - arr_min[count + 1]) - 1; 
    count++;
}
while (arr_min[count] != 0);

int min_diff = 0;
for (int y = 0; y < 48; y++)
{
    if (diff[y] < diff[y+1])
        min_diff = diff[y];
}

Console.WriteLine("Min difference: " + min_diff);

