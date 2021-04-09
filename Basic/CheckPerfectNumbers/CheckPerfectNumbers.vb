Module Module1

    Sub Main()

        Dim num As Integer
        Dim sum As Integer = 0

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

            For i = 1 To num / 2
                If num Mod i = 0 Then
                    sum += i
                End If
            Next

            Console.WriteLine("                                        +++ ---------------------- +++")
            Console.WriteLine("                                        +++ PERFECT NUMBERS RESULT +++")
            Console.WriteLine("                                        +++ ---------------------- +++" & vbNewLine)

            If sum = num Then
                Console.WriteLine("{0} IS A PERFECT NUMBER!!", num)
            Else
                Console.WriteLine("{0} IS NOT A PERFECT NUMBER!!", num)
            End If
        Next

        Console.ReadKey()
    End Sub

End Module
