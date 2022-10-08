<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="../css/mycss.css">
</head>
<body class="coloryellow">
<h1>TravelLog</h1>
<div>
<h3>
<?php
include('../control/tavellogControl.php');
?>
<?php $data; ?>
</h3>
</div>
<br><br><br><br>
<a href="admin.php"> <input name="homePage" type="submit" id="green" value="HOME PAGE"> </a>

</body>
</html>