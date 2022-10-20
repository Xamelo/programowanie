#include <iostream>
using namespace std;

int globalVariable = 7;

void anoteherFunction(int parametr)
{
    parametr = 12;
    int anotherLocalVariableInFunction = 6;
}

void testFunction()
{
    int localVariableInFunction = 5;
    anoteherFunction(localVariableInFunction);
}

int main()
{
    /*int localVariableInMain = 8;
    testFunction();
    globalVariable = 77;
    anotherFunction();*/

    /*
    Stos - obszar pamieci RAM przydzielony naszemu programowi.
    Obszar ten jest ograniczony i sie nie da go zwiekszyc w czasie
    dzialania programu. Laduja tam zmienne lokalne
    */

    //ta zmienna wyladuje na stosie
    //deklaracja zmiennej o nazwie "number" TYPU int
    int number;
    number = 77;
    cout << number << endl;

    //sterta - pozostaly wolny obszar pamieci RAM


    //deklaracja zmiennej lokalnej o nazwie "wsk" ktora jest wskaznikiem NA TYP int
    int *wsk;
    //Operator "new" rezerwuje nowy obszar na stercie o wielkosci typu int i zwraca adres tego obszaru.
    //
    wsk = new int;
    *wsk = 7;
    //wyswietlanie adresu w jakim znajduje sie obasz na stercie
    cout << wsk << endl;
    cout << *wsk << endl;

    //number bedzie rowny 14
    //number = (*wsk) * 2;
    number = *wsk * 2;




}

/*

*/