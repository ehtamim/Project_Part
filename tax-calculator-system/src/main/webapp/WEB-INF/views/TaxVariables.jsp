<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ page isELIgnored="false" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>UpdateVar</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>

<div class="container">
    <h2>Tax variables</h2>
    <h4>Update tax variables</h4>
    <form:form action="updateTaxVariables" modelAttribute="taxVarUpdate">
        Govt. House Rent: <input type="number" step="any" name="houseRent" value=${taxVarUpdate.houseRent}> <br>
        Medical Allowance: <input type="number" step="any" name="medicalAllowance" value=${taxVarUpdate.medicalAllowance}> <br>
        Conveyance: <input type="number" step="any" name="conveyance" value=${taxVarUpdate.conveyance}> <br>
        Festive Bonus: <input type="number" step="any" name="festiveBonus" value=${taxVarUpdate.festiveBonus}> <br>
        Max not taxable amount for male: <input type="number" step="any" name="malePayable" value=${taxVarUpdate.malePayable}> <br>
        Max not taxable amount for female/seniors: <input type="number" step="any" name="femalePayable" value=${taxVarUpdate.femalePayable}> <br>
        Max not taxable amount for disabled: <input type="number" step="any" name="disabledPayable" value=${taxVarUpdate.disabledPayable}> <br>
        Max not taxable amount for freedom fighters: <input type="number" step="any" name="freedomPayable" value=${taxVarUpdate.freedomPayable}> <br>
        For next 1 lac percentage: <input type="number" step="any" name="next1" value=${taxVarUpdate.next1*100}> <br>
        For next 3 lac percentage: <input type="number" step="any" name="next3" value=${taxVarUpdate.next3*100}> <br>
        For next 4 lac percentage: <input type="number" step="any" name="next4" value=${taxVarUpdate.next4*100}> <br>
        For next 4 lac percentage: <input type="number" step="any" name="next5" value=${taxVarUpdate.next5*100}> <br>
        For rest amount percentage: <input type="number" step="any" name="rest" value=${taxVarUpdate.rest*100}> <br>
        <button type="submit" class="btn btn-primary">Update</button>
    </form:form>
</div>
<a href="dashboard"><input type="button" value="Dashboard"></a>
</body>
</html>
