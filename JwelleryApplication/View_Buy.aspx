<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="View_Buy.aspx.cs" Inherits="JwelleryApplication.View_Buy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 860px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form_cont">
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="250px" Width="250px" />
                </td>
               
            </tr>
          
          
            
          
       <tr><td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td> </tr>
       <tr><td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td> </tr>
        <tr><td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>  </tr>
          <tr><td><asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox></td></tr>    
      <tr><td>
           <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Back to Home" />
        <asp:Button ID="Button3" runat="server" Text="Continue" />
          </td></tr> 
              <tr><td><asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label></td> </tr>
             <tr><td><asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label></td> </tr>
        </table>
       
    </form>
         </div>
</asp:Content>
