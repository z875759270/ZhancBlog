using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Categories 的摘要说明
/// </summary>
public class Categories
{
    public int cID { get; set; }
    public string cCategory { get; set; }

    public Categories()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Categories(int cID, string cCategory)
    {
        this.cID = cID;
        this.cCategory = cCategory;
    }
}

public class CategoriesManager
{

}