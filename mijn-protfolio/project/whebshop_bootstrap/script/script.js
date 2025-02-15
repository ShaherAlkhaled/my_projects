var $gird = $('.xgrid').isotope({});

// filter items on button clik 

$('.filter-button-group').on('click','button',function(){
    var filterValue=$(this).attr('data-filter');

    $gird.isotope({filter: filterValue});

});