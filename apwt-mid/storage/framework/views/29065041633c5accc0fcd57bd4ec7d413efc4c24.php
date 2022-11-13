<html>
    <head><title>Profile</title></head>
    <body>
        <h1>Profile Data </h1>
        <table border="1">
            <tr>
                <th>Name</th>
                <th>ID</th>
                <th>Contact</th>
                <th>Email</th>
                <th>Password</th>
            </tr>
            <?php $__currentLoopData = $employees; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $d): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
            <tr>
                <td><?php echo e($d->name); ?></td>
                <td><?php echo e($d->id); ?></td>
                <td><?php echo e($d->contact); ?></td>
                <td><?php echo e($d->email); ?></td>
                <td><?php echo e($d->password); ?></td>
            </tr>
            <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
</table>
</body>
</html><?php /**PATH C:\xampp\htdocs\wtlab2\resources\views/employees/profile.blade.php ENDPATH**/ ?>