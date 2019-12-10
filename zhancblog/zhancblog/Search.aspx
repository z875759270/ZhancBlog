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
                  <button type="submit" class="submit" onclick="SearchBlog()"><i class="icon-search"></i></button>
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
        <div class="container">
            <%--blog--%>
            <div class="row d-flex align-items-stretch">
                <div class="text col-lg-7">
                    <div class="text-inner d-flex align-items-center">
                        <div class="content">
                            <header class="post-header">
                                <div class="category"><a href="#">Business</a><a href="#">Technology</a></div>
                                <a href="post.html">
                                    <h2 class="h4">Alberto Savoia Can Teach You About Interior</h2>
                                </a>
                            </header>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrude consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                            <footer class="post-footer d-flex align-items-center">
                                <a href="#" class="author d-flex align-items-center flex-wrap">
                                    <div class="avatar">
                                        <img src="img/avatar-1.jpg" alt="..." class="img-fluid"></div>
                                    <div class="title"><span>John Doe</span></div>
                                </a>
                                <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                <div class="comments"><i class="icon-comment"></i>12</div>
                            </footer>
                        </div>
                    </div>
                </div>
                <div class="image col-lg-5">
                    <img src="img/featured-pic-1.jpeg" alt="...">
                </div>
            </div>
        </div>
    </section>
</asp:Content>

