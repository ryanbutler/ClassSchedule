<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ClassSchedule._default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<asp:GridView ID="gridView_Schedule" runat="server" AutoGenerateColumns="false" OnRowDataBound="gridView_RowDataBound">
<Columns>
        <asp:BoundField DataField="sectName" HeaderText="Section Name" />
        <asp:BoundField DataField="synonym" HeaderText="Synonym" />
        <asp:BoundField DataField="credhrs" HeaderText="Credit Hours" />
        <asp:BoundField DataField="title" HeaderText="Title" />
        <asp:BoundField DataField="totalSeats" HeaderText="Total Seats" />
        <asp:BoundField DataField="remainSeats" HeaderText="Remaining Seats" />
        <asp:BoundField DataField="meetInfo" HeaderText="Meeting Information" />
        <asp:BoundField DataField="room" HeaderText="Room" />
        <asp:BoundField DataField="days" HeaderText="Days" />
        <asp:BoundField DataField="startTime" HeaderText="Start Time" />
        <asp:BoundField DataField="endTime" HeaderText="End Time" />
        <asp:BoundField DataField="instFullName" HeaderText="Instructor" />
        <asp:BoundField DataField="location" HeaderText="Location" />
    </Columns>
</asp:GridView>
</form>
</body>
</html>
