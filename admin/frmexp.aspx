<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmexp.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Register Expert</h3>
    <table class="nav-justified register_expert">
        <tr class="search_cate">
            <td style="width: 157px"><h4>Category</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 157px"><h4>Expert Name</h4></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Name" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 157px"><h4>Email</h4></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Email" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Valid Email" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 157px;vertical-align:top;"><h4>Profile</h4></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="228px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Profile" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 157px"><h4>Browse Picture</h4></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr class="btns_sec">
            <td style="width: 157px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" Text="Cancel"  CausesValidation="false" OnClick="Button2_Click"/>
            </td>
        </tr>
        <tr>
            <td style="width: 157px">&nbsp;</td>
            <td>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

