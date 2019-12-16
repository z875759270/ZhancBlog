<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Zhanc's Blog</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Hero Section-->
    <section style="background-size: cover; background-position: center center" class="hero">
        <iframe id="lbt" src="lbt.aspx" sandbox="allow-forms allow-modals allow-pointer-lock allow-popups allow-presentation allow-same-origin allow-scripts" allow="geolocation; microphone; camera; midi; vr; accelerometer; gyroscope; payment; ambient-light-sensor; encrypted-media" scrolling="No" allowtransparency="true" allowpaymentrequest="true" allowfullscreen="true" style="display: block; position: absolute"></iframe>
        <div class="container">
            <div class="row">
                <div class="col-lg-7">
                    <h1>Zhanc's Blog - Record My Growth.</h1>
                    <a href="#" class="hero-link">Discover More</a>
                </div>
            </div>
            <a href=".intro" class="continue link-scroll"><i class="fa fa-long-arrow-down"></i>向下滑动</a>

        </div>
    </section>
    <!-- Intro Section-->
    <section class="intro">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <h2 class="h3">詹某的个人秀</h2>
                    <p class="text-big">在此记录一些<b>文章</b>(或技术或无聊或杂七杂八的)，记录日常拍的<b>杂照</b>，记录<b>Everything</b>吧(毕竟买的服务器不能闲着×）
                        <br />
                        如果您在浏览过程中遇见了什么Bug或是有操作不顺畅的地方，敬请<a id="contactmea" href="#contactme"><strong>联系本人</strong></a>（俺看心情什么时候改嘻嘻嘻<br />
                    </p>
                </div>
            </div>
        </div>
    </section>
    <section class="featured-posts no-padding-top">
        <div class="container" id="blogpage" runat="server">
            <!-- Post-->
            <div class="row d-flex align-items-stretch">
                <div class="text col-lg-7">
                    <div class="text-inner d-flex align-items-center">
                        <div class="content">
                            <header class="post-header">
                                <div class="category"><a href="#">Business</a><a href="#">Technology</a></div>
                                <a href="BlogInfo.aspx">
                                    <h2 class="h4">Alberto Savoia Can Teach You About Interior</h2>
                                </a>
                            </header>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrude consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                            <footer class="post-footer d-flex align-items-center">
                                <a href="#" class="author d-flex align-items-center flex-wrap">
                                    <div class="avatar">
                                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg" alt="..." class="img-fluid">
                                    </div>
                                    <div class="title"><span>John Doe</span></div>
                                </a>
                                <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                <div class="comments"><i class="icon-comment"></i>12</div>
                            </footer>
                        </div>
                    </div>
                </div>
                <div class="image col-lg-5">
                    <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/featured-pic-1.jpeg" alt="...">
                </div>
            </div>
            <!-- Post        -->
            <div class="row d-flex align-items-stretch">
                <div class="image col-lg-5">
                    <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/featured-pic-2.jpeg" alt="...">
                </div>
                <div class="text col-lg-7">
                    <div class="text-inner d-flex align-items-center">
                        <div class="content">
                            <header class="post-header">
                                <div class="category"><a href="#">Business</a><a href="#">Technology</a></div>
                                <a href="BlogInfo.aspx">
                                    <h2 class="h4">Alberto Savoia Can Teach You About Interior</h2>
                                </a>
                            </header>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrude consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                            <footer class="post-footer d-flex align-items-center">
                                <a href="#" class="author d-flex align-items-center flex-wrap">
                                    <div class="avatar">
                                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg" alt="..." class="img-fluid">
                                    </div>
                                    <div class="title"><span>John Doe</span></div>
                                </a>
                                <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                <div class="comments"><i class="icon-comment"></i>12</div>
                            </footer>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Post -->
            <div class="row d-flex align-items-stretch">
                <div class="text col-lg-7">
                    <div class="text-inner d-flex align-items-center">
                        <div class="content">
                            <header class="post-header">
                                <div class="category"><a href="#">Business</a><a href="#">Technology</a></div>
                                <a href="BlogInfo.aspx">
                                    <h2 class="h4">Alberto Savoia Can Teach You About Interior</h2>
                                </a>
                            </header>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrude consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                            <footer class="post-footer d-flex align-items-center">
                                <a href="#" class="author d-flex align-items-center flex-wrap">
                                    <div class="avatar">
                                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg" alt="..." class="img-fluid">
                                    </div>
                                    <div class="title"><span>John Doe</span></div>
                                </a>
                                <div class="date"><i class="icon-clock"></i>2 months ago</div>
                                <div class="comments"><i class="icon-comment"></i>12</div>
                            </footer>
                        </div>
                    </div>
                </div>
                <div class="image col-lg-5">
                    <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/featured-pic-3.jpeg" alt="...">
                </div>
            </div>
        </div>
    </section>
    <!-- Divider Section-->
    <section style="background: url(https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/divider-bg.jpg); background-size: cover; background-position: center bottom" class="divider">
        <div class="container">
            <div class="row">
                <div class="col-md-7">
                    <h2>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</h2>
                    <a href="#" class="hero-link">View More</a>
                </div>
            </div>
        </div>
    </section>
    <!-- Latest Posts -->
    <section class="latest-posts">
        <div class="container">
            <header>
                <h2>最新博客</h2>
                <p class="text-big">Don't waste your time.</p>
            </header>
            <div class="row" id="latestblogs" runat="server">
                <div class="post col-md-4">
                    <div class="post-thumbnail">
                        <a href="BlogInfo.aspx">
                            <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/blog-1.jpg" alt="..." class="img-fluid"></a>
                    </div>
                    <div class="post-details">
                        <div class="post-meta d-flex justify-content-between">
                            <div class="date">20 May | 2019</div>
                            <div class="category"><a href="#">Business</a></div>
                        </div>
                        <a href="BlogInfo.aspx">
                            <h3 class="h4">Ways to remember your important ideas</h3>
                        </a>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                    </div>
                </div>
                <div class="post col-md-4">
                    <div class="post-thumbnail">
                        <a href="BlogInfo.aspx">
                            <img src="img/blog-2.jpg" alt="..." class="img-fluid"></a>
                    </div>
                    <div class="post-details">
                        <div class="post-meta d-flex justify-content-between">
                            <div class="date">20 May | 2019</div>
                            <div class="category"><a href="#">Technology</a></div>
                        </div>
                        <a href="BlogInfo.aspx">
                            <h3 class="h4">Diversity in Engineering: Effect on Questions</h3>
                        </a>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                    </div>
                </div>
                <div class="post col-md-4">
                    <div class="post-thumbnail">
                        <a href="BlogInfo.aspx">
                            <img src="img/blog-3.jpg" alt="..." class="img-fluid"></a>
                    </div>
                    <div class="post-details">
                        <div class="post-meta d-flex justify-content-between">
                            <div class="date">20 May | 2019</div>
                            <div class="category"><a href="#">Financial</a></div>
                        </div>
                        <a href="BlogInfo.aspx">
                            <h3 class="h4">Alberto Savoia Can Teach You About Interior</h3>
                        </a>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Newsletter Section-->
    <section class="newsletter no-padding-top">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h2>Subscribe to Newsletter</h2>
                    <p class="text-big">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </div>
                <div class="col-md-8">
                    <div class="form-holder">
                        <form action="#">
                            <div class="form-group">
                                <input type="email" name="email" id="email" placeholder="Type your email address">
                                <button type="submit" class="submit">Subscribe</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Gallery Section-->
    <section class="gallery no-padding">
        <div class="row">
            <div class="mix col-lg-3 col-md-3 col-sm-6">
                <div class="item">
                    <a href="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-1.jpg" data-fancybox="gallery" class="image">
                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-1.jpg" alt="..." class="img-fluid">
                        <div class="overlay d-flex align-items-center justify-content-center"><i class="icon-search"></i></div>
                    </a>
                </div>
            </div>
            <div class="mix col-lg-3 col-md-3 col-sm-6">
                <div class="item">
                    <a href="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-2.jpg" data-fancybox="gallery" class="image">
                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-2.jpg" alt="..." class="img-fluid">
                        <div class="overlay d-flex align-items-center justify-content-center"><i class="icon-search"></i></div>
                    </a>
                </div>
            </div>
            <div class="mix col-lg-3 col-md-3 col-sm-6">
                <div class="item">
                    <a href="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-3.jpg" data-fancybox="gallery" class="image">
                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-3.jpg" alt="..." class="img-fluid">
                        <div class="overlay d-flex align-items-center justify-content-center"><i class="icon-search"></i></div>
                    </a>
                </div>
            </div>
            <div class="mix col-lg-3 col-md-3 col-sm-6">
                <div class="item">
                    <a href="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-4.jpg" data-fancybox="gallery" class="image">
                        <img src="https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/gallery-4.jpg" alt="..." class="img-fluid">
                        <div class="overlay d-flex align-items-center justify-content-center"><i class="icon-search"></i></div>
                    </a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

