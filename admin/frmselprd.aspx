<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmselprd.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="2">
                <h3>Seller Products</h3>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">Select Category</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">Select SubCategory</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">Select Product</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSource3" DataTextField="prdtit" DataValueField="prdcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">Price Offered</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="392px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Offered" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">Product Link</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Link" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="false" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="selprdcod,catcod,subcatcod,prdcod" DataSourceID="ObjectDataSource4" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" Width="941px">
                    <Columns>
                        <asp:BoundField DataField="catnam" HeaderText="Category" />
                        <asp:BoundField DataField="subcatnam" HeaderText="SubCategory" />
                        <asp:BoundField DataField="prdtit" HeaderText="Product" />
                        <asp:BoundField DataField="selprdprc" HeaderText="Price Offered" />
                        <asp:TemplateField HeaderText="Product Link">
                            <ItemTemplate>
    <a href="<%#Eval("selprdlnk") %>" target="_blank">Click here</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clssubcat">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="srcprdbycat" TypeName="nsuncarte.clsprd">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList2" Name="subcatcod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="dspselprd" TypeName="nsuncarte.clsselprd">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="selcod" QueryStringField="scod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

