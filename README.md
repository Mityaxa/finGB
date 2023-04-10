# Описание решения
 Можно было предложить реализацию, при которой не нужно запрашивать у пользователя размер массива, а сразу парсить строку вида: '["hello", "2", "world", ":-)"]', однако такая реализация неудобна с точки зрения удобства ввода. Я решил усовершенствовать алгоритм таким образом, чтобы ввод исходных данных с клавиатуры осуществлялся в два этапа:

1. Программа сначала запрашивает у пользователя размер массива и заполняет массив строк с помощью цикла for и метода Console.ReadLine().
2. Затем программа создает новый массив строк newArr и перебирает все элементы из первоначального массива arr, добавляя элементы, длина которых меньше или равна 3, в новый массив. 
Новый массив выводится на экран с помощью цикла for и метода Console.WriteLine().