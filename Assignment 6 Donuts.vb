Module Module1

    Sub Main()
        Dim Donuts As Integer


        Donuts = 0

        Console.Write("Enter Number of Donuts: ")
        Donuts = Console.ReadLine
        If Donuts < 10 Then
            Console.Write("The Number of donuts ordered are: " & Donuts)
        ElseIf Donuts >= 10 Then
            Console.Write("The number of donuts: Many")

        End If
        Console.ReadKey()

    End Sub

End Module
