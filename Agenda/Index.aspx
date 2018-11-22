<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Agenda.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar id="Calendario" runat="server"
              ForeColor="Blue"
              Height="400"
              Width="600"
              BorderColor="Black"
              BorderStyle="Double"
              ShowGridLines="True"
              DayNameFormat="Full"
              FirstDayOfWeek="Sunday"
              NextMonthText="Próximo"
              PrevMonthText="Anterior"
              OnSelectionChanged="Calendario_SelectionChanged"
              OnDayRender="Calendario_DayRender"/>
            <br />
            <asp:Label id="lblSelecao" runat="server"/>
        </div>
    </form>
</body>
</html>
