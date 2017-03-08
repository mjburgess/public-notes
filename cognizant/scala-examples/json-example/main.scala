// import net.liftweb.json.DefaultFormats
// import net.liftweb.json._

import org.json4s._
import org.json4s.native.JsonMethods._




case class EmailAccount( 
    accountName: String, 
    url: String, 
    username: String, 
    password: String, 
    usersOfInterest: List[String]
)

object ParseJsonArray extends App {
val JSON_STRING = """{
    "accounts": [
        { "emailAccount": {
        "accountName": "YMail",
        "username": "USERNAME",
        "password": "PASSWORD",
        "url": "imap.yahoo.com",
        "usersOfInterest": ["barney", "betty", "wilma"]
        } },

        { "emailAccount": {
        "accountName": "Gmail",
        "username": "USER",
        "password": "PASS",
        "url": "imap.gmail.com",
        "usersOfInterest": ["pebbles", "bam-bam"]
        } }
    ]
}
"""


    implicit val formats = DefaultFormats
    val json = parse(JSON_STRING)
    val elements = (json \\ "emailAccount").children map { _.extract[EmailAccount] }
    
    println(elements)
}

