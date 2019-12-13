using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateHotBlog();
        CreateLatestBlog();
    }

    private void CreateHotBlog()
    {
        BlogManager blogManager = new BlogManager();
        List<Blog> blogs = blogManager.SelectHotestBlogs();
        blogpage.InnerHtml = "";
        string[] tags1 = blogs[0].bTags.Split(',');
        string[] tags2 = blogs[1].bTags.Split(',');
        string[] tags3 = blogs[2].bTags.Split(',');
        blogpage.InnerHtml += "<div class=\"row d-flex align-items-stretch\">\n" +
            "                <div class=\"text col-lg-7\">\n" +
            "                    <div class=\"text-inner d-flex align-items-center\">\n" +
            "                        <div class=\"content\">\n" +
            "                            <header class=\"post-header\">\n" +
            "                                <div class=\"category\"><a href=\"javascript:void(0)\">" + tags1[0] + "</a><a href=\"javascript:void(0)\">" + tags1[1] + "</a></div>\n" +
            "                                <a href=\"BlogInfo.aspx?blogid=" + blogs[0].bID + "\">\n" +
            "                                    <h2 class=\"h4\">" + blogs[0].bTitle + "</h2>\n" +
            "                                </a>\n" +
            "                            </header>\n" +
            "                            <p>" + (blogs[0].bContent.Length >= 200 ? blogs[0].bContent.Substring(0, 200) : blogs[0].bContent) + "...</p>\n" +
            "                            <footer class=\"post-footer d-flex align-items-center\">\n" +
            "                                <a href=\"#\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"avatar\">\n" +
            "                                        <img src=\"img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\">\n" +
            "                                    </div>\n" +
            "                                    <div class=\"title\"><span>Zhanc</span></div>\n" +
            "                                </a>\n" +
            "                                <div class=\"date\"><i class=\"icon-clock\"></i>" + blogs[0].bUpdatedtime.ToString() + "</div>\n" +
            "                                <div class=\"comments\"><i class=\"icon-eye\"></i>" + blogs[0].bHot + "</div>\n" +
            "                            </footer>\n" +
            "                        </div>\n" +
            "                    </div>\n" +
            "                </div>\n" +
            "                <div class=\"image col-lg-5\">\n" +
            "                    <img src=\"" + blogs[0].bTitlepic + "\" alt=\"...\">\n" +
            "                </div>\n" +
            "            </div>\n" +
            "        <!-- Post        -->\n" +
            "        <div class=\"row d-flex align-items-stretch\">\n" +
            "          <div class=\"image col-lg-5\"><img src=\"" + blogs[1].bTitlepic + "\" alt=\"...\"></div>\n" +
            "          <div class=\"text col-lg-7\">\n" +
            "            <div class=\"text-inner d-flex align-items-center\">\n" +
            "              <div class=\"content\">\n" +
            "                <header class=\"post-header\">\n" +
            "                  <div class=\"category\"><a href=\"javascript:void(0)\">" + tags2[0] + "</a><a href=\"javascript:void(0)\">" + tags2[1] + "</a></div><a href=\"BlogInfo.aspx?blogid=" + blogs[1].bID + "\">\n" +
            "                    <h2 class=\"h4\">" + blogs[1].bTitle + "</h2></a>\n" +
            "                </header>\n" +
            "                <p>" + (blogs[1].bContent.Length >= 200 ? blogs[1].bContent.Substring(0, 200) : blogs[1].bContent) + "...</p>\n" +
            "                <footer class=\"post-footer d-flex align-items-center\"><a href=\"#\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                    <div class=\"avatar\"><img src=\"img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\"></div>\n" +
            "                    <div class=\"title\"><span>Zhanc</span></div></a>\n" +
            "                  <div class=\"date\"><i class=\"icon-clock\"></i>" + blogs[1].bUpdatedtime.ToString() + "</div>\n" +
            "                  <div class=\"comments\"><i class=\"icon-eye\"></i>" + blogs[1].bHot + "</div>\n" +
            "                </footer>\n" +
            "              </div>\n" +
            "            </div>\n" +
            "          </div>\n" +
            "        </div>\n" +
            "        <!-- Post                            -->\n" +
            "        <div class=\"row d-flex align-items-stretch\">\n" +
            "                <div class=\"text col-lg-7\">\n" +
            "                    <div class=\"text-inner d-flex align-items-center\">\n" +
            "                        <div class=\"content\">\n" +
            "                            <header class=\"post-header\">\n" +
            "                                <div class=\"category\"><a href=\"javascript:void(0)\">" + tags3[0] + "</a><a href=\"javascript:void(0)\">" + tags3[1] + "</a></div>\n" +
            "                                <a href=\"BlogInfo.aspx?blogid=" + blogs[2].bID + "\">\n" +
            "                                    <h2 class=\"h4\">" + blogs[2].bTitle + "</h2>\n" +
            "                                </a>\n" +
            "                            </header>\n" +
            "                            <p>" + (blogs[2].bContent.Length >= 200 ? blogs[2].bContent.Substring(0, 200) : blogs[2].bContent) + "...</p>\n" +
            "                            <footer class=\"post-footer d-flex align-items-center\">\n" +
            "                                <a href=\"#\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                    <div class=\"avatar\">\n" +
            "                                        <img src=\"img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\">\n" +
            "                                    </div>\n" +
            "                                    <div class=\"title\"><span>Zhanc</span></div>\n" +
            "                                </a>\n" +
            "                                <div class=\"date\"><i class=\"icon-clock\"></i>" + blogs[2].bUpdatedtime.ToString() + "</div>\n" +
            "                                <div class=\"comments\"><i class=\"icon-eye\"></i>" + blogs[2].bHot + "</div>\n" +
            "                            </footer>\n" +
            "                        </div>\n" +
            "                    </div>\n" +
            "                </div>\n" +
            "                <div class=\"image col-lg-5\">\n" +
            "                    <img src=\"" + blogs[2].bTitlepic + "\" alt=\"...\">\n" +
            "                </div>\n" +
            "            </div>";
    }

    private void CreateLatestBlog()
    {
        BlogManager blogManager = new BlogManager();
        List<Blog> blogs = blogManager.SelectLatestBlogs();
        latestblogs.InnerHtml = "";
        for (int i = 0; i < blogs.Count; i++)
        {
            string[] tags = blogs[i].bTags.Split(',');
            latestblogs.InnerHtml += "<div class=\"post col-md-4\">\n" +
            "                    <div class=\"post-thumbnail\">\n" +
            "                        <a href=\"BlogInfo.aspx?blogid=" + blogs[i].bID + "\">\n" +
            "                            <img src=\"" + blogs[i].bTitlepic + "\" alt=\"...\" class=\"img-fluid\"></a>\n" +
            "                    </div>\n" +
            "                    <div class=\"post-details\">\n" +
            "                        <div class=\"post-meta d-flex justify-content-between\">\n" +
            "                            <div class=\"date\">" + blogs[i].bUpdatedtime + "</div>\n" +
            "                            <div class=\"category\"><a href=\"javascript:void(0)\">" + tags[0] + "</a><a href=\"javascript:void(0)\">" + tags[1] + "</a></div>\n" +
            "                        </div>\n" +
            "                        <a href=\"BlogInfo.aspx\">\n" +
            "                            <h3 class=\"h4\">" + blogs[i].bTitle + "</h3>\n" +
            "                        </a>\n" +
            "                        <p class=\"text-muted\">" + (blogs[i].bContent.Length >= 50 ? blogs[i].bContent.Substring(0, 50) : blogs[i].bContent) + "...</p>\n" +
            "                    </div>\n" +
            "                </div>";
        }

    }

}