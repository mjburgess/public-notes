#include <iostream>
#include <vector>           // REQUIRED!

using namespace std;        // std::vector is the fullname, this allows just vector

int main(void) { 
    vector<int> ages;       // a vector<int> is a sequence of ints
                            // 'vector' is not a complete type -- its a family of types of which vector<int> is one
                            // the angle brackets < > provide the extra information needed to fully describe the data (type)

                        
    ages.resize(10, 0);     // 10 elements where each is initialized to 0

    // this is a new kind of expression that we haven't yet seen:
    // identifier.identifier()    or,   variable.function()   or,    object.method()

    // you can read this as, "ask ages to resize"
    // resize() is a method of the object ages
    //( resize() is just like a function which is passed ages as a hidden argument )


    // you may use the subscript operator with ages


    ages[9] = 18;
    size_t num = ages.size(); // unsigned int == 0 to 4GB

    cout << "the number of elements is " << num << endl; 
    cout << "the real size is " << ages.capacity() << endl;
    cout << "the last element is " << ages[num - 1] << endl;


    //C++ 11
    vector<double> distances {100.1, 305.3, 904.2};

}


/* OUTPUT (notes/09.types-vector.cpp):
the number of elements is 10
the real size is 10
the last element is 18

*/