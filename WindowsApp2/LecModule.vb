Module LecModule
    Public Function expandDropDown(panel As Panel, time As Timer, control As Boolean) As Boolean
        panel.Height += 5
        If panel.Height >= panel.MaximumSize.Height Then
            time.Stop()
            control = False
        End If
        Return control
    End Function
    Public Function collapseDropDown(panel As Panel, time As Timer, control As Boolean) As Boolean
        panel.Height -= 5
        If panel.Height <= panel.MinimumSize.Height Then
            time.Stop()
            control = True
        End If
        Return control
    End Function
End Module
