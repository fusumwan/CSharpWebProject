/// <reference path="jquery-1.3.2-vsdoc2.js" />

/* helper functions */

var applyFunction = function(sender, fn) {
    return function() {
        fn.apply(sender);
    };
};

/* global-navigation */

$(document).ready(function() {
    $("#global-navigation li.toplevel").mouseenter(function() {
        var sublevel = $(".sublevel", this);
        var iframe = $("#stupidie");
        var glnav = $("#global-navigation");
        sublevel.css("zIndex", 3000);
        sublevel.show();
        if (sublevel[0].offsetLeft + sublevel[0].offsetWidth >
            glnav[0].offsetLeft + glnav[0].offsetWidth) {

            sublevel.css("left", glnav[0].offsetLeft + glnav[0].offsetWidth - sublevel[0].offsetWidth - 1);
            // This and the following section is commented because IE 6 will display it of a line's height
            /*
            if ($(".ceiling", sublevel).length == 0) {
            sublevel.prepend("<div class=\"ceiling\"></div>");
            $(".ceiling", this).width($(".sublevel", this)[0].offsetWidth - $("a.toplevel", this)[0].offsetWidth)
            .css("margin-right", $("a.toplevel", this)[0].offsetWidth + "px");
            }
            */
        } else {
            /*
            if ($(".ceiling", sublevel).length == 0) {
            sublevel.prepend("<div class=\"ceiling\"></div>");
            $(".ceiling", this).width($(".sublevel", this)[0].offsetWidth - $("a.toplevel", this)[0].offsetWidth)
            .css("margin-left", $("a.toplevel", this)[0].offsetWidth + "px");
            }
            */
        }
        if (sublevel.length > 0 && iframe.length > 0) {
            iframe.css("top", sublevel[0].offsetTop);
            iframe.css("left", sublevel[0].offsetLeft);
            iframe.css("height", sublevel[0].offsetHeight);
            iframe.css("width", sublevel[0].offsetWidth);
            iframe.show();
        }
        $("a.toplevel", this).addClass("hover");
    });
    $("#global-navigation li.toplevel").mouseleave(function() {
        $(".sublevel", this).hide();
        $("#stupidie").hide();
        $("a.toplevel", this).removeClass("hover");
        //$(".sublevel .ceiling", this).remove();
    });
    $(".sublevel").hide();
    $("#global-navigation").append("<iframe id=\"stupidie\" src=\"javascript:'<html></html>';\" scrolling=\"no\" frameborder=\"0\" style=\"position:absolute;border:none;display:none;z-index:0\"></iframe>");
});

/* global-loading */
//document.writeln("<div id=\"global-loading\">Loading...</div>");

$(document).ready(
    function() {
        var indicatorEnabled = true;

        var hideLoadingBox = function() {
            $("#global-loading").fadeOut("fast");
        };

        var showLoadingBox = function() {
            if (!indicatorEnabled) return;
            $("#global-loading").css("display", "block");
        };

        var delayHideLoadingBox = function() {
            setTimeout(hideLoadingBox, 200);
        };

        var brieflyDisableLoadingIndicatior = function() {
            indicatorEnabled = false;
            setTimeout(function() { indicatorEnabled = true; }, 100);
        };

        window.onbeforeunload = showLoadingBox;
        document.onbeforeunload = showLoadingBox;
        try {
            var manager = Sys.WebForms.PageRequestManager.getInstance();
            manager.add_pageLoaded(delayHideLoadingBox);
            manager.add_pageLoading(showLoadingBox);
            manager.add_beginRequest(showLoadingBox);
            manager.add_endRequest(delayHideLoadingBox)
        } catch (ex) {
            // we just ignore it
        }

        // the "global-loading-disabled" class can be used on specific links / buttons
        // so that the loading indicator can be disabled briefly, and re-enable it
        // subsequently after the onbeforeunload event is fired.
        $(".global-loading-disabled").click(brieflyDisableLoadingIndicatior);
        $(".global-loading-disabled").keypress(brieflyDisableLoadingIndicatior);

        delayHideLoadingBox();
    }
);

/* multipage-navigation */

function MultiPaging(navigationId) {
    this.pages = new Object();
    this.registeredToDocument = false;
    this.navigationId = navigationId;
}

MultiPaging.prototype.registerPage = function(pageName, pageId) {
    this.pages[pageName] = pageId

    var navId = this.navigationId
    var pagingObj = this;

    $("#" + this.navigationId + " a[href='#" + pageName + "']").mouseup(
        function() {
            pagingObj.switchToPage(pageName);
        }
    );

    if (!this.registeredToDocument) {
        $(document).ready(function() {
            pagingObj.init();
        });
        this.registeredToDocument = true;
    }
}

MultiPaging.prototype.switchToPage = function(pageName) {
    var p = $("#" + this.navigationId);

    $("a.current", p).removeClass("current");

    for (var i in this.pages) {
        if (i == pageName) {
            $("#" + this.pages[i]).css("display", "block");
            $("a[href='#" + i + "']", p).addClass("current");
        } else {
            $("#" + this.pages[i]).css("display", "none");
        }
    }
}

MultiPaging.prototype.getAnchor = function(url) {
    // Check for anchor and select active image from nav
    var hash = null;
    if ((url.match(/#(\w.*)/) != null)) {
        hash = url.match(/#(\w.*)/)[1];
    }
    return hash;
}

MultiPaging.prototype.init = function() {
    var p = $("#" + this.navigationId);
    var anchor = this.getAnchor(window.location.toString());
    var firstPage = null;

    if (anchor) {
        // we'll switch to this page
        var links = $("a[href='#" + anchor + "']", p);
        if (links.length > 0) {
            firstPage = anchor;
        }
    }

    if (!firstPage) {
        // firstly, try if there is a currently already defined
        var currentLinks = $("a.current", p);
        if (currentLinks.length > 0 && this.getAnchor(currentLinks[0].href)) {
            firstPage = this.getAnchor(currentLinks[0].href);
        }
    }

    if (!firstPage) {
        var firstLink = $("a:first", p);
        if (firstLink.length > 0 && this.getAnchor(firstLink[0].href)) {
            firstPage = this.getAnchor(firstLink[0].href);
        }
    }

    if (firstPage) {
        this.switchToPage(firstPage);
    }
}

/* table-report */
$(document).ready(function() {
    $(".behave-rowselect tr td").click(function() {
        /* $(":checkbox:first-child").click(); */
        var b = $(":checkbox:first-child", $(this).parent()[0]);
        if (b.length > 0) {
            b[0].checked = !b[0].checked;
        }
    });

    $(".behave-rowselect a, .behave-rowselect input").click(function(e) {
        /* courtesy quirksmode.org */
        if (!e) e = window.event;
        e.cancelBubble = true;
        if (e.stopPropagation) e.stopPropagation();
    });

});

/* widget-headingmenu */
$(document).ready(function() {
    $(".widget-headingmenu").mouseenter(function() {
        $("ul", this).fadeIn("fast");
    });
    $(".widget-headingmenu").mouseleave(function() {
        $("ul", this).fadeOut("fast");
    });
});

$(document).ready(function() {
    $(".search-quickoption div.toggle").click(function() {
        $("input[id$='SearchPaneReveal']").val(
            ($("div[id$='SearchOptionsPanel']").css("display") == "block")
                ? "False" : "True");
        $("div[id$='SearchOptionsPanel']").slideToggle(function() {
            $(".search-quickoption div.toggle a").html(($("input[id$='SearchPaneReveal']").val() == "True") ? "less options" : "more options");
            $("div.suboption").toggle();
        });

    });

    if ($("input[id$='SearchPaneReveal']").val() == "True") {
        $("div[id$='SearchOptionsPanel']").css("display", "block");
    } else {
        $("div[id$='SearchOptionsPanel']").css("display", "none");
    }
    $(".search-quickoption div.toggle a").html(($("input[id$='SearchPaneReveal']").val() == "True") ? "less options" : "more options");
});

$(document).ready(function() {
    $(".action-result .dismiss").click(function() {
        $(this).parent(".action-result").fadeTo("fast", 0).slideUp("fast")
    });
});

var behaveTableSelectAll = function(tableIdSuffix, checkedValue) {
    $("[id$='" + tableIdSuffix + "'].behave-rowselect input:checkbox").each(function() {
        this.checked = checkedValue;
    });
}