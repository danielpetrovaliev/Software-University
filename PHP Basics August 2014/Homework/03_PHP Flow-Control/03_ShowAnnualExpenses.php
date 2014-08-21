<?php
$currYear = date('Y');
$years = $_POST['years'];

?>

<!DOCTYPE html>
<html>
<head>
    <title>Show Annual Expenses</title>
    <meta charset="UTF-8"/>
</head>
<body>
    <form action="" method="post">
        <label for="years">Enter Number of years: </label>
        <input type="text" id="years" name="years"/>
        <input type="submit" value="Show costs"/>
    </form>

    <p>
        <table border="1">
            <thead>
                <tr>
                    <td><strong>Year</strong></td>
                    <td><strong>January</strong></td>
                    <td><strong>February</strong></td>
                    <td><strong>March</strong></td>
                    <td><strong>April</strong></td>
                    <td><strong>May</strong></td>
                    <td><strong>June</strong></td>
                    <td><strong>July</strong></td>
                    <td><strong>August</strong></td>
                    <td><strong>September</strong></td>
                    <td><strong>November</strong></td>
                    <td><strong>December</strong></td>
                    <td><strong>Total:</strong></td>
                </tr>
            </thead>
            <tbody>
                <?php $sum = 0; while($years > 0): ?>
                    <tr>
                        <td>
                            <?= $currYear ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $random = rand(1, 1000); $sum+= $random; ?>
                        </td>
                        <td>
                            <?= $sum ?>
                        </td>
                    </tr>
                <?php $years--; $sum = 0; $currYear--; endwhile; ?>
            </tbody>
        </table>
    </p>
</body>
</html>