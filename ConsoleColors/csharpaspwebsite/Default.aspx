<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%
    HelloWorldLabel.Text = "Hello, world!";
     %>  
    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    
      <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="HelloWorldLabel" runat="server" Text="Label"></asp:Label>
    
    
    </div>
    </form>
</body>
</html>
