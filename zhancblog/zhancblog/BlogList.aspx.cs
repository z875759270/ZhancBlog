using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        CreateCategories();
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

    /// <summary>
    /// 创建Tags Widget
    /// </summary>
    private void CreateTags()
    {
        divTags.InnerHtml = string.Empty;
        divTags.InnerHtml = "<header><h3 class=\"h5\">标签</h3></header><ul class=\"list-inline\">";
        //---
        divTags.InnerHtml += "<li class=\"list-inline-item\"><a href=\"#\" class=\"tag\">#ASP.NET</a></li>";
        divTags.InnerHtml += "<li class=\"list-inline-item\"><a href=\"#\" class=\"tag\">#CSharp</a></li>";
        divTags.InnerHtml += "<li class=\"list-inline-item\"><a href=\"#\" class=\"tag\">#Python</a></li>";
        divTags.InnerHtml += "<li class=\"list-inline-item\"><a href=\"#\" class=\"tag\">#Git</a></li>";
        //---
        divTags.InnerHtml += "</ul>";
    }
}