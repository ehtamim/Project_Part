<?php
include('../model/database.php');

$UserName=$loc1Error=$loc2Error=$costError=$vehicleError=$error=$vehicle="";
$vehicle1=$vehicle2=$vehicle3="";

session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $UserName=$_SESSION["username"];
}

if(!empty($UserName))
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->SearchVehicle($conobj,"vehicle",$UserName);
    while($row = $userQuery->fetch_assoc()) 
    {
        $vehicle1=$row["car"];
        $vehicle2=$row["micro_bus"];
        $vehicle3=$row["bus"];

    }
    $connection->CloseCon($conobj);

    if($vehicle1=="Yes")
    {
        $vehicle1="car";
    }
    if($vehicle2=="Yes")
    {
        $vehicle2="micro_bus";
    }
    if($vehicle3=="Yes")
    {
        $vehicle3="bus";
    }
}

if(isset($_POST['add']))
{
    $loc=$_POST['loc1'];
    $dropLoc=$_POST['drop_loc'];
    $cost=$_POST['cost'];
    $vehicle=$_POST['vehicle'];
    if ($vehicle==$vehicle1 || $vehicle==$vehicle2 || $vehicle==$vehicle3)
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->InsertService($conobj,"costing",$UserName,$vehicle,$loc,$dropLoc,$cost);
        if ($userQuery==TRUE) 
        {
            $error = "Costing data inserted";
        }
        else 
        {
            $error = "Costing data not inserted";
        }
        $connection->CloseCon($conobj);
    }
    else
    {
        $error= "You do not provide this service" ;
    }
    
}

//update delete
$va="";
$uperror="";

if(isset($_POST['update']))
{
    $uploc=$_POST['uploc1'];
    $updropLoc=$_POST['uploc2'];
    $upcost=$_POST['upcost'];
    $upvehicle=$_POST['upvehicle'];
    if ($upvehicle==$vehicle1 || $upvehicle==$vehicle2 || $upvehicle==$vehicle3)
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->UpdateCost($conobj,"costing",$UserName,$upvehicle,$uploc,$updropLoc,$upcost);
        if ($userQuery==TRUE) 
        {
            $uperror = "Cost Data Updated";
        }
        else 
        {
            $uperror = "Cost Data not Updated";
        }
        $connection->CloseCon($conobj);
    }
    else
    {
        $uperror= "You do not provide this service" ;
    }
}

if(isset($_POST['delete']))
{
    $dloc=$_POST['uploc1'];
    $ddropLoc=$_POST['uploc2'];
    $dcost=$_POST['upcost'];
    $dvehicle=$_POST['upvehicle'];
    if ($dvehicle==$vehicle1 || $dvehicle==$vehicle2 || $dvehicle==$vehicle3)
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->DeleteCosting($conobj,"costing",$UserName,$dvehicle,$dloc,$ddropLoc);
        if ($userQuery==TRUE) 
        {
            $uperror = "Cost Data Deleted";
        }
        else 
        {
            $uperror = "Cost Data not Deletedd";
        }
        $connection->CloseCon($conobj);
    }
    else
    {
        $uperror= "You do not provide this service" ;
    }
}

?>