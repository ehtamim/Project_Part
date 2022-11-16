<?php
include('../view/calculation.php');
$updelID= $_GET["updelid"];
$upincome=$upexpense=$updelError=$incVal=$expVal="";

if(empty($_SESSION["username"])) 
{
header("Location:login.php"); 
}
else
{
    $uname=$_SESSION["username"];
    $pass=$_SESSION["password"];
}

if (!empty($updelID))
{
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->CheckData($conobj,"calculate",$updelID);
    if ($userQuery->num_rows > 0 && $userQuery->num_rows < 2)
    {
        while($row = $userQuery->fetch_assoc())
        {
            $incVal=$row['income'];
            $expVal= $row['expense'];
        }
    }
    $connection->CloseCon($conobj);
}

if(isset($_POST['up']))
{
    $income=$_POST['upincome'];
    $expense=$_POST['upexpense'];
    $connection = new db();
    $conobj=$connection->OpenCon();
    $userQuery=$connection->UpdateData($conobj,"calculate",$updelID,$income,$expense);
    if ($userQuery==TRUE)
    {
        $errorPrf="Calculation data was Updated Successfully";
    }
    else
    {
        $errorPrf="Calculation data was not updated";
    }
    $connection->CloseCon($conobj);
    header("Location:../view/calculation.php");
}

if(isset($_POST['del']))
{
    if("$updelID")
    {
        $connection = new db();
        $conobj=$connection->OpenCon();
        $userQuery=$connection->DeleteData($conobj,"calculate",$updelID);
        $connection->CloseCon($conobj);
        $updelError="Calculation Data Deleted" ;
    }
    else
    {
        $updelError="Calculation data Not Deleted" ;
    }
    header("Location:../view/calculation.php");
}

?>