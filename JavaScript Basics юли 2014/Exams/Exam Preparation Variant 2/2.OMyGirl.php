<?php

$text = $_GET['text'];
$key = $_GET['key'];



if (!ctype_digit($key[0]) && !ctype_alpha($key[0])) {
    $patternKey = "\\" . $key[0];
} else {
    $patternKey = $key[0];
}

//Generate regex
for ($i = 1; $i < strlen($key)-1; $i++) {
    if (ctype_digit($key[$i])) {
        $patternKey .= '\d*';
    } elseif (ctype_lower($key[$i])) {
        $patternKey .= '[a-z]*';
    } elseif(ctype_upper($key[$i])){
        $patternKey .= '[A-Z]*';
    } else {
        $patternKey .= '\\' . "$key[$i]";
    }
}

if (!ctype_digit($key[strlen($key) - 1]) && !ctype_alpha($key[strlen($key) - 1]) ) {
    $patternKey .= "\\" . $key[strlen($key) - 1];
} else{
    $patternKey .= $key[strlen($key) - 1];
}

//Concate add groups
$pattern = "/".$patternKey .'(.{2,6})'. $patternKey."/";

preg_match_all($pattern, $text, $matches);

$adress = implode("" ,$matches[1]);

echo $adress;