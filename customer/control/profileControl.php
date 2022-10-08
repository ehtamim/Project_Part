<?php
include('../Model/database.php');

$unameOfUser=$nameOfUser=$emailOfUser=$contactOfUser=$genderOfUser=$passOfUser=$error=$errorPrf=$genderMale=$genderFemale=$genderOther="";

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
    $userQuery=$connection->CheckUser($conobj,"customer",$unameOfUser,$passOfUser);
    if ($userQuery->num_rows > 0 && $userQuery->num_rows < 2)
    {
        while($row = $userQuery->fetch_assoc())
        {
            $nameOfUser=$row['name'];
            $unameOfUser= $row['username'];
            $emailOfUser=$row['email'];
            $contactOfUser=$row['contact'];
            $genderOfUser=$row['gender'];
            $passOfUser=$row['password'];
            if ($genderOfUser=="Male")
            {
                $genderMale="checked";
            }
            else if ($genderOfUser=="Female")
            {
                $genderFemale="checked";
            }
            else
            $genderOther="checked";
        }
    }
    $connection->CloseCon($conobj);
}

if(isset($_POST['update']))
{
    //if(!empty($_POST['name']) && !empty($_POST['email']) && !empty($_POST['contact']) && !empty($_POST['password']))
    
    $nameOfUser=$_POST['name'];
    $emailOfUser=$_POST['email'];
    $contactOfUser=$_POST['contact'];
    $genderOfUser=$_POST['gender'];
    $passOfUser=$_POST['password'];
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->UpdateUser($conobj,"customer",$nameOfUser,$unameOfUser,$emailOfUser,$contactOfUser,$genderOfUser,$passOfUser);
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
        $userQuery=$connection->DeleteUser($conobj,"customer",$unameOfUser);
        $connection->CloseCon($conobj);
        $errorPrf="Data Deleted" ;
        session_destroy();
        header("Location:login.php");
    }
    else
    {
        $errorPrf="Not Deleted" ;
    }
    
    //header("Location:login.php"); 
}

?>