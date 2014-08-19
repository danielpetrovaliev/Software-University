<?php
$fName = $_POST['fName'];
$lName = $_POST['lName'];
$email = $_POST['email'];
$pNumber = $_POST['pNumber'];
$gender = $_POST['gender'];
$bDate = $_POST['bDate'];
$nationality = $_POST['nationality'];
$companyName = $_POST['companyName'];
$fromDate = $_POST['fromDate'];
$toDate = $_POST['toDate'];

$progLangs = $_POST['progLangs'];
$progSkillLevels = $_POST['progSkillLevels'];

$otherSkillLangs = $_POST['otherLangs'];
$otherSkillComprehensionLevels = $_POST['comprehensionLevels'];
$otherSkillReadingLevels = $_POST['readingLevels'];
$otherSkillWritingLevels = $_POST['writingLevels'];
$otherSkillDriveLicenseList = $_POST['driveLicense'];


?>

<!DOCTYPE html>
<html>
<head>
    <title>Generated CV</title>
    <meta charset="utf-8"/>
    <style>
        table thead tr td{
            text-align: center;
        }
    </style>
</head>
<body>
    <h1>CV</h1>
    <table border="1">
        <thead>
            <tr>
                <td colspan="2">
                    <strong>Personal Information</strong>
                </td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>First Name</td>
                <td><?= $fName ?></td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td><?= $lName ?></td>
            </tr>
            <tr>
                <td>Email</td>
                <td><?= $email ?></td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td><?= $pNumber ?></td>
            </tr>
            <tr>
                <td>Gender</td>
                <td><?= $gender ?></td>
            </tr>
            <tr>
                <td>Birth Date</td>
                <td><?= $bDate ?></td>
            </tr>
            <tr>
                <td>Nationality</td>
                <td><?= $nationality ?></td>
            </tr>
        </tbody>
    </table>
    <br/>
    <table border="1">
        <thead>
            <tr>
                <td colspan="2">
                    <strong>Last Work Position</strong>
                </td>
            </tr>
        </thead>
        <tbody>
        <tr>
            <td>Company Name</td>
            <td><?= $companyName ?></td>
        </tr>
        <tr>
            <td>From</td>
            <td><?= $fromDate ?></td>
        </tr>
        <tr>
            <td>To</td>
            <td><?= $toDate ?></td>
        </tr>
        </tbody>
    </table>
    <br/>

    <!--Computer Skills-->
    <table border="1">
        <thead>
            <tr>
                <td colspan="4"><strong>Computer Skills</strong></td>
            </tr>
            <tr>
                <td colspan="2">Programing Languages</td>
                <td>
                    <table border="1">
                        <thead>
                            <tr>
                                <td>
                                    <strong>Language</strong>
                                </td>
                                <td>
                                    <strong>Skill Level</strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody>
                        <?php for($i = 0; $i < count($progLangs); $i++) : ?>
                            <tr>
                                <td><?= $progLangs[$i] ?></td>
                                <td><?= $progSkillLevels[$i] ?></td>
                            </tr>
                        <?php endfor; ?>
                        </tbody>
                    </table>
                </td>
            </tr>
        </thead>
    </table>
    <br/>

    <!--Other Skills-->
    <table border="1">
        <thead>
            <tr>
                <td colspan="5">
                    <strong>Other Skills</strong>
                </td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Languages</td>
                <td>
                    <table border="1">
                        <thead>
                            <tr>
                                <td>
                                    <strong>Language</strong>
                                </td>
                                <td>
                                    <strong>Comprehension</strong>
                                </td>
                                <td>
                                    <strong>Reading</strong>
                                </td>
                                <td>
                                    <strong>Writing</strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody>
                            <?php for($i = 0; $i < count($otherSkillLangs); $i++): ?>
                                <tr>
                                    <td><?= $otherSkillLangs[$i]; ?></td>
                                    <td><?= $otherSkillComprehensionLevels[$i]; ?></td>
                                    <td><?= $otherSkillReadingLevels[$i]; ?></td>
                                    <td><?= $otherSkillWritingLevels[$i]; ?></td>
                                </tr>
                            <?php endfor ?>
                        </tbody>
                    </table>
                </td>
            </tr>
            <tr>
                <td>Driver's license</td>
                <td><?= implode(", ",$otherSkillDriveLicenseList); ?></td>
            </tr>
        </tbody>
    </table>

</body>
</html>