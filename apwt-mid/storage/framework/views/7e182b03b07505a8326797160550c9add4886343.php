<html>
    <title>login</title>
<body>
    <form action="/login" method="post">
        <?php echo e(csrf_field()); ?>

    <h1>LOGIN PAGE</h1> <br>
    <?php if(@isset($output)): ?>
        <b><?php echo e($output); ?></b>
<?php endif; ?>
    Your ID is <input type="text" name="id" value="">
<br><br>
    Your password is <input type="password" name="password" value="">
<br><br>
<input type="submit" value="Login"> <br> <br><br>
    </form>
</body>
</html>
<?php /**PATH C:\xampp\htdocs\wtlab2\resources\views/login.blade.php ENDPATH**/ ?>