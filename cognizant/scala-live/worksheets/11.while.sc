

var line = ""

while(line != "q") {
  line = scala.io.StdIn.readLine()

  if(line == "damn") {
    line = "q"
  } else {
    println(line)
  }
}