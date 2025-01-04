Public Class frmUserType
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If radCustomer.Checked Then
            Dim frmCustomer As New frmCustomerSelection
            frmCustomer.ShowDialog()
        ElseIf radPilot.Checked Then
            Dim frmPilot As New frmPilotSelection
            frmPilotSelection.ShowDialog()
        ElseIf radAttendant.Checked Then
            Dim frmAttendant As New frmAttendantSelection
            frmAttendant.ShowDialog()
        ElseIf radAdministration.Checked Then
            Dim frmAdmin As New frmAdminMainMenu
            frmAdmin.ShowDialog()
        End If
    End Sub

    Private Sub frmUserType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
