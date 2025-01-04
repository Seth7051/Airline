Public Class frmPilotMainMenu
    Private Sub btnPast_Click(sender As Object, e As EventArgs) Handles btnPast.Click
        Dim frmPastFlightsPilot As New frmPastFlightsPilot

        frmPastFlightsPilot.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frmUpdatePilot As New frmUpdatePilot
        frmUpdatePilot.ShowDialog()
    End Sub

    Private Sub btnFuture_Click(sender As Object, e As EventArgs) Handles btnFuture.Click
        Dim frmFutureFlightsPilot As New frmFutureFlightsPilot

        frmFutureFlightsPilot.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class