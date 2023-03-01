<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="ViewCategory.aspx.cs" Inherits="JwelleryApplication.ViewCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

       

        .auto-style2 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form_cont">
         
    <form id="form2" runat="server"  style="width: 80%">
       
               
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add New Category" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add New Product" />
              
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  CssClass="table" DataKeyNames="Cat_id" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="163px" Width="687px" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BorderStyle="None">
                        <Columns>
                            <asp:BoundField DataField="Cat_id" HeaderText="Category_id" />
                            <asp:BoundField DataField="Cat_name" HeaderText="Category_Name" />
                            <asp:ImageField DataImageUrlField="Cat_Image" HeaderText="Category_Image">
                                <ControlStyle Height="50px" Width="50px" />
                            </asp:ImageField>
                            <asp:BoundField DataField="Cat_desc" HeaderText="Category_Description" />
                            <asp:BoundField DataField="Cat_status" HeaderText="Category_Status" />
                            <asp:CommandField ShowEditButton="True" AccessibleHeaderText="Edit" HeaderText="Edit" />
                            <asp:CommandField ShowSelectButton="True" HeaderText="Select" />
                            <asp:CommandField ShowDeleteButton="True" HeaderText="Delete" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" ForeColor="White" Font-Bold="True" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
               
    </form>
         </div>
       
</asp:Content>
