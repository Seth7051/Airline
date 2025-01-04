Public Class frmMainMenuAdminAttendant
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddAttendant As New frmAddAttendant
        frmAddAttendant.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frmDeleteAttendant As New frmDeleteAttendant
        frmDeleteAttendant.ShowDialog()
    End Sub

    Private Sub btnFlight_Click(sender As Object, e As EventArgs) Handles btnFlight.Click
        Dim frmAssignAtendant As New frmAssignAttendantToFlight
        frmAssignAtendant.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class