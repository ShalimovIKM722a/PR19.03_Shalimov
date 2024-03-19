//Задачі на арифметичні та логічні оператори
void Task1_operator() {
//    Напишіть програму, яка перевіряє пароль користувача на відповідність
//    вимогам безпеки(наприклад, мінімальна довжина, наявність цифр та
//    спеціальних символів).Використовуйте логічні оператори для перевірки
//умов.


string password;
    Console.WriteLine("Enter password");
    password = Console.ReadLine();

    if (password != null && password.Length >= 8)
    {
        Console.WriteLine("Your password nice!");
    }
    else
    {
        Console.WriteLine("Minimum 8 symbols");
    }
}

void Task2_operator() {
//    Напишіть програму, яка перевіряє, чи є введене користувачем число
//простим.Використовуйте арифметичні операції для перевірки дільників
//числа.


while (true)
    {
        uint number;
        bool prime = false;
        Console.WriteLine("Enter number!");
        number = uint.Parse(Console.ReadLine());
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("Number is not prime");
            }
            else
            {
                prime = true;
            }
        }
        if (prime)
        {
            Console.WriteLine("Number is prime");
        }
    }
}

void Task3_operator() {
//    Напишіть програму, яка перевіряє, чи належить введене користувачем
//число заданому інтервалу.Використовуйте логічні оператори для перевірки
//умови належності числа до інтервалу.


int number;
    Console.WriteLine("Enter number");
    number = int.Parse(Console.ReadLine());
    int low, high;
    Console.WriteLine("Enter low border");
    low = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter hight border");
    high = int.Parse(Console.ReadLine());
    if (number >= low && number <= high)
    {
        Console.WriteLine("Number is in interval");
    }
    else
    {
        Console.WriteLine("Number is not in interval");
    }
}

void Task4_operator()
{
    //    Напишіть програму, яка перевіряє, чи може існувати трикутник з
    //введених користувачем довжин сторін.Використовуйте логічні оператори
    //для перевірки умови існування трикутника.

    int a, b, c;
    Console.WriteLine("Enter a sides ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter b sides ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter c sides ");
    c = int.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Such a triangle has a right to exist");
    }
    else
    {
        Console.WriteLine("Such a triangle is not has the right to exist");
    }
}


//Задачі на одновимірні та двовимірні масиви

void Task1_arrays()
{
    //    Напишіть програму, яка знаходить: суму всіх елементів у заданому
    //масиві.

    int[] a= { 5, 4, 8, 9, 7, 5, 7, 4, 9 };

    int sum = 0;

    for(int i = 0; i < a.Length; i++)
    {
        sum += a[i];
    }
    Console.WriteLine($"Cума елементів масиву{sum}");

}

void Task2_arrays()
{
//     Напишіть програму, яка знаходить середнє значення елементів у
//масиві.

    int[] a = { 5, 4, 8, 9, 7, 5, 7, 4, 9 };

    int sum = 0;

    for (int i = 0; i < a.Length; i++)
    {
        sum += a[i];
    }

    int midle = sum/a.Length;
    Console.WriteLine($"Cереднэ значення елементів масиву{sum}");

}

void Task3_arrays()
{
    //    Напишіть програму, яка шукає всі пари елементів у масиві, сума яких
    //дорівнює заданому числу.

    int[] a = { 5, 4, 8, 9, 7, 5, 7, 4, 9 };
    int sum ;
    Console.WriteLine("Enter number");
    sum = int.Parse( Console.ReadLine() );
    bool check=false;

    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
        {
            if (a[i] + a[j] == sum)
            {
                Console.WriteLine($"This amount will be obtained if you add{i} and {j} елементи масиву");
                check = true;
            }
        }
    }
    if (!check)
    {
        Console.WriteLine("The amount will not work");
    }

}
