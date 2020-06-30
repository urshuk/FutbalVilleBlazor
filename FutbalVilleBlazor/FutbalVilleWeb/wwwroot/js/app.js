//carousel
window.initializeCarousel = () => {
    $('.carousel').carousel();
    $('.carousel-control-prev').click(
        () => $('.carousel').carousel('prev'));
    $('.carousel-control-next').click(
        () => $('.carousel').carousel('next'));

}