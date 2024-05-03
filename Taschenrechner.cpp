#include <iostream>
using namespace std;

int main() {
    double zahl1, zahl2, ergebnis;
    char rechenzeichen;

    cout << "Geben Sie eine Rechenaufgabe ein: ";
    cin >> zahl1 >> rechenzeichen >> zahl2;

    switch (rechenzeichen) {
        case '+':
            ergebnis = zahl1 + zahl2;
            break;
        case '-':
            ergebnis = zahl1 - zahl2;
            break;
        case '*':
            ergebnis = zahl1 * zahl2;
            break;
        case '/':
            ergebnis = zahl1 / zahl2;
            break;
        default:
            cout << "Unbekanntes Rechenzeichen... Bitte verwenden Sie +, -, *, oder /." << endl;
            return 1;
    }

    cout << zahl1 << ' ' << rechenzeichen << ' ' << zahl2 << " = " << ergebnis << endl;

    return 0;
}