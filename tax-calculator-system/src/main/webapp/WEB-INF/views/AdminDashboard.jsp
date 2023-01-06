<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ page isELIgnored="false" %>
<!DOCTYPE html>
<html>
<head>
    <title>Admin Dashboard</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
<div class="jumbotron text-center" style="margin-bottom:0">
    <h1>Welcome Admin</h1>
    <p>Select operations  </p>
</div>
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <a class="navbar-brand" href="/tax_calculator_system_war_exploded/">HomePage</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
        <ul class="navbar-nav">
            <li class="nav-item">
                <a class="nav-link" href="addUser">Add User</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="taxVariables">Tax Variables</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="dashboard">Dashboard</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="tax_calculator_system_war_exploded/logout">Log Out</a>
            </li>
        </ul>
    </div>
</nav>
</div>
<h2>Update or Delete User</h2>
<form method="post" action="updateDeleteUser">
    Enter id to Edit : <input type="text" name="useridForUpDel" id="useridForUpDel" placeholder="Enter ID">
    <input type="submit" name="edit" value="Edit">
</form>
<h2>All User Data</h2>
<table border="1">
    <thead>
    <tr>
        <th>User's Id</th>
        <th>User's Name</th>
        <th>User's username</th>
        <th>User's gender</th>
        <th>User's age</th>
        <th>User's email</th>
        <th>User's contact</th>
    </tr>
    </thead>
    <tbody>
    <c:forEach items="${allUser}" var="au">
        <tr>
            <td>${au.id}</td>
            <td>${au.name}</td>
            <td>${au.username}</td>
            <td>${au.gender}</td>
            <td>${au.age}</td>
            <td>${au.email}</td>
            <td>${au.contact}</td>
        </tr>
    </c:forEach>
    </tbody>
</table>
</body>
</html>
