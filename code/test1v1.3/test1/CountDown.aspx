<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountDown.aspx.cs" Inherits="test1.CountDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 116px;
            margin-left: 384px;
            margin-top: 252px;
        }
    </style>
</head>
<body style="height: 527px; width: 955px" background="http://gousfbulls.com/images/2006/1/19/KPQKUTWAPKTPGBZ.20060119181759.jpg?width=1024&height=576&mode=crop">
    <form id="form1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
    <asp:ScriptManager ID="sp" runat="server"></asp:ScriptManager>
    <asp:Timer ID="timerTest" runat="server" Interval="1000" OnTick="timerTest_tick"></asp:Timer>

    <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:Literal ID="litMsg" runat="server"></asp:Literal>

        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="timerTest" EventName="tick" />
        </Triggers>
    </asp:UpdatePanel>

    </form>
</body>
</html>
