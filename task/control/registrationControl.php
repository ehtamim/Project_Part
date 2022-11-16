<?php
include('../database/database.php');
$error=$errorName=$errorUserName=$errorPass=$errorContact=$userNameTaken="";

if (isset($_POST['submit']))
{
    if (!(empty($_POST['username'])))
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->CheckUique($conobj,"user",$_POST['username']);
        if ($userQuery->num_rows > 0)
        {
            $userNameTaken="yes";
        }
    }
}

// store session data
if (isset($_POST['submit'])) 
{
    if (empty($_POST["name"])) 
    {
        $errorName = "Name is required";
    } 
      else 
      {
        $name = $_POST["name"];
        if (!preg_match("/^[a-zA-Z-' ]*$/",$name)) 
        {
            $errorName = "Only letters and white space allowed";
        }
    }
    if (empty($_POST['username']))
    {
        $errorUserName = "Invalid username was Provided";
    }
    if($userNameTaken != "")
    {
        $errorUserName = "Username was taken already";
    }
    if (empty($_POST['contact'])) 
    {
        $errorContact = "Contact is required";
    }
    else
    {
        $contact = $_POST["contact"];
        if (strlen($contact)!=11 && strlen($contact)!=14)
        {
            $errorContact = "Invalid contact format";
        }
    }
    if (empty($_POST['password'])) 
    {
        $errorPass = "Password is required";
    }
    else
    {
        $password=$_POST['password'];
        if (!preg_match("#.*^(?=.{8,20})(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\W).*$#", $password))
        {
            $errorPass = "Invalid Password was Provided";
        }
    }

if ($errorName=="" && $errorUserName=="" && $errorPass=="" && $errorContact=="")
{
$name=$_POST['name'];
$username=$_POST['username'];
$contact=$_POST['contact'];
$password=$_POST['password'];
$income=0.0;
$expanse=0.0;
date_default_timezone_set('Asia/Dhaka');
$date = date('Y-m-d');

$connection = new db();
$conobj=$connection->OpenCon();

$userQuery=$connection->InsertUser($conobj,"user",$name,$username,$contact,$password);

if ($userQuery===TRUE) 
{
   $error = "User Data inserted";
}
else 
{
   $error = "User Data not inserted";
}
$userQuery1=$connection->InsertData($conobj,"calculate",$username,$date,$income,$expanse);

if ($userQuery1===TRUE) 
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