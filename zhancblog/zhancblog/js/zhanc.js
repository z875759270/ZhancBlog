$(document).ready(function () {
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