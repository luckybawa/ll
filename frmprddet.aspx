<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmprddet.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="container">
			<div class="sectionRead1">
				<div class="row">
					<div class="col-sm-6">
						&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" >
                            <itemtemplate>
                            <img src='prdpic/<%#Eval("pic") %>'  border="2" height="250px" width="250px" />    
                            </itemtemplate>
                        </asp:DataList>
					</div>
					<div class="col-sm-6">
						<div class="productDetails">
                            <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="ObjectDataSource2" Height="50px" Width="358px" AutoGenerateRows="False">
                                <Fields>
                                    <asp:TemplateField>
                                        <itemTemplate>
            <div class="row">
						
							<div class="col-md-12  text-center">
								<div class="boxU">
									

								
									<p class="deviceName">
   
      <h2><%#Eval("prdtit") %></h2>  
 
									</p>
									<p class="p1"><%#Eval("dsc") %><p>
									<p class="ebay">Market Price :$<%#Eval("prdmrkprc") %></p>
									<p class="p2">Release on :<%#Eval("prdreldat","{0:d}") %><p>
									
							
								
							</div>
					
			
    </div>
            
            </div>
        </itemTemplate>
                                    </asp:TemplateField>
                                </Fields>
     
                            </asp:DetailsView>
                            <br />
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="dspprddet" TypeName="nsuncarte.clsprd">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="pcod" QueryStringField="pcod" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <br />
                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dspprddet" TypeName="nsuncarte.clsprd">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="pcod" QueryStringField="pcod" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
						    <br />
                            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="dspprdrev" TypeName="nsuncarte.clsprd">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="pcod" QueryStringField="pcod" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
						    <br />
                            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="selbyprd" TypeName="nsuncarte.clssel">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="pcod" QueryStringField="pcod" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <br />
                            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="dsp_rec" TypeName="nsuncarte.clsprdspc">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="prdcod" QueryStringField="pcod" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4" Width="421px">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Seller">
                                                     <ItemTemplate>
                                                         <img src="selpics/<%# Eval("selcod") %><%# Eval("sellog") %>" height="60px" width="100px" />
                                                     </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField HeaderText="Price" DataField="selprdprc" />
                                                <asp:TemplateField>
                                                <ItemTemplate>
                                                    <a href="<%# Eval("selprdlnk") %>" target="_blank">Click Here</a>
                                                </ItemTemplate>    
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
						</div>
					</div>
				</div>
                
				<div class="row">
					<div class="col-md-12">
						<div class="imagesTab">
							
							<div class="sectionTab">
								<div class="boxTb">
									<ul class="nav nav-tabs">
										<li class="active"><a data-toggle="tab" href="#review">Picture</a></li>
										<li><a data-toggle="tab" href="#read">Specification</a></li>
										<li><a data-toggle="tab" href="#comments">Reviews</a></li>
									    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </li>
                                        
                                        
									</ul>

									<div class="tab-content">
										<div id="review" class="tab-pane fade in active">
											<div class="post">
												<div class="user-block">

												<asp:GridView ID="GridView1" runat="server" Width="77%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Height="813px" ShowHeader="False">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                           
            <img src="prdpic/<%#Eval("pic") %>"
                height="200px" width="200px" border="1" />
                                   
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
												
												</div>
												<ul class="list-inline">
												</ul>
												<%--<input class="form-control input-sm FullWith" placeholder="Type a comment" type="text">--%>
											</div>
										</div>
										
											<div id="read" class="post tab-pane fade>
												<h3 class="readH3">Introduction</h3>
												<p>
													<asp:GridView ID="GridView2" ShowHeader="False" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5" Height="860px">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table class="nav-justified">
                                    <tr>
                                        <td rowspan="4" style="width: 194px">
           <%# Eval("prdspcdsc") %>
                                        </td>
                                      </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
										
										</div>
										<div id="comments" class="tab-pane fade">
											<div class="post">
                                                <asp:GridView ID="GridView3" ShowHeader="False" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table class="nav-justified">
                                    <tr>
                                        <td rowspan="4" style="width: 194px">
          <h3><%# Eval("prdrevtit") %></h3><br />
   <p>Posted Date :<%# Eval("prdrevdat","{0:d}") %></p><br />
     <p><%# Eval("prdrevdsc") %></p><br />
                                        </td>
                                       </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

											
										</div>
                                            </div>
                                        
									</div>
								</div>
							</div>
                           
						</div>
					</div>
				</div>
			</div>
		</div>
</asp:Content>

