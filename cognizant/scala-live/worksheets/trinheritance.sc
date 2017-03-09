
trait Mover {
  def move = println("Moving")
}
trait Walker extends Mover {
  override def move = { println("Walk"); super.move }
}
trait Flyer extends Mover {
  override def move = { println("Flying"); super.move }
}
trait Runner extends Mover {
  override def move = { println("Runs"); super.move }
}
trait Sprinter extends Runner {
  override def move = { println("Sprint"); super.move }
}

class FastBird extends Walker with Flyer with Sprinter

(new FastBird).move
