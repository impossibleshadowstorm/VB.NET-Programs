Module Module1

    Sub Main()

        Dim array As Integer() = New Integer(100) {}
        Dim num As Integer

        Console.WriteLine("                                         PROGRAM TO DEMONSTRATE THE ARRAY ")
        Console.WriteLine("                                      **----------------------------------** ")

        Console.WriteLine("" & vbNewLine)

        Console.Write("HOW MANY NUMBERS YOU WANT TO STORE IN ARRAY:: ")
        num = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("                                           INSERT {0} ELEMENTS IN ARRAY")
        Console.WriteLine("                                         --------------------------------")

        For i = 1 To num
            Console.Write("ELEMENT {0} :: ", i)
            array(i) = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("                                        +++-------------------------+++")
        Console.WriteLine("                                        +++ NUMBERS STORED IN ARRAY +++")
        Console.WriteLine("                                        +++-------------------------+++")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            Console.WriteLine("ELEMENT {0} :: {1}", i, array(i) & vbNewLine)
        Next

        Console.ReadKey()

    End Sub

End Module
