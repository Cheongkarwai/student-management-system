
Imports FontAwesome.Sharp
Public Class StudentDashboardForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCornerModule.roundCorner(pCourse)
        roundCornerModule.roundCorner(pGrade)
        roundCornerModule.roundCorner(pCocurriculum)
        roundCornerModule.roundCorner(pProfile)
        roundCornerModule.roundCorner(pCourse)

    End Sub

    Private Sub picCourse_Click(sender As Object, e As EventArgs) Handles picCourse.Click
        openCourse()
    End Sub

    Private Sub openCourse()
        StudentForm.openNewForm(New StudentCourseSelection())
        StudentForm.activateBtn(StudentForm.btnCourseSelection, Color.Yellow)
    End Sub

    Private Sub openCocurriculum()
        StudentForm.openNewForm(New StudentCocurriculum())
        StudentForm.activateBtn(StudentForm.BtnEvent, Color.LightGray)
    End Sub

    Private Sub txtCourse_Click(sender As Object, e As EventArgs) Handles txtCourse.Click
        openCourse()
    End Sub

    Private Sub openGrade()
        StudentForm.openNewForm(New StudentGradeReport())
        StudentForm.activateBtn(StudentForm.BtnGrade, Color.Violet)
    End Sub

    Private Sub openProfile()
        StudentForm.openNewForm(New StudentProfileForm())
        StudentForm.activateBtn(StudentForm.BtnProfile, Color.LightGreen)
    End Sub

    Private Sub picCocurriculum_Click(sender As Object, e As EventArgs) Handles picCocurriculum.Click
        openCocurriculum()

    End Sub

    Private Sub txtCocurriculum_Click(sender As Object, e As EventArgs) Handles txtCocurriculum.Click
        openCocurriculum()

    End Sub

    Private Sub picGrade_Click(sender As Object, e As EventArgs) Handles picGrade.Click
        openGrade()

    End Sub

    Private Sub txtGrade_Click(sender As Object, e As EventArgs) Handles txtGrade.Click
        openGrade()

    End Sub

    Private Sub picUser_Click(sender As Object, e As EventArgs) Handles picUser.Click
        openProfile()

    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        openProfile()

    End Sub

    Private Sub pCourse_Click(sender As Object, e As EventArgs) Handles pCourse.Click
        openCourse()
    End Sub

    Private Sub pCocurriculum_Click(sender As Object, e As EventArgs) Handles pCocurriculum.Click
        openCocurriculum()
    End Sub

    Private Sub pProfile_Click(sender As Object, e As EventArgs) Handles pProfile.Click
        openProfile()
    End Sub

    Private Sub pGrade_Click(sender As Object, e As EventArgs) Handles pGrade.Click
        openGrade()
    End Sub
End Class
