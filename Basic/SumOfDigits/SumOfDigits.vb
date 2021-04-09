Module Module1

    Sub Main()

        Dim num, remainder As Integer
        Dim sum As Integer = 0

        Console.WriteLine("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        While num > 0
            remainder = num Mod 10
            sum = sum + remainder
            num = Math.Floor(num / 10)
        End While

        Console.WriteLine("SUM OF DIGITS ARE:: " & sum)
        Console.ReadLine()

    End Sub

End Module
