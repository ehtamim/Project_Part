<?php
include('../model/database.php');
$userNAME="";
session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $userNAME=$_SESSION["username"];
}

//<script src="../js/myjs.js"> </script>
//$userNameTaken="";
if (empty($_REQUEST["checkLocation2"]))
{
    echo "Enter your location please!!!";
}
else
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->CheckLoc2($conobj,"costing",$userNAME,$_REQUEST["checkLocation2"]);
    $rows=$userQuery->num_rows;
    if ($rows > 0)
    {
        echo "<table border=5><tr><th>Username</th><th>Vehicle</th><th>Pick up Location</th><th>Dropping Location</th><th>Cost</th></tr>";
        while($row = $userQuery->fetch_assoc()) 
        {
            echo "<tr><td>".$row["username"]."</td><td>".$row["vehicle"]."</td><td>".$row["pick"]."</td><td>".$row["destination"]."</td><td>".$row["cost"]."</td></tr>";
        }
        echo "</table>";
    }
    else
    {
        echo "No location found.";
    }
    $connection->CloseCon($conobj);
}
?>