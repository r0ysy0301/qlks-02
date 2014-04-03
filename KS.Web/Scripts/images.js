$(window).load(function() {
                $('#slider').nivoSlider();
            });
            
            /* ================ TWEETS SCROLL ================ */
            $('.tweets-list-container').tweetscroll({
                username: 'pixel_industry', 
                time: true, 
                limit: 11, 
                replies: true, 
                position: 'append',
                date_format: 'style2',
                animation: 'slide_up',
                visible_tweets: 1
            });
            
            $("#foo3").carouFredSel({
                items: 1,
                auto: true,
                scroll: 1,
                pagination  : "#foo3_pag"
            });

            //placeholder fix
            $('input[placeholder], textarea[placeholder]').placeholder();