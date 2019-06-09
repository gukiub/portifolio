senha = 2002
valor = int(input())

while valor != senha:
    print('Senha Invalida')
    valor = int(input())

    if valor == senha:
        print('Acesso Permitido')

