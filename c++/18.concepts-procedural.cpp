/*
INTERLUDE:  programming paradigms

The next set of concept notes forcus on comparing procedural and object oriented paradigms 
and the how important programming concepts play out in each (state, behaviour, type, identity, etc. ). 

The syntax will be revisited in further detail in subsequent chapters. 
It is more important that you get a general understanding of the concepts in play.

WHAT IS PROGRAMMING?

Rather than engineering programming should be compared to painting. 

The job of the programmer is to translate a scene (problem) into code (paint) using
a variety of techniques to rephrase the world into syntax. 

There are different styles of translation, as with painting, and two important ones are 
procedural programming and object-oriented programming. Both fit into the class of imperative programming. 

Imperative programming uses remembered data, or state, along with modifications to this memory 
in order to achive its effects. Like a potter who begins with a piece of clay and shapes it until it looks right. 

The key concepts in this paradigm are: state, behaviour, identity, equality and type. 
Using these concepts -- combined with the creative eye of the programmer -- we may represent a variety of problems. 

Procedural programming views each of these concepts one way, and object-oriented programming another. 
In particular object-oriented programming is a solution to the problems of state-change: in a complex problem
where memory is chaning in all sorts of ways we would really like to control this as much as possible. Much OO-ritual
revolves around providing this control. 

(Much better than OO's solution would in the first place to prevent state change, ie. 
to have all values be immutable. Pure functional programming takes this approach. ) 
*/


#include <iostream>
using namespace std;

int main(void) {
    cout << boolalpha; 

    //the foundations of imperative programming

    //1. STATE
    // state == remembred data == remembered configuration == the current state of affairs
    int x = 1;
    int y = 1;
    int z = 2;

    //state is used to describe facts  (of a problem):
    int numPeople = 10;
    string skyColour = "blue";          // each of these are *descriptions*

    //2. BEHAVIOUR ~= STATE CHANGE
    //behaviour == commands, ie. grammatical imperatives hence imperative programming

    x++; 	                           //state change == memory change == change of configuration
    cout << "x is " << x << endl;      // << is an operation on cout 
    
    numPeople++;                       // state change represents a "change in the facts"
                                       // ie., it is now true that there are 11 people

    //3. IDENTITY
    //identity  -- two variables are the same if they have the same value
    cout << "x is z: " << (x == z) << endl;
    cout << "y is x: " << (y == x) << endl;

    //identity conditions (the conditions underwhich x is y) help us establish which descriptions are true
    if(numPeople == 11) {
        cout << "there are 11 people" << endl;
    }

    //4. TYPES
    //types: determine valid operations, memory layout, etc. 
    int heightCm = 181;
    double heightM = 1.81;

    cout << "your height is " << heightCm << " cm or " << heightM << " m" << endl;

    // heightCm += 1.5; -- warning due to type 
    heightCm += int(1.5);  

    cout << "your height is " << heightCm << " cm or " << heightM << " m" << endl;


    // NOTE:
    // in C++ *variables* have types, not their contents: their contents are just bit-patterns in memory
    // typed variables are contexts for these bit patterns that the *compiler* uses 
    // types do not exist on the running machine 


    // types are used to enforce constraints on the evolution of the program 
    // the more exact the typing, the more likely that the program will follow predictable laws: 
    // eg. bool will only every be true or false, and so bool && bool will only ever be true or false
    // eg. string + string will be a string

    // we can create our own types with their own operations (structs and functions -- OR classes) 
    // and use these types to enforce ever-more detailed constraints 

    // there are other senses of 'typing' which are less clear: 
    // they were introduced in C mostly as "memory modes" -- C is a very weakly typed language
    // and doesnt really enforce manyt constraints

    // there is a lot of confusion amongst programmers about the purpose, meaning and use of types 
    // because many languages use the term 'type' to mean and to do somewhat differnt things. 

    // a reliable undestanding here is to treat typing as a system which is designed 
    // to make guarantees about the patterns variables will follow 
    
    return 0;
}


/* OUTPUT (notes/18.concepts-procedural.cpp):
x is 2
x is z: true
y is x: false
there are 11 people
your height is 181 cm or 1.81 m
your height is 182 cm or 1.81 m

*/