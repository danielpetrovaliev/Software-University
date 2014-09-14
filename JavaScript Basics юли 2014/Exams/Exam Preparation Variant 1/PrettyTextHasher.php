<?php
$text = $_GET['text'];
$hashValue = $_GET['hashValue'];
$fontSize = $_GET['fontSize'];
$fontStyle = $_GET['fontStyle'];
$output = "";

if ($fontStyle == "normal" || $fontStyle == "italic"){
    $output = '<p style="font-size:' . "$fontSize;" . 'font-style:' . "$fontStyle;\">";
}
else if($fontStyle == "bold"){
    $output = '<p style="font-size:' . "$fontSize;" . 'font-weight:' . "$fontStyle;\">";
}

for ($i = 0; $i < strlen($text); $i++) {
	$letter = $text[$i];
    $hashValueChar = ord($letter);
    if ($i % 2 == 0) {
        $output .= chr($hashValueChar + $hashValue);
    }

    if ($i % 2 != 0) {
        $output .= chr($hashValueChar - $hashValue);
    }
}

$output.= "</p>";
echo "$output";
