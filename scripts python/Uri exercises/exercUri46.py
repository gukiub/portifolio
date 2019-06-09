n1, n2 = map(int, input().split(' '))
if n1 > n2:
    x = 24 - n1
    y = x + n2
    print('O JOGO DUROU {} HORA(S)'.format(y))

elif n2 > n1:
    x = n2 - n1
    print('O JOGO DUROU {} HORA(S)'.format(x))

elif n1 == n2:
    x = 24
    print('O JOGO DUROU {} HORA(S)'.format(x))
