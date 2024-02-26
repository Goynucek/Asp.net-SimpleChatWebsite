<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="ChatApplication.LogIn1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Goynucek</title>
            <style>
                #LogInFrame{
                    width:15em;
                    height:15em;
                    margin:auto;
                    border:1px solid black;
                    display:flex;
                    flex-direction:column;
                    align-items: center;
                    justify-content: center;
                }

                #TextBox1{
                    margin-bottom:1em;
                }
             </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="LogInFrame">  
            <div style="display:flex;flex-direction:column;margin-bottom:1em">
                <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" Width="150px" TextMode="Password"></asp:TextBox>   
            </div>
            <asp:Button ID="Button1" runat="server" Text="Log In" Width="80px" OnClick="Button1_Click" />
            <a href="SignIn.aspx">Sing In</a>
        </div>
</asp:Content>
