from tkinter import *
import dictlol as d

def split_lore(lore):
	x = 60
	slore = ''
	string = [lore[y-x:y] for y in range(x, len(lore)+x,x)]

	for x in range(len(string)):
		slore = slore + str(string[x]) + '\n'
	return slore

def open_details(name, index):
	detail = Tk()
	detail.title(name)
	detail.resizable(False, False)
	detail.iconbitmap("champions_icons/"+name+".ico")

	filebg = PhotoImage(file = 'paper.png', master = detail)
	art = PhotoImage(file = "champions_art/"+name+".png", master = detail)
	w = filebg.width()
	h = filebg.height()

	detail.geometry("%dx%d+50+30" % (w,h)) #JANELA

	canvas = Canvas(detail, bg = 'white', height = h, width = w)
	canvas.pack(side='top', fill='both', expand='yes')
	canvas.create_image(0, 0, image=filebg, anchor='nw')

	if len(d.champdesc[index]) > 70:
		desc = ''
	else:
		desc = d.champdesc[index]

	canvas.create_text(170, 25, fill="white", font="times 25 bold", text=name)
	canvas.create_text(700, 53, fill="white", font="times 15 bold", text=desc, justify = RIGHT)
	canvas.create_image(30, 70, image=art, anchor='nw')


	lore = split_lore(d.champlore[index])

	canvas.create_text(700, 220, fill="white", font='times 15 bold', text=lore, justify=RIGHT)

	detail.mainloop()