<%@ Page Title="" Language="C#" MasterPageFile="~/expert/MasterPage.master" AutoEventWireup="true" CodeFile="frmrev.aspx.cs" Inherits="expert_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Latest Products</h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" DataKeyNames="prdcod,sts" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Product Details
                    </HeaderTemplate>

                    <ItemTemplate>
                        <table class="nav-justified expert_pro">
                            <tr>
                                <td rowspan="5" style="width:20%; text-align:center;">
                    <img src="../prdpic/<%#Eval("pic") %>" height="150px" width="150px" />
                                </td>
                                <td>
                                    <h4><%#Eval("prdtit") %></h4>
                                </td>
                            </tr>
                            <tr>
                                <td>Released on <%#Eval("prdreldat","{0:d}") %></td>
                            </tr>
                            <tr>
                                <td>Market Price :$<%#Eval("prdmrkprc") %></td>
                            </tr>
                            <tr>
                                <td><%#Eval("prddsc") %></td>
                            </tr>
                            <tr>
                                <td>
                  <asp:linkbutton id="lk1" runat="server" commandname="edit" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspprdforrev" TypeName="nsuncarte.clsprd">
            <SelectParameters>
                <asp:SessionParameter Name="expcod" SessionField="cod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>

