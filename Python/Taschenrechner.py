import tkinter # tkinter für das erstellen von separater Oberfläche(Window) für TR

window = tkinter.Tk() # Window erstellen
window.geometry('150x220') # Höhe und Breite des Fensters
window.title('Rechner') # Überschrift des Fensters

gui_items = list() # Liste der Items der Tasten auf dem Rechner
button_values = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                 '+', '-', '*', '/', '=', 'AC'] # alle Variablen des Rechners

calculation = str() # Berechnung der Zeile


def add_button_text_to_calculation(value): # Definition 
    global calculation

    
    if value == 'AC':                       # AC als Löschtaste für alle strings im Fenster
        calculation = str()
        output_label['text'] = '...'
        return

    if value == '=':
        calculate(calculation)
        calculation = str()
        return

    calculation = calculation + value
    output_label['text'] = calculation


def calculate(calc):
    try:
        result = eval(calc)
        print(result)
        output_label['text'] = result

    except Exception as e:
        print(e)
        output_label['text'] = 'Error'


def create_button(value):
    button = tkinter.Button(text=value, command=lambda: add_button_text_to_calculation(value))
    gui_items.append(button)


for val in button_values:
    create_button(val)


output_label = tkinter.Label(text='Rechnung: ')
output_label.grid(row=0, columnspan=10)

# autoplacen der symbole in Grid
# max. 3 Säulen aber unendliche Zeilen 
column_count = 0
row_count = 1
maximum_columns = 3

for item in gui_items:
    item.grid(row=row_count, column=column_count) 

    column_count += 1
    if column_count == maximum_columns:
        column_count = 0
        row_count += 1


if __name__ == '__main__': 
    window.mainloop()