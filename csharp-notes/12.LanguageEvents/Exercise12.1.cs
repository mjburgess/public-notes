/*
 * 
 * In this problem we're going to define a Room, Receptionist and a Cleaner
 * and connect the Room to the Receptionist and Cleaner via an event...
 * so that when a person enters a room the Receptionist and Cleaner are notified. 
 */


/* PART 1 -- Setting Up:
 
Q. define a class Room 

Q. give room a single public field 
    People which is a List<string> 

Q. define a class Receptionist

Q. define a class Cleaner


Q. give room two methods:
    a constructor to initialize People
    AddPerson which .Add()s to People
 
Q. add a *public* method RespondToEntrance to both Receptionist and Cleaner
        these just Console.WriteLine "Receptionist Sighs", "Cleaner Sighs"
*/


/* PART 2 -- Events:

Q. define the delegate type called Responder 
    which is a method that accepts no arguments & returns void

Q. add an event field of type Responder to Room
    called OnRegistration

Q. call OnRegistration (... in the right place...)
    HINT: in AddPerson


In Your Main method:

	Q. create a new Room called room205

	Q. create a Cleaner and a new Receptionist

	Q. register the cleaner's and receptionist's RespondToEntrance methods

	Q. add some people

*/



