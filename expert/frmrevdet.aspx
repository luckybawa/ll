<%@ Page Title="" Language="C#" MasterPageFile="~/expert/MasterPage.master" AutoEventWireup="true" CodeFile="frmrevdet.aspx.cs" Inherits="expert_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified expert_review">
        <tr>
            <td colspan="2">
                <h3>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </h3>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 131px"><h4>Review Title</h4></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Title" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 131px"><h4>Description</h4></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="203px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Description" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr class="btns_sec">
            <td style="width: 131px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />

                <asp:Button ID="Button2" CausesValidation="false" runat="server" Text="Cancel" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

