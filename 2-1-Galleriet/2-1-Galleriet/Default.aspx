<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_2_1_Galleriet.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Galleriet</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- Kontroller för uppladdning --%>
        <asp:FileUpload ID="FileUpload" runat="server" />
        <asp:Button ID="UploadButton" runat="server" Text="Ladda upp Bild" OnClick="UploadButton_Click" />

        <%-- Test kontroller --%>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
