using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Categories 的摘要说明
/// </summary>
public class Categories
{
    public int cID { get; set; }
    public string cCategory { get; set; }
    public int cSum { get; set; }

    public Categories()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Categories(int cID, string cCategory, int cSum)
    {
        this.cID = cID;
        this.cCategory = cCategory;
        this.cSum = cSum;
    }
}

public class CategoriesManager
{
    public List<Categories> SelectAllCategories()
    {
        try
        {
            string sqlStr = "SELECT * FROM tCategories";
            DataTable dt = DAO.dbTools.GetTable(sqlStr);
            List<Categories> categories = new List<Categories> { };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categories.Add(new Categories(Convert.ToInt32(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString(),
                    Convert.ToInt32(dt.Rows[i][2].ToString())));
            }
            if (categories != null)
                return categories;
            else
                return null;
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
            return null;
        }
    }
}