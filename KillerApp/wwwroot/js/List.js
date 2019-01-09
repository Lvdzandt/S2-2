var first = true;
var active = 1;
var rightValue = 0;

function navClickLeft(SignitureWord) {
    console.log(SignitureWord);
    rightValue -= getScrollDistance(SignitureWord);
    $('#' + SignitureWord + "CardsHolder").css("right", rightValue + "px");
}


function navClickRight(SignitureWord) {
    rightValue += getScrollDistance(SignitureWord);
    $('#' + SignitureWord + "CardsHolder").css("right", rightValue + "px");
}


function getScrollDistance(SignitureWord) {
    var elementWidth = $($('#' + SignitureWord + "CardsHolder").children()[0]).outerWidth();
    var windowWidth = $(window).width();
    var amount = windowWidth / elementWidth;
    var elementsToScroll = amount - 2;
    if (elementsToScroll < 1) { elementsToScroll = 1; }
    var result = elementsToScroll * elementWidth;


    return result;
}
