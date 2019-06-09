escolha = int(input('selecione uma operação de aritmética de 0 a 4: '))

if escolha != 1 and escolha != 2 and escolha != 3 and escolha != 4:
    print('operação não encontrada')
else:
    valor1 = float(input('primeiro valor: '))
    valor2 = float(input('segundo valor: '))

    soma = valor1 + valor2
    divisao = valor1 / valor2
    mult = valor1 * valor2
    sub = valor1 - valor2

    if escolha == 1:
        print('soma {:.0f}'.format(soma))
    elif escolha == 2:
        print('divisão {}'.format(divisao))
    elif escolha == 3:
        print('multiplicação {:.0f}'.format(mult))
    elif escolha == 4:
        print('subtração {:.0f}'.format(sub))
    else:
        print('operação não encontrada')


