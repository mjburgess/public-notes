#include <iostream>

using namespace std;

int main(void) {  

    // bitwise operations apply to each bit of data
    // here we reuse the fact that 5 and 9 have interesting bit patters to explore the effect of bitwise operators
    
    // NB. it's hard to see what bitwise operators do looking at the decimal representation of bit patterns.. 
    // and this representation diguses the fact we really care about the bit pattern

    char x = 5;         // char = 1 byte = 8 bits = 00000101
    char y = 9;         // ...                    = 00001001

    char _and = x & y;   // 00000101 &                        
                         // 00001001 ==
                         // 00000001


    char _or = x | y;    // 00000101 |                        
                         // 00001001 ==
                         // 00001101


    // 1 & 1 = 1, otherwise 0
    // 0 | 0 = 0, otherwise 1


    cout << "5 & 9   is " << int(_and) << endl;
    cout << "5 | 9   is " << int(_or) << endl;


    cout << "char(5) is " << bitset<sizeof(char) * 8>(x) << endl; 
    cout << "char(9) is " << bitset<sizeof(char) * 8>(y) << endl; 
    cout << "5 & 9   is " << bitset<sizeof(char) * 8>(_and) << endl;
    cout << "5 | 9   is " << bitset<sizeof(char) * 8>(_or) << endl;

    //some others...
    char _shiftL = x << 1;      // move all the bits along 1 left  (ie. *2)
    char _shiftR = x >> 1;      // move all along 1 right ( ie. /2)
    char _exclOr = x ^ y;

    //c++14 standard allows:
    char byteA = 0b00010000;
    char byteB = 0b00010001;

    cout << "0b00010000 is " << int(byteA) << endl;
    cout << "0b00010001 is " << int(byteB) << endl;

    cout << "A & B is " << int(byteA & byteB) << endl;
    cout << "A | B is " << int(byteA | byteB) << endl;
    cout << "A ^ B is " << int(byteA ^ byteB) << endl;    
    cout << "A << 1 is " << int(byteA << 1) << endl;   
    cout << "A >> 1 is " << int(byteA >> 1) << endl;      
}


/* OUTPUT (notes/05.types-bitwise.cpp):
5 & 9 is 1
5 | 9 is 13
0b00010000 is 16
0b00010001 is 17
A & B is 16
A | B is 17
A ^ B is 1
A << 1 is 32
A >> 1 is 8

*/