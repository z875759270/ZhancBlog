<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--搜索--%>
    <section class="newsletter" style="padding:30px 0">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <div class="form-holder">
                <div class="form-group">
                  <input type="text" placeholder="在此搜索博客..." id="txtSearch">
                  <button type="submit" class="submit"><i class="icon-search"></i></button>
                </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <div style="width:100%;height:20%;margin-bottom:20px" class="text-center">
        <asp:Label ID="lblSearch" runat="server" CssClass="h6" Text="以下内容显示您搜索的‘aslkj’"></asp:Label>
    </div>

    <%--搜索显示的内容--%>
    <section class="featured-posts no-padding-top">
        <div class="container" id="BlogsWidget" runat="server">
            
        </div>
    </section>
</asp:Content>

