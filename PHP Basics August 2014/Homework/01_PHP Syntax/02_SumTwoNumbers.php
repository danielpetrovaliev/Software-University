<?php

function SumTwoNumbers($firstNumber, $secondNumber){
    echo "\$firstNumber + \$secondNumber = $firstNumber + $secondNumber  = " . round($firstNumber+$secondNumber, 2) . "<br />";
}

SumTwoNumbers(2, 5);
SumTwoNumbers(1.567808, 0.356);
SumTwoNumbers(1234.5678, 333);