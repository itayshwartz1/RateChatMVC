$(function () {
    $('form').submit(async e => {
        e.preventDefault();

        const q = $('#search').val();

        /*$('tbody').load('/Rates/Search?query=' + q);*/

        var r = await fetch('/Rates/Search?query=' + q);
        var d = await r.json();

        const tamplate = $('#tamplate').html();
        let result = '';
        for (var item in d) {
            var row = tamplate;
            for (var key in d[item]) {

                row = row.replaceAll('%7B' + key + '%7D', d[item][key]);


                row = row.replaceAll('{' + key + '}', d[item][key]);

            }
            result += row;
        }
        $('tbody').html(result);
    })
})
