<?php

$mainWordInput = $_GET['mainWord'];
$wordsInput  = $_GET['words'];
$words = json_decode($wordsInput);


$mainWordObj = json_decode($mainWordInput);
preg_match('/\d+/', key($mainWordObj), $rowMainWord);
$rowMainWord = $rowMainWord[0];
$mainWordArr = (array)$mainWordObj;
$mainWord = $mainWordArr[key($mainWordObj)];

$tempRow = array_fill(0, strlen($mainWord), "");
for ($col = 0; $col < strlen($mainWord); $col++) {
    $board[] = $tempRow;
    if ($rowMainWord-1 == $col) {
        $board[$col] = str_split($mainWord);
    }
}

usort($words, function ($a, $b){
    return strlen($b) -strlen($a);
});


$tableSize = strlen($mainWord);
$topRow = $rowMainWord -1;
$bottomRow = $tableSize - $rowMainWord;
$targetWord = "";


foreach ($words as $word) {
    $wordLen = strlen($word);

    for ($col = 0; $col < $tableSize; $col++) {
    	for ($wordIndex = 0; $wordIndex < $wordLen; $wordIndex++) {
    		if ($mainWord[$col] == $word[$wordIndex]) {
                $topLen = $wordIndex;
                $bottomLen = $wordLen - $wordIndex -1;
                if ($topLen <= $topRow && $bottomLen <= $bottomRow) {
                    $targetWord = $word;
                    $targetCol = $col;
                    $targetRow = $topRow - $topLen;
                    break;
                }
            }
    	}
        if (isset($targetWord)) {
            break;
        }
    }

    if (isset($targetWord)) {
        break;
    }
}

for ($row = $targetRow; $row < strlen($targetWord) + $targetRow; $row++) {
	$board[$row][$targetCol] = $targetWord[$row];
}

foreach ($words as $word) {
    if ($word != $targetRow) {
        $result[$word];
    }
}


$corssPoints = [];


var_dump($board);