/*
 * There are two relationships between objects:
 * 
 *  x has-a, is-made-from, composed-of y            COMPOSITION
 *  x has-many                                      AGGREGATION
 *  
 *  eg. a person is made from their limbs           C
 *      a room is composed of four walls            C
 *      a pen pot has many pens                     Ag
 *      a kennel has many dogs                      Ag
 *      
 *  There two relationships between an object and a type:
 *  
 *  x is-of-type Y, x belongs-to Y, x instaces Y    MEMBERSHIP
 *  x knows-about Y, x is-associated-with Y         ASSOCIATION
 *  
 *  eg. fido is of type Dog                         M
 *      fluffy is an example of a Cat               M
 *      michael belongs to the class User           M
 *      fido can chew his bone                      As
 *      fluddy can scratch her post                 As
 *      michael can annoy the delegates             As
 *            
 *  There are two relationships between types:
 *  
 *  X has-interface, implements, conforms-to Y      IMPLEMENTATION
 *  X inherits Y, X extends Y                       INHERITANCE
 *  
 *      in both cases X is-a Y, meaning every X object belongs-to Y
 *      with implmenetation Xs are Ys because they do-the-Y-thing
 *      with inhertiance Xs are Ys because Xs have everything Ys have 
 *     
 *  eg. 
 *      The TV is Switchable            Impl
 *      The Car is Drivable             Impl
 *      The Person is Talkable          Impl
 *      Humans are Animals              Inhr
 *      Cars are Vechicle               Inhr
 *      Every Biro is also a Pen        Inhr
 *      
 *      
 *  EXERCISE:
 *  
 *  Chose a common programming problem, 
 *      or problem from your daily life which could be solved by a program:
 * 
 *  (eg.  organizing music, 
 *      rating films, going to the cinema, travelling, etc.)
 *  
 *  Q. define various kinds of objects:
 *          for each, say what they HAVE (fields) 
 *          and what they CAN DO (methods)
 *          
 *  Q. consider how these objects could be related to each other.
 *  
 *  Q. Now, rather than defining one class for every object, 
 *      consider how you might define a parent class and a child class:
 *   
 *   eg., rather than having a single class for Worker, 
 *      have one for Person and one for Worker 
 *      so that a Worker inherits everything a Person also has
 *          
 *  Q. Now consider the cabilities of each object 
 *      and define interfaces that describe specific capabilities
 *    
 *   eg., a Person may do many things: they are an Eater, Walker, Talker, etc.
 *          define these Eater/Walker/Talker capabilities 
 *          
 *    
 */
  