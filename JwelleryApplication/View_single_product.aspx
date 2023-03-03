<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="View_single_product.aspx.cs" Inherits="JwelleryApplication.View_single_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 196px;
            width: 193px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="form_cont">
    <form id="form2" runat="server">
       
        <div class="gap" align="center">
            
<asp:DataList ID="DataList1" runat="server" style="align-content:center" Height="734px" OnItemCommand="DataList1_ItemCommand1">
                    <ItemTemplate>
                        <table class="auto-style1">
                        
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("Pdt_Id") %>' Height="253px" ImageUrl='<%# Eval("Pdt_image") %>' Width="290px" OnCommand="ImageButton1_Command" />
                                </td>
                               
                            </tr>
                           
                            <tr>
                                <td><strong>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Pdt_name") %>'></asp:Label>
                                    </strong></td>
                                
                            </tr>
                           
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Pdt_desc") %>'></asp:Label>
                                </td>
                               
                            </tr>
                            
                               <tr>
                                <td>&nbsp;</td>
                               
                            </tr>
                           
                        </table>
                        <asp:TextBox ID="TextBox1" runat="server" Height="47px" Width="110px"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" Height="74px" Text="Add To Kart" Width="194px" OnClick="Button2_Click" />
                        <asp:Button ID="Button4" runat="server" Text="Continue" />
                        <asp:Button ID="Button3" runat="server" Text="Back to Home" />
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        <strong><b>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Pdt_price") %>'></asp:Label>
                        </b></strong>
                    </ItemTemplate>
                </asp:DataList>
          
      
  
            </div>
          </form>
           </div>
    
</asp:Content>
