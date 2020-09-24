$("a[href='#my-story']").on('click', function () {
    $('.hidden-tab').hide();
    $('#my-story').fadeIn();
    setTimeout(
        function () {
            $("html, body").animate({ scrollTop: $("#hidden-about").offset().top }, "slow");
        }, 100);
    return false;
});

$("a[href='#my-favorites']").on('click', function () {
    $('.hidden-tab').hide();
    $('#my-favorites').fadeIn();
    setTimeout(
        function () {
            $("html, body").animate({ scrollTop: $("#hidden-about").offset().top }, "slow");
        }, 100);
    return false;
});