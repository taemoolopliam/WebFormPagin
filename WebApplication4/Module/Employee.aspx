<%@ Page Title="Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebApplication4.Module.Employee" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-end form-group">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" OnTextChanged="TextBox1_TextChanged"  ></asp:TextBox>
    </div>
        <asp:GridView
            ID="empTable"
            runat="server"
            AutoGenerateColumns="False" 
            Width="100%"
            AllowCustomPaging="True"
            AllowPaging="True"
            OnPageIndexChanging="empTable_PageIndexChanging"
            cssClass="table table-bordered">
            <Columns>
                <asp:BoundField HeaderText="EmployeeID" DataField="EmployeeID" />
                <asp:BoundField HeaderText="EmployeeName" DataField="EmployeeName" />
                <asp:BoundField HeaderText="Department" DataField="Department" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Phone" DataField="Phone" />
            </Columns>
            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
        </asp:GridView>
</asp:Content>

