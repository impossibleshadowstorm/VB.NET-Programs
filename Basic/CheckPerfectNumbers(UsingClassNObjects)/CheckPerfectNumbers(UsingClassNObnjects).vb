Module Module1
    Sub Main()

        Dim num As Integer
        Dim bool As Boolean
        Dim checkperfection As PerfectNumbers = New PerfectNumbers()

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS PERFECT NUMBER")
        Console.WriteLine("                                      **---------------------------------------------------**")

        Console.WriteLine("" & vbNewLine)


        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        Dim test As Integer = CInt(Console.ReadLine())

        For j = 1 To test

            Console.WriteLine("" & vbNewLine + "----------------------------------------------------------------------------------------------")
            Console.WriteLine("                                            TESTCASE {0} ", j)
            Console.WriteLine("----------------------------------------------------------------------------------------------" & vbNewLine & vbNewLine)

            Console.Write("ENTER A NUMBER TO CHECK:: ")
            num = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)

            bool = checkperfection.checkPerfectNumbers(num)

            Console.WriteLine("                                        +++ ---------------------- +++")
            Console.WriteLine("                                        +++ PERFECT NUMBERS RESULT +++")
            Console.WriteLine("                                        +++ ---------------------- +++" & vbNewLine)

            If bool Then
                Console.WriteLine("{0} IS A PERFECT NUMBER!!", num)
            Else
                Console.WriteLine("{0} IS NOT A PERFECT NUMBER!!", num)
            End If
        Next

        Console.ReadKey()
    End Sub

End Module


Public Class PerfectNumbers
    Public Function checkPerfectNumbers(ByVal num As Integer) As Boolean

        Dim sum As Integer = 0
        Dim bool As Boolean = False

        For i = 1 To num / 2
            If num Mod i = 0 Then
                sum += i
            End If
        Next

        If num = sum Then
            bool = True
        End If

        Return bool

    End Function
End Class