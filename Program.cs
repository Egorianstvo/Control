#nullable disable

string [] Words = new string [NumConsole("Ente size")];
EnterString(Words);
System.Console.WriteLine("Вы ввели");
Print(Words);
int Size = CountString(Words);
string [] result = new string [Size];
StringThree(Words);

System.Console.WriteLine();

System.Console.WriteLine("Подходит");
Print(result);


int NumConsole(string NumberName)                        //Просим Пользователя ввести число
{
    System.Console.WriteLine($"{NumberName}");
    int Number = int.Parse(Console.ReadLine());
    return Number;
}

void EnterString(string [] Name)         //Заполняем массив
{
    for (int i = 0; i < Name.Length; i++)
    {
        System.Console.WriteLine("Enter Word");
        Name[i] = Console.ReadLine();
    }
    return;
}

void Print(string [] Masiv)  //  Метод вывод в консоль одномерного массива
{
    for (int count = 0; count < Masiv.Length; count++)
    {
        System.Console.Write(Masiv[count] + " ");
    }
    return;
}


int CountString (string [] array) // Метод для подсчета количества элементов в результирующем массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
                count++;
        }    
    }
    return count;
}

string [] StringThree (string [] array) //  Метод для записи элементов длиной больше 3-х символов в новый массив
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
            {
                result[k] = array[i];
                k++;
            }    
        }    
    }
    return result;
}