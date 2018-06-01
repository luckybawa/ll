<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmsrctit.aspx.cs" Inherits="_Default"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Search By Title</h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="nav-justified">
        <tr class="search_title">
            <td style="width: 199px"><h4>Enter Search Title</h4></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
&nbsp;</td>
        </tr>
        <tr class="search_btnn">
            <td style="width: 199px">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
               
      <ItemTemplate>
            <div class="row">
						
							<div class="col-md-12  text-center">
								<div class="boxU">
									<div class="divMain text-center">
										<p class="new"><%#Eval("catnam") %>,<%#Eval("subcatnam") %></p>
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
        <FooterTemplate>
              </div>
        </FooterTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

