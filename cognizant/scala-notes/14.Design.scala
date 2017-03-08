// CHAPTER 14:  THE DESIGN OF FUNCTIONAL APPLICATIONS 
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// IMMUTABILITY 


class Person(var weight: Double) {
    def eat() = this.weight += 1
    def run() = this.weight *= 0.99
    def wearBelt(): Boolean = this.weight < 100  
}

val me = new Person(100) 
me.eat()
me.eat()
me.run()
me.eat()

println(if(me.wearBelt) { "It fits!" } else { "It hurts!" })

me.run()
me.run()

println(if(me.wearBelt) { "It fits!" } else { "It hurts!" })        // why on earth does this change?




// all data flow is made explicit
class Human(val weight: Double)  {
    def eat() = new Human(this.weight + 1)
    def run() = new Human(this.weight * 0.99)
    def wearBelt(): Boolean = this.weight < 100  
}


val me = new Human(100)

println(if(me.eat().eat().run().eat().wearBelt) { "It fits!" } else { "It hurts!" })        // I see that me is transformed differently
println(if(me.run().run().eat().wearBelt) { "It fits!" } else { "It hurts!" }) 




// MONIDS

// MONADS 

// CAKE PATTERN 

// DSLs 

// (APPLICATIVES, etc. )