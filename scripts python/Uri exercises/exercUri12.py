A, B, C = input().split(" ")

A = float(A)
B = float(B)
C =float(C)

pi = 3.14159
raio = pi * C**2
tri = (A * C)/2
cir = raio
trap = ((A + B) * C)/2
quad = B * B
ret = A * B

print('TRIANGULO: {:.3f}'.format(tri))
print('CIRCULO: {:.3f}'.format(cir))
print('TRAPEZIO: {:.3F}'.format(trap))
print('QUADRADO: {:.3F}'.format(quad))
print('RETANGULO: {:.3f}'.format(ret))
