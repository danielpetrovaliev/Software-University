<?php
$text = $_GET['text'];

$buffer = "";
$newText = '';

for ($i = 0; $i < strlen($text); $i++) {
	$ch = $text[$i];

    if (ctype_alpha($ch)) {
        $buffer.= $ch;
    } else {
        $newText .= processWord($buffer);
        $buffer = '';
        $newText .= $ch;
    }
}
$newText .= processWord($buffer);


echo "<p>" . htmlspecialchars($newText) . "</p>";



function processWord($word){
    if (ctype_upper($word)) {
        $reversed = strrev($word);
        if ($word == $reversed) {
            return doubleWord($word);
        }
        else{
            return $reversed;
        }
    }
    return $word;
}


function doubleWord($word){
    $result = '';
    for ($i = 0; $i < strlen($word); $i++) {
    	$result .= $word[$i] . $word[$i];
    }
    return $result;

}
