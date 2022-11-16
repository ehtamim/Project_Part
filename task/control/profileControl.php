<?php
include('../database/database.php');

$unameOfUser=$nameOfUser=$contactOfUser=$passOfUser=$error=$errorPrf="";

session_start(); 
if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $unameOfUser=$_SESSION["username"];
    $passOfUser=$_SESSION["password"];
}

if (!empty($unameOfUser) && !empty($passOfUser))
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->CheckUser($conobj,"user",$unameOfUser,$passOfUser);
    if ($userQuery->num_rows > 0 && $userQuery->num_rows < 2)
    {
        while($row = $userQuery->fetch_assoc())
        {
            $nameOfUser=$row['name'];
            $unameOfUser= $row['username'];
            $contactOfUser=$row['contact']; 
            $passOfUser=$row['password'];
        }
    }
    $connection->CloseCon($conobj);
}

if(isset($_POST['update']))
{
    $nameOfUser=$_POST['name'];
    $contactOfUser=$_POST['contact'];
    $passOfUser=$_POST['password'];
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->UpdateUser($conobj,"user",$nameOfUser,$unameOfUser,$contactOfUser,$passOfUser);
    if ($userQuery==TRUE)
    {
        $errorPrf="Profile was Updated Successfully";
    }
    else
    {
        $errorPrf="Profile was not updated";
    }
    $connection->CloseCon($conobj);
}

if(isset($_POST['delete']))
{
    if($unameOfUser != "")
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->DeleteUser($conobj,"user",$unameOfUser);
        $connection->CloseCon($conobj);
        $errorPrf="Data Deleted" ;
        session_destroy();
        header("Location:login.php");
    }
    else
    {
        $errorPrf="Not Deleted" ;
    }
}

?>