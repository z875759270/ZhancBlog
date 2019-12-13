<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BlogList.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>BlogList</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <!-- Latest Posts -->
            <main class="posts-listing col-lg-8">
                <div class="container">
                    <div class="row" id="bloglist" runat="server">
                        <!-- post -->
                        <div class="post col-xl-6">
                            <div class="post-thumbnail"><a href="BlogInfo.aspx">
                                <img src="img/blog-post-1.jpeg" alt="..." class="img-fluid"></a></div>
                            <div class="post-details">
                                <div class="post-meta d-flex justify-content-between">
                                    <div class="date meta-last">20 May | 2019</div>
                                    <div class="category"><a href="#">Business</a></div>
                                </div>
                                <a href="BlogInfo.aspx">
                                    <h3 class="h4">Alberto Savoia Can Teach You About Interior</h3>
                                </a>
                                <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                                <footer class="post-footer d-flex align-items-center">
                                    <a href="#" class="author d-flex align-items-center flex-wrap">
                                        <div class="avatar">
                                            <img src="img/avatar-1.jpg" alt="..." class="img-fluid"></div>
                                        <div class="title"><span>John Doe</span></div>
                                    </a>
                                    <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                    <div class="comments meta-last"><i class="icon-comment"></i>12</div>
                                </footer>
                            </div>
                        </div>
                        <!-- post-->
                        <div class="post col-xl-6">
                            <div class="post-thumbnail"><a href="BlogInfo.aspx">
                                <img src="img/blog-post-2.jpg" alt="..." class="img-fluid"></a></div>
                            <div class="post-details">
                                <div class="post-meta d-flex justify-content-between">
                                    <div class="date meta-last">20 May | 2019</div>
                                    <div class="category"><a href="#">Business</a></div>
                                </div>
                                <a href="BlogInfo.aspx">
                                    <h3 class="h4">Alberto Savoia Can Teach You About Interior</h3>
                                </a>
                                <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                                <div class="post-footer d-flex align-items-center">
                                    <a href="#" class="author d-flex align-items-center flex-wrap">
                                        <div class="avatar">
                                            <img src="img/avatar-1.jpg" alt="..." class="img-fluid"></div>
                                        <div class="title"><span>John Doe</span></div>
                                    </a>
                                    <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                    <div class="comments meta-last"><i class="icon-comment"></i>12</div>
                                </div>
                            </div>
                        </div>
                        <!-- post-->
                        <div class="post col-xl-6">
                            <div class="post-thumbnail"><a href="BlogInfo.aspx">
                                <img src="img/blog-post-3.jpeg" alt="..." class="img-fluid"></a></div>
                            <div class="post-details">
                                <div class="post-meta d-flex justify-content-between">
                                    <div class="date meta-last">20 May | 2019</div>
                                    <div class="category"><a href="#">Business</a></div>
                                </div>
                                <a href="BlogInfo.aspx">
                                    <h3 class="h4">Alberto Savoia Can Teach You About Interior</h3>
                                </a>
                                <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                                <div class="post-footer d-flex align-items-center">
                                    <a href="#" class="author d-flex align-items-center flex-wrap">
                                        <div class="avatar">
                                            <img src="img/avatar-1.jpg" alt="..." class="img-fluid"></div>
                                        <div class="title"><span>John Doe</span></div>
                                    </a>
                                    <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                    <div class="comments meta-last"><i class="icon-comment"></i>12</div>
                                </div>
                            </div>
                        </div>
                        <!-- post -->
                        <div class="post col-xl-6">
                            <div class="post-thumbnail"><a href="BlogInfo.aspx">
                                <img src="img/blog-post-4.jpeg" alt="..." class="img-fluid"></a></div>
                            <div class="post-details">
                                <div class="post-meta d-flex justify-content-between">
                                    <div class="date meta-last">20 May | 2019</div>
                                    <div class="category"><a href="#">Business</a></div>
                                </div>
                                <a href="BlogInfo.aspx">
                                    <h3 class="h4">Alberto Savoia Can Teach You About Interior</h3>
                                </a>
                                <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                                <div class="post-footer d-flex align-items-center">
                                    <a href="#" class="author d-flex align-items-center flex-wrap">
                                        <div class="avatar">
                                            <img src="img/avatar-1.jpg" alt="..." class="img-fluid"></div>
                                        <div class="title"><span>John Doe</span></div>
                                    </a>
                                    <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                    <div class="comments meta-last"><i class="icon-comment"></i>12</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Pagination -->
                    <nav aria-label="Page navigation example">
                        <ul class="pagination pagination-template d-flex justify-content-center" id="pageNum" runat="server">
                            <li class="page-item"><a href="#" class="page-link"><i class="fa fa-angle-left"></i></a></li>
                            <li class="page-item"><a href="#" class="page-link active">1</a></li>
                            <li class="page-item"><a href="#" class="page-link">2</a></li>
                            <li class="page-item"><a href="#" class="page-link">3</a></li>
                            <li class="page-item"><a href="#" class="page-link"><i class="fa fa-angle-right"></i></a></li>
                        </ul>
                    </nav>
                </div>
            </main>
            <aside class="col-lg-4">

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
</asp:Content>

