valor1 = 0
valor2 = 1

while valor1 != valor2:
    valor1, valor2 = input().split(' ')
    valor1 = int(valor1)
    valor2 = int(valor2)

    if valor1 > valor2:
        print('Decrescente')
    elif valor2 > valor1:
        print('Crescente')

