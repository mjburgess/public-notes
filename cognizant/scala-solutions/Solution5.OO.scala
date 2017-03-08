
// Q. define a Item class with properties: name and rrp

class Item(val name: String, val rrp: Double)

// Q. define a ReducedItem with properties: name, rrp, discount
//.. give ReducedItem a secondary constructor with a default discount of
// 0.1 * rrp

class ReducedItem(val name: String, val rrp: Double, val discount: Double) {
    def this(name: String, rrp: Double) = this(name, rrp, 0.1 * rrp)
}

// Q. define a DiscountRates object
//.. give it christmas, easter and summer vals with 0.1, 0.2, 0.3 respectively

object DiscountRates {
    val christmas = 0.1
    val easter = 0.2
    val summer = 0.3
}

// Q. create a List of ReducedItems (a basket) and caluclate the total
//.. it should contain reduced items made with the default constructor,
//..the secondary, and pass'd a val from DiscountRates

val basket = List(
    new ReducedItem("A", 10, 5),
    new ReducedItem("B", 10),
    new ReducedItem("C", 20, DiscountRates.summer)
)

var total = 0.0

for(item <- basket) {
    total += item.rrp - item.discount
}

println(total)

// println(
//  basket map { b => b.rrp - b.discount } reduce { _ + _ }
//)
