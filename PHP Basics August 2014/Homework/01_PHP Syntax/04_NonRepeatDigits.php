<?php

function NonRepeatDigits($input){
    $nonRepeatNumbers = [];
    for ($i = 100; $i <= $input; $i++) {
        if ($i > 999) {
            break;
        } if ( (strval($i)[0] != strval($i)[1]) &&
            (strval($i)[1] != strval($i)[2]) &&
            (strval($i)[2]) != strval($i)[0] ) {
            $nonRepeatNumbers[] = $i;
        }

    }
    if (count($nonRepeatNumbers) === 0) {
        $allNumbers = "no";
    } else {
        $allNumbers = implode(", ", $nonRepeatNumbers);
    }

    echo $allNumbers . "<br />" . "<br />";
    
}

NonRepeatDigits(1234);
NonRepeatDigits(145);
NonRepeatDigits(15);
NonRepeatDigits(247);