<?php
/*include('../model/database.php');

$UserName=$loc1=$loc2=$cost=$vehicle=$error=$x="";
$loc1Error=$loc2Error=$costError=$vehicleError="";
session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $UserName=$_SESSION["username"];
}

if (isset($_POST['add']))
{
    $loc1=$_POST['loc1'];
    $x=$_REQUEST['drop_loc'];
    $cost=$_POST['cost'];
    $vehicle= $_POST["vehicle"];
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->InsertService($conobj,"services",$UserName,$vehicle,$loc1,$_POST['drop_loc'],$cost);
    if ($userQuery===TRUE) 
    {
        $error = "Service Data inserted";
    }
    else 
    {
        $error = "Service Data not inserted";
    }
    $connection->CloseCon($conobj);
    if(empty($_REQUEST['loc1']))
    {
        $loc1Error="Please enter a location.";
    }
    else
    {
        $loc1=$_REQUEST['loc1'];
    }
    if(empty($_REQUEST['drop_loc']))
    {
        $loc2Error="Please enter a location.";
    }
    else
    {
        $loc2=$_REQUEST['drop_loc'];
    }
    if(empty($_REQUEST['cost']))
    {
        $costError="Please enter cost.";
    }
    else
    {
        $cost=$_REQUEST['cost'];
    }

    if(isset($_REQUEST["vehicle"]))
    {
        $vehicle= $_REQUEST["vehicle"];
    }
    else
    {
        $vehicleError= "Please select at least one vehicle.";
    }

    if($loc1Error==""  && $loc2Error=="" && $costError=="" && $vehicleError=="")
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->InsertService($conobj,"services",$UserName,$vehicle,$loc1,$loc2,$cost);
        if ($userQuery===TRUE) 
        {
            $error = "Service Data inserted";
        }
        else 
        {
            $error = "Service Data not inserted";
        }
        $connection->CloseCon($conobj);
    }
    //$connection->CloseCon($conobj);
}

//update part
$updateError="";
if (isset($_POST['update']))
{
    $updateError=$_POST['uploc1'];
}

*/
?>