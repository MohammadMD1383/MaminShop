const screen_sm = 576;
const screen_md = 768;
const screen_lg = 992;
const screen_xl = 1200;
const screen_xxl = 1400;

$(() => {
	$('.owl-carousel').owlCarousel({
		loop: true,
		margin: 10,
		nav: false,
		responsive: {
			0: {
				items: 1
			},
			screen_sm: {
				items: 2
			},
			screen_md: {
				items: 4
			},
			screen_lg: {
				items: 6
			}
		}
	});
});
