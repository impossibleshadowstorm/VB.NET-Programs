Module Module1

    Sub Main()
        Dim num As Integer

        Console.WriteLine("                                         PROGRAM TO CHECK WETHER NUMBER IS EVEN OR ODD")
        Console.WriteLine("                                      **-----------------------------------------------** ")

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


            Console.WriteLine("                                        +++--------------------+++")
            Console.WriteLine("                                        +++ EVEN OR ODD RESULT +++")
            Console.WriteLine("                                        +++--------------------+++")
            Console.WriteLine("" & vbNewLine)

            If num Mod 2 = 0 Then
                Console.WriteLine("{0} IS AN EVEN NUMBER BECAUSE {0} CAN BE DIVIDED BY 2 !!", num)
            Else
                Console.WriteLine("{0} IS A ODD NUMBER BECAUSE {0} CAN'T BE DIVIDED BY 2 !!", num)
            End If
        Next

        Console.ReadKey()
    End Sub

End Module
