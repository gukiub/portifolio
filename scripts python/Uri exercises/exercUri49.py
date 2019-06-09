valor1 = input()
valor2 = input()
valor3 = input()

if valor1 == 'vertebrado':
    if valor2 == 'ave':
        if valor3 == 'carnivoro':
            print('aguia')
        elif valor3 == 'onivoro':
            print('pomba')
    elif valor2 == 'mamifero':
        if valor3 == 'onivoro':
            print('homem')
        elif valor3 == 'herbivoro':
            print('vaca')

elif valor1 == 'invertebrado':
    if valor2 == 'inseto':
        if valor3 == 'hematofago':
            print('pulga')
        elif valor3 == 'herbivoro':
            print('lagarta')
    elif valor2 == 'anelideo':
        if valor3 == 'hematofago':
            print('sanguessuga')
        elif valor3 == 'onivoro':
            print('minhoca')
