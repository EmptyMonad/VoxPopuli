<head>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"> </script>
</head>

<button id="" type="button"></button>

<script>
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
            memURL: 0,
            affinity: 0,
        },
    success: function( result ) 
    {   
        alert(result2);
        $( "#div_name" ).html( result2 );
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
        $( "#div_name" ).html( result2 );
    })
     $ajax.({
        url: "./getBill.php",
        data: 
        {
            //Fuck I don't know
        },
    success: function( result3 ) 
    {   
        alert(result3);
        $( "#div_name" ).html( result3 );
    })
});
</script>