# MUTLTITASKING

""" NOVICE ASIDE:

Why do we use multitasking?

To break down problems so they can be solved in parralell, which is faster.
"""

# SIGNALS (to Processes)
import signal
import sys


def signal_handler(signal, frame):
    print('...quitting...')
    sys.exit(0)


signal.signal(signal.SIGINT, signal_handler)

# PROCESSES vs THREADS
# a PROCESS is a running program
# created by another program (frequently, the operating system)
# which can see everything its parent makes available (open files, current directory, environmental data)


# a THREAD is a processing unit *within* a program (eg. a function)
# which runs out-of-sync to the rest of the program (asychronously)

# THREADS ARE (usually) BAD
# very hard to think about out-of-order execution
# python has a GIL (global interpreter lock) that locks execution for 100 instructions
# theref. threading, in python, is best avoided

# almost everything can be solved with multiple processes
# AND multiple processes scale better across multiple systems (eg., in a cloud environment)


# now we have a test.py file...
TEST_SCRIPT = """
import sys
print('Hello from ', sys.argv)
"""

with open('test.py', 'w') as test:
    test.write(TEST_SCRIPT)

# subprocess module
import subprocess
import sys

# opening via shell
test_process = subprocess.Popen('python test.py', shell=True)  # ask bash to open python test.py
test_process.wait()  # daemon mode
print('The shell test process finished!\n')

# opening process
test_process = subprocess.Popen([sys.executable, 'test.py'])  # sys.executable is the python vm
test_process.wait()  # daemon mode
print('The sys exec test process finished!\n')

# communicating
test_process = subprocess.Popen([sys.executable, 'test.py', 'HI!!'], stdout=subprocess.PIPE)  # PIPE == memory
output, error = test_process.communicate()

print('The test process said', output)

# ASIDE: threads
import threading
import time


def task(thread_name):
    time.sleep(1)
    print('Hello from', thread_name, '\n')
    time.sleep(2)


fst = threading.Thread(target=task, args=('ThreadOne',))
snd = threading.Thread(target=task, args=('ThreadTwo',))

fst.start()
snd.start()

print('Afer fst snd start in...', __name__)

fst.join()  # wait untill done
snd.join()  # wait untill done... fst and snd will have been ticking async. by this point

print('After fst snd join...', __name__)

# multiprocess -- running functions as processes

import multiprocessing

def server_task():
    time.sleep(1)
    print('doing the server thing...\n')
    time.sleep(2)


def client_task():
    time.sleep(1)
    print('doing the client thing...\n')
    time.sleep(2)


svr = multiprocessing.Process(target=server_task)
clt = multiprocessing.Process(target=client_task)

svr.start()
clt.start()  # running async...

print('MULTIPROCESS: simple starts', __name__)

svr.join()
clt.join()  # re-syncing

# CLEANUP
import os
os.remove('test.py')  # clean up after ourselves


print('/MULTIPROCESS', __name__)


# EXTRA: socket library
import socket
import select

SERVER_ADDRESS = ('127.0.0.1', 10000)


def server(server_address=SERVER_ADDRESS):
    server_connection = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server_connection.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    server_connection.bind(server_address)
    server_connection.listen(1)

    clients = []
    while True:
        read_ready, _, _ = select.select([server_connection] + clients, [], [])

        for reader in read_ready:
            if reader is server_connection:
                clients.append(server_connection.accept()[0])
            else:
                message = reader.recv(1024).strip()
                if message:
                    print(message)


def client(client_name, server_address=SERVER_ADDRESS):
    server_connection = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server_connection.connect(server_address)

    while True:
        time.sleep(2)
        server_connection.send("Hello from {0}\n".format(client_name).encode())


svr = multiprocessing.Process(target=server)
clt1 = multiprocessing.Process(target=client, args=('Client1',))
clt2 = multiprocessing.Process(target=client, args=('Client2',))

svr.start()
clt1.start()  # running async...
clt2.start()  # running async...

print('MULTIPROCESS: after sever & client starts', __name__)

time.sleep(5)

svr.terminate()
clt1.terminate()  # running async...
clt2.terminate()  # running async...


''' OUTPUT (13.Multitasking/Demo13-06.Multitasking.py):
('Hello from ', ['test.py'])
Hello from  ['test.py']
The shell test process finished!

The sys exec test process finished!

The test process said b"Hello from  ['test.py', 'HI!!']\n"
Afer fst snd start in... __main__
Hello from ThreadOne 

Hello from ThreadTwo 

After fst snd join... __main__
doing the server thing...

doing the client thing...

MULTIPROCESS: simple starts __main__
/MULTIPROCESS __main__
MULTIPROCESS: after sever & client starts __main__

'''

