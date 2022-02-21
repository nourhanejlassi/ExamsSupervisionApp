<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adduser.aspx.cs" Inherits="surveillance_des_examens.adduser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                           <img width="100px" src="imgs/generaluser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Add member</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Date of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Contact No" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>State</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Tunis" Value="Tunis" />
                              <asp:ListItem Text="Ariana" Value="Ariana" />
                              <asp:ListItem Text="Ben Arous" Value="Ben Arous" />
                              <asp:ListItem Text="Mannouba" Value="Manouba" />
                              <asp:ListItem Text="Bizerte" Value="Bizerte" />
                              <asp:ListItem Text="Nabeul" Value="Nabeul" />
                              <asp:ListItem Text="Beja" Value="Beja" />
                              <asp:ListItem Text="Jendouba" Value="Jendouba" />
                              <asp:ListItem Text="Zaghouan" Value="Zaghouan" />
                              <asp:ListItem Text="Siliana" Value="Siliana" />
                              <asp:ListItem Text="Kef" Value="Kef" />
                              <asp:ListItem Text="Sousse" Value="Sousse" />
                              <asp:ListItem Text="Monastir" Value="Monastir" />
                              <asp:ListItem Text="Mahdia" Value="Mahdia" />
                              <asp:ListItem Text="Kasserine" Value="Kasserine" />
                              <asp:ListItem Text="Sidi Bouzid" Value="Sidi Bouzid" />
                              <asp:ListItem Text="Kairouan" Value="Kairouan" />
                              <asp:ListItem Text="Gafsa" Value="Gafsa" />
                              <asp:ListItem Text="Sfax" Value="Sfax" />
                              <asp:ListItem Text="Gabes" Value="Gabes" />
                              <asp:ListItem Text="Medenine" Value="Medenine" />
                              <asp:ListItem Text="Tozeur" Value="Tozeur" />
                              <asp:ListItem Text="Kebili" Value="Kebili" />
                              <asp:ListItem Text="Tataouine" Value="Tataouine" />

                           </asp:DropDownList>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="City"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Pincode</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Pincode" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Full Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <span class="badge badge-pill badge-info">Login Credentials</span>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>User ID</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="User ID" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Email ID" TextMode="Password" ></asp:TextBox>
                        </div>
                     </div>
                     
                  </div>
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                           </div>
                        </center>
                     </div>
                  </div>
               </div>
            </div> <br />
            <a href="homepage.aspx"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>
