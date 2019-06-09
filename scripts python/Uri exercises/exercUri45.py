valores = input().split(' ')
valores = list(map(float, valores))

a, b, c = sorted(valores)[::-1]

batata = True

if (a >= b + c):
    print('NAO FORMA TRIANGULO')
    batata = False

if (a**2 == (b**2) + (c**2) and batata):
    print('TRIANGULO RETANGULO')

if (a**2 > (b**2) + (c**2) and batata):
    print('TRIANGULO OBTUSANGULO')

if (a**2 < (b**2) + (c**2) and batata):
    print('TRIANGULO ACUTANGULO')

if (a == b and (b == c) and batata):
    print('TRIANGULO EQUILATERO')

if (a == b or b == c) and not (a == b and b == c) and batata:
    print('TRIANGULO ISOSCELES')
