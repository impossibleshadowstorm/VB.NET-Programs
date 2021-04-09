Module Module1

    Sub Main()
        Dim array As Integer() = New Integer(100) {}
        Dim num As Integer

        Console.WriteLine("                                         PROGRAM TO FIND MAXIMUM IN THE ARRAY ")
        Console.WriteLine("                                      **--------------------------------------** ")

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

        Dim max As Integer

        For i = 1 To num
            If max < array(i) Then
                max = array(i)
            End If
        Next


        Console.WriteLine("                                        +++--------------------------+++")
        Console.WriteLine("                                        +++ LARGEST NUMBERS IN ARRAY +++")
        Console.WriteLine("                                        +++--------------------------+++")
        Console.WriteLine("" & vbNewLine)

        Console.WriteLine("" & vbNewLine + "LARGEST NUMBER IN YOUR ARRAY IS:: {0}", max)

        Console.ReadKey()

    End Sub

End Module
