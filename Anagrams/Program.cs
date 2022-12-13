using System.Formats.Asn1;

int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = 0; j < mas.Length - i - 1; j++)
        {
            if (mas[j + 1] < mas[j])
            {
                temp = mas[j + 1];
                mas[j + 1] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

//Выводим на экран сообщение
Console.WriteLine("Введите первое слово: ");
//Считываем первое слово
string first_word = Console.ReadLine();
//Перевожу все буквы в первом слове в верхний регист
first_word = first_word.ToUpper();
//Выводим на экран сообщение
Console.WriteLine("Введите второе слово: ");
//Считываем первое слово
string second_word = Console.ReadLine();
//Перевожу все буквы во втором слове в верхний регист
second_word = second_word.ToUpper();
//Переводим первое слово в массив чисел
int[] first_word_mas = first_word.Select(x => (int)char.GetNumericValue(x)).ToArray();
//Переводим второе слово в массив чисел
int[] second_word_mas = second_word.ToUpper().Select(x => (int)char.GetNumericValue(x)).ToArray();
//Сортируем первый массив
int[] sorted_first = BubbleSort(first_word_mas);
//Сортируем второй массив
int[] sorted_second = BubbleSort(second_word_mas);
//Проверяем если слова не равны по количеству букв, то они не анаграммы
if (sorted_first.Length != sorted_second.Length)
{
    //Выводит NO
    Console.WriteLine("No");
    //Завершает программу
    return;
}
// Если слова равны по количеству букв
else
{
    //Перебираем массив отсортированных букв
    for (int i = 0; i < sorted_first.Length; i++)
    {
        // Если буквы с одинковым индексом  не равны 
        if (sorted_first[i] != sorted_second[i])
        {
            //Выводит NO
            Console.WriteLine("No");
            //Завершает программу
            return;
        }
    }
}
// Выводит YES
Console.WriteLine("YES");