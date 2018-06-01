<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmcat.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Categories</h3>
    <table id="category_main" class="nav-justified">
        <tr class="category">
            <td class="cate_search">
                <label>Category</label>
                <asp:TextBox ID="txtcat" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcat" ErrorMessage="Enter category" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="browser">
                <label for="#ContentPlaceHolder1_filupl">Browse Banner</label>
                <asp:FileUpload ID="filupl" runat="server" />
            </td>
        </tr>
        <tr class="btns_sec">
            <td colspan="2" class="cate_search_btns">
                <asp:Button ID="btnsub" runat="server" OnClick="btnsub_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" CausesValidation="false" Text="Cancel" OnClick="Button2_Click" />
                </br></br></br></br>
            </td>
        </tr>
        <tr class="category_con_main">
            <td colspan="2" class="cate_main-in">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="705px" DataKeyNames="catcod" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                    <Columns>
                        <asp:TemplateField HeaderText="Banner">
                            <itemtemplate>
 <img src="../banners/<%#Eval("catcod") %><%#Eval("catban") %>"
    width="20%" height="40px" border="2" />
                            </itemtemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="catnam" HeaderText="Category" SortExpression="catnam" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

