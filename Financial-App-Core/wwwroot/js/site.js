function onDataBound(e) {
        var grid = this;
        var themeColor;
        var text;
        
        grid.table.find("tr").each(function() {
            var dataItem = grid.dataItem(this);
        
            if (dataItem.Status == 0){
                themeColor = "success";
                text = "Published";
            }
            else if (dataItem.Status == 1) {
                themeColor = "warning";
                text = "Pending";
            }
            else{
                themeColor = "error";
                text = "Postponed";
            }
            
            $(this).find(".badgeTemplate").kendoBadge({
                themeColor: themeColor,
                text: text,
                rounded: "large",
            });
            
            
            kendo.bind($(this), dataItem);
        });
}

$(document).on("click", ".legend-toggle", function () {
    const chart = $("#cashFlow").data("kendoChart");
    const seriesName = $(this).data("series");

    const seriesIndex = chart.options.series.findIndex(s => s.name === seriesName);
    if (seriesIndex >= 0) {
        const series = chart.options.series[seriesIndex];
        series.visible = !series.visible;

        // Optional: toggle class to style inactive legend
        $(this).toggleClass("inactive", !series.visible);

        chart.refresh();
    }
});

