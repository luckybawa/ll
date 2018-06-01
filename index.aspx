<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="backImage">
			<div class="container-fluid">
                <div class="row">
                    <div id="myCarousel" class="carousel slide" data-ride="carousel">
                       
                          <div class="carousel-inner" role="listbox">
                            <div class="item active">
                              <img src="images/banner_img_1.jpg" alt="Cars">
                            </div>

                            <div class="item">
                              <img src="images/banner_img_2.jpg" alt="Books">
                            </div>

                            <div class="item">
                              <img src="images/banner_img_3.jpg" alt="Kitchen">
                            </div>
                              <div class="item">
                              <img src="images/banner_img_4.jpg" alt="Kitchen">
                            </div>

                          <!-- Left and right controls -->
                          <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                          </a>
                          <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                          </a>
                        </div>
                </div>
            </div>
	</div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    		

<div class="row">
				<div class="col-md-6">
					<h2 class="hTopD">Top Recent Products</h2>
				</div>
				
			</div>
    
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" RepeatColumns="3" RepeatDirection="Horizontal" Width="1001px">
     
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
       
    </asp:DataList>

			<br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ltsprd" TypeName="nsuncarte.clsprd"></asp:ObjectDataSource>

			
				
				
		

</asp:Content>

