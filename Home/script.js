const screen_xs = 0;
const screen_sm = 576;
const screen_md = 768;
const screen_lg = 992;
const screen_xl = 1200;
const screen_xxl = 1400;

$(() => {
	$('.owl-carousel').owlCarousel({
		center: true,
		rtl: true,
		margin: 16,
		loop: true,
		autoplay: true,
		autoplayTimeout: 3000,
		autoplayHoverPause: true,
		dots: false,
		nav: false,
		responsive: {
			0: {items: 1},
			576: {items: 2},
			992: {items: 3},
			1400: {items: 4},
		}
	});
});
