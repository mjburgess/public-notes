import scala.util._

def getWebPage(url: String, pin: Int) =
  if(pin == 1234) {
    Success(url)
  } else {
    Failure(new Exception("Couldn't get webpage!"))
  }

def getUsername(name: String, pin: Int) =
  if(pin == 1234) {
    Success(name)
  } else {
    Failure(new Exception("Couldn't get user!"))
  }


val result = for(user <- getUsername("Michael", 134);
                 page <- getWebPage("GOOGLE", 124) ) yield user + page

println(result)


//always defer logging to the last possible point!
// In scala 2.12, you may use Either[A, B]

/*


def getWebPage(url: String, pin: Int) =
  if(pin == 1234) {
    Right(url)
  } else {
    Left("Couldn't get webpage!")
  }

def getUsername(name: String, pin: Int) =
  if(pin == 1234) {
    Right(name)
  } else {
    Left("Couldn't get user!")
  }


val result = for(user <- getUsername("Michael", 1234);
                 page <- getWebPage("GOOGLE", 1234) ) yield user + page

println(result)


 */