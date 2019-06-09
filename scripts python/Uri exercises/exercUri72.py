n = int(input())
contador = 0
n1 = 0
n2 = 0

for batata in range(n):
    n = int(input())
    if n >= 10 and n <= 20:
        n1 += 1
    elif n < 0:
        pass
    else:
        n2 += 1
    contador += 1

print('{} in'.format(n1))
print('{} out'.format(n2))



