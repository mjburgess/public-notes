<?php

echo "CODE INSIDE the IncludeMe file!\n";

const DEFAULT_USERNAME = 'Michael'; // recall constants: unchangable values

function show_username() {
  return DEFAULT_USERNAME;      //constants *can* be referred to inside functions
                                // because there nothing more than cut-and-paste

                                //recall: varaibles from outside functions cannot be used inside
                                // they have to be passed as a paramter at call-time
}
