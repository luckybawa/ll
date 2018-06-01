<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmsrccat.aspx.cs" Inherits="_Default"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h3>Search By Category</h3>
    <table class="nav-justified">
        <tr class="search_cate">
            <td style="width: 157px"><h4>Select Category</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="catnam" DataValueField="catcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="search_sub_cate">
            <td style="width: 157px"><h4>SubCategory</h4></td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="subcatnam" DataValueField="subcatcod">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource3" RepeatColumns="3" RepeatDirection="Horizontal">
                 <ItemTemplate>
            <div class="row">
						
							<div class="col-md-12  text-center">
								<div class="boxU">
									<div class="divMain text-center">
										<p classs="new"><%#Eval("catnam") %>,<%#Eval("subcatnam") %></p>
	<img src="prdpic/<%#Eval("pic") %>" class="imgTshirt">
										<!-- <p class="off">20%off</p> -->
<a href="#"><p class="comments"><span><%#Eval("nos") %></span><i class="fa fa-comment-o"></i></p></a>
									</div>
								</div>	
								
									<p class="deviceName">
    <a href="frmprddet.aspx?pcod=<%#Eval("prdcod") %>">
        <%#Eval("prdtit") %>
    </a>
									</p>
									<p class="p1"><%#Eval("dsc") %><p>
									<p class="ebay">Market Price :$<%#Eval("prdmrkprc") %></p>
									<p class="p2">Release on :<%#Eval("prdreldat","{0:d}") %><p>
									
									<p class="getD clearfix">
           <a href="frmprddet.aspx?pcod=<%#Eval("prdcod") %>">Read More</a></p>
								
							</div>
					
			
    </div>
            
            </div>
        </ItemTemplate>
       
     
     
                
                </asp:DataList>
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
            </td>
        </tr>
    </table>
</asp:Content>

