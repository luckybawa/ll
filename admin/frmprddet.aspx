<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmprddet.aspx.cs" Inherits="admin_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="aspj" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
  

       <h3>Product Details</h3>
      
    <aspj:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="655px" Width="100%">
        <aspj:TabPanel runat="server" HeaderText="Product Information" ID="TabPanel1">
        <ContentTemplate>

            <br />
            <table class="nav-justified pro_detail_table">
                <tr class="search_sub_cate">
                    <td style="width: 172px"><h4>Category</h4></td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 172px"><h4>SubCategory</h4></td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 172px"><h4>Product Title</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" max-Width="300px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Title" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 172px"><h4>Release Date</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter date" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                        <aspj:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox2">
                        </aspj:CalendarExtender>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 172px"><h4>Market Price</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter price" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 172px; height: 302px;"><h4>Description</h4></td>
                    <td style="height: 302px">
                        <asp:TextBox ID="TextBox7" runat="server" Height="252px" TextMode="MultiLine" Width="797px"></asp:TextBox>
                    </td>
                </tr>
                <tr class="btns_sec">
                    <td style="width: 172px">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Submit" CausesValidation="False"/>
                        <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="False" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 172px">&nbsp;</td>
                    <td>
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clscat"></asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clssubcat">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList1" Name="catcod" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
            <br />

        </ContentTemplate>
        </aspj:TabPanel>
        <aspj:TabPanel runat="server" HeaderText="Pictures" ID="TabPanel2">
        <ContentTemplate>

            <br />
            <table class="nav-justified pictures_table">
                <tr class="search_sub_cate">
                    <td style="width: 168px"><h4>Browse Picture</h4></td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 168px"><h4>Description</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Height="104px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter description" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="btns_sec">
                    <td style="width: 133px">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" CausesValidation="false" />
                        <asp:Button ID="Button4" runat="server" Text="Cancel" CausesValidation="False" OnClick="Button4_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:DataList ID="DataList1" Class="pic_area" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%" Height="412px" DataKeyField="prdpiccod" OnDeleteCommand="DataList1_DeleteCommand" OnEditCommand="DataList1_EditCommand">
        <HeaderTemplate>
            <table border="1" width="100%">
        </HeaderTemplate>
         <ItemTemplate>
             <td align="center" class="btns_sec">
   <img src="../prdpic/<%#Eval("prdpiccod") %><%#Eval("prdpicpic") %>" width="200px"
       height="200px" />
                 <br />
    <asp:LinkButton ID="lk1" CssClass="set_pic" runat ="server" CommandName="Edit" Text="Set As Main Picture" CausesValidation="false" />
    <asp:LinkButton ID="lk2" CssClass="delete_pic" runat ="server" CommandName="Delete" Text="Delete" CausesValidation="false" />
             </td>
        </ItemTemplate>
         <FooterTemplate>
              </table>
          </FooterTemplate>
                        </asp:DataList>
                    </td>
                </tr>
            </table>

        </ContentTemplate>
        </aspj:TabPanel>
        <aspj:TabPanel ID="TabPanel3" runat="server" HeaderText="Specifications">
        <ContentTemplate>

            <br />
            <table class="nav-justified Specification">
                <tr class="search_sub_cate">
                    <td style="width: 168px"><h4>Specification</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter specification" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="search_sub_cate">
                    <td style="width: 168px"><h4>Details</h4></td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Height="95px" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter Details" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="btns_sec">
                    <td style="width: 129px">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Submit"  CausesValidation="False"/>
                        
                        <asp:Button ID="Button6" runat="server" Text="Cancel"  CausesValidation="False" OnClick="Button6_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" Class="specification_submit" runat="server" AutoGenerateColumns="False" Height="136px" Width="100%" DataKeyNames="prdspccod" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                                <asp:BoundField DataField="prdspctit" HeaderText="Specification" />
                                <asp:BoundField DataField="prdspcdsc" HeaderText="Details" />
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </ContentTemplate>
        </aspj:TabPanel>
    </aspj:TabContainer>
</asp:Content>

