Public Class AdminManageClassForm
    Private Sub ManageClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(panelRemoveClass)
        roundCornerModule.roundCorner(panelClassList)
        roundCornerModule.roundCorner(panelAddClass)
    End Sub
End Class