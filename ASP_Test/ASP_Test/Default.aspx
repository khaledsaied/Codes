<%@ Page Language="C#" Inherits="ASP_Test.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
		<asp:Button id="button2" runat="server" Text="Click me2!" OnClick="button2Clicked" />
		<br /><br />
		A basic TextBox:
		<asp:TextBox id="tb1" runat="server" />
		<br /><br />
		A password TextBox:
		<asp:TextBox id="tb2" TextMode="password" runat="server" />
		<br /><br />
		A TextBox with text:
		<asp:TextBox id="tb4" Text="Hello World!" runat="server" />
		<br /><br />
		A multiline TextBox:
		<asp:TextBox id="tb3" TextMode="multiline" runat="server" OnTextChanged="tb3_TextChanged" />
		<br /><br />
	</form>
</body>
</html>
