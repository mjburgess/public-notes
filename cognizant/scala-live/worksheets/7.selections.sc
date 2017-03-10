
val timeOfDay = "AM"

def sir(m: String) = m + ", Sir!"

println(sir(if(timeOfDay == "AM") {
  "Good Morning!"
} else if (timeOfDay == "PM") {
  "Good Afternoon!"
} else {
  "Good Day"
}))



if(timeOfDay == "AM") {
  println(sir("Good Morning!"))
} else if (timeOfDay == "PM") {
  println(sir("Good Afternoon!"))
} else {
  println("Good Day")
}


val name = "Taft"

val message = name match {
  case "Taft" => "Hello, Mr. President!"
  case "Holmes" => "Hello, Mr. Detective!"
  case _ => "Hi!"
}

println(message)









