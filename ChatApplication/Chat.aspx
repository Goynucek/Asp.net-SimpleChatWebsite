<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ChatApplication.Chat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #frame{
            height:20em;
            width:50em;
        }
        #ChatPanel{
            height:17em;
            width:30em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="frame">
        <div>
            <div id="ChatPanel">
                <asp:ListBox ID="ListBox1" runat="server" Height="265px" Width="789px">

                </asp:ListBox>
            </div>
            <div id="ChatInput">
                <asp:TextBox ID="TextBox1" runat="server" Height="42px" Width="699px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Height="48px" Text="Button" Width="86px" OnClick="Button1_Click" />
            </div>
        </div>

    </div>
</asp:Content>
