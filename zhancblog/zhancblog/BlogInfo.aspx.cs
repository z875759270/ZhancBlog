using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int blogid = Request.QueryString["blogid"] != null ? Convert.ToInt32(Request.QueryString["blogid"].ToString()) : -1;
        if (blogid != -1)
        {
            BlogManager blogManager = new BlogManager();
            Blog blog = blogManager.SelectBlog(blogid);
            CreateBlogInfo(blog);
        }
        CreateCategories();
    }

    private void CreateBlogInfo(Blog blog)
    {
        try
        {
            string[] tags = blog.bTags.Split(',');
            bloginfo.InnerHtml = "<div class=\"post-thumbnail\">\n" +
            "                            <img src=\"" + blog.bTitlepic + "\" alt=\"...\" class=\"img-fluid\">\n" +
            "                        </div>\n" +
            "                        <div class=\"post-details\">\n" +
            "                            <div class=\"post-meta d-flex justify-content-between\">\n" +
            "                                <div class=\"category\"><a href=\"javascript:void(0)\">" + tags[0] + "</a><a href=\"javascript:void(0)\">" + tags[1] + "</a></div>\n" +
            "                            </div>\n" +
            "                            <h1>" + blog.bTitle + "</h1>\n" +
            "                            <div class=\"post-footer d-flex align-items-center flex-column flex-sm-row\">\n" +
            "                                <a href=\"javascript:void(0)\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"avatar\">\n" +
            "                                        <img src=\"img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\">\n" +
            "                                    </div>\n" +
            "                                    <div class=\"title\"><span>Zhanc</span></div>\n" +
            "                                </a>\n" +
            "                                <div class=\"d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"date\"><i class=\"icon-clock\"></i>" + blog.bUpdatedtime.ToString() + "</div>\n" +
            "                                    <div class=\"views\"><i class=\"icon-eye\"></i>" + blog.bHot + "</div>\n" +
            "                                </div>\n" +
            "                            </div>\n" +
            "                            <div class=\"post-body\" id=\"blogbody\">\n" + blog.bContent +
            "                             \n" +
            "                            </div>\n" +
            "                        </div>";
        }
        catch (Exception sa)
        {
            System.Diagnostics.Debug.WriteLine(sa);
        }


    }


    /// <summary>
    /// 创建一篇Blog
    /// </summary>
    private void CreateOneBlog()
    {
        string htmlStr = "            <div class=\"post col-xl-6\">\n" +
            "                            <div class=\"post-thumbnail\"><a href=\"BlogInfo.aspx\">\n" +
            "                                <img src=\"img/blog-post-1.jpeg\" alt=\"...\" class=\"img-fluid\"></a></div>\n" +
            "                            <div class=\"post-details\">\n" +
            "                                <div class=\"post-meta d-flex justify-content-between\">\n" +
            "                                    <div class=\"date meta-last\">20 May | 2019</div>\n" +
            "                                    <div class=\"category\"><a href=\"#\">Business</a></div>\n" +
            "                                </div>\n" +
            "                                <a href=\"BlogInfo.aspx\">\n" +
            "                                    <h3 class=\"h4\">Alberto Savoia Can Teach You About Interior</h3>\n" +
            "                                </a>\n" +
            "                                <p class=\"text-muted\">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.</p>\n" +
            "                                <footer class=\"post-footer d-flex align-items-center\">\n" +
            "                                    <a href=\"#\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                        <div class=\"avatar\">\n" +
            "                                            <img src=\"img/avatar-3.jpg\" alt=\"...\" class=\"img-fluid\"></div>\n" +
            "                                        <div class=\"title\"><span>John Doe</span></div>\n" +
            "                                    </a>\n" +
            "                                    <div class=\"date\"><i class=\"icon-clock\"></i>2 months ago</div>\n" +
            "                                    <div class=\"comments meta-last\"><i class=\"icon-comment\"></i>12</div>\n" +
            "                                </footer>\n" +
            "                            </div>\n" +
            "                        </div>";
    }

    /// <summary>
    /// 创建分类 Widget
    /// </summary>
    private void CreateCategories()
    {
        divCategories.InnerHtml = string.Empty;
        divCategories.InnerHtml = "<header><h3 class=\"h5\">分类</h3></header>";
        CategoriesManager categoriesManager = new CategoriesManager();
        List<Categories> categories = categoriesManager.SelectAllCategories();
        for (int i = 0; i < categories.Count; i++)
        {
            divCategories.InnerHtml += "<div class=\"item d-flex justify-content-between\"><a href=\"#\">" + categories[i].cCategory + "</a><span>" + categories[i].cSum + "</span></div>";
        }
    }
}