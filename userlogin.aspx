<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="surveillance_des_examens.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminlogin%20stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CententPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/generaluser.png"/>                                  
                                </center>
                            </div>
                        </div>

                      <div class="row">
                         <div class="col">
                                <center>
                                    <h3> Member Login </h3>
                                </center>
                           </div>
                     </div> 
                    
                     <div class="row">
                         <div class="col">
                                <hr />
                           </div>
                     </div> 

                    <div class="row">
                         <div class="col">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Enter your member ID"></asp:TextBox>
                                </div>

                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Enter your password" TextMode="Password" ></asp:TextBox>
                                </div>
                                <div class="form-group"> 
                                    <asp:Button CssClass="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

                                </div>
                                
                           </div>
                     </div> 
                     
                    </div>
                </div> <br />

                <a href="homepage.aspx"><< Back to Home</a><br><br />
            </div>
        </div> 
    </div>





</asp:Content>
