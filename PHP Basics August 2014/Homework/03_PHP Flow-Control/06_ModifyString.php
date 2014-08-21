<?php
if (isset($_POST['input']) && isset($_POST['method'])) {
    $input = $_POST['input'];
    $method = $_POST['method'];
    $output = "";

    /*Check palindrome*/
    if ($method == "CheckPalindrome") {
        $isPalindrome = false;
        $rightCharCounter = strlen($input)-1;
        for ($j = 0; $j < strlen($input)/2; $j++) {
            if ($input[$j] === $input[$rightCharCounter]) {
                $isPalindrome = true;
            }
            if (!$isPalindrome) {
                break;
            }
            $rightCharCounter--;
        }
        if ($isPalindrome) {
            $output = "$input is palindrome!";
        } else {
            $output = "$input is not a palindrome!";
        }
    }

    /*Reverse string*/
    else if ($method == "ReverseString") {
        $output = strrev($input);
    }

    /*Split*/
    else if ($method == "Split") {
        $words = [];
        for ($i = 0; $i < strlen($input); $i++) {
        	if ($input[$i] == "" || $input[$i] == " ") {
                continue;
            } else {
                $words[] = $input[$i];
            }
        }
        $output = implode(" ", $words);
    }

    /*Hash String*/
    else if ($method == "HashString") {
        $output = crypt($input);
    }

    /*Shuffle String*/
    else if ($method == "ShuffleString") {
        $output = str_shuffle($input);
    }
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Modify String</title>
    <meta charset="UTF-8"/>
</head>
<body>
<form method="post">
    <input type="text" name="input"/>
    <input id="checkPalindrome" name="method" value="CheckPalindrome" type="radio"/>
    <label for="checkPalindrome">Check Palindrome</label>
    <input type="radio" name="method" id="reverseString" value="ReverseString"/>
    <label for="reverseString">Reverse String</label>
    <input type="radio" name="method" id="split" value="Split"/>
    <label for="split">Split</label>
    <input type="radio" name="method" id="hashString" value="HashString"/>
    <label for="hashString">Hash String</label>
    <input type="radio" name="method" id="shuffleString" value="ShuffleString"/>
    <label for="shuffleString">Shuffle String</label>
    <input type="submit" value="Submit"/>
</form>
<p>
    <?php if(isset($output)): ?>
    <?= htmlentities($output) ?>
    <?php endif; ?>
</p>
</body>
</html>