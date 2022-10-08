<?php
include ('../model/database.php');
$errorCity=$errorDate=$error=$unameOfUser=$bookHotel=$room="";
$hotel=array();
session_start();
if(isset($_SESSION['username']))
{
    $unameOfUser=$_SESSION['username'];
}
else
{
header("location: login.php");
}

if (isset($_POST['search']))
{
    if (empty($_POST['city']))
{
  $errorCity = "City is invalid";
}
else{
    $c=$_POST['city'];
    $connection = new db();
$conobj=$connection->OpenCon();

$userQuery=$connection->CheckCity($conobj,"hotels",$c);
$hotel=$userQuery;
$connection->CloseCon($conobj);
}
}
?>