from tkinter import *
import tkinter

# Funktion, welche beim Klick des Buttons
# ausgeführt wird.
def action():
    print("Aua!")

# Ein Fenster erstellen
fenster = Tk()
tkinter 
# Einen Button erstellen
button = Button(fenster, text="Hit me!", command=action)
button.pack()

mainloop()