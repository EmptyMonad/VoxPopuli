<?php
	//server connection here
	
$conn = new mysqli($servername, $username, $password);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";
//get elements
	$code = $GET['picurl'];
	echo $code;
?>