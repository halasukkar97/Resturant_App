<?php
	$db = mysqli_connect('localhost', 'id6397301_halasukkar','hala6611847') or die('Could not connect: '.mysqli_error());
	mysqli_select_db($db, 'id6397301_software') or die('Could not select database');
	

	$Name = mysqli_real_escape_string($db, $_GET['Name']);
	$Price = mysqli_real_escape_string($db, $_GET['Price']);
	$Amount = mysqli_real_escape_string($db, $_GET['Amount']);

	
		$query = "insert into menu values (NULL, '$Name', '$Price', '$Amount');";
		$result = mysqli_query($db, $query) or die('Query fielded; ' .mysqli_error($db));
	
	
	?>