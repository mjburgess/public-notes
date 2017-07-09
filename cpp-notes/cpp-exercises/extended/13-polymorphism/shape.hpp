
//======================================================================
//
//  Filename:     shape.hpp
//  Description:  Definition of the shape hierarchy
//
//======================================================================

#ifndef SHAPE_INCLUDED
#define SHAPE_INCLUDED

//======================================================================
// shape abstract base class
//======================================================================

class shape
{
public:

    void display_coords() const;             // Non-virtual functions
    void translateX(int dx);
    void translateY(int dy);    

    virtual ~shape();                       // Virtual destructor

    virtual double area()      const;       // Virtual function
    virtual double perimeter() const = 0;   // Pure virtual function

protected:

    shape(int x0, int y0, int x1, int y1);  // Protected constructor
    
    int top, left, bottom, right;           // Protected data members
};


//======================================================================
// circle derived class
//======================================================================

class circle : public shape
{          
public:

    circle(int cx, int cy, int rad);        // Note: public constructor
    virtual ~circle();

    // Inherit shape::translateX
    // Inherit shape::translateY

    virtual double area() const;            // Override shape::area
    virtual double perimeter() const;       // Override shape::perimeter
};


//======================================================================
// parallelogram derived class
//======================================================================

class parallelogram : public shape
{          
public:

    parallelogram(int x0, int y0, int x1, int y1, int dx);
    virtual ~parallelogram();
    
    // Inherit shape::translateX
    // Inherit shape::translateY

    virtual double area() const;            // Override shape::area
    virtual double perimeter() const;       // Override shape::perimeter

private:

    int delta;
};                                              
    

//======================================================================
// rectangle derived class
//======================================================================

class rectangle : public parallelogram
{          
public:

    rectangle(int x0, int y0, int x1, int y1);
    virtual ~rectangle();

    // Inherit shape::translateX
    // Inherit shape::translateY

    // Inherit parallelogram::area
    // Inherit parallelogram::perimeter
};


#endif
