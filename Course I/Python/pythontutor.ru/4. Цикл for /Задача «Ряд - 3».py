#Даны два целых числа A и В, A>B
#. Выведите все нечётные числа от A до B включительно, в порядке убывания. В этой задаче можно обойтись без инструкции if.

print(*(lambda x, y: [i for i in range(x - (x + 1) % 2, y - y % 2, -2)])(int(input()), int(input())))