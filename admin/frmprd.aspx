<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmprd.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Search Products</h3>
    <table class="nav-justified">
        <tr class="search_cate">
            <td style="width: 200px"><h4>Category</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width:200px"><h4>Select SubCategory</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                </asp:DropDownList>
                <asp:HyperLink ID="HyperLink1" Class="add_new" runat="server" NavigateUrl="frmprddet.aspx">Add New Product</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" Class="search_results_tab" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" style="    height: 346px;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="Search Results">
                            <ItemTemplate>
                                <table class="nav-justified">
                                    <tr>
                                        <td rowspan="4" style="width: 194px">
            <img src="../prdpic/<%#getpic(Convert.ToString(Eval("pic"))) %>"
                height="160px" width="160px" border="1" />
                                        </td>
                                        <td>
                    <h4>
   <a href="frmprddet.aspx?pcod=<%#Eval("prdcod") %>"><%#Eval("prdtit") %></a>
                    </h4>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                Release Date :<%#Eval("prdreldat","{0:d}") %></td>
                                    </tr>
                                    <tr>
                                        <td>
                Market Price :<%#Eval("prdmrkprc") %></td>
                                    </tr>
                                    <tr>
                                        <td>
                    Sold By <%#Eval("nos") %> sellers
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="srcprd" TypeName="nsuncarte.clsprd">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList2" Name="subcatcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

