<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidationControls.aspx.cs" Inherits="WorkShop1_EF.ValidationControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div>
            <h3>2. Using the RequiredFieldValidator Control</h3>
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="Enter your name" Width="230px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="TextBox1" ForeColor="Red"
                ErrorMessage="RequiredFieldValidator">Name is required</asp:RequiredFieldValidator>
            <hr />
            <h3>3. Using the CompareValidator control</h3>
            <p>Checks for similar values</p>
            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="177px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToCompare="TextBox3" ControlToValidate="TextBox2"
                ErrorMessage="CompareValidator">Email not the same</asp:CompareValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email (again): "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="177px"></asp:TextBox>
            <hr />
            <h3>4. Using the RangeValidator control</h3>
            <p>Checks for input to be within a range</p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ErrorMessage="RangeValidator" ControlToValidate="TextBox4"
                ForeColor="Red" Type="Integer"
                MaximumValue="105" MinimumValue="12">Invalid age</asp:RangeValidator>
            <hr />
            <h3>5. Using the RegularExpression Validator control</h3>
            <p>Using the RegularExpressionValidator control</p>
             <%--Expression မှာစစ်ထားတဲ့ format တိုင်းပဲ ဖော်ြပသည်--%>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox5"
                ValidationExpression="[A-Z]{1,3}[1-9][0-9]{0,3}[A-Z]"
                ForeColor="Red">Invalid vehicle</asp:RegularExpressionValidator>
            <hr />
            <h3>6. Using the ValidationSummary control</h3>
            <p>Using the RegularExpressionValidator control</p>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Register me" />
            
        </div>
    </form>
</asp:Content>
