Public Class frmAdminMainMenu
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub

    Private Sub btnPilots_Click(sender As Object, e As EventArgs) Handles btnPilots.Click
        Dim frmPilotAdmin As New frmMainMenuAdminPilot
        frmPilotAdmin.ShowDialog()
    End Sub

    Private Sub btnAttendants_Click(sender As Object, e As EventArgs) Handles btnAttendants.Click
        Dim frmAttendantAdmin As New frmMainMenuAdminAttendant
        frmAttendantAdmin.ShowDialog()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim frmStats As New frmStatistics
        frmStats.ShowDialog()
    End Sub
End Class