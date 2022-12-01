Module Module1

    Sub Main()
        'DECLARATION

        Dim ND As Integer

        'INITIALISATION

        ND = 0

        Console.Write("Enter number of donuts: ")
        ND = Console.ReadLine

        If ND >= 10 Then
            Console.WriteLine("Number of donuts: Many")
        Else
            Console.WriteLine("Numner of donuts: " & ND)
        End If
        Console.ReadKey()
    End Sub

End Module
