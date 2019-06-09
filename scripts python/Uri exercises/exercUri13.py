A, B, C = input().split(" ")
A = int(A)
B = int(B)
C = int(C)

MAAB = (A + B + abs(A - B))/2
maior = (MAAB + C + abs(MAAB - C))/2

print('{:.0f} eh o maior'.format(maior))
