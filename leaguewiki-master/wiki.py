from tkinter import *
from tkinter import messagebox
from functools import partial
import dictlol as d
import source as s

##Variaveis
cpimg = []
btvalid = []

##JANELA
root = Tk()
root.title('League Wiki')
root.resizable(False, False)
root.iconbitmap("main.ico")

##FUNDO
try:
       filebg = PhotoImage(file = "background1.png")
       w = filebg.width()
       h = filebg.height()
       root.geometry("%dx%d+50+30" % (w,h)) #JANELA

       canvas = Canvas(height = h, width = w)
       canvas.pack(side='top', fill='both', expand='yes')
       canvas.create_image(0, 0, image=filebg, anchor='nw')
except:
       print('Erro ao desenhar o background')



##ARRAY IMAGENS
try:
       for x in range(len(d.champname)):
              imgtemp = PhotoImage(file = "champions/"+d.champname[x]+".png")
              cpimg.append(imgtemp)
              btvalid.append(True)
except:
       print('Erro ao armazenar as imagens dos champions')  


##DRAW BUTTONS
try:
       for x in range(7):
              bt = Button(canvas, image = cpimg[x], width = 118, height = 118, bd = 0, highlightthicknes=0)
              bt["command"] = partial(s.open_details, d.champname[x], x)   
              if btvalid[x] == True:   
                     bt.grid(row = 0, column = x, padx=13, pady=18)

       for x in range(4):
              if x < 2:
                     bt = Button(canvas, image = cpimg[x+7], width = 118, height = 118, bd = 0, highlightthicknes=0)
                     bt["command"] = partial(s.open_details, d.champname[x+7], x+7)
                     if btvalid[x+7] == True: 
                            bt.grid(row = 1, column = x, padx=13, pady=10)
              else:
                     bt = Button(canvas, image = cpimg[x+7], width = 118, height = 118, bd = 0, highlightthicknes=0)
                     bt["command"] = partial(s.open_details, d.champname[x+7], x+7)
                     if btvalid[x+7] == True: 
                            bt.grid(row = 1, column = x+3, padx=13, pady=10)

       for x in range(4):
              if x < 2:
                     bt = Button(canvas, image = cpimg[x+11], width = 118, height = 118, bd = 0, highlightthicknes=0)
                     bt["command"] = partial(s.open_details, d.champname[x+11], x+11)
                     if btvalid[x+11] == True: 
                            bt.grid(row = 2, column = x, padx=13, pady=10)
              else:
                     bt = Button(canvas, image = cpimg[x+11], width = 118, height = 118, bd = 0, highlightthicknes=0)
                     bt["command"] = partial(s.open_details, d.champname[x+11], x+11)
                     if btvalid[x+11] == True:
                            bt.grid(row = 2, column = x+3, padx=13, pady=10)

       for x in range(7):
              bt = Button(canvas, image = cpimg[x+15], width = 118, height = 118, bd = 0, highlightthicknes=0)
              bt["command"] = partial(s.open_details, d.champname[x+15], x+15)
              if btvalid[x+15] == True:
                     bt.grid(row = 3, column = x, padx=13, pady=10)
except:
       print('Erro ao desenhar os botões na tela')
##MAIN
root.mainloop()