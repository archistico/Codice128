Imports Microsoft.Win32

Public Class frmLicenza

    Private Sub btAttiva_Click(sender As Object, e As EventArgs) Handles btAttiva.Click
        If tbCodiceAttivazione.Text = "" Then
            Dim str As String = Registry.CurrentUser.GetValue("Codice128Registrato")

            If str = Nothing Or str = "" Then
                Registry.CurrentUser.SetValue("Codice128Registrato", "1")
                MessageBox.Show("Attivazione effettuata", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Copia già registrata", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            End If
        Else
            MessageBox.Show("Codice di attivazione non valido", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.No
        End If
    End Sub
End Class