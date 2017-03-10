
//1. everything is an object
3 + 2

"Michael" + " Burgess"

3.+(2)

"Michael".+("Burgess")

//2. syntax is an expression where  possible

val x = 2 + 2

2 + 2 * 3

println("Hello")


// val OUTPUT  = f(g(h(i(j(k(INPUT))))))

val age  = 27

val message = if(age > 18) {
  "ALLOWED"
} else {
  "DENIED"
}


println(message)


//3. properties of objects

val name = "Jefferson"

name.concat(", Thomas")
name

name.getClass.getSimpleName

name.getClass.getMethods map { _.getName }





















