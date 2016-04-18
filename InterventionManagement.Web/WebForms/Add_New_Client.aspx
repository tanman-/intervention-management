﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_New_Client.aspx.cs" Inherits="au.edu.uts.ASDF.ENETCare.InterventionManagement.Web.WebForms.Add_New_Client" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="Add new client" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
    </div>
    <div class="centerblock">
        <b>Name:</b>
        <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
        <br />
        <br />
        <b>District:</b>
        <asp:DropDownList ID="dropList_District" runat="server"></asp:DropDownList>
        <br />
        <br />
        <b>Location Description:</b>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="150px" Width="500px"></asp:TextBox>
    </div>
    <div class="centerblock">

        <asp:Button ID="btn_CreateClient" runat="server" Text="Create Client" OnClick="btn_CreateClient_Click" />
        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel and Go Back" OnClick="btn_Cancel_Click" />

    </div>
</asp:Content>