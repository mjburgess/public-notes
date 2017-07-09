// CHAPTER:   8. OBJECT ORIENTATION
// OBJECTIVE: Answer the following questions.
// PROBLEM:   Manage item discounts at a store.
// TIME:      10 * 3 m

// CLASSES AND CONSTRUCTORS
// Q. define a Item class with properties: name and rrp
class Item(val name: String, val rrp: Double)

// Q. define a ReducedItem class with properties: name, rrp, discount
//.. give ReducedItem a secondary constructor with a default discount of
// 0.1 * rrp
class ReducedItem(val name: String, val rrp: Double, val discount: Double) {
  def this(name: String, rrp: Double) = this(name, rrp, 0.1 * rrp)

  def price = this.rrp - this.discount
}

//Q. add a price method which returns the rrp - discount

// Q. create a ReducedItem and print out its price
val myItem = new ReducedItem("Cheap Toy", 100)
println(myItem.price)


// OBJECTS
// Q. define a DiscountRates object
//.. give it christmas, easter and summer vals with 0.1, 0.2, 0.3 respectively
object DiscountRates {
  val christmas = 0.1
  val easter = 0.2
  val summer = 0.3
}


// Q. create a List of ReducedItems (a basket)
//.. it should contain reduced items made with the default constructor,
//.. the secondary constructor, and using DiscountRates
val basket = List(
  new ReducedItem("A", 10, 5),
  new ReducedItem("B", 10),
  new ReducedItem("C", 20, DiscountRates.summer)
)

// Q. calculate the total of the basket
var total = 0.0

for(item <- basket) {
  total += item.price
}

println(total)

//OR,
println(basket.foldLeft(0) { _ + _.price })

// Q. define a Teddy class and a Teddy object
// the Teddy object should have val numEyes = 2
// the Teddy class' constructor should accept an eyes
// the object's apply() method should creat a new Teddy
// using Teddy.numEyes as a default

//Q. create a Teddy and print out its number of eyes
class Teddy(val numEyes: Int)

object Teddy {
  val numEyes = 2
  def apply() = new Teddy(Teddy.numEyes)
}

//Q. create a Teddy and print out its number of eyes
val fido = Teddy()
println(fido.numEyes)


// CASE CLASSES 
// Q. define a case class Customer with a name and age 
// Q. create two people me, and you 
case class Customer(val name: String, val age: Int)

val me  = Customer("Me", 27)
val you = Customer("You", 30)

// Q. define a method called printCustomer that accepts a Customer as an argument
// it should extract and print the name and age 
// HINT: match
def printCustomer(p: Customer) = p match {
  case Customer(name, age) => println(s"$name is $age")
}

// Q. use printCustomer with me and you
printCustomer(me)
printCustomer(you)

// REVIEW: What did you learn from this exercise?