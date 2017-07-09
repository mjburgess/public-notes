
// Chapter:     Pointers
// File:        pointers.cpp
// Description: Show results of pointer manipulation

#include <iostream>
using namespace std;

void question_a();
void question_b();
void question_c();
void question_d();
void question_e();
void question_f();
void question_g();
void question_h();
void question_i();
void question_j();
void question_k();
void question_l();
void question_m();
void question_n();

int main()
{
    char response;

    do
    {
        cout << endl << "Which question? [a to n, or x to exit] ";
        cin >> response;

        switch (response)
        {
        case 'a':
            question_a();
            break;
        case 'b':
            question_b();
            break;
        case 'c':
            question_c();
            break;
        case 'd':
            question_d();
            break;
        case 'e':
            question_e();
            break;
        case 'f':
            question_f();
            break;
        case 'g':
            question_g();
            break;
        case 'h':
            question_h();
            break;
        case 'i':
            question_i();
            break;
        case 'j':
            question_j();
            break;
        case 'k':
            question_k();
            break;
        case 'l':
            question_l();
            break;
        case 'm':
            question_m();
            break;
        case 'n':
            question_n();
            break;
        }
    }
    while (response != 'x');

    return 0;
}

void question_a()
{
    int m, n;
    int * iptr; 

    m = 38;
    iptr = &m;
    n = *iptr;

    cout << "n = " << n << endl;
}

void question_b()
{
    int m, n;
    int * iptr; 

    n = 10;
    iptr = &n;
    n = 11;
    m = *iptr;

    cout << "m = " << m << endl;
}

void question_c()
{
    int * lptr;
    int c, d; 

    c = 65;
    lptr = &c;
    d = *lptr + 1;

    cout << "d = " << d << endl;
}

void question_d()
{
    int * lptr;

    int i = 65;
    lptr = &i;

    cout << "*lptr = " << *lptr << endl;
}

void question_e()
{
    int * lptr;
    int i, j = 4;

    lptr = &i;
    i = j;

    cout << "*lptr = " << *lptr << endl;
}

void question_f()
{
    int num_days, i = 4;
    int * lptr = &num_days;

    cout << "*lptr = " << *lptr << endl;
	cout << "Explanation: " << *lptr << " is num_days' garbage value" << endl;
}

void question_g()
{
    double f = 4.0, fred = 37.0;
    //int *lptr;

    f = fred;

    cout << "*lptr = ?" << endl;
	cout << "Explanation: lptr is not initialised. Who knows where it points to." << endl;
	cout << "I'm not even going to attempt to dereference it because it could   " << endl;
	cout << "cause a crash. So there." << endl;
}

void question_h()
{
    int i = 9, j = 10;
    int * lptr = &i;

    *lptr = i;
    j = i;

    cout << "*lptr = " << *lptr 
		 << " ,i = " << i
		 << " ,j = " << j << endl;
}

void question_i()
{
    int i, j;
    int * pl = &i, *p2 = &j;

    *pl = 8;
    i = 7;
    *p2 = *pl;

    cout << "i = " << i 
		 << ", j = " << j << endl;
}

void question_j()
{
    double zero = 1.0, one;
    double * fpl = &zero, * fp0 = &one;

    fpl = fp0;
    *fpl = 0.0;
    *fp0 = 1.0;

    cout << "zero = " << zero << ", one = " << one << endl;
}

void question_k()
{
    char d, ch = 'q', grade = 'b';

    char * cp = &grade;
    grade = 'l';
    d = *cp;

    char * pp = cp;
    *pp = grade;

    cout << "d = " << d
         << ", ch = " << ch
         << ", grade = " << grade
         << ", *cp = " << *cp
         << ", *pp = " << *pp << endl;
}

void question_l()
{
    double f, fl = 4.0, f2 = 1.5;
    double * fpl = &fl, * fp2 = &f2;

    f = *fpl * *fp2;

    cout << "f = " << f << endl;
}

void question_m()
{
    long lvall = 3L, lval2 = 2L, * lptr;

    lptr = &lvall;
    *lptr = lval2++ * *lptr;

    cout << "lval1 = " << lvall 
		 << ", lval2 = " << lval2 << endl;
}

void question_n()
{
    long lvall, lval2 = 4L, * lp = &lval2, ** lpp = &lp;

    lp = &lvall;
    *lp = 2L;
    **lpp = 3L;

    cout << "lval1 = " << lvall 
		 << ", lval2 = " << lval2 << endl;
}
