<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="examOnline.aspx.cs" Inherits="OnlineExamination.examOnline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>How to create An online examination test</h1>
                <hr />
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate> 
                        <table>
                            <tr>

                                <td>
                                    <%#Eval("Qid") %> :  <%#Eval("Question") %>
                                </td>

                            </tr>

                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadOption1" runat="server" Text =' <%#Eval("option1") %>' GroupName ="rdexam"></asp:RadioButton>
                                    <asp:RadioButton ID="RadOption2" runat="server" Text =' <%#Eval("option2") %>' GroupName ="rdexam"></asp:RadioButton>
                                    <asp:RadioButton ID="RadOption3" runat="server" Text =' <%#Eval("option3") %>' GroupName ="rdexam"></asp:RadioButton>
                                    <asp:RadioButton ID="RadOption4" runat="server" Text =' <%#Eval("option4") %>' GroupName ="rdexam"></asp:RadioButton>
                                    <br />
                                    <asp:Label ID="CorrectAns" runat="server" Text='<%#Eval("correctans") %>' Visible ="false"></asp:Label>

                                </td>

                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="SelectedOption" runat="server" Text=""></asp:Label>

                                </td>

                            </tr>


                        </table>

                    </ItemTemplate>
                </asp:Repeater>
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click"></asp:Button>
            </center>
        </div>
    </form>
</body>
</html>
