Module Module1

    Sub Main()
        Dim Fromstation, Tostation, Passengers, Total, Stations As Integer

        Fromstation = 0
        Tostation = 0
        Passengers = 0
        Total = 0
        Stations = 0

        Do

            Console.Write("From which station?: ")
            Fromstation = Console.ReadLine
            If (Fromstation < 1) Or (Fromstation > 5) Then
                Console.WriteLine("Please select station from 1 to 5: ")
            End If

        Loop Until (Fromstation >= 1) And (Fromstation <= 5)

        Do
            Console.Write("To which station?: ")
            Tostation = Console.ReadLine
            If (Tostation < 1) Or (Tostation > 5) Then
                Console.WriteLine("Please select station from 1 to 5: ")
            End If

        Loop Until (Tostation >= 1) And (Tostation <= 5)

        Console.Write("Enter no. of Passengers: ")
        Passengers = Console.ReadLine

        Stations = Tostation - Fromstation

        If Stations < 0 Then
            Stations = Stations * (-1)
        End If

        Total = Total + (Passengers * Stations * 2)

        If (Passengers >= 5) And (Passengers <= 9) Then
            Total = Total - 8
        End If

        If (Passengers > 9) Then
            Total = Total - 15
        End If

        Console.Write("Total Fare: " & Total)
        Console.ReadKey()
    End Sub

End Module
