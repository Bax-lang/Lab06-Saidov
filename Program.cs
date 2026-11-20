// // // // // // // // for (int i = 10; i >= 1; i--) {
// // // // // // // //     Console.WriteLine(i);
// // // // // // // // }

// // // // // // // Задание 1.2
// // // // // // // for (int i = 2; i <= 50; i += 2) {
// // // // // // //     Console.WriteLine(i);
// // // // // // // }

// // // // // // // Задание 2
// // // // // // int sum3 = 0;
// // // // // // int count7 = 0;

// // // // // // for (int i = 1; i <= 100; i++) {
// // // // // //     if (i % 3 == 0) {
// // // // // //         sum3 += i;
// // // // // //     }
// // // // // //     if (i % 7 == 0) {
// // // // // //         count7++;
// // // // // //     }
// // // // // // }

// // // // // // Console.WriteLine($"Сумма кратных 3: {sum3}");
// // // // // // Console.WriteLine($"Количество кратных 7: {count7}");

// // // // // // Задание 3
// // // // // int number = Convert.ToInt32(Console.ReadLine());
// // // // // int pos = 0;
// // // // // int neg = 0;

// // // // // while (number != 0) {
// // // // //     if (number > 0) {
// // // // //         pos++;
// // // // //     }
// // // // //     else if (number < 0) {
// // // // //         neg++;
// // // // //     }
// // // // //     number = Convert.ToInt32(Console.ReadLine());
// // // // // }

// // // // // Console.WriteLine($"Положительных: {pos}");
// // // // // Console.WriteLine($"Отрицательных: {neg}");

// // // // // Задание 4
// // // // bool access = false;

// // // // for (int i = 1; i <= 3; i++) {
// // // //     Console.Write("Введите пароль: ");
// // // //     string password = Console.ReadLine();
// // // //     if (password == "qwerty") {
// // // //         Console.WriteLine("Доступ разрешён");
// // // //         access = true;
// // // //         break;
// // // //     }
// // // // }

// // // // if (!access) {
// // // //     Console.WriteLine("Доступ заблокирован");
// // // // }

// // // // Задание 5
// // // Console.Write("Введите число n (1-9): ");
// // // int n = Convert.ToInt32(Console.ReadLine());

// // // for (int i = 1; i <= 10; i++) {
// // //     Console.WriteLine($"{n} x {i} = {n * i}");
// // // }

// // // Задание 6
// // for (int i = 1; i <= 30; i++) {
// //     if (i % 3 == 0) {
// //         continue;
// //     }
// //     if (i % 10 == 0 && i > 20) {
// //         break;
// //     }
// //     Console.WriteLine(i);
// // }

// // Итоговая задача
// int secret = 42;
// bool win = false;

// for (int i = 1; i <= 5; i++) {
//     Console.Write($"Попытка {i}. Введите число: ");
//     int guess = Convert.ToInt32(Console.ReadLine());

//     if (guess == secret) {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         win = true;
//         break;
//     }
//     else if (guess < secret) {
//         Console.WriteLine("Больше");
//     }
//     else {
//         Console.WriteLine("Меньше");
//     }
// }

// if (!win) {
//     Console.WriteLine("Вы проиграли, число было 42");
// }

// Дополнительное задание
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = 0;
int countDigits = 0;

while (num > 0) {
    sumDigits += num % 10;
    countDigits++;
    num = num / 10;
}

Console.WriteLine($"Сумма цифр: {sumDigits}");
Console.WriteLine($"Количество цифр: {countDigits}");
