<?php
session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $cookie_value=$_SESSION["username"];
    $wel=$_SESSION["username"];
}
$cookie_name = "Customer";

setcookie($cookie_name, $cookie_value, time() + (86400 * 30), "/");
?>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="../css/mycss.css">
</head>
<body>

<?php
if(!isset($_COOKIE[$cookie_name])) {
echo "Cookie named '" . $cookie_name . "' is not set!";
} else {
echo "Cookie '" . $cookie_name . "' is set!<br>";
echo "Value is: " . $_COOKIE[$cookie_name];
}
?>

<h2> WELCOME TO OUR WEBSITE, <?php echo $wel; ?> </h2> 
<h2>Customer Dashboard</h2> <br>
<div class="content4">
<a href="profile.php"> <input name="profile" type="submit" id="click" value=" PROFILE "> </a>
<br> <br>
<a href="bookhotel.php"> <input name="bookhotel" type="submit" id="click" value="BOOK HOTEL"> </a>
<br> <br>
<a href="bookings.php"> <input name="bookings" type="submit" id="click" value="BOOKINGS"> </a>
<br><br>
<a href="../control/logout.php"> <input name="logout" type="submit" id="click" value="LOG OUT"> </a>
<br>
<br>
</div>
</body>
</html>

<?php


?>   