$(document).ready(function () {
    $("[name='btnSearch']").click(SearchBlog);
    SetNavActive();
})

function SetNavActive() {
    var pagename = window.location.pathname;
    if (pagename.includes('Default.aspx') || pagename=="/")
        $("[href='Default.aspx'].nav-link").attr("class", "nav-link active");
    else if (pagename.includes('BlogList.aspx'))
        $("[href='BlogList.aspx'].nav-link").attr("class", "nav-link active");
    else if (pagename.includes('BlogInfo.aspx'))
        $("[href='BlogInfo.aspx'].nav-link").attr("class", "nav-link active");
}

function SearchBlog() {
    window.location.href = "Search.aspx?search=" + $("[name='txtSearch']").val();
    /*$.ajax({
        type: "post",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "Default.aspx/btnSearch",
        data: "{'str':'" + $("[name='txtSearch']").val() + "'}",
        success: function (data) {
            alert(data.d);
        },
        error: function (err) {
            alert("多捞噢" + err.d);
        }
    });
    return false;*/
}
