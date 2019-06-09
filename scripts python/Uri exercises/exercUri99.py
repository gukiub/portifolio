n = int(input())
x, y = map(int, input().split(' '))

soma = 0

while x < y:
    if x % 2 != 0 and y % 2 != 0:
        x, y = map(int, input().split(' '))
        soma = x + y
        print(soma)