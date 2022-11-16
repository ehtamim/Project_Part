<?php
session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
?>

<!DOCTYPE html>
<html>
<head>
<title>dashboard</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body class="container">

<h1>USER DASHBOARD</h1> 
<a href="profile.php"> <input name="profile" type="submit" value=" PROFILE "> </a><br> <br>
<a href="calculation.php"> <input name="calculation" type="submit" value="CALCULATION"> </a><br> <br>
<a href="../control/logout.php"> <input name="logOut" type="submit" value="LOG OUT"> </a><br><br>
</body>
</html> 