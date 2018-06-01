<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmsel.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Sellers</h3>
    <table class="nav-justified Sellers">
        <tr class="search_sub_cate">
            <td style="width: 168px"><h4>Seller Name</h4></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Name" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 168px"><h4>Terms and Conditions</h4></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="162px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Terms &amp; Conditions" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 168px"><h4>Browse Logo</h4></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr class="btns_sec">
            <td style="width: 168px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

                <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="false" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" Class="seller_table" runat="server" DataKeyNames="selcod" Width="100%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Height="181px" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <img src="../selpics/<%# Eval("selcod") %><%# Eval("sellog") %>" height="90px" width="auto" />
                            <br />
                                <a href="frmselprd.aspx?scod=<%#Eval("selcod") %>">Seller Products</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="selnam" HeaderText="Name" SortExpression="selnam" />
                        <asp:BoundField DataField="seltrm" HeaderText="Terms & Conditional" SortExpression="seltrm" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                     
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clssel"></asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

