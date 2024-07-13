
Imports MySql.Data.MySqlClient
Public Class AdminDashboardForm
    Private conn As New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadTable()

        Try
            conn.Open()
            Dim sql As String = "SELECT studentID,studentName,studentEmail,contactNo,programmeName,semester FROM Student s
                                JOIN Programme p
                                ON s.programmeID = p.programmeID"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvStud.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUpdateStud.Text = Date.Now().Year & "-" & Date.Now().Month & "-" & Date.Now().Day & "  " & Date.Now().Hour & ":" & Date.Now().Minute & ":" & Date.Now().Second
        lblUpdateLec.Text = Date.Now().Year & "-" & Date.Now().Month & "-" & Date.Now().Day & "  " & Date.Now().Hour & ":" & Date.Now().Minute & ":" & Date.Now().Second
        lblUpdateClass.Text = Date.Now().Year & "-" & Date.Now().Month & "-" & Date.Now().Day & "  " & Date.Now().Hour & ":" & Date.Now().Minute & ":" & Date.Now().Second

        progressStud.Value = 0
        progressClass.Value = 0
        progressLec.Value = 0

        timerProgStud1.Interval = 30
        timerProgStud1.Start()
        timerProgStud2.Interval = 1
        timerProgStud2.Start()
        timerLblStud.Start()

        timerProgLec1.Interval = 30
        timerProgLec1.Start()
        timerProgLec2.Interval = 1
        timerProgLec2.Start()
        timerLblLec.Start()

        timerProgClass1.Interval = 30
        timerProgClass1.Start()
        timerProgClass2.Interval = 1
        timerProgClass2.Start()

        timerLblClass.Start()


        roundCornerModule.roundCorner(panelLec)
        roundCornerModule.roundCorner(panelStud)
        roundCornerModule.roundCorner(panelClass)
        roundCornerModule.roundCorner(dgvStud)
        roundCornerModule.roundCorner(panelNewLec)
        roundCornerModule.roundCorner(panelNewApp)
        roundCornerModule.roundCorner(panelNewClass)

        lblNewApp.Text = retrieveNumApplicant().ToString()
        lblNewClass.Text = retrieveNumClass().ToString()
        lblNewLec.Text = retrieveNumLec().ToString()

        loadTable()
    End Sub

    Private Function retrieveNumApplicant() As Integer
        Dim n As Integer = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(applicationNo) AS NumOfApplicant FROM Application"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfApplicant"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        Return n

    End Function

    Private Function retrieveNumStud() As Integer
        Dim n As Integer = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(studentID) AS NumOfStud FROM Student"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfStud"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        Return n
    End Function

    Private Function retrieveNumStud(m As Double) As Double
        Dim n As Double = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(studentID) AS NumOfStud FROM Student"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfStud"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        n = (n / m) * 100

        Return n

    End Function

    Private Function retrieveNumClass() As Integer
        Dim n As Integer
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(courseID) AS NumOfCourse FROM Course"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfCourse"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        Return n
    End Function

    Private Function retrieveNumClass(m As Double) As Double
        Dim n As Double
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(courseID) AS NumOfCourse FROM Course"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfCourse"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        n = (n / m) * 100

        Return n

    End Function

    Private Function retrieveNumLec() As Integer
        Dim n As Integer
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(lecID) AS NumOfLec FROM Lecturer"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfLec"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        Return n
    End Function

    Private Function retrieveNumLec(m As Double) As Double
        Dim n As Double
        Try
            conn.Open()
            Dim sql As String = "SELECT COUNT(lecID) AS NumOfLec FROM Lecturer"
            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                n = n + Integer.Parse(dt.Rows(i).Item("NumOfLec"))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

        n = (n / m) * 100

        Return n

    End Function

    Private Sub timerProgStud1_Tick(sender As Object, e As EventArgs) Handles timerProgStud1.Tick

        If retrieveNumStud() > 0 Then
            Dim percentageStud As Decimal = Double.Parse(progressStud.Text)

            percentageStud += 0.1

            progressStud.Text = percentageStud.ToString()

            If percentageStud >= retrieveNumStud(1000) Then
                timerProgStud1.Stop()
            End If
        Else
            timerProgStud1.Stop()
        End If

    End Sub

    Private Sub timerProgStud2_Tick(sender As Object, e As EventArgs) Handles timerProgStud2.Tick

        If retrieveNumStud() > 0 Then
            progressStud.Value += 0.1

            If progressStud.Value >= retrieveNumStud(1000) Then
                timerProgStud2.Stop()
            End If
        Else
            timerProgStud2.Stop()
        End If
    End Sub

    Private Sub timerlblStud_Tick(sender As Object, e As EventArgs) Handles timerLblStud.Tick

        If retrieveNumStud() > 0 Then
            Dim temp As Decimal = Integer.Parse(lblStud.Text)
            temp += 1
            lblStud.Text = temp.ToString()

            If temp >= retrieveNumStud() Then
                timerLblStud.Stop()
            End If
        Else
            timerLblStud.Stop()
        End If
    End Sub

    Private Sub timerProgLec1_Tick(sender As Object, e As EventArgs) Handles timerProgLec1.Tick

        If retrieveNumLec() > 0 Then
            Dim percentageLec As Decimal = Double.Parse(progressLec.Text)

            percentageLec += 0.1

            progressLec.Text = percentageLec


            If percentageLec >= retrieveNumLec(1000) Then
                timerProgLec1.Stop()
            End If
        Else
            timerProgLec1.Stop()
        End If
    End Sub

    Private Sub timerProgLec2_Tick(sender As Object, e As EventArgs) Handles timerProgLec2.Tick

        If retrieveNumLec() > 0 Then
            progressLec.Value += 0.1

            If progressLec.Value >= retrieveNumLec(1000) Then
                timerProgLec2.Stop()
            End If
        Else
            timerProgLec2.Stop()
        End If
    End Sub

    Private Sub timerLblLec_Tick(sender As Object, e As EventArgs) Handles timerLblLec.Tick

        If retrieveNumLec() > 0 Then
            Dim temp As Decimal = Integer.Parse(lblLec.Text)

            temp += 1

            lblLec.Text = temp

            If temp >= retrieveNumLec() Then
                timerLblLec.Stop()
            End If
        Else
            timerLblLec.Stop()
        End If
    End Sub

    Private Sub timerProgClass1_Tick(sender As Object, e As EventArgs) Handles timerProgClass1.Tick

        If retrieveNumClass() > 0 Then
            Dim percentageClass As Decimal = Double.Parse(progressClass.Text)

            percentageClass += 0.1

            progressClass.Text = percentageClass

            If percentageClass >= retrieveNumClass(1000) Then
                timerProgClass1.Stop()
            End If
        Else
            timerProgClass1.Stop()
        End If
    End Sub

    Private Sub timerProgClass2_Tick(sender As Object, e As EventArgs) Handles timerProgClass2.Tick

        If retrieveNumClass() > 0 Then
            progressClass.Value += 0.1

            If progressClass.Value >= retrieveNumClass(1000) Then
                timerProgClass2.Stop()
            End If
        Else
            timerProgClass2.Stop()
        End If
    End Sub

    Private Sub timerLblClass_Tick(sender As Object, e As EventArgs) Handles timerLblClass.Tick

        If retrieveNumClass() > 0 Then
            Dim temp As Decimal = Integer.Parse(lblClass.Text)

            temp += 1

            lblClass.Text = temp

            If temp >= retrieveNumClass() Then
                timerLblClass.Stop()
            End If
        Else
            timerLblClass.Stop()
        End If
    End Sub
End Class
