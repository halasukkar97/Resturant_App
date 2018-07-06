<?php
	$db = mysqli_connect('localhost', 'id6397301_halasukkar','hala6611847') or die('Could not connect: '.mysqli_error());
	mysqli_select_db($db, 'id6397301_software') or die('Could not select database');
	

	$TableNumber = mysqli_real_escape_string($db, $_GET['TableNumber']);
	$Booked = mysqli_real_escape_string($db, $_GET['Booked']);
	
	
	
	
		$query = "insert into tables values (NULL, '$TableNumber', '$Booked');";
		$result = mysqli_query($db, $query) or die('Query fielded; ' .mysqli_error($db));
	
	?>