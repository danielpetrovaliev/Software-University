<?php
$input = [];
if (isset($_POST['input'])) {
    $input = explode(", ",$_POST['input']);
}
function SumDigits($number)
{
    $sum = 0;
    for ($i = 0; $i < strlen($number); $i++) {
        $sum += intval($number[$i]);
        if (!is_numeric($number[$i])) {
            return "I cannot sum that";
        }
    }

    return $sum;
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Square Root Sum</title>
    <meta charset="UTF-8"/>
</head>
<body>
<form action="" method="post">
    <label for="input">Input string: </label>
    <input type="text" id="input" name="input"/>
    <input type="submit" value="Submit"/>
</form>
<?php if(isset($_POST['input'])): ?>
    <table border="1">
        <?php foreach ($input as $number): ?>
            <tr>
                <td><?= $number ?></td>
                <td><?= SumDigits($number) ?></td>
            </tr>
        <?php endforeach; ?>
    </table>
<?php endif; ?>
</body>
</html>