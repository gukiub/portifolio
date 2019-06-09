homem = 0
mulher = 0

sexo = 1

while sexo != '0':
    sexo = input('qual seu genero? [H/M]\nCaso deseje encerrar o programa digite 0.').upper()
    if sexo == 'H':
        homem += 1
    elif sexo == 'M':
        mulher += 1
    elif sexo != 'M' and sexo != 'H' and sexo != '0':
        print('valor incorreto')
print('homems {} e mulheres {}'.format(homem, mulher))
