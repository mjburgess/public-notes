#!/usr/bin/env bash
# unix (linux, mac)  only script...
# this script compiles & runs each notes file,
# appending the output to the bottom of the original source

shopt -s nullglob dotglob  # mac requires a nudge to use *.py syntax

#for each cpp-file f in notes
for f in **/*.py ; do
    echo "$f"

    # remove OUTPUT+ lines
    sed -n '/OUTPUT/q;p' "$f" > temp && printf %s "$(cat temp)" > "$f"

    python3 "$f" > temp

    # write output to end of file
    printf "\n\n\n''' OUTPUT ($f):\n" >> "$f"
    cat temp >> "$f"
    printf "\n'''\n" >> "$f"

    rm temp
done
