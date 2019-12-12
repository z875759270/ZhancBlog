$(document).ready(function () {
    $("[name='btnSearch']").click(SearchBlog);
    SetNavActive();
    SetLbtSize();
    window.onresize = SetLbtSize;
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
    window.location.href = "Search.aspx?search=" + ($("[name='txtSearch']").val());
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

function SetLbtSize() {
    //获取浏览器窗口高度
    $("#lbt").attr("style", "display:block;position:absolute;width:" + $(".hero").width() + "px;height:" + $(".hero").height()+"px");
}

function GetWidth() {
    var winWidth = 0;
    if (window.innerWidth)
        winWidth = window.innerWidth;
    else if ((document.body) && (document.body.clientWidth))
        winWidth = document.body.clientWidth;
    //通过深入Document内部对body进行检测，获取浏览器窗口高度
    if (document.documentElement && document.documentElement.clientWidth)
        winWidth = document.documentElement.clientWidth;
    return winWidth;
}

function GetHeight() {
    var winHeight = 0;
    if (window.innerHeight)
        winHeight = window.innerHeight;
    else if ((document.body) && (document.body.clientHeight))
        winHeight = document.body.clientHeight;
    //通过深入Document内部对body进行检测，获取浏览器窗口高度
    if (document.documentElement && document.documentElement.clientHeight)
        winHeight = document.documentElement.clientHeight;
    return winHeight;
}
