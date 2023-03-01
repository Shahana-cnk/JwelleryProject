<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="View_User.aspx.cs" Inherits="JwelleryApplication.View_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 98%;
        }
        h3{
            align-content:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form_cont">
    <form id="form2" runat="server">
        <br />
        <h3>Users</h3>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="User_id" Width="1060px" >
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td>Name</td>
                        <td>Age </td>
                        <td>Address</td>
                        <td>State</td>
                        <td>Pincode</td>
                        <td>Contact</td>
                      
                        <td>Status</td>
                    </tr>
                    <tr>
                        <td><%#Eval("User_name")%></td>
                        <td><%#Eval("User_age")%></td>
                        <td><%#Eval("User_address")%></td>
                        <td><%#Eval("User_state")%></td>
                        <td><%#Eval("User_pincode")%></td>
                        <td><%#Eval("User_contact")%></td>
                       
                         <td><%#Eval("Status")%></td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
    </form>
         </div>
</asp:Content>
