<!DOCTYPE html>
<html>
<head>
    <title>Car Randomizer</title>
    <style>

    </style>
</head>
<body>
    <form method="POST">
        Enter cars <input name="cars" type="text"/>
        <input type="submit"/>
    </form>

    <?php
        if (isset($_POST['cars']) && !empty($_POST['cars'])) :
            $carsList = $_POST['cars'];
            $cars = explode(", ", $carsList);

    ?>
    <table border="1">
        <thead>
            <tr>
                <td><strong>Car</strong></td>
                <td><strong>Color</strong></td>
                <td><strong>Count</strong></td>
            </tr>
        </thead>
    <?php
        $colors = ['red', 'yellow', 'blue', 'black', 'orange'];
        foreach ($cars as $car) :
            $count = rand(1, 5);
            $randColor = array_rand($colors);
    ?>
        <tr>
            <td><?=$car ?></td>
            <td><?= $colors[$randColor] ?></td>
            <td><?= $count ?></td>
        </tr>
    <?php endforeach; ?>
    </table>
    <?php
        endif;
    ?>
</body>
</html>