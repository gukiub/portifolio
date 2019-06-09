valores = map(int, input().split(' '))

a, b, c, d = valores

inicio = a * 60 + b
final = c * 60 + d
duracao = 0

if a <= c:
    duracao = final - inicio
    if duracao == 0:
        print('O JOGO DUROU {:.0f} HORA(S) E {} MINUTO(S)'.format(24, duracao % 60))
    else:
        print('O JOGO DUROU {:.0f} HORA(S) E {} MINUTO(S)'.format((duracao - duracao % 60) / 60, duracao % 60))
else:
    duracao = (24 * 60 - inicio) + final
    print('O JOGO DUROU {:.0f} HORA(S) E {} MINUTO(S)'.format((duracao - duracao % 60) / 60, duracao % 60))