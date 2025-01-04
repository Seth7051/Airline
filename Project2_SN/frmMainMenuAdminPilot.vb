Public Class frmMainMenuAdminPilot
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddPilot As New frmAddPilot
        frmAddPilot.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frmDeletePilot As New frmDeletePilot
        frmDeletePilot.ShowDialog()
    End Sub

    Private Sub btnFlight_Click(sender As Object, e As EventArgs) Handles btnFlight.Click
        Dim frmaddPilotFlight As New frmAssignPilotToFlight
        frmaddPilotFlight.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class