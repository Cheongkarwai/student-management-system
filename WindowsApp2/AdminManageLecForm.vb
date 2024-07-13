Public Class AdminManageLecForm
    Private Sub ManageLecForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(panelRegisterLec)
        roundCornerModule.roundCorner(panelLecList)
        roundCornerModule.roundCorner(panelLecTimetable)
    End Sub
End Class