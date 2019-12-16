$(document).ready(function () {

    $("[name='btnSearch']").click(SearchBlog);
    LinkAnimate();
    SetNavActive();
    SetLbtSize();
    window.onresize = SetLbtSize;
    siteTime();
})

function SetNavActive() {
    var pagename = window.location.pathname;
    if (pagename.includes('Default.aspx') || pagename == "/")
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
    $("#lbt").attr("style", "display:block;position:absolute;width:" + $(".hero").width() + "px;height:" + $(".hero").height() + "px");
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

function LinkAnimate() {
    //联系本人
    $("#contactmea").click(function () {
        $('html, body').animate({
            scrollTop: $("#contactme").offset().top
        }, 1000);
        return false;
    })
}

function siteTime() {
    window.setTimeout("siteTime()", 1000);
    var seconds = 1000;
    var minutes = seconds * 60;
    var hours = minutes * 60;
    var days = hours * 24;
    var years = days * 365;
    var today = new Date();
    var todayYear = today.getFullYear();
    var todayMonth = today.getMonth();
    var todayDate = today.getDate();
    var todayHour = today.getHours();
    var todayMinute = today.getMinutes();
    var todaySecond = today.getSeconds();
    /* Date.UTC() -- 返回date对象距世界标准时间(UTC)1970年1月1日午夜之间的毫秒数(时间戳)
    year - 作为date对象的年份，为4位年份值
    month - 0-11之间的整数，做为date对象的月份
    day - 1-31之间的整数，做为date对象的天数
    hours - 0(午夜24点)-23之间的整数，做为date对象的小时数
    minutes - 0-59之间的整数，做为date对象的分钟数
    seconds - 0-59之间的整数，做为date对象的秒数
    microseconds - 0-999之间的整数，做为date对象的毫秒数 */
    var t1 = Date.UTC(2019, 11, 13, 15, 20, 00);
    var t2 = Date.UTC(todayYear, todayMonth, todayDate, todayHour, todayMinute, todaySecond);
    var diff = t2 - t1;
    var diffYears = Math.floor(diff / years);
    var diffDays = Math.floor((diff / days) - diffYears * 365);
    var diffHours = Math.floor((diff - (diffYears * 365 + diffDays) * days) / hours);
    var diffMinutes = Math.floor((diff - (diffYears * 365 + diffDays) * days - diffHours * hours) / minutes);
    var diffSeconds = Math.floor((diff - (diffYears * 365 + diffDays) * days - diffHours * hours - diffMinutes * minutes) / seconds);
    document.getElementById("sitetime").innerHTML = ("这破网站已运行" + diffYears + " 年 " + diffDays + " 天 " + diffHours + " 小时 " + diffMinutes + " 分钟 " + diffSeconds + " 秒");
}



