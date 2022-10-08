<?php
include('../model/database.php');

$usna=$transport="";

session_start(); 
if(empty($_SESSION["username"])) 
{
//header("Location:login.php"); 
}
else
{
    $usna=$_SESSION["username"];
}

if(!empty($usna))
{
    //$transport=$_REQUEST['valcar']
    echo "SERVICES OF CAR" ;
    echo "<br>";
    echo "<br>";
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->SearchService($conobj,"costing",$usna,"car");
    if ($userQuery->num_rows > 0)
    {
    echo "<table border=5><tr><th>VEHICLE</th><th>PICK UP POINT</th><th>DROPPING LOCATION</th><th>COST</th></tr>";
    while($row = $userQuery->fetch_assoc()) 
    {
      echo "<tr><td>".$row["vehicle"]."</td><td>".$row["pick"]."</td><td>".$row["destination"]."</td><td>".$row["cost"]."</td></tr>";
    }
    echo "</table>";
    } else {
    echo "No data Found";
   }
   //$connection->CloseCon($conobj);
   //$connection = new db();
   echo "<br>";
   echo "SERVICES OF MICRO BUS";
   echo "<br>";
   echo "<br>";
    $conobj2=$connection->OpenCon();
    $userQuery2=$connection->SearchService($conobj,"costing",$usna,"micro_bus");
    if ($userQuery2->num_rows > 0)
    {
    echo "<table border=5><tr><th>VEHICLE</th><th>PICK UP POINT</th><th>DROPPING LOCATION</th><th>COST</th></tr>";
    while($row = $userQuery2->fetch_assoc()) 
    {
      echo "<tr><td>".$row["vehicle"]."</td><td>".$row["pick"]."</td><td>".$row["destination"]."</td><td>".$row["cost"]."</td></tr>";
    }
    echo "</table>";
    } else {
    echo "No data Found";
   }

   echo "<br>";
   echo "SERVICES OF BUS";
   echo "<br>";
   echo "<br>";

   $conobj3=$connection->OpenCon();
    $userQuery3=$connection->SearchService($conobj,"costing",$usna,"bus");
    if ($userQuery2->num_rows > 0)
    {
    echo "<table border=5><tr><th>VEHICLE</th><th>PICK UP POINT</th><th>DROPPING LOCATION</th><th>COST</th></tr>";
    while($row = $userQuery3->fetch_assoc()) 
    {
      echo "<tr><td>".$row["vehicle"]."</td><td>".$row["pick"]."</td><td>".$row["destination"]."</td><td>".$row["cost"]."</td></tr>";
    }
    echo "</table>";
    } else {
    echo "No data Found";
   }


   $connection->CloseCon($conobj2);
}

?>