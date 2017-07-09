# CHAPTER 10: Libraries


# PART 1 -- TESTING

## WHY IS THIS IMPORTANT?: 
## 
## 

# MiniTest::Test and Test::Unit are commonly used
# MiniTest is a subset of Test, and is now preferred
# Create a subclass of MiniTest::Test
# Write methods starting test_ that call assertions
# A very large number of assertions are supplied

# "The first line in the file (require "minitest/autorun"),
# when evaluated, loads the MiniTest library
# and then calls MiniTest::Unit.autorun,
# which installs an at_exit hook
# – a block of code that will be run
# when this Ruby interpreter process starts to exit."
# - http://interblah.net/how-minitest-works
# see also http://www.mattsears.com/articles/2011/12/10/minitest-quick-reference/

#  gem install 'minitest' # from 2.2+

require 'minitest/autorun'

class Person
  attr_accessor :weight

  def initialize(weight=70)
    @weight = weight
  end

  def eat
    @weight += 0.1
  end
end


class TestPerson < MiniTest::Test
  def test_eating
    me = Person.new
    me.eat
    assert_equals me.weight, 70.1
  end
end


class SomethingTest < MiniTest::Unit::TestCase
  def setup
    @something = Object.new
  end

  def test_something
    refute_nil @something
  end

  def teardown
    @something = nil
  end
end



# PART 2 -- WEB

# reading web pages
require 'open-uri'

uri = 'http://www.qa.com/training-locations'

open(uri) do |fo|

  p fo.meta

  fo.each do |line|
    if line.index('<h3>') && line.index('training-locations')
      line.scan(/href="(.+?)">(.+?)<\/a>/) do |href, name|
       p href
       p name
      end
    end
  end
end


# parsing json

# uri = '...json'
# open(uri).readlines

users = JSON.parse('{"users": [
  {"name": "michael",  "location": "UK"},
  {"name": "sherlock", "location": "FR"}
]}')

p users['users'].map { |u| u['name'] }

# NET


require 'net/http'                  # The library we need
host = 'www.google.com'     # The web server
path = '/index.htm'                 # The file we want

http = Net::HTTP.new(host)          # Create a connection
headers, body = http.get(path)      # Request the file
if headers.code == "200"            # Check the status code
  print body
else
  puts "#{headers.code} #{headers.message}"
end


# TCPServer


require 'socket' # Provides TCPServer and TCPSocket classes

# Initialize a TCPServer object that will listen
# on localhost:2345 for incoming connections.
server = TCPServer.new('localhost', 2345)

# loop infinitely, processing one incoming
# connection at a time.
loop do

  # Wait until a client connects, then return a TCPSocket
  # that can be used in a similar fashion to other Ruby
  # I/O objects. (In fact, TCPSocket is a subclass of IO.)
  socket = server.accept

  # Read the first line of the request (the Request-Line)
  request = socket.gets

  # Log the request to the console for debugging
  STDERR.puts request

  response = "Hello World!\n"

  # We need to include the Content-Type and Content-Length headers
  # to let the client know the size and type of data
  # contained in the response. Note that HTTP is whitespace
  # sensitive, and expects each header line to end with CRLF (i.e. "\r\n")
  socket.print "HTTP/1.1 200 OK\r\n" +
                   "Content-Type: text/plain\r\n" +
                   "Content-Length: #{response.bytesize}\r\n" +
                   "Connection: close\r\n"

  # Print a blank line to separate the header from the response body,
  # as required by the protocol.
  socket.print "\r\n"

  # Print the actual response body, which is just "Hello World!\n"
  socket.print response

  # Close the socket, terminating the connection
  socket.close
end