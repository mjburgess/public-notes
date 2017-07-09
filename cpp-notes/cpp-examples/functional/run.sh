# run from parent directory, ie.  sh samples/functional/run.sh

echo "compiling functional/Main.cpp"

#compile
g++ samples/functional/Main.cpp samples/functional/Calculator.cpp -std=c++11 -stdlib=libc++


f="samples/functional/Main.cpp"

# remove OUTPUT+ lines
sed -n '/OUTPUT/q;p' "$f" > temp && printf %s "$(cat temp)" > "$f" && rm temp

# write output to end of file
printf "\n\n\n/* OUTPUT ($f):\n" >> "$f"
./a.out >> "$f" && rm a.out             
printf "\n*/" >> "$f"