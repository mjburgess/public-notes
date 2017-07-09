/*

PART 1 -- ABSTRACT CLASSES


Q. Define the abstract class Renderer
    with a public string Body 
    
    which contains two methods:
	 abstract string FormatBody()
	 public void Render()
	 
 
 The render method prints out FormatBody()
 
 
Q. define several children of Renderer: 
    HtmlRenderer, TextRenderer

    Each of which override FormatBody() :

 HtmlRenderer's FormatBody should 
    return <html><p>{Body}</p></html>

 TextRenderer's should 
    return -----\n {Body}\n ----\n
 

In Your Main Method:

Q. Create an array of Renders,

 Renderer[] rds = {
     new HtmlRenderer { Body = "Message" },
     new TextRenderer { Body = "Another Message"}
 };


 Loop over this array, render (print out) each message.




PART 2 -- INTERFACES
 
Q. Create an interface IRenderable with two methods:
    string FormatBody 
    void Render

Q. Define a class which implements this interface, ConsoleRenderer
    with both methods:
        FormatBody should be a virutal method, which just returns a public Body.
 
Q. Create a child of ConsoleRenderer, HtmlConsoleRenderer 
        which overrides FormatBody, returning <p>{Body}</p>
    and TextConsoleRenderer which  returns -----\n {Body}\n ----\n
       
In Your Main Method:

 IRenderable [] irds = {
     new HtmlConsoleRenderer { Body = "Message" },
     new TextConsoleRenderer { Body = "Another Message"}
 };

Q. Compare your solutions from PART1 and PART2 -- what's the difference?

    HINT: what would it mean to define a class BrowserRenderer : IRenderable ?
        Can you define a BrowserRenderer in the first case?
*/