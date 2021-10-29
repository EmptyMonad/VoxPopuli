<?php
	//server connection here
	
$conn = new mysqli($SQLEXPRESS, $Admin, $Asylo);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";
//get table elements
	$code = $GET['results_members_first_name'];
	$code1 = $GET['results_members_last_name'];
	$code2 = $GET['results_members_party'];
	$code3 = $GET['results_members_state'];
	$code4 = $GET['results_members_district'];
	$code5 = $GET['results_members_office'];
	$code6 = $GET['results_members_next_election'];
	$code7 = $GET['results_members_url'];
	$code8 = $GET['results_members_facebook_account'];
	$code9 = $GET['results_members_twitter_account'];
	//testing section
	echo $code;
	echo $code1;
	echo $code2;
	echo $code3;
	echo $code4;
	echo $code5;
	echo $code6;
	echo $code7;
	echo $code8;
	echo $code9;
?>