<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ page isELIgnored="false" %>
<!DOCTYPE html>
<html>
<head>
    <title>User Dashboard</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
<div class="jumbotron text-center" style="margin-bottom:0">
    <h1>WELCOME TO OUR WEBSITE</h1>
    <p>Choose your operation</p>
</div>
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <a class="navbar-brand" href="/tax_calculator_system_war_exploded/">HomePage</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
        <ul class="navbar-nav">
            <li class="nav-item">
                <a class="nav-link" href="calculateTax">Calculate Tax</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="/tax_calculator_system_war_exploded/logout">Log out</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="entries">Entries</a>
            </li>
        </ul>
    </div>
</nav>
</div>
<h1>All tax Calculation Data</h1>
<table border="1">
    <thead>
    <tr>
        <th>Date</th>
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
            <td>${t.date}</td>
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
