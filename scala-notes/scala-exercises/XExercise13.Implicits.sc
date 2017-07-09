// CHAPTER:   IMPLICITS 
// PROBLEM:    
// TIME:       25 m


// PACKAGE OBJECT + IMPORT 


// IMPLICITS
trait Speaker {
  def speak(): Unit
}

case class Person(name: String)
case class Dog(name: String)

val taft = Person("Taft")
val spot = Dog("Spot")

implicit class DogSpeaker(d: Dog) extends Speaker {
    def speak() = println("Woof!")
}


implicit class PersonSpeaker(p: Person) extends Speaker {
    def speak() = println("Hi!")
}

def talkTo(speakers: List[Speaker]) {
    speakers foreach { (s: Speaker) => s.speak() }
}

talkTo(List(taft, spot))

// REVIEW: What did you learn from this exercise?