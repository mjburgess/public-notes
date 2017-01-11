#include <iostream>
using namespace std;

//skip over for now...
//write the return type of the function in terms of the type of its arguments
auto add(int x, int y) -> decltype(x + y) {
    return x + y;
}

int main(void) {
    // TYPEDEFs

    // typedef TYPE NEW-NAME;
    typedef unsigned char byte;

    byte sixtyFive = 65;        //equivalent to...
    char upperA = 'A';          //but each type signals what the intended purpose of the data is

    // AUTO 
    auto lower_a = 'a';     //infers char
    auto height = 181;      //infers int
    auto weight = 90.5;     //infers double
    auto distance = 1L;     //infers long


    // DECLTYPE -- the type of expressions
    decltype(height / weight) bmi = weight * 1E4 / (height * height);


    cout << "the bmi is " << bmi << endl;
    cout << "5 + 6 is" << add(5, 6) << endl;

    return 0;
}


/* OUTPUT (notes/06.types-typedef.cpp):
the bmi is 27.6243
5 + 6 is11

*/