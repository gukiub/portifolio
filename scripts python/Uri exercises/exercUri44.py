batata = input().split(' ')
batata = list(map(int, batata))

a, b = batata

if (b % a == 0) or (a % b == 0):
    print('Sao Multiplos')
else:
    print('Nao sao Multiplos')
