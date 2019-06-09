lista = [float(input()), float(input()), float(input()), float(input()), float(input())]

positivos = 0
negativos = 0
impares = 0
pares = 0

for batata in lista:
    if batata % 2 == 0:
        pares += 1
    else:
        impares += 1

    if batata > 0:
        positivos += 1
    else:
        if batata < 0:
            negativos += 1


print('{} valor(es) par(es)'.format(pares))
print('{} valor(es) impar(es)'.format(impares))
print('{} valor(es) positivo(s)'.format(positivos))
print('{} valor(es) negativo(s)'.format(negativos))