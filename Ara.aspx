<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Ara.aspx.cs" Inherits="DiziYorumProje.Default" %>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>   
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>

                <%#Eval("BLOGBASLIK") %>
            </ItemTemplate>

        </asp:Repeater>
    
    </form>
       
</body>
</html>
