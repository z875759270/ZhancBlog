using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateHotestBlogs();
    }

    private void CreateHotestBlogs()
    {
        BlogManager blogManager = new BlogManager();
        List<Blog> blogs = blogManager.SelectHotestBlogs();
        hotestblogs.InnerHtml = "";
        for (int i = 0; i < 3; i++)
        {
            hotestblogs.InnerHtml += "<a href=\"BlogInfo.aspx?blogid=" + blogs[i].bID + "\">\n" +
            "                            <div class=\"post d-flex align-items-center\">\n" +
            "                                <div class=\"image\">\n" +
            "                                    <img src=\"" + blogs[i].bTitlepic + "\" alt=\"...\" class=\"img-fluid\"></div>\n" +
            "                                <div class=\"title\"><strong>" + (blogs[i].bTitle.Length < 20 ? blogs[i].bTitle : (blogs[i].bTitle.Substring(0, 20) + "...")) + "</strong><span class=\"date last-meta\">" + blogs[i].bUpdatedtime + "</span></div>\n" +
            "                            </div>\n" +
            "                        </a>";
        }
    }
}
