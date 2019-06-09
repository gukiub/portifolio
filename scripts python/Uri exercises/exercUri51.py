imp = float(input())

if imp <= 2000.00:
  print('Isento')

if imp >= 2000.01 and imp <= 3000.00:
  val1 = (imp - 2000)
  val2 = (val1 * 0.080)
  print('R$ {:.2f}'.format(val2))

if imp >= 3000.01 and imp <= 4500.00:
  val1 = (imp - 2000)
  val2 = val1 - 1000
  val3 = (1000 * 0.080)
  val4 = (val2 * 0.18)
  print('R$ {:.2f}'.format(val3 + val4))

if imp > 4500:
  val1 = (imp - 2000)
  val2 = val1 - 1000
  val3 = (1000 * 0.080)
  val4 = val2 - 1500
  val5 = (1500 * 0.18)
  val6 = (val4 * 0.28)
  print('R$ {:.2f}'.format(val6 + val3 + val5))
