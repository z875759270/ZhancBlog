﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static void btnSearch(string str)
    {
        BlogManager blogManager = new BlogManager();
        List<Blog> blogs = blogManager.SelectBlogBySearch(str);
        if (blogs != null)
        {
            
        }
    }
}