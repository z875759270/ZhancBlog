<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lbt.aspx.cs" Inherits="lbt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="three-container"></div>
    </form>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/three.js/r75/three.min.js'></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/gsap/1.18.0/TweenMax.min.js'></script>
    <script src='https://s3-us-west-2.amazonaws.com/s.cdpn.io/175711/bas.js'></script>
    <script src='https://s3-us-west-2.amazonaws.com/s.cdpn.io/175711/OrbitControls-2.js'></script>
    <script src="js/script.js"></script>
    <script type="text/javascript">
         //获取浏览器窗口高度
        var winHeight = 0;
        if (window.innerHeight)
            winHeight = window.innerHeight;
        else if ((document.body) && (document.body.clientHeight))
            winHeight = document.body.clientHeight;
        //通过深入Document内部对body进行检测，获取浏览器窗口高度
        if (document.documentElement && document.documentElement.clientHeight)
            winHeight = document.documentElement.clientHeight;

    </script>
</body>
</html>
