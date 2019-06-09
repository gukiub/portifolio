x1, y1 = input().split(" ")
x2, y2 = input().split(" ")

X = (float(x2) - float(x1)) ** 2
Y = (float(y2) - float(y1)) ** 2

raiz = (X + Y)**(1/2)

print('{:.4f}'.format(raiz))

