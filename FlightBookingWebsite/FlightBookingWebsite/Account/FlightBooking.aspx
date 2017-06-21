<%@ Page Title="Add new booking" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="FlightBooking.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Chọn hình thức bay: bay khứ hồi hay bay một chiều -->
    <div class="form-inline form-group">
        <asp:RadioButton runat="server" ID="roundTripRoute" CssClass="form-control" Text="Round-trip" GroupName="Closed" Checked="true" />
        <asp:RadioButton runat="server" ID="oneWayRoute" CssClass="form-control" Text="One-way" GroupName="Closed" />
    </div>

    <!--Địa điểm khởi hành-->
    <div class="form-group">
        <asp:Label runat="server" Text="From" />
        <asp:DropDownList runat="server" ID="drpFrom" AutoPostBack="true" CssClass="form-control" />
        <!--Địa điểm đến-->
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="To" />
        <asp:DropDownList runat="server" ID="drpTo" AutoPostBack="true" CssClass="form-control" />
    </div>

    <!--Thời gian khởi hành-->
    <div class="form-group">
        <asp:Label runat="server" Text="Departure date" />
        <asp:TextBox runat="server" AutoPostBack="true" ID="txtDepartureDate" TextMode="Date" CssClass="form-control" />

    </div>

    <!--Thời gian trở lại || Nếu hình thức bay là khứ hồi thì div này mới xuất hiện (chưa xử lí)-->
    <div class="form-group">
        <asp:Label runat="server" Text="Return date" />
        <asp:TextBox runat="server" AutoPostBack="true" ID="txtReturnDate" TextMode="Date" CssClass="form-control" />

    </div>
    <!--Số lượng vé người lớn -->
    <div class="form-group">
        <asp:Label runat="server" Text="Adults" />
        <asp:DropDownList runat="server" ID="drpAdults" AutoPostBack="true" CssClass="form-control" >
            <asp:ListItem Selected="True">1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
        </asp:DropDownList>
    </div>

    <!--Số lượng vé trẻ em-->
    <div class="form-group">
        <asp:Label runat="server" Text="Children" />
        <asp:DropDownList runat="server" ID="drpChild" AutoPostBack="true" CssClass="form-control" >
            <asp:ListItem Selected="True">0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
        </asp:DropDownList>

    </div>


    <div class="form-group">
        <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary" Text="Save" />
        <asp:HyperLink runat="server" ID="btnBack" CssClass="btn btn-default" Text="Back" NavigateUrl="~/Default.aspx" />
    </div>
</asp:Content>

