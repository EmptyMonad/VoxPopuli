<?php
	//server connection here
 $dbhost = "localhost";
 $dbuser = "root";
 $dbpass = "";
 $db = "Database1";
 $conn = new mysqli($dbhost, $dbuser, $dbpass,$db) or die("Connect failed: %s\n". $conn -> error);
$sql = "SELECT * from congress2 WHERE results_members_id = B001260";
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