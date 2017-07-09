# run from parent directory, ie.  sh samples/procedural/run.sh

echo "compiling procedural/Main.cpp"
#compile
g++ "samples/procedural/Main.cpp" "samples/procedural/LibA.cpp" 

f="samples/procedural/Main.cpp"

# remove OUTPUT+ lines
sed -n '/OUTPUT/q;p' "$f" > temp && printf %s "$(cat temp)" > "$f" && rm temp

# write output to end of file
printf "\n\n\n/* OUTPUT ($f):\n" >> "$f"
./a.out >> "$f" && rm a.out             
printf "\n*/" >> "$f"