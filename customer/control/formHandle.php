<?php
include('../model/database.php');
$userNAME=$sdate="";
if (empty($_REQUEST["checkCity"]))
{
    echo "Enter your City please!!!";
}
else
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->CheckCity($conobj,"hotels",$_REQUEST["checkCity"]);
    $rows=$userQuery->num_rows;
    if ($rows > 0)
    {
        echo "<table border=5><tr><th>Hotel Name</th><th>City</th><th>Location</th><th>Room</th><th>Bed</th><th>Cost</th></tr>";
        while($row = $userQuery->fetch_assoc()) 
        {
            echo "<tr><td>".$row["name"]."</td><td>".$row["city"]."</td><td>".$row["location"]."</td><td>".$row["room"]."</td><td>".$row["bed"]."</td><td>".$row["cost"]."</td></tr>";
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