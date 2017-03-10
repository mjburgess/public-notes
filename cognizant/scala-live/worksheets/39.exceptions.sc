import java.io.IOError

import scala.util.{Failure, Success, Try}

def broken() = throw new Exception("Error!")

try {
  broken()
} catch {
  case io: IOError => println("HISLDK!")
  case e: Exception => print(e.getMessage)
}

def wrap() = Try {
  broken()
}

wrap() match {
  case Success(v) => println("Successful!")
  case Failure(e) => println("HSDH")
}

/*
for(x <- throws();
    y <- throws(y);
    z <- throws(z)) yield connect(x, y, z)
*/