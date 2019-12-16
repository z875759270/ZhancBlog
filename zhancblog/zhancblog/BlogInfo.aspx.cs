using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    BlogManager blogManager = new BlogManager();
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateHotBlog();
        int blogid = Request.QueryString["blogid"] != null ? Convert.ToInt32(Request.QueryString["blogid"].ToString()) : -1;
        if (blogid != -1)
        {

            Blog blog = blogManager.SelectBlog(blogid);
            CreateBlogInfo(blog);
            if (!IsPostBack)
                blogManager.HotUp(blog.bID);
        }
        CreateCategories();
    }

    private void CreateBlogInfo(Blog blog)
    {
        try
        {
            string[] tags = blog.bTags.Split(',');
            bloginfo.InnerHtml = "<div class=\"post-thumbnail\">\n" +
            "                            <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/" + blog.bTitlepic + "\" alt=\"...\" class=\"img-fluid\">\n" +
            "                        </div>\n" +
            "                        <div class=\"post-details\">\n" +
            "                            <div class=\"post-meta d-flex justify-content-between\">\n" +
            "                                <div class=\"category\"><a href=\"javascript:void(0)\">" + tags[0] + "</a><a href=\"javascript:void(0)\">" + tags[1] + "</a></div>\n" +
            "                            </div>\n" +
            "                            <h1>" + blog.bTitle + "</h1>\n" +
            "                            <div class=\"post-footer d-flex align-items-center flex-column flex-sm-row\">\n" +
            "                                <a href=\"javascript:void(0)\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"avatar\">\n" +
            "                                        <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\">\n" +
            "                                    </div>\n" +
            "                                    <div class=\"title\"><span>Zhanc</span></div>\n" +
            "                                </a>\n" +
            "                                <div class=\"d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"date\"><i class=\"icon-clock\"></i>" + blog.bUpdatedtime.ToString().Substring(0, 16) + "</div>\n" +
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

    private void CreateHotBlog()
    {
        hotblogs.InnerHtml = "";
        List<Blog> blogs = blogManager.SelectHotestBlogs();
        for (int i = 0; i < blogs.Count; i++)
        {
            hotblogs.InnerHtml += "<a href=\"BlogInfo.aspx?blogid=" + blogs[i].bID + "\">\n" +
            "                            <div class=\"item d-flex align-items-center\">\n" +
            "                                <div class=\"image\">\n" +
            "                                    <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/" + blogs[i].bTitlepic + "\" alt=\"...\" class=\"img-fluid\">\n" +
            "                                </div>\n" +
            "                                <div class=\"title\">\n" +
            "                                    <strong>" + (blogs[i].bTitle.Length < 25 ? blogs[i].bTitle : (blogs[i].bTitle.Substring(0, 25) + "...")) + "</strong>\n" +
            "                                    <div class=\"d-flex align-items-center\">\n" +
            "                                        <div class=\"views\"><i class=\"icon-eye\"></i>" + blogs[i].bHot + "</div>\n" +
            "                                    </div>\n" +
            "                                </div>\n" +
            "                            </div>\n" +
            "                        </a>";
        }
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