#include <string>
#include <numeric>
#include <regex>
#include <stdexcept>
#include "Calculator.hpp"

using namespace std;


int Calculator::add1(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    return 1;
}

int Calculator::add2(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    return stoi(number_string);
}

int Calculator::add3(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    regex re(",");

    vector<string> numbers = re_split(number_string, re);

    vector<int> parts;

    transform(numbers.begin(), numbers.end(), back_inserter(parts), [](string x) { return stoi(x); });
    
    return accumulate(parts.begin(), parts.end(), 0);
}

int Calculator::add4(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    regex re("[,\n]");

    vector<string> numbers = re_split(number_string, re);

    vector<int> parts;

    transform(numbers.begin(), numbers.end(), back_inserter(parts), [](string x) { return stoi(x); });
    
    return accumulate(parts.begin(), parts.end(), 0);
}

int Calculator::add5(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    regex re("[,\n]");

    vector<string> numbers = re_split(number_string, re);

    vector<int> parts;

    transform(numbers.begin(), numbers.end(), back_inserter(parts), [](string x) { return stoi(x); });
    
    return accumulate(parts.begin(), parts.end(), 0);
}

int Calculator::add6(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    regex re("[,\n]");

    vector<string> numbers = re_split(number_string, re);

    vector<int> parts;

    transform(numbers.begin(), numbers.end(), back_inserter(parts), [](string x) { return stoi(x); });
    
    if(any_of(parts.begin(), parts.end(), [](int x) { return x < 0; })) {
        throw out_of_range("No Negatives!");
    }

    return accumulate(parts.begin(), parts.end(), 0);
}

int Calculator::add7(string number_string) {
    if(number_string.empty()) {
        return 0;
    }

    regex re("[,\n]");

    vector<string> numbers = re_split(number_string, re);

    vector<int> parts;

    transform(numbers.begin(), numbers.end(), back_inserter(parts), [](string x) { return stoi(x); });
    
    return accumulate(parts.begin(), parts.end(), 0, [](int l, int r){ return l + (r > 1000 ? 1000 : r); });
}



// HELPERs


vector<string> re_split( const string str, const regex regex )
{
    vector<string> result;

    sregex_token_iterator it( str.begin(), str.end(), regex, -1 );
    sregex_token_iterator reg_end;

    for ( ; it != reg_end && !it->str().empty(); ++it ) {
        result.emplace_back( it->str() );
    }

    return result;
}