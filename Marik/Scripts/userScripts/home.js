var height = $(window).height() - $('.menu-container').outerHeight();
$('.home-banner img').css('height', height);
window.onresize = function () {
    height = $(window).height() - $('.menu-container').outerHeight();;
    $('.home-banner img').css('height', height);
};

$('.reviews-carousel').owlCarousel({
    items: 1,
    mouseDrag: false,
    nav: true,
    dots: false,
    navText: ['<i class="fas fa-arrow-left"></i>', '<i class="fas fa-arrow-right"></i>'],
    autoplay: true,
    loop: true,
    animateIn: 'fadeIn',
    animateOut: 'fadeOut'
});

$("a[href='#services']").on('click', function () {
    $("html, body").animate({ scrollTop: $("#services").offset().top }, "slow");
    return false;
});