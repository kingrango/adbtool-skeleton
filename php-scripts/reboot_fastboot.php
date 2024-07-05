<?php
$output = shell_exec('adb reboot bootloader');
echo $output;
?>
