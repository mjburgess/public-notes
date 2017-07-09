#include <iostream>
#include <limits>

using namespace std;

int main(void) {        // another acceptable defintion of main; here void == taking no arguments

    // INTEGERS -- standard does not define size, always >= short

    int numAtoms;         // Q. what value does this have? A. not defined.

    int year = 1875;
    int month = 12, day = 1;

    int x(0), y(0);     // alternative initilization syntax read x(0) as "construct from 0"
    int a {0}, b {0};   // uniform initilization synax -- in C++11 {} can be used to initialize abitary values
    
    // alternate forms of integer literals

    int numApples = 0xA;      // hex A = 10
    int numOranges = 010 + 2; // oct 10 = 8 + dec 2 = 10
    int numPears = 10;

    int large = INT_MAX;    //INT_MAX is system-specific constant, usually about 2.1 billion

    cout << "the largest int is " << large << endl;
    cout << "one greater than the largest int is " << large + 1 << endl;

    // the integer type is *circular* ! not monotonically increasing, as we're used to...
    // this creates all kinds of weird edge-cases and "unexpected" behaviour

    int halved = 9 / 2; //Q. which is? A. / is integer-division, cf. operator polymorphism
    double halvedD = 9 / 2; // recall: OPERATOR polymorphism

    cout << "i = 9 / 2 is " << halved << endl;
    cout << "d = 9 / 2 is " << halvedD << endl;

    cout << "we have " << numPears << " pears\n"; // \n == endl
    cout << "we have " << ++numPears << " pears\n"; 
    cout << "we have " << numPears++ << " pears\n"; 
    cout << "we have " << numPears << " pears\n"; 

    cout << "we have " << numPears-- << " pears\n";
    cout << "we have " << --numPears << " pears\n";


    // FLOATS

    cout << fixed; // comment-out this line; Q. what happens? -- fixed is a stream modifier/manipulator

    float heightF = 1.81f;  //f suffix forces the literal 1.81 to be a float
    double heightD = 1.81;  

    cout << "heightF is " << heightF << endl;
    cout << "heightD is " << heightD << endl;

    double c = 3e8;
    double population = 6e7;


    cout << "the speed of light in a vaccuum is " << c << endl;
    cout << "the population of the UK is about " << population << endl;


    // MISC. INTEGER TYPES

    long long speedOfLight = 300000000LL;
    short annualDays = 365;
    unsigned int dvd = 4000000000UL; // 4 GB
    
    // CHARACTERS -- an integer type (unsigned)

    char lowercase_a = 'a', uppercase_B = 'A' + 1;
    
    const char tab = '\t';      // useful for naming control characters
    const char newline = 10;

    cout << lowercase_a << tab << uppercase_B << newline;

    //ASIDE: escape characters -- the enter key is one character, is represented by \n
    // \n  means a single character where \ can be read as "the special meaning of..."
    // \n then is "the special meaning of n" which is the newline

    // c-strings == sequence of characters 
    char name[] = "Michael";    // null-terminated, so stores strlen("Michael") + 1
                                // double-quotes == string == seq. of chars incl. null
                                // single-quotes == character == one

    cout << "strlen of Michael is " << strlen(name) << endl;
    cout << "sizeof of Michael is " << sizeof name << " bytes" << endl;

    // PRECEDENCE
    // assignment, BODMAS, scope-resolution ::
    
    int result;
    result = 10 * 2 + 6 * 10 + 5 * 8 + 2;

    //Q. which is the way the above is parsed?
    result = 10 * (2 + 6) * (10 + 5) * (8 + 2);
    result = (10 * 2) + (6 * 10) + (5 * 8) + 2;     //A. this one!

    // BODMAS or () / * + -  therf. * comes before + (ie. is higher precedence) 

    // the precendence of an operator can be thought of as how tighly it binds its arguments, like a magnetic force
    // the higher the precedence, the more quickly the arguments snap to it
    // * is high precedence, + is low -- so * binds tightly, and + weakly 
    // the initial expression can be read as + pushing-away, and * gouping-together 

    //CASTING -- moving between data types
    //recall: types are annotations that the *compiler* is aware of
    //the contents of variables are untyped, they are bit patterns held in memory
    //we can treat the very same patterns different... or even translate one kind of pattern into another:
    
    //implicit conversions 
    double level = 0;
    // int anchientPi = 3.141592; // Q. is this an error? A. No (it is a warning however! -- uncomment to see)
    float pi = 3.141592653359; // Q. is there a loss of precision? A. Yes!

    //explict -- C-style
    int slice = (int) pi / 2;
    double distance = (double) 2;       // or just,  2.0

    //explict -- C++ style
    int anotherSlice = int(pi / 2);
    double height = double(2);

    const int days = 365;

    cout << "half a year is " << double(days) / 2 << " days" << endl;

    return 0;
}


/* OUTPUT (notes/03.types-data.cpp):
the largest int is 2147483647
one greater than the largest int is -2147483648
i = 9 / 2 is 4
d = 9 / 2 is 4
we have 10 pears
we have 11 pears
we have 11 pears
we have 12 pears
we have 12 pears
we have 10 pears
heightF is 1.810000
heightD is 1.810000
the speed of light in a vaccuum is 300000000.000000
the population of the UK is about 60000000.000000
a	B
strlen of Michael is 7
sizeof of Michael is 8 bytes
half a year is 182.500000 days

*/