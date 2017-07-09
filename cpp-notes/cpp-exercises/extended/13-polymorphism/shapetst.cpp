
//======================================================================
//
//  Filename:     shapetst.cpp
//  Description:  Test harness to exercise the shape hierarchy
//
//======================================================================

#include <iostream>                      // Stream class definition
using namespace std;
#include "shape.hpp"                     // shape  class hierarchy

void test2();                            // Test harness for question 2
void test3();                            // Test harness for question 3
void test4();                            // Test harness for question 4
void test5();                            // Test harness for question 5

int main()
{
//  test2();
//  test3();
//  test4();
    test5();

	return 0;
}
    
void test2()
{
/***
    
    shape * pshape;                      // Base-class pointer
    
    pshape = new circle(10,10,10);       // Create derived-class object. 
                                         // circle constructor arguments are:
                                         // (centreX, centreY, radius)
                        
    
    // The expected output is as follows:
    //   coordinates (50,100,70,120)
    //   area  314

    pshape->translateX(50);
    pshape->translateY(100);
    pshape->display_coords();
    
    cout << "area = " << pshape->area() << endl;

    cout << "\nDestroying the circle\n";
    delete pshape;

***/
}

void test3()
{
/***
	int i;
    shape * ptable[] = {
                          new circle(10,10,10),
                          new parallelogram(0,0,100,100,50),
                       };                        
                        
    // The expected output is as follows:
    //   circle:         coords (10,10,30,30),   area 314
    //   parallelogram:  coords (10,10,110,110), area 5000

    for (i = 0; i < 2; ++i)
    {
        ptable[i]->translateX(10);
        ptable[i]->translateY(10);
        ptable[i]->display_coords();
    
        cout << "area = " << ptable[i]->area() << endl;
    }

    cout << "\nDestroying the shapes\n";
    for (i = 0; i < 2; ++i)
    {
        delete ptable[i];
    }

***/
}

void test4()
{
/***
	int i;
    shape * ptable[] = {
                          new circle(10,10,10),
                          new parallelogram(0,0,100,100,50),
                          new rectangle(50,50,150,150)
                       };                        
                        
    // The expected output is as follows:
    //   circle:         coords (10,10,30,30),   area 314
    //   parallelogram:  coords (10,10,110,110), area 5000
    //   rectangle:      coords (60,60,160,160), area 10000 

    for (i = 0; i < 3; ++i)
    {
        ptable[i]->translateX(10);
        ptable[i]->translateY(10);
        ptable[i]->display_coords();
    
        cout << "area = " << ptable[i]->area() << endl;
    }

    cout << "\nDestroying the shapes\n";
    for (i = 0; i < 3; ++i)
    {
        delete ptable[i];
    }

***/
}

void test5()
{
	int i;
    shape * ptable[] = {
                          new circle(75,75,25),
                          new parallelogram(0,0,120,30,40),
                          new rectangle(200,200,300,300)
                       };                        
                        
    // The expected perimeter values are:
    //    157 for the circle
    //    260 for the parallelogram
    //    400 for the rectangle

    for (i = 0; i < 3; ++i)
    {
        cout << "perimeter = " << ptable[i]->perimeter() << endl;
    }

    cout << "\nDestroying the shapes\n";
    for (i = 0; i < 3; ++i)
    {
        delete ptable[i];
    }
}
