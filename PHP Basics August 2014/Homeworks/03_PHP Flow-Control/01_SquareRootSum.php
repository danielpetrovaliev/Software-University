<?php

    for ($i = 0; $i < 100; $i++) :

    endfor;
?>

<!DOCTYPE html>
<html>
<head>
    <title>Square Root Sum</title>
    <meta charset="UTF-8"/>
</head>
<body>
<table border="1">
    <thead>
        <tr>
            <td><strong>Number</strong></td>
            <td><strong>Square</strong></td>
        </tr>
    </thead>

    <?php
    $sum = 0;
    for ($i = 0; $i <= 100; $i+=2) :
        $sum += sqrt($i);
    ?>

        <tr>
            <td><?= $i ?></td>
            <td><?= round(sqrt($i), 2) ?></td>
        </tr>
    <?php endfor; ?>

    <tfoot>
        <tr>
            <td><strong>Total:</strong></td>
            <td><?= round($sum, 2) ?></td>
        </tr>
    </tfoot>
</table>
</body>
</html>