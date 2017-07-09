# CHAPTER 10: Multitasking

## WHY IS THIS IMPORTANT?: 
## 
## 

# SIGNALS
Signal.trap('INT') { throw :sigint }

catch :sigint do
  while true
    p gets.chomp
  end
end

puts 'Just caught a SIGINT'

def shut_down
  puts "\nShutting down gracefully..."
  sleep 1
end

puts "I have PID #{Process.pid}"

# Trap ^C
Signal.trap("INT") {
  shut_down
  exit
}

# Trap Kill
Signal.trap("TERM") {
  shut_down
  exit
}

# PROCESSES VS THREADS

# process
# instance of a running program
# a container for thread(s)
# process ends when primary thread ends

# threads
# many threads / process

#ps., also, fibers
# fibers ~= generators are not related to multithreaded/multiprocess programming
# but can be used to break problems down into multiple parts


# PROCESSES

# blocking

puts `ls` # backticks create a child process
# stdout is captured

system 'ls' #stdout forwarded (printed) but not captured

# or with pipes,
pipe = IO.popen(["ls", "-lrt"], :err => [:child, :out])
pipe.each { |line| puts line }


# pipes are standard IO objects with usual read/write/puts/etc. methods
pipe.methods.sort

# ruby also supports non-blocking IO:  see IO#readpartial (IO#read_nonblock is similar).

# non-blocking

IO.write('test.rb', "p 10..20")

pid1 = spawn(RbConfig.ruby, "test.rb")

Dir.unlink('test.rb')

pid2 = spawn("ls")

Process.wait pid1
Process.wait pid2


# THREADS 
$count = 0
def increase_counter(num)
  val = $count + 1
  sleep 0.1
  puts "Thread #{num}, Count: #{$count}"
  $count = val
end

threads = 5.times.map {
    |i| Thread.new { increase_counter(i) }
}

puts "from main"
threads.each {
    |thr| thr.join
}
puts "final count: #{$count}"


# EXTRA: SOCKETS

require 'socket'      # Sockets are in standard library

hostname = 'localhost'
port = 2000

s = TCPSocket.open(hostname, port)

while line = s.gets   # Read lines from the socket
  puts line.chop      # And print with platform line terminator
end
s.close               # Close the socket when done


# web server

require 'socket'               # Get sockets from stdlib

server = TCPServer.open(2000)  # Socket to listen on port 2000    SERVER (vs socket)
loop {                         # Servers run forever
  client = server.accept       # Wait for a client to connect
  client.puts(Time.now.ctime)  # Send the time to the client
  client.puts "Closing the connection. Bye!"
  client.close                 # Disconnect from the client
}


# web browser

require 'socket'

host = 'www.tutorialspoint.com'     # The web server
port = 80                           # Default HTTP port
path = "/index.htm"                 # The file we want

# This is the HTTP request we send to fetch a file
request = "GET #{path} HTTP/1.0\r\n\r\n"

socket = TCPSocket.open(host,port)  # Connect to server
socket.print(request)               # Send request
response = socket.read              # Read complete response
# Split response at first blank line into headers and body
headers,body = response.split("\r\n\r\n", 2)
print body                          # And display it

