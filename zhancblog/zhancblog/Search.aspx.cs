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
        try
        {
            string search = Request.QueryString["search"] != null ? Request.QueryString["search"].ToString() : "";
            if (search != "")
            {
                lblSearch.Text = "以下内容显示您搜索的：" + search;
                BlogManager blogManager = new BlogManager();
                List<Blog> blogs = blogManager.SelectBlogBySearch(search);
                if (blogs != null)
                {
                    blogs.ForEach(u => CreateBlogWidget(u));
                }
            }
        }
        catch (Exception ae)
        {
            System.Diagnostics.Debug.WriteLine(ae);
        }

    }

    private void CreateBlogWidget(Blog blog)
    {
        try
        {
            string[] tags = blog.bTags.Split(',');
            BlogsWidget.InnerHtml += "<div class=\"row d-flex align-items-stretch\">\n" +
                "                <div class=\"text col-lg-7\">\n" +
                "                    <div class=\"text-inner d-flex align-items-center\">\n" +
                "                        <div class=\"content\">\n" +
                "                            <header class=\"post-header\">\n" +
                "                                <div class=\"category\"><a href=\"javascript:void(0)\">" + tags[0] + "</a><a href=\"javascript:void(0)\">" + tags[1] + "</a></div>\n" +
                "                                <a href=\"BlogInfo.aspx?blogid=" + blog.bID + "\">\n" +
                "                                    <h2 class=\"h4\">" + blog.bTitle + "</h2>\n" +
                "                                </a>\n" +
                "                            </header>\n" +
                "                            <p>" + (blog.bContent.Length >= 200 ? blog.bContent.Substring(0, 200) : blog.bContent) + "...</p>\n" +
                "                            <footer class=\"post-footer d-flex align-items-center\">\n" +
                "                                <a href=\"javascript:void(0)\" class=\"author d-flex align-items-center flex-wrap\">\n" +
                "                                    <div class=\"avatar\">\n" +
                "                                        <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\"></div>\n" +
                "                                    <div class=\"title\"><span>Zhanc</span></div>\n" +
                "                                </a>\n" +
                "                                <div class=\"date\"><i class=\"icon-clock\"></i>" + blog.bUpdatedtime.ToString().Substring(0, 16) + "</div>\n" +
                "                                <div class=\"comments\"><i class=\"icon-eye\"></i>" + blog.bHot + "</div>\n" +
                "                            </footer>\n" +
                "                        </div>\n" +
                "                    </div>\n" +
                "                </div>\n" +
                "                <div class=\"image col-lg-5\">\n" +
                "                    <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/" + blog.bTitlepic + "\" alt=\"...\">\n" +
                "                </div>\n" +
                "            </div>";
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
        }

    }
}