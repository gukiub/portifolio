import sys

while True:
  #menu
  print('=-='*20, '\n')
  print('soma [1]')
  print('subtra��o [2]')
  print('multiplica��o [3]')
  print('tabuada [4]')
  print('divis�o [5]')
  print('encerrar o programa [exit]', '\n')
  print('=-='*20, '\n')



  menu = str(input('selecione sua opera��o: '))
  print('')



  if menu == 'exit':
    sys.exit()
    
  if menu == '1':
    print('Para finalizar a opera��o digite [exit]')
    print('')
    while True:
      n = str(input('primeiro valor: '))
      if n == 'exit':
        break
      else:
        n = int(n)
      n2 = str(input('segundo valor: '))
      if n2 == 'exit':
        break
      else:
        n2 = int(n2)
      soma = n + n2
      print(f'{n} + {n2} = {soma}')
      print('')
      

  if menu == '2':
    print('Para finalizar a opera��o digite [exit]')
    while True:
      n = str(input('primeiro valor: '))
      if n == 'exit':
        break
      else:
        n = int(n)

      n2 = str(input('segundo valor: '))
      if n2 == 'exit':
        break
      else:
        n2 = int(n2)

      sub = n - n2
      print(f'{n} - {n2} = {sub}')
      print('')


  if menu == '3':
    print('Para finalizar a opera��o digite [exit]')
    while True:
      n = str(input('primeiro valor: '))
      if n == 'exit':
        break
      else:
        n = int(n)

      n2 = str(input('segundo valor: '))
      if n2 == 'exit':
        break
      else:
        n2 = int(n2)

      sub = n * n2
      print(f'{n} * {n2} = {sub}')
      print('')


  if menu == '4':
      #tabuada
    while True:
      n = str(input('qual tabuada?: '))
      if n == 'exit':
        break
      else:
        n = int(n)
      n2 = str(input('at� qual valor?: '))
      if n2 == 'exit':
        break
      else:
        n2 = int(n2)
      print('')

      contador = 1
      mult = 0

      if n < 0:
        print('resposta invalida')
      else:
        for ada in range(1, n2+1):
          mult = contador * n
          print('{} x {} = {}'.format(n, contador, mult))
          contador += 1

  if menu == '5':
    print('Para finalizar a opera��o digite [exit]')
    while True:
      n = str(input('primeiro valor: '))
      if n == 'exit':
        break
      else:
        n = int(n)

      n2 = str(input('segundo valor: '))
      if n2 == 'exit':
        break
      else:
        n2 = int(n2)

      sub = n / n2
      print(f'{n} / {n2} = {sub}')
      print('')