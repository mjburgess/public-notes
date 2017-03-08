
def show_next_age(): Unit = {
  var a = 26
  a += 1
  println(a)
}


class Person(val age: Int) {
  def grow_older(): Person = {
    new Person(age + 1)
  }

  def describe(): Unit = {
    println(age)
  }
}

var me = new Person(26)

val meLater = me.grow_older()
me.describe()
meLater.describe()

