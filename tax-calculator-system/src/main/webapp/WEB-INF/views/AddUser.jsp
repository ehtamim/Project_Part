<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ page isELIgnored="false" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Add Useer</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>

<div class="container">
    <h2>Add User</h2>
    <h4>Give user Information</h4>
    <form:form action="addUser" modelAttribute="addUser">
        <div class="form-group">
            <label for="name">Name:</label>
            <input type="text" class="form-control" id="name" placeholder="Enter your name" name="name">
        </div>
        <div class="form-group">
            <label for="username">Username:</label>
            <input type="text" class="form-control" id="username" placeholder="Enter your username" name="username">
        </div>
        <div class="form-group">
            <label for="age">Age:</label>
            <input type="number" id="age" name="age" min="18" max="100">
        </div>
        <div class="form-group">
            <label for="contact">Contact:</label>
            <input type="text" class="form-control" id="contact" placeholder="Enter your contact no" name="contact">
        </div>
        <div>
            <label for="gender">Choose a Gender:</label>
            <select name="gender" id="gender">
                <option value="Male">Male</option>
                <option value="Female">Female</option>
                <option value="Other">Other</option>
            </select>
        </div>
        <div class="form-group">
            <label for="email">Email:</label>
            <input type="text" class="form-control" id="email" placeholder="Enter your email" name="email">
        </div>
        <div class="form-group">
            <label for="password">Password:</label>
            <input type="password" class="form-control" id="password" placeholder="Enter your password" name="password">
        </div>
        <div>
            <label for="disabled">Disabled??</label>
            <select name="disabled" id="disabled">
                <option value="False">No</option>
                <option value="True">Yes</option>
            </select>
        </div>
        <div>
            <label for="freedomfighter">Freedom Fighter?? </label>
            <select name="freedomfighter" id="freedomfighter">
                <option value="False">No</option>
                <option value="True">Yes</option>
            </select>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form:form>
</div>
<a href="dashboard"><input type="button" value="Dashboard"></a>
</body>
</html>
