<?php
include('../control/calculationControl.php');
?>
<!DOCTYPE html>
<html>
<head>
<title>calculation</title>
</head>

<body> 
<a href="dashboard.php"> <input name="dashboard" type="submit" value="DASHBOARD"> </a> <br> <br>
<h3>INSERT INCOME or EXPANSE DETAILS</h3> 
<form name="myForm" action="" method="post">
Enter your income: <input type="text" id="income" name="income" placeholder="Enter your income" > <?php echo $errorIncome; ?> <br> <br>
Enter your expanse: <input type="expense" id="expense" name="expense" placeholder="Enter your expense" > <?php echo $errorExpanse; ?> <br> <br>  
<input name="submit" type="submit" value="INSERT">
</form>
<?php echo $error; ?> <br>

<h3>YOUR BALANCE DETAILS</h3>
<table border="1">
     <caption>INCOME EXPENSE DETAILS</caption>
     <th>Id</th>
     <th>Date</th>
     <th>Income</th>
     <th>Expense</th>
<?php  
$totalIncome=$totalExpense=$balance=0.0;
     foreach ($details as $d) 
          {
               echo "<tr>";
               echo "<td>" .$d["id"]. "</td>";
               echo "<td>" .$d["date"]. "</td>";
               echo "<td>" .$d["income"]. "</td>";
               echo "<td>" .$d["expense"]. "</td>";
               echo "<td><a href='updel.php?updelid=" .$d["id"]. "'>edit</a></td>";
               echo "<td><a href='updel.php?updelid=" .$d["id"]. "'>delete</a></td>";
               echo "</tr>";
               $totalIncome=$d["income"]+$totalIncome;
               $totalExpense=$d["expense"]+$totalExpense;
               $balance=$totalIncome-$totalExpense;
          }
    echo "Total Income is : " .$totalIncome."<br>";
    echo "Total Expense is : " .$totalExpense."<br>";
    echo "Balance is : " .$balance."<br>";
?>

</body>
</html>