#Процентная ставка по вкладу составляет P процентов годовых, которые прибавляются к сумме вклада. Вклад составляет X рублей Y копеек. Определите размер вклада через год.
#Программа получает на вход целые числа P, X, Y и должна вывести два числа: величину вклада через год в рублях и копейках. Дробная часть копеек отбрасывается.

print(*(lambda p, x, y: [(int((100 * x + y) * (100 + p) / 100)) // 100, (int((100 * x + y) * (100 + p) / 100)) % 100])(*[int(input()) for i in range(3)]))