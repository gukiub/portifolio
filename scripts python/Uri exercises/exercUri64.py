lista = [float(input()), float(input()), float(input()), float(input()), float(input()), float(input())]

positivos = 0
soma = 0.0

for batata in lista:
    if batata > 0:
        positivos += 1
        soma += batata

media = soma / float(positivos)
print('{} valores positivos'.format(positivos))
print('{:.1f}'.format(media))