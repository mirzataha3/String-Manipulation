Module Module1

    Sub Main()
        'DECLARATION

        Dim s As String

        'INITIALISATION

        s = " "

        'INPUT

        Console.Write("Enter statement: ")
        s = Console.ReadLine

        'PROCESS

       
        If Len(s) >= 3 And Right(s, 3) = ("ing") Then
            s = s + ("ly")
            Console.WriteLine("New statement: " & s)
        ElseIf Len(s) >= 3 Then
            s = s + ("ing")
            Console.WriteLine("New statement: " & s)
        End If
        If Len(s) < 3 Then
            Console.WriteLine("New statement: " & s)
        End If

        Console.ReadKey()
    End Sub

End Module
