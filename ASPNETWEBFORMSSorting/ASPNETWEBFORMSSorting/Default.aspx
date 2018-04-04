<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNETWEBFORMSSorting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;&nbsp;&nbsp; &nbsp;Fun with arrays and sorting!!!&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp; First lets set up an array!<br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Then lets put them in an array!&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="arrayButton" runat="server" OnClick="arrayButton_Click" Text="Make it an array!" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Now lets sort it, and see how long our timer says it takes!<br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bubbleButton" runat="server" OnClick="bubbleButton_Click" Text="Bubble Sort" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="selectionButton" runat="server" OnClick="selectionButton_Click" Text="Selection Sort" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="InsertionButton" runat="server" OnClick="InsertionButton_Click" Text="Insertion Sort" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="shellButton" runat="server" OnClick="shellButton_Click" Text="Shell Sort" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="quickButton" runat="server" OnClick="quickButton_Click" Text="Quicksort aka Partition Sort" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Here is the timer to see how long the sort took!<br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="timerLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
