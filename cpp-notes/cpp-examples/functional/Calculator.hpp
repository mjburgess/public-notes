#include <string>
#include <regex>
#include <vector>

#pragma once

using namespace std;

class Calculator {
    public:
        int add1(string number_string);
        int add2(string number_string);
        int add3(string number_string);
        int add4(string number_string);
        int add5(string number_string);
        int add6(string number_string);
        int add7(string number_string);
};


vector<string> re_split( const string str, const regex regex );