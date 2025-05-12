function onDataBound(e) {
    var grid = this;
    var themeColor;
    var text;

    grid.table.find("tr").each(function (index) {
        var dataItem = grid.dataItem(this);

        const { themeColor, text } = updateStatus(dataItem.Status);

        $(this).find(".badgeTemplate").kendoBadge({
            themeColor: themeColor,
            text: text,
            rounded: "large",
        });


        kendo.bind($(this), dataItem);
    });

    let firstRow = $(grid.table).find("tr")[1];

    $(firstRow)
        .find(".k-font-icon")
        .on("click", function (e) { })
        .trigger("click");
}

function updateStatus(status) {
    switch (status) {
        case 0:
            return { themeColor: "success", text: "Published" };
        case 1:
            return { themeColor: "warning", text: "Pending" };
        default:
            return { themeColor: "error", text: "Postponed" };
    }
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

