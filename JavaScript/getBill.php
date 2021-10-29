<?php
	//server connection here
	
$conn = new mysqli($servername, $username, $password);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";
//get elements
	$code = $GET['bill1-Row?'];
	$code = $GET['bill2-Row?'];
	$code = $GET['bill3-Row?'];
	$code = $GET['bill4-Row?'];
	$code = $GET['bill5-Row?'];
	$code = $GET['bill6-Row?'];
	$code = $GET['bill7-Row?'];
	$code = $GET['bill8-Row?'];
	$code = $GET['bill9-Row?'];
	$code = $GET['bill0-Row?'];
	?>