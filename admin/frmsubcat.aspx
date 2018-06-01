<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmsubcat.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>SubCategories</h3>
    <table class="nav-justified sub_cate_table">
        <tr class="search_cate">
            <td style="width: 131px; height: 30px"><h4>Category</h4></td>
            <td style="height: 30px">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 131px; height: 30px"><h4>SubCategory</h4></td>
            <td style="height: 30px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter SubCategory" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="btns_sec">
            <td style="width: 131px; height: 30px"></td>
            <td style="height: 30px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" CausesValidation="false" runat="server" Text="Cancel" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" Class="subcate" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Width="100%" DataKeyNames="subcatcod" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="subcatnam" HeaderText="SubCategory" SortExpression="subcatnam" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

