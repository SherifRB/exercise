

int min = 1;
int max = 100;
int num = (max - min) / 2;
string answer; //ответ пользователя

bool checkAnswer = false; //проверка на правильность ответа

Console.WriteLine("Добро пожаловать в игру! Я угадаю загаданное тобой число");
Console.WriteLine($"Напиши '+', если мое число больше твоего, '-', если меньше, и '=', если я угадал: {num}?");

Console.WriteLine($"Test {num}"); //test
//test

while (checkAnswer != true)
{
    answer = Console.ReadLine();
    switch (answer)
    {
        case "+":
            max = num;
            num = num - (max - min) / 2;
            Console.WriteLine($"Наверное, это {num}?");
            Console.WriteLine($"Test {num}"); //test
            break;
        case "-":
            min = num;
            num = num + (max - min) / 2;
            Console.WriteLine($"Возможно, это {num}?");
            Console.WriteLine($"Test {num}"); //test
            break;
        case "=":
            checkAnswer = true;
            Console.WriteLine($"Ура! Я угадал твое число {num}!");
            Console.WriteLine($"Test {num}"); //test
            break;
        default:
            Console.WriteLine("Вы ввели неверный символ, попробуйте еще раз");
            Console.WriteLine($"Test {num}"); //test
            break;
    }
}


//Console.WriteLine(num); //test
