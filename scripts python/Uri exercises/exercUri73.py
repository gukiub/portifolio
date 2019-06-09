n = int(input())

contador = 2

for batata in range(1, n, 2):
    print('{}^2 = {}'.format(contador, (contador**2)))
    contador += 2