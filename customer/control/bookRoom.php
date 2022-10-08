<?php
include('../view/bookhotel.php');

$bookHotel=$_GET["hotelName"];
$room=$_GET["roomno"];
if($bookHotel!="" && $room!="")
{
$connection = new db();
$conobj=$connection->OpenCon();

$userQuery=$connection->BookRoom($conobj,"hotels",$unameOfUser,$bookHotel,"$room");

if ($userQuery===TRUE) 
{
   $bookerror = "Hotel Room Booked";
}
else 
{
   $bookerror = "Error in booking hotel room";
}
$connection->CloseCon($conobj);
}
?>