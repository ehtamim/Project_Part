<?php
include('../database/database.php');
$errorIncome=$errorExpanse=$error=$unameOfUser=$passOfUser="";
$details=array();

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

if (!empty($unameOfUser))
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->UserData($conobj,"calculate",$unameOfUser);
    $details=$userQuery;
    $connection->CloseCon($conobj);
}

if (isset($_POST['submit'])) 
{
    $income=$_POST["income"];
    $expense=$_POST["expense"];
    if($income=="" && $expense=="")
    {
        $errorIncome="Give value";
        $errorExpanse="Give value";
    }
    else
    {
    }

    if ($errorExpanse=="" || $errorIncome=="")
    {
        date_default_timezone_set('Asia/Dhaka');
        $date = date('Y-m-d');
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->InsertData($conobj,"calculate",$unameOfUser,$date,$income,$expense);
        if ($userQuery===TRUE) 
        {
            $error = "User Data inserted";
        }
        else 
        {
            $error = "User Data not inserted";
        }
        $connection->CloseCon($conobj);
    }
}
?>