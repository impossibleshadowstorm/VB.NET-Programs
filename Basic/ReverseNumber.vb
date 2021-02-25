Module Module1

    Sub Main()

        Dim num, remainder, reverse, test As Integer
        Dim temp As Double

        Console.WriteLine("ENTER THE NUMBER OF TESTCASES:: ")
        test = CInt(Console.ReadLine())

        For i As Integer = 1 To test

            Console.Write("***********TESTCASE " & i)
            Console.Write("***********")

            reverse = 0

            Console.WriteLine("" & vbNewLine)

            Console.Write("ENTER A NUMBER:: ")
            num = CInt(Console.ReadLine())

            While num <> 0
                remainder = num Mod 10
                reverse = reverse * 10 + remainder
                temp = num / 10
                temp = Math.Floor(temp)
                num = temp
            End While

            Console.WriteLine("REVERSED NUMBER IS:: " & reverse)
            Console.WriteLine("" & vbNewLine)

        Next

        Console.ReadLine()

    End Sub

End Module
