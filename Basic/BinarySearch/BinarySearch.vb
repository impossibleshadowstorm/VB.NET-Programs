Module Module1

    Sub Main()
        Dim array As Integer() = New Integer(100) {}
        Dim num, test As Integer
        Dim flag As Integer = 0

        Console.WriteLine("                                         PROGRAM TO SEARCH ELEMENT IN THE ARRAY ")
        Console.WriteLine("                                      **----------------------------------------** ")
        Console.WriteLine("" & vbNewLine)

        Console.Write("HOW MANY NUMBERS YOU WANT TO STORE IN ARRAY:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("                                           INSERT {0} ELEMENTS IN ARRAY")
        Console.WriteLine("                                         --------------------------------")

        For i = 1 To num
            Console.Write("ELEMENT {0} :: ", i)
            array(i) = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine + "************************************************************************************************************")
        Console.Write("ENTER THE NUMBER OF TESTCASES:: ")
        test = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 1 To test

            flag = 0

            Console.WriteLine("" & vbNewLine + "------------------------------------------------------------------------------------------------------------")
            Console.WriteLine("                                              TESTCASE {0}", i)
            Console.WriteLine("------------------------------------------------------------------------------------------------------------" & vbNewLine)

            Console.Write("" & vbNewLine + "ENTER THE NUMBER TO SEARCH IN ARRAY:: ")
            Dim search As Integer = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)

            Console.WriteLine("                                        +++------------------------+++")
            Console.WriteLine("                                        +++ SEARCH RESULT IN ARRAY +++")
            Console.WriteLine("                                        +++------------------------+++")
            Console.WriteLine("" & vbNewLine)

            For j = 1 To num
                If array(j) = search Then
                    flag = j
                    Exit For
                End If
            Next

            If flag <> 0 Then
                Console.WriteLine("{0} FOUND IN ARRAY AT POSITION {1}.", search, flag)
            Else
                Console.WriteLine("{0} IS NOT AVAILABLE IN ARRAY.", search)
            End If

        Next


        Console.ReadKey()

    End Sub

End Module
