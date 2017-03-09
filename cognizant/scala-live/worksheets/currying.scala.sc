
//def bake(fl: Int, sgr: Int) = fl + sgr

def bake(fl: Int)(sgr: Int) = fl + sgr

val bake100 = bake(100) _

bake100(200)
bake100(400)


def price(original: Double)(discount: Double => Double) = {
  discount(original * 2)
}


price(10) {
  _ * 0.3
}

List(2, 3, 4).map((x: Int) => x * 2)

// Q. with a list of names,
// use map and an _ to uppercase all the names

val names = List("Tom", "Jerry", "Fred")

names.map( _.toUpperCase )

names map { _.toUpperCase }




