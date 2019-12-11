<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BlogInfo.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Blog Content</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <!-- Latest Posts -->
            <main class="post blog-post col-lg-8">
                <div class="container">
                    <div class="post-single" id="bloginfo" runat="server">
                    </div>
                </div>
            </main>
            <aside class="col-lg-4">
                <!-- Widget [Latest Posts Widget]        -->
                <div class="widget latest-posts">
                    <header>
                        <h3 class="h5">最新发布</h3>
                    </header>
                    <div class="blog-posts">
                        <a href="#">
                            <div class="item d-flex align-items-center">
                                <div class="image">
                                    <img src="img/small-thumbnail-1.jpg" alt="..." class="img-fluid">
                                </div>
                                <div class="title">
                                    <strong>Alberto Savoia Can Teach You About</strong>
                                    <div class="d-flex align-items-center">
                                        <div class="views"><i class="icon-eye"></i>500</div>
                                        <div class="comments"><i class="icon-comment"></i>12</div>
                                    </div>
                                </div>
                            </div>
                        </a><a href="#">
                            <div class="item d-flex align-items-center">
                                <div class="image">
                                    <img src="img/small-thumbnail-2.jpg" alt="..." class="img-fluid">
                                </div>
                                <div class="title">
                                    <strong>Alberto Savoia Can Teach You About</strong>
                                    <div class="d-flex align-items-center">
                                        <div class="views"><i class="icon-eye"></i>500</div>
                                        <div class="comments"><i class="icon-comment"></i>12</div>
                                    </div>
                                </div>
                            </div>
                        </a><a href="#">
                            <div class="item d-flex align-items-center">
                                <div class="image">
                                    <img src="img/small-thumbnail-3.jpg" alt="..." class="img-fluid">
                                </div>
                                <div class="title">
                                    <strong>Alberto Savoia Can Teach You About</strong>
                                    <div class="d-flex align-items-center">
                                        <div class="views"><i class="icon-eye"></i>500</div>
                                        <div class="comments"><i class="icon-comment"></i>12</div>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <!-- Widget [Categories Widget]-->
                <div class="widget categories" id="divCategories" runat="server">
                    <header>
                        <h3 class="h5">分类</h3>
                    </header>
                    <div class="item d-flex justify-content-between"><a href="#">Growth</a><span>12</span></div>
                    <div class="item d-flex justify-content-between"><a href="#">Local</a><span>25</span></div>
                    <div class="item d-flex justify-content-between"><a href="#">Sales</a><span>8</span></div>
                    <div class="item d-flex justify-content-between"><a href="#">Tips</a><span>17</span></div>
                    <div class="item d-flex justify-content-between"><a href="#">Local</a><span>25</span></div>
                </div>
                <!-- Widget [Tags Cloud Widget]-->
                <div class="widget tags" id="divTags" runat="server">
                    <header>
                        <h3 class="h5">标签</h3>
                    </header>
                    <ul class="list-inline">
                        <li class="list-inline-item"><a href="#" class="tag">#Business</a></li>
                        <li class="list-inline-item"><a href="#" class="tag">#Technology</a></li>
                        <li class="list-inline-item"><a href="#" class="tag">#Fashion</a></li>
                        <li class="list-inline-item"><a href="#" class="tag">#Sports</a></li>
                        <li class="list-inline-item"><a href="#" class="tag">#Economy</a></li>
                    </ul>
                </div>
            </aside>
        </div>
    </div>
    <script src="js/showdown.js"></script>
    <script src="js/showdown.min.js"></script>
    <script type="text/javascript">
        function a() {
            var text = document.getElementById("blogbody").innerText;
            console.log(text);
            var converter = new showdown.Converter();
            var html = converter.makeHtml(text);
            console.log(html);
            document.getElementById("blogbody").innerHTML = html;
        }

    </script>
</asp:Content>


