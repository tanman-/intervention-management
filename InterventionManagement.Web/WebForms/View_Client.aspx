﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View_Client.aspx.cs" Inherits="au.edu.uts.ASDF.ENETCare.InterventionManagement.Web.WebForms.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <!--Page heading -->
        <div align="center">
            <asp:Label ID="lblTitle" runat="server" Text="Client Details" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        </div>
        <!--End page heading -->

        <!--Start client details -->
        <div style="margin-left: 30%; margin-top: 5%">
            <table style="width: 60%; line-height: 150%;">
                <colgroup>
                    <col style="width: 15%" />
                    <col style="width: 85%" />
                </colgroup>

                <tr>
                    <td>
                        <asp:Label ID="lblClientName" runat="server" Text="Name: " Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblClientLocation" runat="server" Text="Location: " Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="lblLocation" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblClientDistrict" runat="server" Text="District: " Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblDistrict" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <!-- End client details -->


        <!-- Start data table-->
        <div style="margin-left: 20%; margin-top: 5%">
            <asp:Table ID="InterventionTable" runat="server" GridLines="Both" Width="80%">
                <asp:TableRow runat="server" Font-Bold="True" Height="50px">
                    <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" Width="30%">Interventions</asp:TableCell>
                    <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" Width="40%">Intervention Details</asp:TableCell>
                    <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" Width="30%">Update Intervention</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:Button ID="btnAddIntervention" runat="server" Text="Add new intervention" OnClick="btnAddIntervention_Click" />
        </div>

        <!-- End data table-->

    </div>
</asp:Content>
