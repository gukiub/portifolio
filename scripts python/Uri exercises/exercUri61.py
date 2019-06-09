valor = input().split()
diaInit = int(valor[1])

valores = input().split(" : ")
a1, b1, c1 = list(map(int, valores))


valor = input().split()
diaFim = int(valor[1])

valores = input().split(" : ")
a2, b2, c2 = list(map(int, valores))

dia = diaFim - diaInit

a = a2 - a1
if a < 0:
    a += 24
    dia -= 1

b = b2 - b1
if b < 0:
    b += 60
    a -= 1

c = c2 - c1
if c < 0:
    c += 60
    b -= 1

if dia <= 0:
    dia = 0

print('{} dia(s)'.format(dia))
print('{} hora(s)'.format(a))
print('{} minuto(s)'.format(b))
print('{} segundo(s)'.format(c))