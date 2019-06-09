valor1 = int(input())
valor2 = int(input())
cambio = valor1

if valor1 > valor2:
    valor1 = valor2
    valor2 = cambio

while valor1 < valor2:
    valor1 += 1
    if valor1 % 5 == 2 or valor1 % 5 == 3 and valor1 != valor2:
        print(valor1)