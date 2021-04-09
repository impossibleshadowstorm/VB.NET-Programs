Module Module1

    Sub Main()
        Dim num As Integer
        Dim isPowerIsBigger As Integer

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS POWER OF 5 OR NOT")
        Console.WriteLine("                                     **------------------------------------------------------** ")

        Console.WriteLine("" & vbNewLine)


        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        Dim test As Integer = CInt(Console.ReadLine())

        For i = 1 To test

            Console.WriteLine("" & vbNewLine + "----------------------------------------------------------------------------------------------")
            Console.WriteLine("                                            TESTCASE {0} ", i)
            Console.WriteLine("----------------------------------------------------------------------------------------------" & vbNewLine & vbNewLine)

            Console.Write("ENTER A NUMBER TO CHECK:: ")
            num = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)

            For j = 1 To num

                Dim power As Integer = 5 ^ j

                isPowerIsBigger = isPowerIsGreaterThanNum(power, num)

                If isPowerIsBigger = 1 Then
                    Console.WriteLine("" & vbNewLine + "                                    +++ RESULT +++")
                    Console.WriteLine("                                    +++ ------ +++" & vbNewLine)

                    Console.WriteLine("NUMBER CAN BE POWER OF 5")
                    Exit For
                ElseIf isPowerIsBigger = 2 Then
                    Console.WriteLine("" & vbNewLine + "                                    +++ RESULT +++")
                    Console.WriteLine("                                    +++ ------ +++" & vbNewLine)

                    Console.WriteLine("NUMBER CAN NOT BE POWER OF 5")
                    Exit For
                End If

            Next
        Next
    End Sub

    Public Function isPowerIsGreaterThanNum(ByVal power As Integer, ByVal num As Integer) As Integer

        Dim check As Integer = 0

        If power = num Then
            check = 1
        ElseIf power > num Then
            check = 2
        Else
            check = 0
        End If

        Return check
    End Function

End Module
