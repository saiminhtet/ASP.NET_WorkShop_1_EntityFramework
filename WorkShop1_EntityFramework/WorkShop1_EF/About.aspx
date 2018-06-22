<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WorkShop1_EF.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
   
         <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

        <asp:FileUpload ID="FileUpload1" runat="server" onchange="getISBN()" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script>
        function getISBN() {
            var fileName = $("input[id*=FileUpload1]").val().replace(/C:\\fakepath\\/i, '');
            alert(fileName);
            document.getElementById('<%=TextBox1.ClientID%>').value = fileName;
        }
   
       

       
    </script>
</asp:Content>
