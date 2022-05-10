$(function(){
    $('form').submit(e=> {
        e.preventDefault();

        const q = $('#queryToSearch').val();

        $('tbody').load('/Rates/Search?queryToSearch=' + q);
    })
})
