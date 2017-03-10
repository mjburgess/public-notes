
val pets: List[List[String]] = List(
  List("Fido", "Fluffy", "Spot"),
  List("Paul", "Henry", "Jeff")
)


for (
  ps <- pets
) println(ps(0), ps(1), ps(2))


for (
  ps <- pets;
  a <- ps
) println(a)


val names = for (
  ps <- pets;
  a <- ps;
  if a(0) == 'F'
) yield a.toUpperCase


println(names)