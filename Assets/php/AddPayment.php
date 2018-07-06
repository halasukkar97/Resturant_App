<?php
	$db = mysqli_connect('localhost', 'id6397301_halasukkar','hala6611847') or die('Could not connect: '.mysqli_error());
	mysqli_select_db($db, 'id6397301_software') or die('Could not select database');
	

	$PaymentMethode = mysqli_real_escape_string($db, $_GET['PaymentMethode']);
	$Date = mysqli_real_escape_string($db, $_GET['Date']);
	$Total = mysqli_real_escape_string($db, $_GET['Total']);

	
		$query = "insert into payment values (NULL, '$PaymentMethode', '$Date', '$Total');";
		$result = mysqli_query($db, $query) or die('Query fielded; ' .mysqli_error($db));
	
	
	?>