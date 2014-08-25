<?php

function DumpVariable($input){
    if (is_numeric($input)) {
        echo var_dump($input);
    } else if (!is_numeric($input)) {
       echo gettype($input) . "<br />";
    }
}

DumpVariable("hello");
DumpVariable(15);
DumpVariable(1.234);
DumpVariable(array(1, 2, 3));
DumpVariable((object)[2,34]);