int min = 0;
int max = 101;
int num = (max - min) / 2;
string answer; //ответ пользователя

//Рандом и массив со случайными ответами
Random rnd = new Random();
string[] answers = new string[10] {"Возможно, это ", "Наверное, это ", "Я знаю! Это ", "Предположим, что это ", "Думаю, это ", "Определенно, ", "Хм.. Может быть, ", "Как насчет ", "Допустим, ", "Наверняка это "};

bool checkAnswer = false; //проверка на правильность ответа

Console.WriteLine("Добро пожаловать в игру! Я угадаю загаданное тобой число");
Console.WriteLine($"Напиши '+', если мое число больше твоего, '-', если меньше, и '=', если я угадал: {num}?");

while (checkAnswer != true)
{
    answer = Console.ReadLine();
    
    switch (answer)
    {
        case "+":
            if (num - min == 1) //проверка на максимальное количество делений
            {
                Console.WriteLine($"Хм.. Вы не ошиблись? Это не число {num}?");
                break;
            }
            max = num;
            num = num - (max - min) / 2;
            Console.WriteLine($"{answers[rnd.Next(answers.Length)]}{num}?");
            break;
        case "-":
            if (max - num == 1)
            {
                Console.WriteLine($"Хм.. Вы не ошиблись? Это не число {num}?");
                break;
            }
            min = num;
            num = num + (max - min) / 2;
            Console.WriteLine($"{answers[rnd.Next(answers.Length)]}{num}?");
            break;
        case "=":
            checkAnswer = true;
            Console.WriteLine($"Ура! Я угадал твое число {num}!");
            break;
        default:
            Console.WriteLine("Вы ввели неверный символ, попробуйте еще раз");
            break;
    }
}