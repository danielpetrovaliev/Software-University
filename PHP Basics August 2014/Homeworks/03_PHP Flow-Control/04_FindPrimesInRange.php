<?php
function isPrime($num) {

    if($num == 1)
        return false;

    if($num == 2)
        return true;

    if($num % 2 == 0) {
        return false;
    }

    for($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2) {
        if($num % $i == 0)
            return false;
    }

    return true;
}
if (isset($_POST['start']) && isset($_POST['end'])) {
    $start = $_POST['start'];
    $end = $_POST['end'];
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Square Root Sum</title>
    <meta charset="UTF-8"/>
</head>
<body>
<form method="post">
    <label for="startIndex">Starting Index: </label>
    <input type="text" id="startIndex" name="start"/>
    <label for="endIndex">End: </label>
    <input type="text" id="endIndex" name="end"/>
    <input type="submit" value="Submit"/>
</form>
<p>
    <?php for($i = $start; $i <= $end; $i++): ?>
            <?php if (isPrime($i)): ?><strong><?= $i ?></strong><?php endif; ?><?php if(!isPrime($i)): ?><?= $i ?><?php endif; ?><?php if($i <$end): ?>, <?php endif; ?>
    <?php endfor; ?>
</p>
</body>
</html>