<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewBlog.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <!-- Latest Posts -->
            <main class="post blog-post col-lg-8">
                <div class="container">
                    <div class="post-single">
                        <div class="post-details">
                            <div class="add-comment">
                                <header>
                                    <h3 class="h6">整一个新文章！兄弟们干了！</h3>
                                </header>
                                <div class="commenting-form">
                                    <div class="row">
                                        <div class="form-group col-md-6">
                                            <asp:TextBox ID="txtTitle" runat="server" placeholder="文章标题" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:TextBox ID="txtTags" runat="server" placeholder="标签" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:FileUpload ID="imgUpload" runat="server" />
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:DropDownList ID="ddlCategories" runat="server" CssClass="form-control" placeholder="分类"></asp:DropDownList>
                                        </div>
                                        <div class="form-group col-md-12">
                                            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="form-control" placeholder="博客正文"></asp:TextBox>
                                        </div>
                                        <div class="col-md-12">
                                            <asp:Button ID="btnSubmit" runat="server" Text="提 交"  CssClass="btn btn-secondary" OnClick="btnSubmit_Click"/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
    </div>

</asp:Content>

