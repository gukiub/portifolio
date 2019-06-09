x = int(input())

y = 1

while y <= 10:
  print("{1} x {0:>2} = {2:>2}".format(x, y, x*y))
  y += 1