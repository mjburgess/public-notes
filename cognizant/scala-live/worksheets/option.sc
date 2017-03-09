

val x: Any = 1
val y: Any = "String"

val emptyM: Option[String] = None
val message: Option[String] = Some("Hello")


for(mesg <- message) println(mesg)



for(mesg <- emptyM) println(mesg)


println(emptyM map { _.toUpperCase })
println(message map { _.toUpperCase })