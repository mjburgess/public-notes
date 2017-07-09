#include <iostream>
using namespace std;


//recall: function overloading
//functions may be overloaded where a subsequent function must differ by its parameter list (either number or type)
void print(string str) { cout << "s: " << str << endl;}
void print(double d)  {  cout << "d: " << d << endl;}

//and methods too:
class PrefixPrinter {
    public:
        PrefixPrinter(string prf) : prefix(prf) {}
        void print(int i) const    {  cout << prefix + "int is " << i + 10 << endl;}
        void print(double d) const {  cout << prefix + "dbl is " << d + 10 << endl;}          
                                                        //operators are overloaded too!
                                                        //recall: operator polymorphism
        string getPrefix() const { return prefix; }
    private:
        string prefix;
};


// + really represents a family of operations:  string + string,  int + int, double + double, etc. 
// (this family is united by following certain laws, eg.  T + T = T  and v + 0 = v)

// operators can be overloaded, but only on user-defined types (ie. you cannot change string+string behaviour)...

//here I define a global operator (one available everywhere) which allows to PrefixPrinters to be added together
//such that the resulting printer will print the prefixs of both operands
PrefixPrinter operator+(const PrefixPrinter &l, const PrefixPrinter &r) {       // why const & ?
    return PrefixPrinter { l.getPrefix() + r.getPrefix() };
}

//l + r ==  operator+(l, r)

int main(void) {
    print("Sample");
    print(1.1);

    PrefixPrinter me { "Michael's " };
    PrefixPrinter you { "Sherlock's " };

    me.print(10);
    you.print(12.1);
    
    //add two printers together & call print
    (me + you).print(100);


    //Q. What is the type of all the + operators in this file?

    return 0; 
}


/* OUTPUT (notes/99.appendix-overloading-operators.cpp):
TODO

*/