<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmexps.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr class="search_cate">
            <td style="width: 145px"><h4>Category</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" Class="expert_table" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Height="201px" DataKeyNames="expcod" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Pictures">
                            <ItemTemplate>
                                <img src="../exppics/<%# Eval("expcod")%><%# Eval("exppic") %>" height="150px" width="auto" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField   HeaderText="Description">
                            <ItemTemplate>
                                <b><%# Eval("expnam") %></b>
                                <br></br>
                                <%# Eval("expprf") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                       
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clsexp">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="cod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <br />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

