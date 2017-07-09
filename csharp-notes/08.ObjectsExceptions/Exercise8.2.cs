/*
Q. Define a static method called GetTransactionValue()
    the method should return an int by asking the user (Console.ReadLine()) 
    for a transaction value and int.Parse()ing that number.

    This process can fail in two important ways, with a:   
        FormatException
        OverflowException
  
    Handle the formatting error by either:
    
    a) SIMPLE OPTION: returning 0
    
    b) ADVANCED OPTION:
        asking the user again for a number,
            (ie., return & call your own method again, GetTransactionValue()) 

    Handle the overflow error by returning int.MaxValue

 In the Main Method of Your Program:

Q. Console.WriteLine(GetTransactionValue())

Q. Modify the defintion of GetTransactionValue to accept an int scale 
    and return scale * the result
    
Q. Define a new exception BadScaleError and throw this if the scale is < 2

    HINT: BadScaleError : System.Exception  

 Q. Now Console.WriteLine(GetTransactionValue(1))
    & Handle the BadScale Error

*/