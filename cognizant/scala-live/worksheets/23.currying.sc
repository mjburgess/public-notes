

def config(host: String, user: String, pwd: Int) = println(host, user, pwd)


def cconfig(host: String)(user: String)(pwd: Int) = println(host, user, pwd)


config("US", "Cog", 1234)

val cUS = cconfig("US") _

cUS("TEST")(3456)
cUS("testing")(89)



val configUK = (u: String, p: Int) => config("US", u, p)

//val conf = (u: String) => (p: Int) => config(u, p)

/*
function config(u, p) {
  return function (p) {
    config("US", u, p)
  }
}
*/





def transform(xs: List[Int], f: Int => Int) = xs map f


transform(List(1,2,3), { _ * 10 })



def ctransform(xs: List[Int])(f: Int => Int) = xs map f


ctransform(List(2, 4, 6))  {
    _ * 10
  }



