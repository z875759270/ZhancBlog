<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NotFound.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>你要找的网页莫得辽</title>
    <link href="https://fonts.googleapis.com/css?family=Righteous&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/notfound.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%
        Response.Status = "404 Not Found";
    %>
    <section>
        <div class="code-area">

            <span style="color: #777; font-style: italic;">// 404 page not found.
  </span>
            <span>
                <span style="color: #d65562;">if
    </span>
                (<span style="color: #4ca8ef;">!</span><span style="font-style: italic; color: #bdbdbd;">found</span>)
    {
  </span>
            <span>
                <span style="padding-left: 15px; color: #2796ec">
                    <i style="width: 10px; display: inline-block"></i>throw
    </span>
                <span>(<span style="color: #a6a61f">"(╯°□°)╯︵ ┻━┻"</span>);
    </span>
                <span style="display: block">}</span>
                <span style="color: #777; font-style: italic;">// <a href="Default.aspx"><u>Go home!</u></a>
                </span>
            </span>
        </div>
    </section>
</asp:Content>

