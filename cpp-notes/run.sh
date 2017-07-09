# unix (linux, mac)  only script...
# this script compiles & runs each notes file, 
# appending the output to the bottom of the original source .cpp

shopt -s nullglob dotglob  # mac requires a nudge to use *.cpp syntax

#for each cpp-file f in notes
for f in notes/*.cpp ; do
    echo "$f"

    # compile
    g++ "$f" -std=c++11     

    # remove OUTPUT+ lines
    sed -n '/OUTPUT/q;p' "$f" > temp && printf %s "$(cat temp)" > "$f" && rm temp
    
    # write output to end of file
    printf "\n\n\n/* OUTPUT ($f):\n" >> "$f"
    ./a.out >> "$f" && rm a.out             
    printf "\n*/" >> "$f"
done

echo
echo "building samples:"
sh samples/functional/run.sh
sh samples/oo/run.sh
sh samples/procedural/run.sh
