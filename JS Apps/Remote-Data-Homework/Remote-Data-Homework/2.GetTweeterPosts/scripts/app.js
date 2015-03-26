(function () {
    require.config({
        paths: {
            "jquery": "../../libs/jquery/dist/jquery.min",
            "q": "../../libs/q/q",
            "twitterFetcher": "twitterFetcher"
        }
    });

    require(["jquery"], function ($) {
        // 493514735464087552
        var TWEET_CONST = '493514735464087552';

        $('#generate-content').on('click', function(){
            var id = $('#id-field').val();
            if (TWEET_CONST.length != id.length) {
                id = TWEET_CONST;
            }

            twitterFetcher.fetch(id, 'tweet-container', 100, true, true, true);
        })
    });

}());