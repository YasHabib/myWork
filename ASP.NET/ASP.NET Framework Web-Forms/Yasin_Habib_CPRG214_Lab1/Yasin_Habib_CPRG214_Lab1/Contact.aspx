<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Yasin_Habib_CPRG214_Lab1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <h2><%: Title %></h2>
    <br />
    <address>
        Inland Lake Marina<br />
        Box 123<br />
        Inland Lake, Arizona<br />
        86038<br />
    </address>


    <abbr title="Phone"></abbr>
    (office ph): 928-555-2234<br />
    (leasing ph): 928-555-2235<br />
    (fax): 928-555-2236<br />

    <address>
        <strong>Contact:</strong>   <a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a><br />
            Manager: Glenn Cooke<br />
            Slip Manager: Kimberley Carson<br />
    </address>
</asp:Content>
