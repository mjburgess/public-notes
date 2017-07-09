/* INTRODUCTION:

These notes illustrate concepts in code. 

They are modifiable so you may test your ideas immediately.
They are severely under-commented: please add your own notes. 

There are several occasions when code is commented out because it will cause an error,
or otherwise is not central to the main concept being illustrated --
you are invited to uncomment these lines and to play around. 


CONTENTS:
1. This notes/ folder contains .cpp files which are all indepdent and self-contained;
    the output of each file is included at the very bottom. 

Notes get going from 03.types-data.cpp onwards. First few are for group discussion. 
Esp. useful for reading are 13 onwards and in particular 18.concepts onwards. 

2. The samples/ folder contains applications which need special compliation, in particular,
there are several .cpp files all of which need compiled for the application to run. ... 

The samples/ folder illustrates additional language features and basic application design. 
In particular, the functional/ folder illustrates test-driven design (Main.cpp is the test spec) 
and functional programming language features.


3. The exercises/ folder contains two sets of exercises: pratice/ exercises 
which correspond to each notes file here and extended/ exercises more closely based off the QACPP course notes.



If you add comments or exapand these comments please
email me your version, or any questions about mine at
michael.burgess@qa.com .

EXTRA:
    In order to automate testing of these files I've commented out any user interaction (eg. cin) --
    feel free to uncomment these lines and try the program yourself. 
*/


// the first lesson:  the basic structure of C++ programs... 


#include <iostream>             

int main(void) {
    std::string message = "Hello World";

    std::cout << message << std::endl;

    return 0;
}

/* three senses of program structure:

physical: a collection of header files (.hpp, .h) and source files (eg., this one, 00.helloworld.cpp)
    aka. translation units (source) and translated units (machine code)

logical: functions (eg. main), variables (eg. message); classes, objects (eg. cout), methods (eg. <<)

running: executing functions, loading data into memory, creating objects, etc.
-- execution begins from the *main* function, called by the operating system
*/


// compile, link and run C++ programs -- compilation: preprocess, translate (compile & assemble), link


//COMMANDS

//clang  (OS X default)
// clang++ --std=c99 00.helloworld.cpp 
// ./a.out


// g++ gnu compiler (linux default,  mac defines g++ = clang++)
// g++ --std=c99 00.helloworld.cpp 
// ./a.out


// microsoft visual c++ compiler (ms. default, need to open developer tools prompt) 
// cl 00.helloworld.cpp /EHsc
// 00.helloworld.exe


/* OUTPUT (notes/00.helloworld.cpp):
Hello World

*/