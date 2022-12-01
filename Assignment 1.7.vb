Module Module1

    Sub Main()
        'DECLARATION

        Dim s, a, b As String

        'INITIALISATION

        s = " "
        a = " "
        b = " "

        'INPUT

        Console.Write("Enter statement 1: ")
        s = Console.ReadLine

        'PROCESS

        a = Left(s, 2)
        b = Right(s, 2)

        If Len(s) < 2 Then
            Console.WriteLine(s)
        Else
            Console.WriteLine("New statement: " & a & b)
        End If
        Console.ReadKey()
    End Sub

End Module
