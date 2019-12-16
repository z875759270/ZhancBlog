using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    CategoriesManager categoriesManager = new CategoriesManager();
    BlogManager blogManager = new BlogManager();

    protected void Page_Load(object sender, EventArgs e)
    {
        int pageIndex = Request.QueryString["pageIndex"] != null ? Convert.ToInt32(Request.QueryString["pageIndex"].ToString()) : 1;
        int categoryid = Request.QueryString["category"] != null ? Convert.ToInt32(Request.QueryString["category"].ToString()) : 1;
        categoriesManager.UpdateCategorieNum();
        if (categoryid != 1)
            CreateBlogList(pageIndex,4,categoryid);
        else
            CreateBlogList(pageIndex);
        CreateCategories();
    }

    /// <summary>
    /// 创建列表页主体部分
    /// </summary>
    /// <param name="pageIndex"></param>
    /// <param name="pageSize"></param>
    private void CreateBlogList(int pageIndex = 1, int pageSize = 4, int categoryid = 1)
    {
        List<Blog> blogsList = blogManager.SelectBlogAll();
        if (categoryid != 1)
        {
            blogsList = blogManager.SelectBlogByCategoryid(categoryid);
        }

        CreatePageNum(blogsList, pageIndex);
        blogsList = blogManager.ShowOnePage(blogsList, pageIndex, pageSize);
        if (blogsList != null)
        {
            bloglist.InnerHtml = "";
            for (int i = 0; i < blogsList.Count; i++)
            {
                CreateOneBlog(blogsList[i]);
            }
        }
    }

    /// <summary>
    /// 创建一篇Blog
    /// </summary>
    private void CreateOneBlog(Blog blog)
    {
        string[] tags = blog.bTags.Split(',');
        bloglist.InnerHtml += "            <div class=\"post col-xl-6\">\n" +
            "                            <div class=\"post-thumbnail\"><a href=\"BlogInfo.aspx?blogid=" + blog.bID + "\">\n" +
            "                                <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/" + blog.bTitlepic + "\" alt=\"...\" class=\"img-fluid\"></a></div>\n" +
            "                            <div class=\"post-details\">\n" +
            "                                <div class=\"post-meta d-flex justify-content-between\">\n" +
            "                                    <div class=\"date meta-last\">" + blog.bUpdatedtime.ToShortDateString() + "</div>\n" +
            "                                    <div class=\"category\"><a href=\"javascript:void(0)\">" + tags[0] + "</a><a href=\"javascript:void(0)\">" + tags[1] + "</a></div>\n" +
            "                                </div>\n" +
            "                                <a href=\"BlogInfo.aspx?blogid=" + blog.bID + "\">\n" +
            "                                    <h3 class=\"h4\">" + blog.bTitle + "</h3>\n" +
            "                                </a>\n" +
            "                                <p class=\"text-muted\">" + (blog.bContent.Length >= 50 ? blog.bContent.Substring(0, 50) : blog.bContent) + "...</p>\n" +
            "                                <footer class=\"post-footer d-flex align-items-center\">\n" +
            "                                    <a href=\"#\" class=\"author d-flex align-items-center flex-wrap\">\n" +
            "                                        <div class=\"avatar\">\n" +
            "                                            <img src=\"https://zhanc.oss-cn-shenzhen.aliyuncs.com/web/zhancblog/img/avatar-1.jpg\" alt=\"...\" class=\"img-fluid\"></div>\n" +
            "                                        <div class=\"title\"><span>Zhanc</span></div>\n" +
            "                                    </a>\n" +
            "                                    <div class=\"date\"><i class=\"icon-clock\"></i>" + blog.bUpdatedtime.ToString() + "</div>\n" +
            "                                    <div class=\"comments meta-last\"><i class=\"icon-eye\"></i>" + blog.bHot + "</div>\n" +
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
            divCategories.InnerHtml += "<div class=\"item d-flex justify-content-between\"><a href=\"BlogList.aspx?category=" + categories[i].cID + "\">" + categories[i].cCategory + "</a><span>" + categories[i].cSum + "</span></div>";
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

    /// <summary>
    /// 创建分页 Widget
    /// </summary>
    /// <param name="blogs">当前页面的List</param>
    private void CreatePageNum(List<Blog> blogs, int pageIndex)
    {
        int pageCount = blogManager.GetPageCount(blogs);
        pageNum.InnerHtml = "";
        pageNum.InnerHtml += "<li class=\"page-item\"><a href=\"" + GetLinkToURL(Request.Url.ToString(), "pageIndex") + "pageIndex=" + (pageIndex <= 1 ? pageIndex : pageIndex - 1) + "\" class=\"page-link\"><i class=\"fa fa-angle-left\"></i></a></li>";

        for (int i = 0; i < pageCount; i++)
        {
            pageNum.InnerHtml += "<li class=\"page-item\"><a href =\"" + GetLinkToURL(Request.Url.ToString(), "pageIndex") + "pageIndex=" + (i + 1) + "\" class=\"page-link active\">" + (i + 1) + "</a></li>";
        }

        pageNum.InnerHtml += "<li class=\"page-item\"><a href=\"" + GetLinkToURL(Request.Url.ToString(), "pageIndex") + "pageIndex=" + (pageIndex < pageCount ? pageIndex + 1 : pageIndex) + "\" class=\"page-link\"><i class=\"fa fa-angle-right\"></i></a></li>";
    }

    /// <summary>
    /// 获取跳转URL
    /// </summary>
    /// <param name="url">uri</param>
    /// <param name="type">要添加的参数</param>
    /// <returns></returns>
    private string GetLinkToURL(string url, string type)
    {
        //string url = Request.Url.ToString();
        if (url.Contains("?"))
        {
            if (url.Contains(type))
            {
                if (url.Contains('&'))
                {
                    string[] temp = url.Split('&');
                    return temp[0] + "&";
                }
                else
                {
                    string[] temp = url.Split('?');
                    return temp[0] + "?";
                }
                
            }
            else
            {
                return url + "&";
            }
        }
        else
        {
            return url + "?";
        }
    }
}