﻿<head>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"> </script>
</head>

<button id="district1" type="button"></button>
<script>
$("#btn").click(function()
$("#btn").click(function()
{
    alert("Function is being called.");
    $ajax.({
        url: "./getCongress.php",
        data: 
        {
            fname: 0,
            lname: 0,
            party: 0,
            state: 0,
            district: 0,
            election: 0,
            website: 0,
            facebook: 0,
            twitter: 0,
        },
    success: function( data ) 
    {   
        alert(data);
        $( "#messages" ).html( data );
    })
 $ajax.({
        url: "./getPic.php",
        data: 
        {
            pic: 0
        },
    success: function( result2 ) 
    {   
        alert(result2);
        $( "#repphoto" ).html( result2 );
    })
/*     $ajax.({
        url: "./getBill.php",
        data: 
        {
            //Fuck I don't know
        },
    success: function( result3 ) 
    {   
        alert(result3);
        $( "#div_name" ).html( result3 );
    })*/
});
</script>