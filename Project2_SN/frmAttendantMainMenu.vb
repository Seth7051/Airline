Public Class frmAttendantMainMenu
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frmUpdate As New frmUpdateAttendant

        frmUpdate.ShowDialog()
    End Sub

    Private Sub btnPast_Click(sender As Object, e As EventArgs) Handles btnPast.Click
        Dim frmPast As New frmPastFlightsAttendant

        frmPast.ShowDialog()
    End Sub

    Private Sub btnFuture_Click(sender As Object, e As EventArgs) Handles btnFuture.Click
        Dim frmFuture As New frmFutureFlightsAttendant

        frmFuture.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class