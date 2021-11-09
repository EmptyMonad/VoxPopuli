<?php
	//server connection here
$serverName = ".\SQLEXPRESS";
$connectionInfo = array( "Database"=>"Database1.mdf", "UID"=>"username", "PWD"=>"password" );
$conn = sqlsrv_connect( $serverName, $connectionInfo);
if( $conn === false ) {
     die( print_r( sqlsrv_errors(), true));
}
echo "Connected successfully";
//get elements
	$code = "Select picurl from congress2 where results_members_id = G000552";
	echo $code;
?>