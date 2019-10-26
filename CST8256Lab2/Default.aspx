<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CST8256Lab2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Coure Infromation</title>
     <link href="App_Themes/StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            border: 2px ridge #f00;
            background-color: lightblue;
        }
    </style>
</head>
<body>
     <h1>Course Information</h1>
    <form id="form1" runat="server">
        <div>
            <div style="float: left">
                 Course Number: &nbsp;
                 <asp:Textbox runat="server" id="txtnumber" CssClass="input"> </asp:Textbox>
                 &nbsp; &nbsp; 
                 <asp:RequiredFieldValidator runat="server" id="reNumber" controltovalidate="txtnumber" errormessage="Required" CssClass="required" />
                <br /> <br />
                 Course Name : &nbsp; &nbsp;
                 <asp:Textbox runat="server" id="txtname" CssClass="input"></asp:Textbox>
                 &nbsp; &nbsp;
                 <asp:RequiredFieldValidator runat="server" id="reName" controltovalidate="txtname" errormessage="Required" CssClass="required"/>

                <br /> <br />
                <asp:Button runat="server" id="btnSubmit" Text="Submit Course Information" OnClick="btnSubmit_Click" CssClass="button" Width="200px" />

             </div>         
        </div>
    </form>
</body>
</html>
