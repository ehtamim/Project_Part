<?php
include('../Model/database.php');

$username=$vehicle1=$vehicle2=$vehicle3=$input=$serviceError=$dataError="";
$pic1=$pic2=$pic3=4;

session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $username=$_SESSION["username"];
}

if(!empty($username))
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->SearchVehicle($conobj,"vehicle",$username);
    while($row = $userQuery->fetch_assoc()) 
    {
        $vehicle1=$row["car"];
        $vehicle2=$row["micro_bus"];
        $vehicle3=$row["bus"];

    }

    $connection->CloseCon($conobj);

    if($vehicle1=="Yes")
    {
        $pic1=1;
    }
    if($vehicle2=="Yes")
    {
        $pic2=2;
    }
    if($vehicle3=="Yes")
    {
        $pic3=3;
    }
}

if(isset($_POST['update']))
{
    $input=$_POST['vehiclename'];
    if ($input=="car" && $vehicle1=="Yes")
    {
        $serviceError="This service already exists in your Database.";
    }
    else if ($input=="micro_bus" && $vehicle2=="Yes")
    {
        $serviceError="This service already exists in your Database.";
    }
    else if ($input=="bus" && $vehicle3=="Yes")
    {
        $serviceError="This service already exists in your Database.";
    }

    if ($serviceError=="")
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->UpdateVehicle($conobj,"vehicle",$username,$input);
        if($userQuery==TRUE)
        {
            $dataError="Service was Updated Successfully.";
        }
        else
        {
            $dataError="Service was not Updated.";
        }
        $connection->CloseCon($conobj);
    }
}

if(isset($_POST['delete']))
{
    $input=$_POST['vehiclename'];
    if ($input=="car" && $vehicle1=="No")
    {
        $serviceError="This service does not exists in your Database.";
    }
    else if ($input=="micro_bus" && $vehicle2=="No")
    {
        $serviceError="This service does not exists in your Database.";
    }
    else if ($input=="bus" && $vehicle3=="No")
    {
        $serviceError="This service does not exists in your Database.";
    }

    if ($serviceError=="")
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->DeleteVehicle($conobj,"vehicle",$username,$input);
        if($userQuery==TRUE)
        {
            $dataError="Service was Deleted Successfully.";
        }
        else
        {
            $dataError="Service was not Deleted.";
        }
        $connection->CloseCon($conobj);
    }
}

?>