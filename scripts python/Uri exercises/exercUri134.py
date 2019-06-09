alcool = 0
gasolina = 0
diesel = 0

while True:
    valor = int(input())
    if valor == 1:
        alcool += 1
    elif valor == 2:
        gasolina += 1
    elif valor == 3:
        diesel += 1
    elif valor == 4:
        break
    else:
        pass
print('MUITO OBRIGADO')
print('Alcool: {}'.format(alcool))
print('Gasolina: {}'.format(gasolina))
print('Diesel: {}'.format(diesel))
