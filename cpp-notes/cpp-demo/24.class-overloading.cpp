#include <iostream>
using namespace std;

//often there are different ways an object may acquire a valid initial state
//therefore constructors may be overloaded (as with ordinary functions)
class Remote {
    public:
        
        Remote() : channel(1) {}           //the default (ie. no-arg) constructor; sets channel=1
        Remote(int ch) : channel(ch) {}    // 1-arg constructor choses that arg

        int getChannel() const { return channel; }
    private:
        int channel;
};

Remote myRemote;       // the constructor matching the initialization will be used
                       // here i havent provided any arguments, therefore the default constructor will be used.

class TV {
    public:
        
        TV() : channel(2) {}                          //default
        TV(int ch): channel(ch) {}
        TV(Remote r): channel(r.getChannel()) {}      //if a remote is passed, use its channel selection 

        int getChannel() const { return channel; }
        bool isOn() const { return on; }
        
        void power() { on = !on; }
        void power(Remote r) { on = (r.getChannel() != 0); }

    private:
        int channel;
        bool on;
};

int main(void) {

    TV myTV { myRemote };       // here i've passed in a remote
    TV yourTV { Remote { 7 } }; // make a new remote and pass it in (objects need not be assigned to variables first!)
    TV ourTV { 10 };            // passing in 10
    TV theirTV;                 // default constructor


    cout << "my    TV channel is " << myTV.getChannel() << endl;
    cout << "your  TV channel is " << yourTV.getChannel() << endl;
    cout << "our   TV channel is " << ourTV.getChannel() << endl;
    cout << "their TV channel is " << theirTV.getChannel() << endl;
    

    //recall, we can use the older and more idiomatic syntax:

    TV _myTV(myRemote);
    TV _yourTV( Remote(7) );    // compare this with double(2), int(2.1) etc. : it reads as construct-remote-from-7
    TV _ourTV(10);
    TV _theirTV;

    cout << "_my    TV channel is " << _myTV.getChannel() << endl;
    cout << "_your  TV channel is " << _yourTV.getChannel() << endl;
    cout << "_our   TV channel is " << _ourTV.getChannel() << endl;
    cout << "_their TV channel is " << _theirTV.getChannel() << endl;
    

    //finally: abitary methods may be overloaded, as for example, the power method
    cout << boolalpha;


    myTV.power();  //reverses the on state (on becomes off, off becomes on)
    cout << "is my tv on? " << myTV.isOn() << endl;


    myTV.power();  //reverses the on state (on becomes off, off becomes on)
    cout << "is my tv on? " << myTV.isOn() << endl;

    myTV.power( Remote(7) ); // sets off if remote's channel is 0, otherwise on
    cout << "turning to ch7, is my tv on? " << myTV.isOn() << endl;

    myTV.power( Remote(0) ); 
    cout << "turning to ch0, is my tv on? " << myTV.isOn() << endl;

    return 0; 
}


/* OUTPUT (notes/24.class-overloading.cpp):
TODO

*/