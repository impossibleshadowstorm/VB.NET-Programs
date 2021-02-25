Module Module1

    Sub Main()

        Dim num, i, j As Integer

        Console.Write("ENTER A NUMBER:: ")
        num = CInt(Console.ReadLine())

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************HALF PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            For j = 1 To i
                Console.Write("* ")
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************HALF INVERTED PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = num To 1 Step -1
            For j = 1 To i
                Console.Write("* ")
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************Mirrored HALF PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            For j = num To i Step -1
                Console.Write("  ")
            Next
            For j = 1 To i
                Console.Write("* ")
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************Mirrored HALF INVERTED PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            For j = 1 To i
                Console.Write("  ")
            Next
            For j = num To i Step -1
                Console.Write("* ")
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************HALF HOLLOW PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            For j = 1 To i
                If j = 1 Or i = j Or i = num Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************HALF INVERTED HOLLOW PYRAMID STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num
            For j = num To i Step -1
                Console.Write("  ")
            Next
            For j = 1 To i
                If j = 1 Or i = j Or i = num Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************HALF DIAMOND STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        For i = 1 To num Step 1
            For j = num - 1 To i Step -1
                Console.Write("  ")
            Next
            For j = 1 To (2 * i) - 1 Step 1
                Console.Write("* ")
            Next
            Console.WriteLine("" & vbNewLine)
        Next

        'Alternate Method For Above Pattern
        'Console.WriteLine("" & vbNewLine)
        'Console.WriteLine("*************HALF DIAMOND STAR PATTERN*************")
        'Console.WriteLine("" & vbNewLine)

        'For i = 1 To num Step 1
        '    For j = i To num - 1 Step 1
        '        Console.Write("  ")
        '    Next
        '    For j = 1 To i
        '        Console.Write("* ")
        '    Next
        '    For j = 2 To i
        '        Console.Write("* ")
        '    Next
        '    Console.WriteLine("" & vbNewLine)
        'Next

        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("*************FULL DIAMOND STAR PATTERN*************")
        Console.WriteLine("" & vbNewLine)

        Dim odd As Integer = 1
        For i = 1 To num Step 1
            For j = i To num - 1 Step 1
                Console.Write("  ")
            Next
            For j = 1 To odd Step 1
                Console.Write("* ")
            Next
            odd += 2
            Console.WriteLine("" & vbNewLine)
        Next
        odd -= 4
        For i = 1 To num - 1 Step 1
            For j = 1 To i
                Console.Write("  ")
            Next
            For j = 1 To odd Step 1
                Console.Write("* ")
            Next
            odd -= 2
            Console.WriteLine("" & vbNewLine)
        Next

        Console.ReadLine()
    End Sub

End Module
