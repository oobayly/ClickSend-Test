Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ClickSend.Configuration.BaseUri = "http://rest.clicksend.com/v3" ' So I can capture traffic
    Dim client = New ClickSend.ClickSendClient(txtUserName.Text, txtPassword.Text)
    TextBox1.Text = client.Account.GetAccount() ' This never returns
  End Sub
End Class
