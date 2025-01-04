Public Class frmCustomerMainMenu

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim frmAddFlight As New frmAddFlight

        frmAddFlight.ShowDialog()

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frmUpdate As New frmUpdateCustomer

        frmUpdate.ShowDialog()
    End Sub


    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim frmPastFlights As New frmPastFlightsCustomer

        frmPastFlights.ShowDialog()
    End Sub


    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        Dim frmFutureFlights As New frmFutureFlightsCustomer

        frmFutureFlights.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class