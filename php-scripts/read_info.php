<?php
$output = shell_exec('adb shell getprop');
echo $output;
?>
