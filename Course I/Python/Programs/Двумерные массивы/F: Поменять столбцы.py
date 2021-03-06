# F: Поменять столбцы
#
# Дан двумерный массив и два числа: i и j. Поменяйте в массиве столбцы с номерами i и j и выведите результат.
#
# Программа получает на вход размеры массива n и m, затем элементы массива, затем числа i и j.
#
# Решение оформите в виде функции SwapColumns (A, i, j).


def SwapColumns(A, i, j):
    """
    Меняет стобцы местами
    :param A: матрица
    :param i: 1 столбец
    :param j: 2 столбец
    :return:
    """

    for w in range(len(A)):
        A[w][i], A[w][j] = A[w][j], A[w][i]

    return A


data = [[11, 12, 13, 14],
        [21, 22, 23, 24],
        [31, 32, 33, 34]]

data = SwapColumns(data, 0, 1)

for i in data:
    print(" ".join(map(str, i)))
