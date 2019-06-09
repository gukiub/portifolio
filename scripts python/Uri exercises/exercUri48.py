money = float(input())

if money <= 400:
    print('Novo salario: {:.2f}'.format(money * 1.15))
    print('Reajuste ganho: {:.2f}'.format(money * 0.15))
    print('Em percentual: 15 %')

if money > 400 and money <= 800:
    print('Novo salario: {:.2f}'.format(money * 1.12))
    print('Reajuste ganho: {:.2f}'.format(money * 0.12))
    print('Em percentual: 12 %')

if money > 800 and money <= 1200:
    print('Novo salario: {:.2f}'.format(money * 1.10))
    print('Reajuste ganho: {:.2f}'.format(money * 0.10))
    print('Em percentual: 10 %')

if money > 1200 and money <= 2000:
    print('Novo salario: {:.2f}'.format(money * 1.07))
    print('Reajuste ganho: {:.2f}'.format(money * 0.07))
    print('Em percentual: 7 %')

if money > 2000:
    print('Novo salario: {:.2f}'.format(money * 1.04))
    print('Reajuste ganho: {:.2f}'.format(money * 0.04))
    print('Em percentual: 4 %')