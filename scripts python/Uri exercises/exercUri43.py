a, b, c = input().split(' ')
a = float(a)
b = float(b)
c = float(c)

perimetro = (a + b + c)
area = (0.5 * (a+b) * c)

if(a+b > c) and (b+c > a) and (a+c > b):
    print('Perimetro = {:.1f}'.format(perimetro))
else:
    print('Area = {:.1f}'.format(area))
