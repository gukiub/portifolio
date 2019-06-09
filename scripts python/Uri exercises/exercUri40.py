notas = input().split(" ")
n1 = float(notas[0])
n2 = float(notas[1])
n3 = float(notas[2])
n4 = float(notas[3])

media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1))/10

print("Media: {}".format(media))

if media >= 7.0:
    print('Aluno aprovado.')
elif media < 5.0:
    print('Aluno reprovado.')
elif (media > 5.0) and media < 6.9:
    print('Aluno em exame.')
    exame = float(input('Nota do exame: '))
    mediaFinal = (media + exame)/2

    if mediaFinal >= 5.0:
        print('Aluno aprovado.')
        print('Media final: {}'.format(mediaFinal))
    else:
        print('Aluno reprovado.')
        print('Media final: {}'.format(mediaFinal))

else:
    pass

