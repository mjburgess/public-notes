#include <iostream>
using namespace std;

template<typename O, typename P> bool is_a(P obj) { return dynamic_cast<O*>(&obj) != nullptr; }
//ignore the above -- details not essential for understanding the concepts below


// ENCAPSULATION

// mutable (changable) state creates some major problems
// if it is changed unpredicatably the program becomes very hard to reason about and understand

// one solution to this problem is encapsulation 
//where modifications to state can only happen through predefined routes..

class BankAccount {
    private:                            // this is an access modifier, it says every subsequent declaration is private
       double balance = 0;              // meaning it is accessible only within the object's methods
                                        // ie. it is only visible with the BankAccount scope



    public:                             // all subsequent declarations are now public
                                        // they may be accessed externally


        void withdraw(double amount) {     
            if(this->balance - amount >= 0) {       // prevent the account from going overdrawn
                this->balance -= amount;
            }

            //note: since withdraw() is a method of BankAccount it is able to see the balance
        }

        double get_balance() const { return this->balance; }  // "getter" to provide read-only access
                                                              // most of the time there should be NO setter!
        //here, then, we have encapsulated the balance
};

//NB. 'this' is a pointer to the object-in-question; a placeholder variable that is assinged to which ever 
//object has, eg., its withdraw method called, 
//ie.  myBank->withdraw() , yourBank->withdraw()  -- this == myBank, this == yourBank

// INHERITANCE & POLYMORPHISM

//1. the type of an object is the group it belongs to 
//ie., its class in the english sense

class Person_ { };

Person_ me;
Person_ you;

//	me and you belong to the class Person_, ie., the type 'Person_' denotes the set {me, you}
//  cf. bool means {true, false}, int means {-2^32, ..., 0, 1, ..., 2^32 - 1}


//2. an object can belong to many groups
//eg. a particular detective is a Person and also a Son, a Human, etc.
// objects however have one 'pricipal' type, the type they were made from but belong to many

// here we define the group (or class) Person
class Person { 
    public:
        //every person has a title
        virtual string title() { return "Mx. "; }
};


//here we say all detectives are people
class Detective : public Person {
    public:
        //every detective has its title
        virtual string title() { return "Detective"; }
};

//all doctors are people
class Doctor : public Person {
    public:
        //every doctor has its own title
        virtual string title() { return "Dr. "; }
};

int main(void) {

    BankAccount mine;
    mine.withdraw(-100); // is this right?
    mine.withdraw(50);
    cout << "my balance is: " << mine.get_balance() << endl;
    cout << boolalpha;


    //... moving on ...
    Detective sherlock;
    Doctor watson;

    cout << "sherlock is a person? " << is_a<Person>(sherlock) << endl;;
    cout << "sherlock is a detective? " << is_a<Detective>(sherlock) << endl;
    cout << "sherlock is a doctor? " << is_a<Doctor>(sherlock) << endl;

    cout << "watson is a person? " << is_a<Person>(watson) << endl;
    cout << "watson is a doctor? " << is_a<Doctor>(watson) << endl;
    cout << "watson is a detective? " << is_a<Detective>(watson) << endl;


    //now let's attend to the virtual keyword
    //the vitual keyword allows us as ask what an object would do in different contexts

    //here's watson: recall he is a Person and a Doctor, so we can put him in variables of those types
    Doctor docWatson = watson;
    Person perWatson = watson;

    //and now ask:
    cout << docWatson.title() << " Watson" << endl; // Dr. Watson
    cout << perWatson.title() << " Watson" << endl; // Mx. Watson


    //recall sherlock is a Detective and a Person
    Detective dtvSherlock = sherlock;
    Person perSherlock = sherlock;

    //and now ask:
    cout << dtvSherlock.title() << " Sherlock" << endl; // Detective Sherlock
    cout << perSherlock.title() << " Sherlock" << endl; // Mx. Sherlock


    // the very same object's title() gives different results in different contexts
    // when sherlock is placed in a variable of type Detective he respond's with the detective's title
    // when placed in a variable of type Person he respond's with person's title

    // the virtual keywords makes the call to the title function sensitive to the type of variable
    // the object finds itself in

    // this is the OO version of polymorphism: type-sensitive behaviour
    // since types are compiler information, polymorphism is a compiler action
    // that is, the compiler works out which particular implementation of title() you would like to call

    // title() 'has many forms' but most importantly, sherlock 'has many forms'
    // sherlock is polymorphic because it is able to act as-a-Person AND as-a-Detetive

    // recall:  the contents of variables do not have types!
    //... *variables* have types.  If you place the very same contents into a differnt context 
    // (ie. variable) you may get different results!
}


/* OUTPUT (notes/21.concepts-oop.cpp):
my balance is: 50
sherlock is a person? true
sherlock is a detective? true
sherlock is a doctor? false
watson is a person? true
watson is a doctor? true
watson is a detective? false
Dr.  Watson
Mx.  Watson
Detective Sherlock
Mx.  Sherlock

*/