Imports System.IO

Public Class frmLista

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbLista.Text = "Prima riga" & vbCrLf & "Seconda riga" & vbCrLf & "Terza riga"
    End Sub

    Private Sub btConverti_Click(sender As Object, e As EventArgs) Handles btConverti.Click
        Dim numLinee As Integer = tbLista.Lines.Length

        If numLinee = 0 Then
            MessageBox.Show("Scrivere il testo da codificare", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim i As Integer = 0
        For i = 0 To numLinee - 1
            Try
                Code128Rendering.MakeBarcodePDF(tbLista.Lines(i), Integer.Parse(Form1.udBarra.Text), Form1.cbZonaBianca.Checked, Form1.tbCartella.Text)
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, Me.Text)
            End Try
        Next

        MessageBox.Show("File registrato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class