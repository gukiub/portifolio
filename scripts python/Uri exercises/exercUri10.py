codPeca1, numPeca1, unit1 = input().split(" ")
codPeca2, numPeca2, unit2 = input().split(" ")

total = ((float(unit1) * int(numPeca1)) + (float(unit2) * int(numPeca2)))

print('VALOR A PAGAR: R$ {:.2f}'.format(total))

