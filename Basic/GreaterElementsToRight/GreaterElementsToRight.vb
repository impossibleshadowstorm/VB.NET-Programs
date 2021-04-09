'
' 
' PROGRAM TO PRINT GREATER NUMBER IN ARRAY TO ITS RIGHT
' 
' INPUT:: 
'   16 17 4 3 5 2 
' 
' OUTPUT::
'   17 5 2
'
'


Module Module1

    Sub Main()

        Dim array As Integer() = New Integer(1001) {}

        Console.WriteLine("                        PROGRAM TO PRINT ELEMENTS IN ARRAY GREATER THAN TO ITS RIGHT")
        Console.WriteLine("                     **--------------------------------------------------------------**")

        Console.WriteLine("" & vbNewLine)

        Console.Write("ENTER THE NUMBER OF ELEMENTS YOU WANT TO INSERT IN ARRAY:: ")
        Dim num As Integer = CInt(Console.ReadLine())
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            Console.Write("ELEMENT [{0}]:: ", i)
            array(i) = CInt(Console.ReadLine())
            Console.WriteLine("" & vbNewLine)
        Next



        '
        ' METHOD 1
        '



        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("                                       +++ SOLUTION WITH METHOD 1 +++")
        Console.WriteLine("                                       +++------------------------+++")

        Console.WriteLine("" & vbNewLine)

        Console.Write("LIST OF NUMBERS IN ARRAY WHICH ARE GREATER THAN TO ITS RIGHT:: ")

        For i = 1 To num
            For j = i + 1 To num
                If array(i) < array(j) Then
                    Exit For
                End If

                If j = num Then
                    Console.Write(" {0}", array(i))
                End If
            Next

            If i = num Then
                Console.Write(" {0}", array(i))
            End If
        Next


        '
        ' METHOD 1
        '



        Console.WriteLine("" & vbNewLine & vbNewLine)

        Console.WriteLine("                                       +++ SOLUTION WITH METHOD 2 +++")
        Console.WriteLine("                                       +++------------------------+++")

        Console.WriteLine("" & vbNewLine)

        Console.Write("LIST OF NUMBERS IN ARRAY WHICH ARE GREATER THAN TO ITS RIGHT:: ")

        For i = 1 To num
            Dim count As Integer = 0
            For j = i + 1 To num
                If array(i) > array(j) Then
                    count += 1
                End If
            Next

            If count = num - i Then
                Console.Write(" {0}", array(i))
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
