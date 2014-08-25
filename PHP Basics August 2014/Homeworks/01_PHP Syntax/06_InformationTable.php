<?php
$firstInput = ['Gosho', '0882-321-423', '24', 'Hadji Dimitar'];
$secondInput = ['Pesho', '0884-888-888', '67', 'Suhata Reka'];
?>

<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="06_InformationTable.css"/>
    <title>Information Table</title>
</head>
<body>
<table border="1">
    <thead>
        <tr>
            <td>Name</td>
            <td><?php echo $firstInput[0]; ?></td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Phone number</td>
            <td><?php echo $firstInput[1]; ?></td>
        </tr>
        <tr>
            <td>Age</td>
            <td><?php echo $firstInput[2]; ?></td>
        </tr>
        <tr>
            <td>Address</td>
            <td><?php echo $firstInput[3]; ?></td>
        </tr>
    </tbody>
</table>
<table border="1">
    <thead>
    <tr>
        <td>Name</td>
        <td><?php echo $secondInput[0]; ?></td>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>Phone number</td>
        <td><?php echo $secondInput[1]; ?></td>
    </tr>
    <tr>
        <td>Age</td>
        <td><?php echo $secondInput[2]; ?></td>
    </tr>
    <tr>
        <td>Address</td>
        <td><?php echo $secondInput[3]; ?></td>
    </tr>
    </tbody>
</table>
</body>
</html>