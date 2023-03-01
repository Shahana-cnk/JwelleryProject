<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="View_Shop.aspx.cs" Inherits="JwelleryApplication.View_Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="gap" align="center">
    <form id="form2" runat="server">
        
   <table class="auto-style1">

         <tr>
             <td>&nbsp;</td> 
             <td>&nbsp;</td>
         </tr>
       <tr>
             <td>&nbsp;</td> 
             <td>&nbsp;</td>
         </tr>
       <tr>
             <td>&nbsp;</td> 
             <td>&nbsp;</td>
         </tr>
        <tr>

             <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Height="601px">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td>
                                 <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("Cat_Id") %>' Height="259px" ImageUrl='<%# Eval("Cat_Image") %>' Width="251px" OnCommand="ImageButton1_Command" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text='<%# Eval("Cat_Name") %>'></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
          
    </form>
      </div> 
    
</asp:Content>
