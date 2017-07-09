#include <iostream>
#include <string>
using namespace std;

//SYNTAX

//class defintions create new types 
//recall: types are used to annotate variables so that the compiler knows what operations are valid on that variable
//and what data that variable contains 

// class defintions therefore have to say what data is going to be in an variable (the state)
// and define what operations are possible on that variable

// class newtypename
class Person {

    private: //access modifier
    //fields
    
        string firstname, lastname;
        int age;

                    

    public: //access modifier
    //methods

        string getName() const;                             //prototype, defined later

        void setName(string first, string second) {       //OR full implementation
            this->firstname = first;
            this->lastname = second;
        }

        int getAge() {
            return age;                                     // this->   not required!
        }

        void setAge(int newAge) {
            if(newAge > 0) {
                age = newAge;
            }
        }
};

//Person's getName()  is implemented later

//Type::method  -- the full name of each of these methods
string Person::getName() const {
    return firstname + " " + lastname;            //ie., return this->firstname + this->lastname
}


// STANDARD-FORM

// class defintions are almost always seprated out from implementation...
// a best-practice standard form for class defintions could be:

// definintion goes in a .hpp file, often named after the class (eg. BankAccount.hpp)
class BankAccount {
    public:                                      //public tends to come first, since this is what readers mostly care about 

    BankAccount(double start);                   //constructor first (more on this next...)

    BankAccount withdraw(double amount) const;   //an immutable interface
    BankAccount deposit(double amount)  const;   //methods return new objects rather than modifying state

    double getBalance() const;

    private:                               
        double balance;                     // state is almost-always private
};  //SEMI-COLON!


// implementation goes in a .cpp file, often named after the class (BankAccount.cpp)
BankAccount::BankAccount(double start) {
    balance = start;
}

BankAccount BankAccount::withdraw(double amount) const {
    return BankAccount { balance - amount };
}

BankAccount BankAccount::deposit(double amount) const {
    return BankAccount { balance + amount };
}

double BankAccount::getBalance() const {
    return balance;
}

int main(void) {

    Person me;
    me.setName("Michael", "Burgess");
    me.setAge(27);

    cout << me.getName() << " is " << me.getAge() << endl;


    BankAccount myToday { 0 }, myTomorrow { 0 };
    myTomorrow = myToday.deposit(100);

    cout << "my bank account has £" << myTomorrow.getBalance() << endl;
    return 0;
}


/* OUTPUT (notes/22.class-defintion.cpp):
Michael Burgess is 27
my bank account has £100

*/