﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="master.aspx.cs" Inherits="surveillance_des_examens.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/schedule%20stylesheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CententPlaceHolder1" runat="server">
    <div class="container">
       <br />
       <center>
           <h1>
               Master Exams Schedule
           </h1> <br /> <br />
       </center>
       <center>
                     <table class="table table-striped table-responsive-md btn-table">

        <thead>
             <tr>
             <th>Time</th>
             <th>Monday</th>
             <th>Tuesday</th>
             <th>Wednesday</th>
             <th>Thursday</th>
             <th>Friday</th>
             <th>Saturday</th>
        </tr>
    
      </thead>

      <tbody>
                <tr>
          <th scope="row" class="auto-style1">1PM-2:30PM</th>
           <td class="auto-style1">
              <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Reserve</asp:LinkButton>
           </td>

          <td class="auto-style1">
             <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Reserve</asp:LinkButton>
          </td>

          <td class="auto-style1">
              <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Reserve</asp:LinkButton>
          </td>

           <td class="auto-style1">
               <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Reserve</asp:LinkButton>
          </td>

           <td class="auto-style1">
               <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Reserve</asp:LinkButton>
          </td>

           <td class="auto-style1">
               <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Reserve</asp:LinkButton>
          </td>
      </tr>


          <tr>
          <th scope="row">2:30PM-4PM</th>
           <td>
               <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">Reserve</asp:LinkButton>
           </td>

          <td>
              <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">Reserve</asp:LinkButton>
          </td>

          <td>
              <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">Reserve</asp:LinkButton>
          </td>

           <td>
               <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">Reserve</asp:LinkButton>
          </td>

           <td>
               <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">Reserve</asp:LinkButton>
          </td>

           <td>
             <p> No Exams </p>
          </td>
      </tr>
              
  
</tbody>

</table> <br /> <br />

       </center>

       </div>"
</asp:Content>
