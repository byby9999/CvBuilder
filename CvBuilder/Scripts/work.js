$("#addWorkItem").click(function () {

    var firstWorkItemHidden = $(".work-item:hidden").first();
    if (firstWorkItemHidden !== null && firstWorkItemHidden !== undefined) {
        
        firstWorkItemHidden.show();

        var contentOfCurrentTab = firstWorkItemHidden.closest(".content");
        contentOfCurrentTab.css('max-height', '');
        contentOfCurrentTab.css('height', 'auto');
    }
    
    var visibleWorkItems = $(".work-item:visible");
    if (visibleWorkItems.length == 10)
        $("#addWorkItem").css('disabled', 'disabled');
});