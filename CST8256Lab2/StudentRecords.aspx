<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRecords.aspx.cs" Inherits="CST8256Lab2.StudentRecords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="DynamicTitle" runat="server"></title>
    <link href="App_Themes/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h1>Course Information</h1>
    <form id="form1" runat="server">
        <div>
            <div style="float: left">
                 Student ID: &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                 <asp:Textbox runat="server" ID="txtStudentID" CssClass="input"> </asp:Textbox>
                 &nbsp; &nbsp; 
                 <asp:RequiredFieldValidator runat="server" id="reNumber" controltovalidate="txtStudentID" errormessage="Required" CssClass="required" />

                <br /> <br />
                 Student Name: &nbsp; &nbsp;
                 <asp:Textbox runat="server" ID="txtStudentName" CssClass="input"></asp:Textbox>
                 &nbsp; &nbsp;
                 <asp:RegularExpressionValidator ID="RegularExpValidator" ValidationExpression="[a-zA-Z]+\s+[a-zA-Z]+" ControlToValidate="txtStudentName" CssClass="required" Display="Dynamic" ErrorMessage="Must be in first_name last_name!" runat="server"/>

                <br /> <br />

                Grade (0-100): &nbsp; &nbsp;
                 <asp:Textbox runat="server" ID="txtGrade" CssClass="input" Type="Integer"></asp:Textbox>
                 &nbsp; &nbsp;
                <asp:RangeValidator ID="reGrade" runat="server" ControlToValidate="txtGrade" Type="Integer" MinimumValue="0" MaximumValue="100" ErrorMessage="Grade from 0 to 100" CssClass="required"></asp:RangeValidator>
                <br /> <br />
                 <asp:Button runat="server" ID="btnSubmit" Text="Add to Course Record" OnClick="btnSubmit_Click" CssClass="button" Width="150px" />
                <p>Following students have been added: <br /></p>
                <p>Order By</p>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" TextAlign="Right" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">

                <asp:ListItem Value="ID" Selected="True"> </asp:ListItem>         
                <asp:ListItem Value="Name"></asp:ListItem>
                <asp:ListItem Value="Grade"> </asp:ListItem>
                </asp:RadioButtonList>

                <asp:Table runat="server" ID="tble" CssClass="table">
                <asp:TableRow>
                    <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Name</asp:TableHeaderCell>    
                    <asp:TableHeaderCell>Grade</asp:TableHeaderCell> 
                </asp:TableRow>
            </asp:Table>
             </div>
            
        </div>
    </form>
</body>
</html>
