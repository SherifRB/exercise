int min = 0;
int max = 101;
int num = (max - min) / 2;
string answer; //ответ пользователя

bool checkAnswer = false; //проверка на правильность ответа

Console.WriteLine("Добро пожаловать в игру! Я угадаю загаданное тобой число");
Console.WriteLine($"Напиши '+', если мое число больше твоего, '-', если меньше, и '=', если я угадал: {num}?");

while (checkAnswer != true)
{
    answer = Console.ReadLine();
    switch (answer)
    {
        case "+":
            max = num;
            num = num - (max - min) / 2;
            Console.WriteLine($"Наверное, это {num}?");
            break;
        case "-":
            min = num;
            num = num + (max - min) / 2;
            Console.WriteLine($"Возможно, это {num}?");
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