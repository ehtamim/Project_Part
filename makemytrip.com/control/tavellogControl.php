<?php
include('../model/database.php');

$data=$user="";

session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $user=$_SESSION["username"];
}

$connection = new db();
$conobj=$connection->OpenCon();
$userQuery=$connection->ShowTravel($conobj,"travel_log",$user);

if ($userQuery->num_rows > 0)
 {
    echo "<table border=5><tr><th>CUSTOMER</th><th>ADDRESS</th><th>DATE OF TRAVEL</th><th>COST OF TRAVEL</th><th>PICK UP POINT</th><th>DESTINATION</th></tr>";
    while($row = $userQuery->fetch_assoc()) 
    {
      echo "<tr><td>".$row["customer"]."</td><td>".$row["address"]."</td><td>".$row["date_of_travel"]."</td><td>".$row["cost"]."</td><td>".$row["pickup_point"]."</td><td>".$row["destination"]."</td></tr>";
    }
    echo "</table>";
  } 
  else 
  {
    echo "No data Found";
  }
$connection->CloseCon($conobj);

?>