Module Module1

    Sub Main()
        Dim num, reverse As Integer
        Dim GetReverse As FindReverseNumber = New FindReverseNumber()

        Console.WriteLine("*****************************************************************************************************")
        Console.WriteLine("                                                   REVERSE NUMBERS")
        Console.WriteLine("*****************************************************************************************************" & vbNewLine)


        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        Dim test As Integer = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 1 To test

            Console.WriteLine("                                                TESTCASE {0} ", i)
            Console.WriteLine("                                             **--------------**")
            Console.WriteLine("" & vbNewLine)

            Console.Write("ENTER A NUMBER:: ")
            num = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)
            reverse = GetReverse.reverseNumber(num)

            Console.WriteLine("" & vbNewLine + "REVERSED NUMBER IS:: {0}", reverse)
            Console.WriteLine("" & vbNewLine)

        Next

        Console.ReadKey()
    End Sub

    Public Class FindReverseNumber
        Public Function reverseNumber(ByVal num As Integer) As Integer
            Dim reverse As Integer = 0
            Dim temp As Double

            While num <> 0
                reverse = reverse * 10 + (num Mod 10)
                temp = num / 10
                temp = Math.Floor(temp)
                num = temp
            End While

            Return reverse
        End Function
    End Class

End Module
