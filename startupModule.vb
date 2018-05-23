Imports System.IO

Module startupModule
    Public Function Main(ByVal Args() As String) As Integer
        Dim F As New startupform
        F.chosenfilepath = ""
        For Each Arg As String In Args
            If file.exists(Arg) Then F.chosenfilepath = Arg
        Next
        F.Show()
        Application.Run()
    End Function

End Module
