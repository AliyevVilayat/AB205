(function ($) {
    ('use strict');

    /*----------------------------------------*/
    /*  Preloader  
/*----------------------------------------*/
    var windows = $(window);
    windows.on('load', function () {
        $('.preloader-activate').removeClass('preloader-active');
    });
    jQuery(window).on('load', function () {
        setTimeout(function () {
            jQuery('.open_tm_preloader').addClass('loaded');
        }, 1000);
    });

    /*----------------------------------------*/
    /*  Check if element exists
/*----------------------------------------*/
    $.fn.elExists = function () {
        return this.length > 0;
    };

    /*--
        Custom script to call Background
        Image & Color from html data attribute
    -----------------------------------*/
    $('[data-bg-image]').each(function () {
        var $this = $(this),
            $image = $this.data('bg-image');
        $this.css('background-image', 'url(' + $image + ')');
    });
    $('[data-bg-color]').each(function () {
        var $this = $(this),
            $color = $this.data('bg-color');
        $this.css('background-color', $color);
    });

    /*----------------------------------------*/
    /*  WOW
/*----------------------------------------*/
    new WOW().init();

    /*---------------------------------------
		Header Sticky
---------------------------------*/
    $(window).on('scroll', function () {
        if ($(this).scrollTop() > 210) {
            $('.header-sticky').addClass('sticky');
        } else {
            $('.header-sticky').removeClass('sticky');
        }
    });

    /*----------------------------------------*/
    /*  HasSub Item
/*----------------------------------------*/
    $('.hassub-item li.hassub a, .frequently-item li.has-sub a').on(
        'click',
        function () {
            $(this).removeAttr('href');
            var element = $(this).parent('li');
            if (element.hasClass('open')) {
                element.removeClass('open');
                element.find('li').removeClass('open');
                element.find('ul').slideUp();
            } else {
                element.addClass('open');
                element.children('ul').slideDown();
                element.siblings('li').children('ul').slideUp();
                element.siblings('li').removeClass('open');
                element.siblings('li').find('li').removeClass('open');
                element.siblings('li').find('ul').slideUp();
            }
        }
    );

    /*---------------------------------------
		Swiper All Slider
---------------------------------*/

    /* ---Main Slider--- */
    if ($('.main-slider').elExists()) {
        var swiper = new Swiper('.main-slider', {
            loop: true,
            slidesPerView: 1,
            speed: 750,
            autoplay: {
                delay: 4000,
            },
            effect: 'fade',
            fadeEffect: {
                crossFade: true,
            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            pagination: {
                el: '.swiper-pagination',
                clickable: true,
                type: 'bullets',
            },
        });
    }
    $('.main-slider').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* ---Main Slider Two--- */
    if ($('.main-slider-2').elExists()) {
        var swiper = new Swiper('.main-slider-2', {
            loop: true,
            slidesPerView: 1,
            speed: 750,
            autoplay: {
                delay: 4000,
            },
            effect: 'fade',
            fadeEffect: {
                crossFade: true,
            },
            navigation: {
                nextEl: '.slide-button-next',
                prevEl: '.slide-button-prev',
            },
        });
    }
    $('.main-slider-2').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* --- Product Slider--- */
    if ($('.product-slider').elExists()) {
        var mySwiper = new Swiper('.product-slider', {
            slidesPerView: 4,
            spaceBetween: 30,
            loop: true,
            navigation: {
                nextEl: '.product-button-next',
                prevEl: '.product-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                },
                480: {
                    slidesPerView: 2,
                },
                768: {
                    slidesPerView: 3,
                },
                992: {
                    slidesPerView: 4,
                },
            },
        });
    }

    /* --- Product List Slider--- */
    if ($('.product-list-slider').elExists()) {
        var mySwiper = new Swiper('.product-list-slider', {
            slidesPerView: 3,
            spaceBetween: 30,
            loop: false,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                    slidesPerColumn: 1,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'column',
                },
                768: {
                    slidesPerView: 2,
                    slidesPerColumn: 2,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'row',
                },
                1200: {
                    slidesPerView: 3,
                    slidesPerColumn: 2,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'row',
                },
            },
        });
    }

    /* --- Product List Slider Two--- */
    if ($('.widgets-list-slider').elExists()) {
        var mySwiper = new Swiper('.widgets-list-slider', {
            slidesPerView: 1,
            loop: false,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                    slidesPerColumn: 1,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'column',
                    spaceBetween: 5,
                },
                768: {
                    slidesPerView: 1,
                    slidesPerColumn: 2,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'row',
                },
                992: {
                    slidesPerView: 1,
                    slidesPerColumn: 4,
                    slidesPerGroup: 1,
                    slidesPerColumnFill: 'row',
                },
            },
        });
    }

    /* --- Blog Slider--- */
    if ($('.blog-slider').elExists()) {
        var swiper = new Swiper('.blog-slider', {
            slidesPerView: 3,
            spaceBetween: 30,
            speed: 750,
            autoplay: {
                delay: 5000,
            },
            loop: true,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                },
                768: {
                    slidesPerView: 2,
                },
                992: {
                    slidesPerView: 3,
                },
            },
        });
    }
    $('.blog-slider').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* --- Single Blog Slider--- */
    if ($('.single-blog-slider').elExists()) {
        var swiper = new Swiper('.single-blog-slider', {
            slidesPerView: 1,
            effect: 'fade',
            fadeEffect: {
                crossFade: true,
            },
            speed: 750,
            autoplay: {
                disableOnInteraction: false,
                delay: 3000,
            },
            loop: true,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
        });
    }
    $('.single-blog-slider').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* --- Testimonial Sliderr--- */
    if ($('.testimonial-slider').elExists()) {
        var mySwiper = new Swiper('.testimonial-slider', {
            preventInteractionOnTransition: true,
            slidesPerView: 3,
            spaceBetween: 30,
            loop: true,
            navigation: {
                nextEl: '.testimonial-button-next',
                prevEl: '.testimonial-button-prev',
            },
            pagination: {
                el: '.swiper-pagination',
                clickable: true,
                type: 'bullets',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                },
                768: {
                    slidesPerView: 2,
                },
                1200: {
                    slidesPerView: 3,
                },
            },
        });
    }

    /* --- Brand Slider--- */
    if ($('.brand-slider').elExists()) {
        var swiper = new Swiper('.brand-slider', {
            slidesPerView: 5,
            spaceBetween: 120,
            loop: true,
            speed: 750,
            autoplay: {
                delay: 4000,
            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 2,
                    spaceBetween: 30,
                },
                480: {
                    slidesPerView: 3,
                    spaceBetween: 30,
                },
                992: {
                    slidesPerView: 4,
                },
                1200: {
                    slidesPerView: 5,
                },
            },
        });
    }
    $('.brand-slider').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* --- Brand Slider--- */
    if ($('.brand-slider-2').elExists()) {
        var swiper = new Swiper('.brand-slider-2', {
            slidesPerView: 5,
            spaceBetween: 120,
            loop: true,
            speed: 750,
            autoplay: {
                delay: 4000,
            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 2,
                    spaceBetween: 30,
                },
                480: {
                    slidesPerView: 3,
                    spaceBetween: 30,
                },
                992: {
                    slidesPerView: 4,
                },
                1200: {
                    slidesPerView: 5,
                },
            },
        });
    }
    $('.brand-slider-2').hover(
        function () {
            this.swiper.autoplay.stop();
        },
        function () {
            this.swiper.autoplay.start();
        }
    );

    /* --- Team Member Sliderr--- */
    if ($('.team-member-slider').elExists()) {
        var mySwiper = new Swiper('.team-member-slider', {
            slidesPerView: 3,
            spaceBetween: 30,
            loop: true,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            breakpoints: {
                320: {
                    slidesPerView: 1,
                },
                576: {
                    slidesPerView: 2,
                },
                768: {
                    slidesPerView: 3,
                },
            },
        });
    }

    /* ---Single Product Slider--- */
    if ($('.single-product-slider').elExists()) {
        const multipleSwiperSlides = function () {
            let sliderMain = document.querySelectorAll(
                '.single-product-slider'
            );
            let sliderNav = document.querySelectorAll('.single-product-thumbs');

            let mainArray = [];
            let navArray = [];

            sliderMain.forEach(function (element, i) {
                mainArray.push(
                    new Swiper(element, {
                        loop: true,
                        loopedSlides: 3,
                    })
                );
            });

            sliderNav.forEach(function (element, i) {
                var self = sliderNav;
                navArray.push(
                    new Swiper(element, {
                        slidesPerView: 3,
                        loop: true,
                        loopedSlides: 3,
                        slideToClickedSlide: true,
                        spaceBetween: 20,
                        navigation: {
                            nextEl: self[i].querySelector(
                                '.thumbs-button-next'
                            ),
                            prevEl: self[i].querySelector(
                                '.thumbs-button-prev'
                            ),
                        },
                    })
                );
            });

            const checkOnPage = function () {
                if (sliderMain.length > 0 && sliderNav.length > 0) {
                    let numberOfSlides =
                        mainArray.length || navArray.length || 0;
                    for (let i = 0; i < numberOfSlides; i++) {
                        mainArray[i].controller.control = navArray[i];
                        navArray[i].controller.control = mainArray[i];
                    }
                }
            };

            checkOnPage();
        };

        multipleSwiperSlides();
    }

    /* ---Modal Slider--- */
    if ($('.modal-slider').elExists()) {
        var mySwiper = new Swiper('.modal-slider', {
            autoplay: false,
            delay: 5000,
            slidesPerView: 1,
            slidesPerGroup: 1,
            observer: true,
            observeParents: true,
            loop: false,
            navigation: {
                nextEl: '.thumbs-button-next',
                prevEl: '.thumbs-button-prev',
            },
        });
    }

    /* ---Scene--- */
    $('.scene').each(function () {
        new Parallax($(this)[0]);
    });

    /*----------------------------------------*/
    /*  CounterUp
/*----------------------------------------*/
    if ($('.count').elExists()) {
        $('.count').counterUp({
            delay: 10,
            time: 1000,
        });
    }

    /*----------------------------------------*/
    /* Toggle Function Active
	/*----------------------------------------*/
    // showlogin toggle
    $('#showlogin').on('click', function () {
        $('#checkout-login').slideToggle(900);
    });
    // showlogin toggle
    $('#showcoupon').on('click', function () {
        $('#checkout_coupon').slideToggle(900);
    });
    // showlogin toggle
    $('#cbox').on('click', function () {
        $('#cbox-info').slideToggle(900);
    });

    // showlogin toggle
    $('#ship-box').on('click', function () {
        $('#ship-box-info').slideToggle(1000);
    });

    /*----------------------------------------*/
    /*  Countdown
/*----------------------------------------*/
    function makeTimer($endDate, $this, $format) {
        var today = new Date();
        var BigDay = new Date($endDate),
            msPerDay = 24 * 60 * 60 * 1000,
            timeLeft = BigDay.getTime() - today.getTime(),
            e_daysLeft = timeLeft / msPerDay,
            daysLeft = Math.floor(e_daysLeft),
            e_hrsLeft = (e_daysLeft - daysLeft) * 24,
            hrsLeft = Math.floor(e_hrsLeft),
            e_minsLeft = (e_hrsLeft - hrsLeft) * 60,
            minsLeft = Math.floor((e_hrsLeft - hrsLeft) * 60),
            e_secsLeft = (e_minsLeft - minsLeft) * 60,
            secsLeft = Math.floor((e_minsLeft - minsLeft) * 60);

        var yearsLeft = 0;
        var monthsLeft = 0;
        var weeksLeft = 0;

        if ($format != 'short') {
            if (daysLeft > 365) {
                yearsLeft = Math.floor(daysLeft / 365);
                daysLeft = daysLeft % 365;
            }

            if (daysLeft > 30) {
                monthsLeft = Math.floor(daysLeft / 30);
                daysLeft = daysLeft % 30;
            }
            if (daysLeft > 7) {
                weeksLeft = Math.floor(daysLeft / 7);
                daysLeft = daysLeft % 7;
            }
        }

        var yearsLeft = yearsLeft < 10 ? '0' + yearsLeft : yearsLeft,
            monthsLeft = monthsLeft < 10 ? '0' + monthsLeft : monthsLeft,
            weeksLeft = weeksLeft < 10 ? '0' + weeksLeft : weeksLeft,
            daysLeft = daysLeft < 10 ? '0' + daysLeft : daysLeft,
            hrsLeft = hrsLeft < 10 ? '0' + hrsLeft : hrsLeft,
            minsLeft = minsLeft < 10 ? '0' + minsLeft : minsLeft,
            secsLeft = secsLeft < 10 ? '0' + secsLeft : secsLeft,
            yearsText = yearsLeft > 1 ? 'years' : 'year',
            monthsText = monthsLeft > 1 ? 'months' : 'month',
            weeksText = weeksLeft > 1 ? 'weeks' : 'week',
            daysText = daysLeft > 1 ? 'days' : 'day',
            hourText = hrsLeft > 1 ? 'hrs' : 'hr',
            minsText = minsLeft > 1 ? 'mins' : 'min',
            secText = secsLeft > 1 ? 'secs' : 'sec';

        var $markup = {
            wrapper: $this.find('.countdown__item'),
            year: $this.find('.yearsLeft'),
            month: $this.find('.monthsLeft'),
            week: $this.find('.weeksLeft'),
            day: $this.find('.daysLeft'),
            hour: $this.find('.hoursLeft'),
            minute: $this.find('.minsLeft'),
            second: $this.find('.secsLeft'),
            yearTxt: $this.find('.yearsText'),
            monthTxt: $this.find('.monthsText'),
            weekTxt: $this.find('.weeksText'),
            dayTxt: $this.find('.daysText'),
            hourTxt: $this.find('.hoursText'),
            minTxt: $this.find('.minsText'),
            secTxt: $this.find('.secsText'),
        };

        var elNumber = $markup.wrapper.length;
        $this.addClass('item-' + elNumber);
        $($markup.year).html(yearsLeft);
        $($markup.yearTxt).html(yearsText);
        $($markup.month).html(monthsLeft);
        $($markup.monthTxt).html(monthsText);
        $($markup.week).html(weeksLeft);
        $($markup.weekTxt).html(weeksText);
        $($markup.day).html(daysLeft);
        $($markup.dayTxt).html(daysText);
        $($markup.hour).html(hrsLeft);
        $($markup.hourTxt).html(hourText);
        $($markup.minute).html(minsLeft);
        $($markup.minTxt).html(minsText);
        $($markup.second).html(secsLeft);
        $($markup.secTxt).html(secText);
    }

    if ($('.countdown').elExists()) {
        $('.countdown').each(function () {
            var $this = $(this);
            var $endDate = $(this).data('countdown');
            var $format = $(this).data('format');
            setInterval(function () {
                makeTimer($endDate, $this, $format);
            }, 0);
        });
    }

    /*------------------------------------
	    Magnific Popup
	    ------------------------------------- */
    if ($('.popup-vimeo').elExists()) {
        $('.popup-vimeo').magnificPopup({
            type: 'iframe',
            disableOn: function () {
                if ($(window).width() < 600) {
                    return false;
                }
                return true;
            },
        });
    }
    if ($('.gallery-popup').elExists()) {
        $('.gallery-popup').magnificPopup({
            type: 'image',
            gallery: {
                enabled: true,
            },
        });
    }

    /*------------------------------------
	Toolbar Button
	------------------------------------- */
    var $overlay = $('.global-overlay');
    $('.toolbar-btn').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        var $this = $(this);
        var target = $this.attr('href');
        var prevTarget = $this
            .parent()
            .siblings()
            .children('.toolbar-btn')
            .attr('href');
        $(target).toggleClass('open');
        $(prevTarget).removeClass('open');
        $($overlay).addClass('overlay-open');
    });

    /*----------------------------------------*/
    /*  Click on Documnet
/*----------------------------------------*/
    var $body = $('.global-overlay');

    $body.on('click', function (e) {
        var $target = e.target;
        var dom = $('.main-wrapper').children();

        if (
            !$($target).is('.toolbar-btn') &&
            !$($target).parents().is('.open')
        ) {
            dom.removeClass('open');
            dom.find('.open').removeClass('open');
            $overlay.removeClass('overlay-open');
        }
    });

    /*----------------------------------------*/
    /*  Close Button Actions
/*----------------------------------------*/
    $('.button-close').on('click', function (e) {
        var dom = $('.main-wrapper').children();
        e.preventDefault();
        var $this = $(this);
        $this.parents('.open').removeClass('open');
        dom.find('.global-overlay').removeClass('overlay-open');
    });

    /*----------------------------------------*/
    /*  Offcanvas
/*----------------------------------------*/
    var $offcanvasNav = $('.mobile-menu, .offcanvas-minicart_menu'),
        $offcanvasNavWrap = $(
            '.mobile-menu_wrapper, .offcanvas-minicart_wrapperm, .offcanvas-search_wrapper'
        ),
        $offcanvasNavSubMenu = $offcanvasNav.find('.sub-menu'),
        $menuToggle = $('.menu-btn'),
        $menuClose = $('.button-close');

    $offcanvasNavSubMenu.slideUp();

    $offcanvasNav.on('click', 'li a, li .menu-expand', function (e) {
        var $this = $(this);
        if (
            $this
                .parent()
                .attr('class')
                .match(
                    /\b(menu-item-has-children|has-children|has-sub-menu)\b/
                ) &&
            ($this.attr('href') === '#' ||
                $this.attr('href') === '' ||
                $this.hasClass('menu-expand'))
        ) {
            e.preventDefault();
            if ($this.siblings('ul:visible').length) {
                $this.siblings('ul').slideUp('slow');
            } else {
                $this
                    .closest('li')
                    .siblings('li')
                    .find('ul:visible')
                    .slideUp('slow');
                $this.closest('li').siblings('li').removeClass('menu-open');
                $this.siblings('ul').slideDown('slow');
                $this.parent().siblings().children('ul').slideUp();
            }
        }
        if (
            $this.is('a') ||
            $this.is('span') ||
            $this.attr('class').match(/\b(menu-expand)\b/)
        ) {
            $this.parent().toggleClass('menu-open');
        } else if (
            $this.is('li') &&
            $this.attr('class').match(/\b('menu-item-has-children')\b/)
        ) {
            $this.toggleClass('menu-open');
        }
    });

    $('.button-close').on('click', function (e) {
        e.preventDefault();
        $('.mobile-menu .sub-menu').slideUp();
        $('.mobile-menu .menu-item-has-children').removeClass('menu-open');
    });

    /*----------------------------------------*/
    /*  QTY Button
/*----------------------------------------*/
    $('.cart-plus-minus').append(
        '<div class="dec qtybutton"><i class="fa fa-minus"></i></div><div class="inc qtybutton"><i class="fa fa-plus"></i></div>'
    );
    $('.qtybutton').on('click', function () {
        var $button = $(this);
        var oldValue = $button.parent().find('input').val();
        if ($button.hasClass('inc')) {
            var newVal = parseFloat(oldValue) + 1;
        } else {
            // Don't allow decrementing below zero
            if (oldValue > 1) {
                var newVal = parseFloat(oldValue) - 1;
            } else {
                newVal = 1;
            }
        }
        $button.parent().find('input').val(newVal);
    });

    /*----------------------------------------*/
    /*  Nice Select
/*----------------------------------------*/
    if ($('.nice-select').elExists()) {
        $('.nice-select').niceSelect();
    }

    /*----------------------------------------*/
    /*  ion Range Slider 
/*----------------------------------------*/
    $('.pronia-range-slider').ionRangeSlider({
        prefix: '$',
    });

    /*--------------------------------
    Ajax Contact Form
-------------------------------- */
    $(function () {
        // Get the form.
        var form = $('#contact-form');
        // Get the messages div.
        var formMessages = $('.form-message');
        // Set up an event listener for the contact form.
        $(form).submit(function (e) {
            // Stop the browser from submitting the form.
            e.preventDefault();
            // Serialize the form data.
            var formData = $(form).serialize();
            // Submit the form using AJAX.
            $.ajax({
                type: 'POST',
                url: $(form).attr('action'),
                data: formData,
            })
                .done(function (response) {
                    // Make sure that the formMessages div has the 'success' class.
                    $(formMessages).removeClass('error');
                    $(formMessages).addClass('success');

                    // Set the message text.
                    $(formMessages).text(response);

                    // Clear the form.
                    $('#contact-form input,#contact-form textarea').val('');
                })
                .fail(function (data) {
                    // Make sure that the formMessages div has the 'error' class.
                    $(formMessages).removeClass('success');
                    $(formMessages).addClass('error');

                    // Set the message text.
                    if (data.responseText !== '') {
                        $(formMessages).text(data.responseText);
                    } else {
                        $(formMessages).text(
                            'Oops! An error occured and your message could not be sent.'
                        );
                    }
                });
        });
    });

    /*--------------------------------
    Scroll To Top
-------------------------------- */
    function scrollToTop() {
        var $scrollUp = $('.scroll-to-top'),
            $lastScrollTop = 0,
            $window = $(window);

        $window.on('scroll', function () {
            var topPos = $(this).scrollTop();
            if (topPos > $lastScrollTop) {
                $scrollUp.removeClass('show');
            } else {
                if ($window.scrollTop() > 200) {
                    $scrollUp.addClass('show');
                } else {
                    $scrollUp.removeClass('show');
                }
            }
            $lastScrollTop = topPos;
        });

        $scrollUp.on('click', function (evt) {
            $('html, body').animate(
                {
                    scrollTop: 0,
                },
                600
            );
            evt.preventDefault();
        });
    }

    scrollToTop();

    /*--------------------------------
    MailChimp
-------------------------------- */
    $('#mc-form').ajaxChimp({
        language: 'en',
        callback: mailChimpResponse,
        url: 'https://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef',
    });
    function mailChimpResponse(resp) {
        if (resp.result === 'success') {
            $('.mailchimp-success').addClass('active');
            $('.mailchimp-success')
                .html('' + resp.msg)
                .fadeIn(900);
            $('.mailchimp-error').fadeOut(400);
        } else if (resp.result === 'error') {
            $('.mailchimp-error')
                .html('' + resp.msg)
                .fadeIn(900);
        }
    }
})(jQuery);
