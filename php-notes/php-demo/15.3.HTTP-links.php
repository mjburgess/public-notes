<!-- RUN THIS FILE via APACHE, ie. put it in htdocs and browse to localhost -->
<!DOCTYPE html>
<html>
<head>
    <title>Example Forms</title>
</head>
<body>

<h1>Information from the Url (Query String)</h1>
<!--
The url (in the address bar) can contain information sent by the browser,
to the webserver, and ultimately to PHP as it runs your script.


The information is present in the Query String... the part of the url after ?

as in,

http://www.example.com/index.php?name=Michael&balance=1000

or,

http://localhost/?profession=philosopher&position=Professor


These urls both include a question mark (?) followed by
name=value pairs, each separated by an ampersand (&).

This information, in its entirety, is known as the query string.
-->

<p><pre><?php print_r($_GET); ?></pre></p>

<!-- try adding a question mark & name-value pairs
on to the end of the address bar for this page -->

<!-- and try these... -->
<p>
	<a href="?name=Michael" /> A Link With a Query String </a>
</p>

<p>
	<a href="?name=Michael&age=27" /> with Name and Age </a>
</p>

<p>
	<a href="?name=Zeiss+Batis+18mm&price=1500" /> with some product information </a>
</p>

<p>
	<a href="?id=1&action=delete&article=Example"/> with some realistic information</a>
</p>

<!-- NB. a href with no url refers to the present page

so href="?x=y"  means the current url with ?x=y on the end

-->
</body>
</html>
