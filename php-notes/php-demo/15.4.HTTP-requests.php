<?php

// the following request is sent by the browser, to the webserver, when clinking on a link
// or visiting a url via the address bar

/*
GET /index.php?name=Michael&age=27 HTTP/1.1
Host: localhost
Connection: keep-alive
Cache-Control: max-age=0
Upgrade-Insecure-Requests: 1
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36
Accept: text/html,application/xhtml+xml,application/xml
Accept-Encoding: gzip, deflate, sdch
Accept-Language: en-US,en;q=0.8,en-GB;q=0.6
*/


// it is known as a GET request -- and just means "get me a resource"
// where url means "uniform resource locator"
// and resource, in this case, just means a web page

// the first line determines the type of the request (GET) and it's language (HTTP version 1.1)
// every other line is known as a "header" -- they come in key-value pairs

// the Host header tells the webserver which domain you were requesting
// the User-Agent header tells the webserver which browser you were using
// the Accept header says what kind markup languages the browser can read (html,...)




// here is the reply the webserver sends to the request above
// it is a 200 OK *HTTP Response*

/*
HTTP/1.1 200 OK
Date: Thu, 18 Aug 2016 18:34:07 GMT
Server: Apache/2.4.18 (Win32) OpenSSL/1.0.2e PHP/7.0.8
X-Powered-By: PHP/7.0.8
Content-Length: 12
Keep-Alive: timeout=5, max=100
Connection: Keep-Alive
Content-Type: text/html; charset=UTF-8
Array
(
    [name] => Michael
    [age] => 27
)

*/



// the first line determines the type of response (200 OK, or for example, 404 NOT FOUND)
// every other line, *until the "request body" at the end* is a header

// Date tells you the date the response was sent (according to the server)
// Content-Length tells the browser how much content has been sent (~ the size of the HTML page)
// Content-Type tells the browser what kind of content the page has, here it says it's html

// finally, after all the headers, there is the response-body or the content
// which is, in this case, the output of a PHP script

// it's the response body which the browser displays




//finally, a POST *request*
// this is sent by the browser when you click a submit button on a form

/*

POST /index.php HTTP/1.1
Host: localhost
Connection: keep-alive
Content-Length: 109
Cache-Control: max-age=0
Origin: http://localhost
Upgrade-Insecure-Requests: 1
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36
Content-Type: application/x-www-form-urlencoded
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp;q=0.8
Referer: http://localhost/
Accept-Encoding: gzip, deflate
Accept-Language: en-US,en;q=0.8,en-GB;q=0.6

first_name=&last_name=mjburgess&password=password&description=&size=s&extra_information=this+is+an+example%21
*/


// thus the browser typically sends either a GET request or a POST request
// a POST request when you've submitted a form
// a GET request when you've clicked on a link, or typed it in the address bar


// in the POST request the browser has extra information to send along, namely, the contents of the form
// it attached this information at the end of the request in the *request body*

// this information is formatted in the same way a query string is,
// ie, name=michael&age=27&location=UK


// POST request bodies can be much larger than URLs though
// so you can send more information in a form than you would be able to in a url
// for example, a blog article
