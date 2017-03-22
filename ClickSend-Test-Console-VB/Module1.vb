Module Module1

  Sub Main()
    Console.Write("ClickSend Username: ")
    Dim username = Console.ReadLine()
    Console.Write("ClickSend Password: ")
    Dim password = Console.ReadLine()

    ClickSend.Configuration.BaseUri = "http://rest.clicksend.com/v3" ' So I can capture traffic
    Dim client = New ClickSend.ClickSendClient(username, password)
    Dim resp = client.Account.GetAccount() ' This *does* returns
    Console.WriteLine(resp)

    Console.WriteLine("Press any key to continue...")
    Console.Read()
  End Sub

End Module
