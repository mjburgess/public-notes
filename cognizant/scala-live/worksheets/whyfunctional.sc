
class Ingredients(var amount: Double) {

  def prep() = amount *= 2
  def mix()  = amount += 2
  def bake() = amount /= 2
}


val ingr = new Ingredients(100)
ingr.prep()
ingr.mix()
ingr.bake()

println(ingr.amount)

//functional

def prep(amount: Double) = amount * 2
def mix(amount: Double) = amount + 2
def bake(amount: Double) = amount / 2

val ingredients = 100
val prepd = prep(ingredients)
val mixed = mix(prepd)
val baked = bake(mixed)

println(baked)
println(bake(mix(prep(ingredients))))


