Public Class verifyForm
    Private text As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
    Private Sub verifyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVerify.Text = generateString(text)
    End Sub
    Private Function generateString(text As String) As String
        Dim r1 As New Random()
        Dim result As String = ""
        For i = 0 To 8
            result &= text.Chars(r1.Next(0, text.Length - 1))
        Next
        Return result
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        lblVerify.Text = generateString(text)
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        errorVerify.SetIconPadding(txtVerify, 8)

        If (txtVerify.Text.Trim.Equals(lblVerify.Text)) Then
            setSuccessMsg(errorVerify, txtVerify, "Success")
            RegistrationForm.isVerified = True
            Me.Close()
        Else
                setErrorMsg(errorVerify, txtVerify, "Please try again")
            lblVerify.Text = generateString(text)
            txtVerify.Text = ""
        End If
    End Sub
    Private Sub setErrorMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_cancel.ico")
    End Sub

    Private Sub setSuccessMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_tick.ico")
    End Sub
End Class