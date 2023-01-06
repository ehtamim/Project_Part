<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ page isELIgnored="false" %>
<!DOCTYPE html>
<html>
<head>
    <title>View Entries</title>
</head>
<body>
<h1>All tax Calculation Data</h1>
<table border="1">
    <thead>
    <tr>
        <th>User_ID</th>
        <th>Basic Salary</th>
        <th>House Rent</th>
        <th>Medical Allowance</th>
        <th>Conveyance</th>
        <th>Festival Bonus</th>
        <th>Taxable Income</th>
        <th>Gross Tax</th>
        <th>Rebate</th>
        <th>Net Tax</th>
    </tr>
    </thead>
    <tbody>
    <c:forEach items="${entries}" var="t">
        <tr>
            <td>${t.user_id}</td>
            <td>${t.basicSalary}</td>
            <td>${t.houseRent}</td>
            <td>${t.medicalAllowance}</td>
            <td>${t.conveyance}</td>
            <td>${t.festivalBonus}</td>
            <td>${t.taxAbleIncome}</td>
            <td>${t.taxLiability}</td>
            <td>${t.rebate}</td>
            <td>${t.netTax}</td>
        </tr>
    </c:forEach>
    </tbody>
</table>
</body>
</html>
