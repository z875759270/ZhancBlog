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
        if (!IsPostBack)
        {
            AddCategories();
        }
    }

    private void AddCategories()
    {
        CategoriesManager categoriesManager = new CategoriesManager();
        List<Categories> categories = categoriesManager.SelectAllCategories();
        for (int i = 1; i < categories.Count; i++)
        {
            ddlCategories.Items.Add(categories[i].cCategory);
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text.ToString();
        string content = txtContent.Text.ToString();
        int category = ddlCategories.SelectedIndex + 2;
        string imgUrl = "";
        if (imgUpload.FileName.EndsWith(".jpg") | imgUpload.FileName.EndsWith(".png") | imgUpload.FileName.EndsWith(".jpeg"))
        {
            imgUrl = "img/blogimg/" + GetIntTime() + imgUpload.FileName.Substring(imgUpload.FileName.Length - 4, 4);
            imgUpload.SaveAs(Server.MapPath("~") + imgUrl);
        }

        Blog blog = new Blog();
        blog.bTitle = title;
        blog.bContent = content;
        blog.bCategoryid = category;
        blog.bTitlepic = imgUrl;
        blog.bTags = "";

        BlogManager blogManager = new BlogManager();
        int res = blogManager.InsertBlog(blog);
        if (res != -1)
            btnSubmit.Text = "成功";
        else
            btnSubmit.Text = "失败";
    }

    private string GetIntTime()
    {
        string now = DateTime.Now.ToString();
        string[] temp = now.Split(' ');
        now = temp[0] + temp[1];
        List<string> temps = now.Split('/').ToList();
        now = "";
        temps.ForEach(u => now += u);
        temps = now.Split(':').ToList();
        now = "";
        temps.ForEach(s => now += s);
        return now;
    }
}