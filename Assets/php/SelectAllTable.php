<?php
	$db = mysqli_connect('localhost', 'id6397301_halasukkar','hala6611847') or die('Could not connect: '.mysqli_error());
	mysqli_select_db($db, 'id6397301_software') or die('Could not select database');
	
	
	$query = "SELECT * FROM 'table' ORDER BY 'ID' DESC LIMIT 5";
	
	$result = mysqli_query($db, $query) or die('query failed: '.mysqli_error($db));
	
	$num_results = mysqli_num_rows($result);
	
	for($i = 0; $i<$num_results; $i++)
	{
		$row = mysqli_fetch_array($result);
		echo $row['ID']."\t".$row['TableNumber']."\t".$row['Booked']."\n";
	}
	?>