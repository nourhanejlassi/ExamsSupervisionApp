<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mainpage.aspx.cs" Inherits="surveillance_des_examens.mainpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/main%20page%20stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CententPlaceHolder1" runat="server">
    <div class="container">
  <div class="row">
    <div class="col-sm">
        <center>
             <img src="imgs/bachelors-degree-icon.png" />

        </center>
        <p>
            Exams for bachelors starts from 8AM to 12AM.
            Check the schedule for more details and to reserve your sutable time for supervision.
        </p>
        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="View schedule" OnClick="Button1_Click" />


    </div> <br />

    <div class="col-sm">
        <center>
            <img src="imgs/masters-degree-icon.png" />

        </center>
        <p>
            Exams for master's students starts from 1PM to 4PM.
            Check the schedule for more details and to reserve your sutable time for supervision.
        </p>
        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="View schedule" OnClick="Button2_Click" />
    </div> <br />

    <div class="col-sm">
        <center>
           <img src="imgs/phd-degree-icon.png" />
        </center>

      <p>
          Exams for engineering's students starts from 9AM to 2PM.
          Check the schedule for more details and to reserve your suitable time for supervision.
      </p>
      <asp:Button class="btn btn-success btn-block btn-lg" ID="Button3" runat="server" Text="View schedule" OnClick="Button3_Click" />


    </div>
  </div>
</div>

</asp:Content>
