#Факториалом числа n называется произведение 1 × 2 × ... × n. Обозначение: n!.
#По данному натуральному n вычислите значение n!. Пользоваться математической библиотекой math в этой задаче запрещено.

from functools import reduce; print(reduce(lambda x, y:x * y, [i for i in range(1, int(input()) + 1)]))