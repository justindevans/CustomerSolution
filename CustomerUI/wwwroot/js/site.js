$(document).ready(function () {   
        
    $('.ViewAddressDetails').off('click').on('click', function () {
        var addr1 = $(this).attr('data-customerAddr1');  
        var addr2 = $(this).attr('data-customerAddr2'); 
        var town = $(this).attr('data-customerTown'); 
        var postcode = $(this).attr('data-customerPostcode');       
       
        $('#customerAddr1').text(addr1);
        $('#customerAddr2').text(addr2);
        $('#customerTown').text(town);
        $('#customerPostcode').text(postcode);
    });
});

function confirmCustomerDelete() {
    return confirm("Are you sure you want to delete this customer?");
}
