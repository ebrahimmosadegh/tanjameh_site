// callback for ltr or rtl direction
function callbackOwlCarousel() {
    var mydir = $("html").attr("dir");
    if (mydir == 'rtl') {
        var rtl = true;
        navText = ['<i class="fa-solid fa-arrow-right"></i>', '<i class="fa-solid fa-arrow-left"></i>'];
    }
    else {
        var rtl = false
        var navText = ['<i class="fa-solid fa-arrow-left"></i>', '<i class="fa-solid fa-arrow-right"></i>'];
    }

    return { rtl, navText };
}
const values = callbackOwlCarousel()
const rtlVal = values.rtl
const navTextVal = values.navText;





window.initializeOwlCarousel = () => {


    var $carousel = $('.owl-center-nonloop');

    if ($carousel.data('owl.carousel')) {
        $carousel.trigger('destroy.owl.carousel');
        $carousel.find('.owl-stage-outer').children().unwrap();
        $carousel.removeClass("owl-center-nonloop owl-loaded owl-hidden");
    }

    if ($carousel.length > 0) {

        $($carousel).owlCarousel({
            loop: false,
            nav: true,
            rtl: rtlVal,
            lazyLoad: true,
            dots: false,
            navText: navTextVal,
            margin: 17,
            responsive: {
                0: {
                    items: 2,
                },
                700: {
                    items: 4,
                },
                1000: {
                    items: 5
                }
            }
        });
    }

};

function slideUp(element, duration = 500) {
    element.style.height = element.offsetHeight + 'px';
    element.style.transitionProperty = 'height, margin, padding';
    element.style.transitionDuration = duration + 'ms';
    element.offsetHeight; // Trigger a reflow
    element.style.overflow = 'hidden';
    element.style.height = 0;
    element.style.paddingTop = 0;
    element.style.paddingBottom = 0;
    element.style.marginTop = 0;
    element.style.marginBottom = 0;

    window.setTimeout(() => {
        element.style.removeProperty('display');
        element.style.removeProperty('height');
        element.style.removeProperty('padding-top');
        element.style.removeProperty('padding-bottom');
        element.style.removeProperty('margin-top');
        element.style.removeProperty('margin-bottom');
        element.style.removeProperty('overflow');
        element.style.removeProperty('transition-duration');
        element.style.removeProperty('transition-property');
        element.classList.remove("open-slide");
    }, duration);
}



function slideToggle(element, duration = 500) {
    if (window.getComputedStyle(element).display === 'none') {
        slideDown(element, duration);
    } else {
        slideUp(element, duration);
    }
}

window.sildeToggle = (id) => {
    slideToggle(document.getElementById(id));
}



// carousel index page
jQuery(document).ready(function ($) {
    window.initializeMenu();
    window.initializeOwlCarousel()

});


window.initializeLazyImage = () => {
    lazyLoad();
}

window.initializeMenu = () => {

    document.querySelectorAll('.has-menu .menu-toggle').forEach(function (toggle) {
        toggle.addEventListener('click', function (e) {
            e.preventDefault();

            var menu = this.nextElementSibling;
            var isVisible = window.getComputedStyle(menu).display !== 'none';


            document.querySelectorAll('.has-menu.open').forEach(function (item) {
                item.classList.remove('open');
                const dropdownMenu = item.querySelector(".i-menu");
                if (dropdownMenu) {
                    slideUp(dropdownMenu, 200);
                }
            });


            if (!isVisible) {
                const slideTime = 300;
                slideDown(menu, slideTime);
                setTimeout(() => {
                    this.parentElement.classList.add('open');
                }, slideTime)
            }
        });
    });

    window.closeAllMenu = () => {
        document.querySelectorAll('.i-menu').forEach(function (menu) {
            slideUp(menu, 300);
        });
        document.querySelectorAll('.has-menu').forEach(function (item) {
            item.classList.remove('open');
        });
    }


    document.querySelectorAll('.has-menu').forEach(function (menu) {
        menu.addEventListener('mousedown', function (e) {
            e.stopPropagation();
        });
    });


    document.addEventListener('mousedown', function () {
        window.closeAllMenu();
    });

}
window.initializeProductSingle = () => {
    // product zoom config
    $('.display1').glassCase({
        //'widthDisplay': 370,
        //'heightDisplay': 550,
        'isSlowZoom': true,
        'isSlowLens': true,
        'capZType': 'in',
        'isHoverShowThumbs': true,
        'colorIcons': '#fff',
        'colorActiveThumb': '#333',
        'thumbsPosition': 'right'
    });

}



// scroll back to top
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 50) {
            $('#back-to-top').fadeIn();
        } else {
            $('#back-to-top').fadeOut();
        }
    });
    // scroll body to 0px on click
    $('#back-to-top').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 400);
        return false;
    });
});

// heart button like and dislike
$(".btn-heart").click(function () {
    var counter = parseFloat($(".heartCounter").text());
    var heartCounter = $(".heartCounter");
    if ($(this).hasClass("dislike")) {
        $(this).removeClass("dislike")
        $(this).html('<i class="fa-solid fa-heart text-orange" aria-hidden="true"></i>');
        counter = counter + 1;
        heartCounter.text(counter);
    }
    if ($(this).hasClass("like")) {
        $(this).addClass("dislike")
        $(this).html('<i class="fa-regular fa-heart" aria-hidden="true"></i>');
        counter = counter - 1;
        heartCounter.text(counter);
    }
    $(this).toggleClass("like");
});

// change button click brand follow
$(document).on('click', '.clike-follow', function () {

    var brandName = $(this).parent().find(".brandName");

    if ($(this).hasClass("notfollow")) {
        $(this).removeClass("notfollow");
        $(this).html('<i class="fa-solid fa-check me-2"></i><span>دنبال شده</span>');
        const toastLiveExample = document.getElementById('brandFollowToast');
        const toast = new bootstrap.Toast(toastLiveExample);
        toast.show()

        if ($("#boxBrandSelected")) {
            $("#boxBrandSelected").append(
                `
        <li class="brandItem col nav-hover">
          <div class="border-bottom px-1 py-2 d-flex align-items-center">
            <a href="${brandName.attr("data-url")}" class="text-decoration-none text-dark">${brandName.text()}</a>
            <button class="btn border-1 rounded-0 btn-outline-dark ms-auto d-flex align-items-center clike-follow follow"><i class="fa-solid fa-check me-2"></i><span>دنبال شده</span></button>
        </div>
        </li>
        `
            )
        }
    }
    if ($(this).hasClass("follow")) {
        $(this).addClass("notfollow");
        $(this).html('<i class="fa-solid fa-plus me-2"></i><span>دنبال کنید</span>');

        if ($("#boxBrandSelected")) {
            $(this).closest(".brandItem").remove();
        }
    }
    $(this).toggleClass("follow");
});



// select all checkbox
$("#checkall").click(function () {
    if ($(this).hasClass('allChecked')) {
        $('input[type="checkbox"]', '#choiceAll').prop('checked', false);
    } else {
        $('input[type="checkbox"]', '#choiceAll').prop('checked', true);
    }
    $(this).toggleClass('allChecked');
});




// image lazy load

let inAdvance = 300;
function lazyLoad() {
    let lazyImages = [...document.querySelectorAll(".lazy-image")];
    lazyImages.forEach((image) => {
        if (image.offsetTop < window.innerHeight + window.pageYOffset + inAdvance) {
            image.src = image.dataset.src;
            image.onload = () => image.classList.add("loaded");
        }
        image.parentElement.classList.remove("placeholder");
    });
    // if all loaded removeEventListener
}

lazyLoad();


// feedback helpful
$('.btnPositive').click(function () {
    if ($('.btnPositive').html('<i class="fa-regular fa-thumbs-up"></i>')) {
        $('.btnPositive').html('<i class="fa-solid fa-thumbs-up"></i>');
        $('.btnNegative').html('<i class="fa-regular fa-thumbs-down"></i>');
    }
    else {
        $('.btnPositive').html('<i class="fa-regular fa-thumbs-up"></i>');
    }
});

$('.btnNegative').click(function () {
    if ($('.btnNegative').html('<i class="fa-regular fa-thumbs-down"></i>')) {
        $('.btnNegative').html('<i class="fa-solid fa-thumbs-down"></i>');
        $('.btnPositive').html('<i class="fa-regular fa-thumbs-up"></i>');
    }
    else {
        $('.btnNegative').html('<i class="fa-regular fa-thumbs-down"></i>');
    }
});



window.initializeSearchBox = () => {

    // ---- ---- Const ---- ---- //
    let inputBox = document.querySelector('.search-input-box'),
        searchIcon = document.querySelector('.search');

    // ---- ---- Open Input ---- ---- //
    searchIcon.addEventListener('click', () => {
        inputBox.classList.add('open');
        inputBox.querySelector("input").focus();
    });
    inputBox.addEventListener('click', () => {
        inputBox.classList.add('open');
    });
    // ---- ---- Close Input ---- ---- //
    document.addEventListener('click', (e) => {
        if (!inputBox.contains(e.target) && !searchIcon.contains(e.target)) {
            inputBox.classList.remove('open');
        }
    });

    $(document).on('click', function () {
        $('.quick-search-results').removeClass('show');
    });
}

window.scrollTop = () => {
    console.log("sc")
    $('body,html').animate({
        scrollTop: 0
    }, 300);
}


function slideUp(element, duration = 500) {
    element.style.height = element.offsetHeight + 'px';
    element.style.transitionProperty = 'height, margin, padding';
    element.style.transitionDuration = duration + 'ms';
    element.offsetHeight; // Trigger a reflow
    element.style.overflow = 'hidden';
    element.style.height = 0;
    element.style.paddingTop = 0;
    element.style.paddingBottom = 0;
    element.style.marginTop = 0;
    element.style.marginBottom = 0;

    window.setTimeout(() => {
        element.style.display = 'none';
        element.style.removeProperty('height');
        element.style.removeProperty('padding-top');
        element.style.removeProperty('padding-bottom');
        element.style.removeProperty('margin-top');
        element.style.removeProperty('margin-bottom');
        element.style.removeProperty('overflow');
        element.style.removeProperty('transition-duration');
        element.style.removeProperty('transition-property');
        element.classList.remove("open-slide");
    }, duration);
}

function slideDown(element, duration = 500) {
    element.style.removeProperty('display');
    let display = window.getComputedStyle(element).display;

    if (display === 'none') {
        display = 'block';
    }

    element.style.display = display;
    let height = element.offsetHeight;
    element.style.height = 0;
    element.style.paddingTop = 0;
    element.style.paddingBottom = 0;
    element.style.marginTop = 0;
    element.style.marginBottom = 0;
    element.offsetHeight; // Trigger reflow

    element.style.transitionProperty = 'height, margin, padding';
    element.style.transitionDuration = duration + 'ms';
    element.style.overflow = 'hidden';
    element.style.height = height + 'px';
    element.style.removeProperty('padding-top');
    element.style.removeProperty('padding-bottom');
    element.style.removeProperty('margin-top');
    element.style.removeProperty('margin-bottom');

    window.setTimeout(() => {
        element.style.removeProperty('height');
        element.style.removeProperty('overflow');
        element.style.removeProperty('transition-duration');
        element.style.removeProperty('transition-property');
        element.classList.add("open-slide");
    }, duration);
}


window.tanjameh = {
    bootstrap: {
        modals: {
            show: el => {
                const instance = bootstrap.Modal.getOrCreateInstance(el);
                instance.show();
            },
            hide: el => {
                const instance = bootstrap.Modal.getOrCreateInstance(el);
                instance.hide();
            }
        }
    }
};


window.isMobile = function () {
    return window.innerWidth <= 768;
};
