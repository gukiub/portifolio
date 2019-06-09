valores = []
batata = int(input())
for lp in range(batata):
    valores.append(int(input()))

for lp in valores:
    if lp == 0:
        print('NULL')
    if (lp % 2 == 0) and lp > 0:
        print('EVEN POSITIVE')
    if (lp % 2 != 0) and lp < 0:
        print('ODD NEGATIVE')
    if (lp % 2 != 0) and lp > 0:
        print('ODD POSITIVE')
    if (lp % 2 == 0) and lp < 0:
        print('EVEN NEGATIVE')