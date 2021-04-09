Module Module1

    Sub Main()

        Dim FacultySalarySum As ScienceFaculty = New ScienceFaculty()

        Console.WriteLine("" & vbNewLine & vbNewLine + "                                    PROGRAM TO SHOW DEMO OF SINGLE INHERITANCE USING FACULTY SALARY AND BONUS")
        Console.WriteLine("                                 **---------------------------------------------------------------------------** " & vbNewLine & vbNewLine)

        Console.WriteLine("NOTE:: NORMAL SALARY FOR ALL FACULTY IS 5K AND BONUSES ARE GIVEN ACCORDING TO DEPARTMENTS!!!" & vbNewLine & vbNewLine)

        Console.WriteLine("ACCESSING PARENT CLASS METHOD THROUGH CHILD CLASS OBJECT...")
        Console.WriteLine("EVERY FACULTY SALARY IS:: {0}", FacultySalarySum.EveryFacultySalary() & vbNewLine)

        Console.WriteLine("ACCESSING BOTH CLASS METHODS THROUGH CHILD CLASS OBJECT...")
        Console.WriteLine("EVERY FACULTY SALARY IS:: {0}", FacultySalarySum.EveryFacultySalary())
        Console.WriteLine("SCIENCE FACULTY BONUS IS:: {0}", FacultySalarySum.scienceFacultyBonus())
        Console.WriteLine("SO, THE TOTAL SALARY OF SCIENCE FACULTY ALONG WITH BONUS IS:: {0}", FacultySalarySum.EveryFacultySalary + FacultySalarySum.scienceFacultyBonus())

        Console.ReadKey()
    End Sub

    Public Class Faculty

        Public Function EveryFacultySalary() As Integer
            Dim salary As Integer = 5000

            Return salary
        End Function

    End Class

    Public Class ScienceFaculty : Inherits Faculty

        Public Function scienceFacultyBonus() As Integer
            Dim bonus As Integer = 20000

            Return bonus
        End Function

    End Class

End Module
