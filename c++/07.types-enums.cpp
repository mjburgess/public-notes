#include <iostream>

using namespace std;

int main(void) {  
    // ENUMERATIONS
    enum season : int {                     // season is a kind of integer
        spring, summer, autum, winter       // a value of type season is in the set {0, 1, 2, 3, 4} 
                                            // == {spring, summer, autum, winter}
    };

    season ofDiscontent = winter;
    season ofIcream = summer;

    season fall = season(2);                // convert from integer to season

    cout << "fall is the " << int(fall) << "nd season" << endl;



    enum button : bool {                    // button is a kind of bool
        off, on                             // {0, 1} == {false, true} == {off, on}
    };

    button lightSwitch = on;

    cout <<  boolalpha << "the lightSwitch is " << bool(lightSwitch) << endl;   
    // recall: boolapha modifies cout so that it prints true/false instead of 1/0



    enum weekdays {                         //backed by int by default
        Monday = 1,
        Tuesday,                            //Tuesday == 2
        Wednesday,
        Thursday,
        Friday
    };


    //gotchas
    season magical = season(666); // convert 666 to a season
    int magic = magical;
    
    cout << (magic == 666 ? "the season is 666" : "the season is not 666") << endl;

    // Monday = 2;   //error, Monday is a constant


    /* ERROR: confusion over which type 'blue' belongs to

        enum colour { blue, red };
        enum mood { blue, happy };

        colour hue = blue; 
    
    */

    //C++11
    enum class colour { blue, red };        // here class means we require a colour:: prefix on each value
    enum class mood { blue, happy };

    colour hue = colour::blue;

    return 0;
}


/* OUTPUT (notes/07.types-enums.cpp):
fall is the 2nd season
the lightSwitch is true
the season is 666

*/