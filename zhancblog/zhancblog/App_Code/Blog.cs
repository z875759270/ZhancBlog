﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Blog 属性类
/// </summary>
public class Blog
{
    public int bID { get; set; }
    public string bTitle { get; set; }
    public string bContent { get; set; }
    public string bTitlepic { get; set; }
    public DateTime bUpdatedtime { get; set; }
    public int bCategoryid { get; set; }
    public string bTags { get; set; }
    public int bHot { get; set; }
    public int bEnable { get; set; }

    public Blog()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Blog(string bTitle, string bContent, string bTitlepic, DateTime bUpdatedtime, int bCategoryid, string bTags)
    {
        this.bTitle = bTitle;
        this.bContent = bContent;
        this.bTitlepic = bTitlepic;
        this.bCategoryid = bCategoryid;
        this.bTags = bTags;
    }

    public Blog(int bID, string bTitle, string bContent, string bTitlepic, DateTime bUpdatedtime, int bCategoryid, string bTags, int bHot, int bEnable)
    {
        this.bID = bID;
        this.bTitle = bTitle;
        this.bContent = bContent;
        this.bTitlepic = bTitlepic;
        this.bUpdatedtime = bUpdatedtime;
        this.bCategoryid = bCategoryid;
        this.bTags = bTags;
        this.bHot = bHot;
        this.bEnable = bEnable;
    }
}

/// <summary>
/// Blog 管理类
/// </summary>
public class BlogManager
{
    #region 增删改查


    /// <summary>
    /// 增加一篇BLOG
    /// </summary>
    /// <param name="blog"></param>
    /// <returns></returns>
    public int InsertBlog(Blog blog)
    {
        try
        {
            string sqlStr = "INSERT INTO tBlog(b_Title,b_Content,b_Titlepic,b_Categoryid,b_Tags) VALUES(@title,@content,@titlepic,@categoryid,@tags)";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@title",blog.bTitle),
                new SqlParameter("@content",blog.bContent),
                new SqlParameter("@titlepic",blog.bTitlepic),
                new SqlParameter("@categoryid",blog.bCategoryid),
                new SqlParameter("@tags",blog.bTags)
            };
            int res = DAO.dbTools.ExcuteSQL(sqlStr, paras);
            if (res > 0)
                return 1;
            else
                return -1;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return -1;
        }
    }

    /// <summary>
    /// 删除一篇BLOG
    /// </summary>
    /// <param name="id">Blog ID</param>
    /// <returns></returns>
    public int DeleteBlog(int id)
    {
        try
        {
            string sqlStr = "DELETE FROM tBlog WHERE b_ID=@id";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            int res = DAO.dbTools.ExcuteSQL(sqlStr, paras);
            if (res > 0)
                return 1;
            else
                return -1;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return -1;
        }
    }

    /// <summary>
    /// 查询一条Blog
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Blog SelectBlog(int id)
    {
        try
        {
            string sqlStr = "SELECT * FROM tBlog WHERE b_ID=@id";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            DataTable dt = DAO.dbTools.GetTable(sqlStr, paras);
            Blog blog = new Blog();
            blog = new Blog(Convert.ToInt32(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),
                    dt.Rows[0][3].ToString(), Convert.ToDateTime(dt.Rows[0][4].ToString()), Convert.ToInt32(dt.Rows[0][5].ToString()),
                    dt.Rows[0][6].ToString(), Convert.ToInt32(dt.Rows[0][7].ToString()), Convert.ToInt32(dt.Rows[0][8].ToString()));
            return blog;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 分类查询
    /// </summary>
    /// <param name="categoryid"></param>
    /// <returns></returns>
    public List<Blog> SelectBlogByCategoryid(int categoryid)
    {
        try
        {
            string sqlStr = "SELECT * FROM tBlog WHERE b_Categoryid=" + categoryid;
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 模糊查询
    /// </summary>
    /// <param name="str">查询关键词</param>
    /// <returns></returns>
    public List<Blog> SelectBlogBySearch(string str)
    {
        try
        {
            string sqlStr = "SELECT * FROM tBlog WHERE b_Title LIKE '%" + str + "%'";
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 查询最热门的三篇博客
    /// </summary>
    /// <returns></returns>
    public List<Blog> SelectHotestBlogs()
    {
        try
        {
            string sqlStr = "SELECT TOP(3) * FROM tBlog ORDER BY b_Hot DESC";
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 查询最新的三篇博客
    /// </summary>
    /// <returns></returns>
    public List<Blog> SelectLatestBlogs()
    {
        try
        {
            string sqlStr = "SELECT TOP(3) * FROM tBlog ORDER BY b_Updatedtime DESC";
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 查询所有的Blog
    /// </summary>
    /// <returns></returns>
    public List<Blog> SelectBlogAll()
    {
        try
        {
            string sqlStr = "SELECT * FROM tBlog";
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// +浏览
    /// </summary>
    /// <param name="id">blogid</param>
    public void HotUp(int id)
    {
        try
        {
            string sqlStr = "UPDATE tBlog SET b_Hot=b_Hot+1 WHERE b_ID=@id";
            SqlParameter[] paras = new SqlParameter[] {
            new SqlParameter("@id",id)
            };
            DAO.dbTools.ExcuteSQL(sqlStr, paras);
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
        }
    }


    #endregion

    #region 分页
    /// <summary>
    /// 分页查询
    /// </summary>
    /// <param name="offset">偏移量，从第几条开始查询</param>
    /// <param name="pageSize">一页的记录数，默认4</param>
    /// <returns></returns>
    public List<Blog> SelectOnePage(int offset, int pageSize = 4)
    {
        try
        {
            string sqlStr = "SELECT TOP(@pageSize) * FROM tBlog WHERE b_ID NOT IN(SELECT TOP(@offset) b_ID FROM tBlog)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@pageSize",pageSize),
                new SqlParameter("@offset",offset)
            };
            DataTable dt = DAO.dbTools.GetTable(sqlStr, paras);
            List<Blog> blogs = new List<Blog> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                blogs.Add(new Blog(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(), Convert.ToDateTime(dt.Rows[i][4].ToString()), Convert.ToInt32(dt.Rows[i][5].ToString()),
                    dt.Rows[i][6].ToString(), Convert.ToInt32(dt.Rows[i][7].ToString()), Convert.ToInt32(dt.Rows[i][8].ToString())));
            }
            return blogs;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 显示一页记录
    /// </summary>
    /// <param name="blogs">要分页的List</param>
    /// <param name="pageIndex">要显示第几页</param>
    /// <param name="pageSize">一页多少记录</param>
    /// <returns>一页记录</returns>
    public List<Blog> ShowOnePage(List<Blog> blogs, int pageIndex, int pageSize = 4)
    {
        try
        {
            int pageCount = GetPageCount(blogs, pageSize);
            List<Blog> resList = new List<Blog> { };
            if (pageIndex < pageCount)
            {
                for (int i = 0; i < pageSize; i++)
                {
                    resList.Add(blogs[i + ((pageIndex - 1) * pageSize)]);
                }
                return resList;
            }
            else if (pageIndex == pageCount)
            {
                for (int i = 0; i < ((blogs.Count % pageSize) == 0 ? pageSize : blogs.Count % pageSize); i++)
                {
                    resList.Add(blogs[i + ((pageIndex - 1) * pageSize)]);
                }
                return resList;
            }
            else
            {
                return ShowOnePage(blogs, pageCount);  //pageIndex过大时矫正
            }
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// 获取总页数
    /// </summary>
    /// <param name="blogs">要分页的List</param>
    /// <param name="pageSize">单页的记录数</param>
    /// <returns>总页数</returns>
    public int GetPageCount(List<Blog> blogs, int pageSize = 4)
    {
        return (blogs.Count % pageSize) == 0 ? blogs.Count / pageSize : (blogs.Count / pageSize) + 1;
    }
    #endregion




}