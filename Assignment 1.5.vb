Module Module1

    Sub Main()
        'DECLARATION

        Dim str1 As String
        Dim char1 As Char
        Dim i, vowelCounter As Integer

        'INITIALISATION

        str1 = " "
        char1 = " "
        i = 1
        vowelCounter = 0

        'INPUT

        Console.Write("Enter the statement: ")
        str1 = Console.ReadLine

        'PROCESS

        For i = 1 To Len(str1)
            char1 = (Mid(str1, i, 1))
            char1 = UCase(char1)
            If InStr("AEIOU", char1) > 0 Then

                vowelCounter = vowelCounter + 1
            End If
        Next i


        'OUTPUT

        Console.WriteLine("Vowels in string are: " & vowelCounter)
        Console.ReadKey()

    End Sub

End Module
