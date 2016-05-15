<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Dropdown lists that receive data from the ShowTracker Service -->
        <h2>Venues</h2>
        <asp:DropDownList ID="VenueDropDownList" runat="server"></asp:DropDownList> 
        
        <hr />
        <h2>Artists</h2>
         <asp:DropDownList ID="ArtistDropDownList" runat="server"></asp:DropDownList> 
         
         <hr />
        <h2>Shows</h2>
         <asp:DropDownList ID="ShowDropDownList" runat="server"></asp:DropDownList> 
       
         <hr />
        <h2>Select venue to see up comming shows.</h2>
         <asp:DropDownList ID="VenueByShowDropDownList" runat="server"></asp:DropDownList> 
         <asp:GridView ID="VenueByShowGridView" runat="server"></asp:GridView>
        <asp:Button ID="VenueByShowButton" runat="server" Text="Shows by Venue" OnClick="VenueByShowButton_Click" />

         <hr />
        <h2>Select artist to see up comming shows.</h2>
         <asp:DropDownList ID="ArtistByShowDropDownList" runat="server" ></asp:DropDownList> 
         <asp:GridView ID="ArtistByShowGridView" runat="server"></asp:GridView>
        <asp:Button ID="ArtistByShowButton" runat="server" Text="Shows by Artist" OnClick="ArtistByShowButton_Click" />
        
    </div>
    </form>
</body>
</html>
