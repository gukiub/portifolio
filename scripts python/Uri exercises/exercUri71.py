valor1 = int(input())
valor2 = int(input())

soma = 0

if valor1>valor2:
    ta = valor1
    valor1 = valor2
    valor2 = ta

if valor1 % 2 != 0:
    valor1 += 2
    while valor1 < valor2:
        if valor1 % 2 !=0:
            soma += valor1
        valor1 += 1
else:
    valor1 += 1
    while valor1 < valor2:
        if valor1%2 !=0:
            soma += valor1
        valor1 += 1

print(soma)