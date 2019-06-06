Imports System.IO
Imports System
Imports Microsoft.Win32

Public Class Form1

    Public Shared Function FileNameValido(ByVal nomefile As String) As String
        If nomefile Is Nothing Then
            Return "Vuoto"
        End If

        Dim i As Integer = 0
        Dim car As Char() = nomefile.ToCharArray()

        For i = 0 To nomefile.Length - 1
            For Each carNonAmmesso As Char In System.IO.Path.GetInvalidFileNameChars
                If car(i) = carNonAmmesso Then
                    car(i) = "_"
                End If
            Next
        Next
        Dim nomeCorretto As String = New String(car)
        Return nomeCorretto

    End Function

    Private Function NonValidato() As Boolean
        If tbTesto.Text = "" Then
            MessageBox.Show("Immettere un testo da codificare")
            tbTesto.Focus()
            Return True
        End If

        If Not (IsNumeric(udBarra.Text)) Then
            MessageBox.Show("Immettere un numero")
            udBarra.Focus()
            Return True
        End If

        If tbCartella.Text = "" Then
            MessageBox.Show("Immettere la cartella di export")
            tbTesto.Focus()
            Return True
        End If

        Return False
    End Function

    Private Sub CaricaPb()
        Try
            Dim myimg As System.Drawing.Image = Code128Rendering.MakeBarcodeImage(tbTesto.Text, Integer.Parse(udBarra.Text), cbZonaBianca.Checked)
            pbCodiceBarre.Image = myimg
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btCodifica_Click(sender As Object, e As EventArgs) Handles btCodifica.Click
        If NonValidato() Then
            Exit Sub
        End If
        CaricaPb()
        Dim OutputFile As String = Path.Combine(tbCartella.Text, FileNameValido(tbTesto.Text) & ".jpg")
        pbCodiceBarre.Image.Save(OutputFile, System.Drawing.Imaging.ImageFormat.Jpeg)
        MessageBox.Show("File registrato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btCreaPdf_Click(sender As Object, e As EventArgs) Handles btCreaPdf.Click
        If NonValidato() Then
            Exit Sub
        End If
        CaricaPb()
        Try
            Code128Rendering.MakeBarcodePDF(tbTesto.Text, Integer.Parse(udBarra.Text), cbZonaBianca.Checked, tbCartella.Text)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text)
        End Try

        MessageBox.Show("File registrato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btLista_Click(sender As Object, e As EventArgs) Handles btLista.Click
        Dim frm As New frmLista
        frm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbCartella.Text = My.Application.Info.DirectoryPath
        'Registry.CurrentUser.DeleteValue("Codice128Esecuzioni")
        'Registry.CurrentUser.DeleteValue("Codice128Registrato")

        Dim str As String = Registry.CurrentUser.GetValue("Codice128Esecuzioni")
        Dim reg As String = Registry.CurrentUser.GetValue("Codice128Registrato")
        Dim ese As Integer = 0
        Dim MAXese As Integer = 5

        If reg = Nothing Then
            'Non registrato
            If str = Nothing Or str = "" Then
                Registry.CurrentUser.SetValue("Codice128Esecuzioni", "1")
                lbRegistrato.Text = "Copia DEMO - Eseguito 1 volta"
            Else
                ese = Integer.Parse(str)
                ese = ese + 1
                Registry.CurrentUser.SetValue("Codice128Esecuzioni", ese.ToString)
                lbRegistrato.Text = "Copia DEMO - Eseguito " & ese.ToString & " volte su " & MAXese.ToString & " possibili"
                If ese >= MAXese Then
                    'MessageBox.Show("Acquistare il programma, informazioni all'email info@archistico.com", "DEMO FINITA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Se superato il numero di esecuzioni
                    Dim frm As New frmLicenza
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        btCompra.Visible = False
                        lbRegistrato.Text = "Copia attivata"
                    Else
                        Me.Close()
                    End If
                End If

            End If
        Else
            'Registrato
            btCompra.Visible = False
            lbRegistrato.Text = "Copia attivata"
        End If
    End Sub

    Private Sub btCartella_Click(sender As Object, e As EventArgs) Handles btCartella.Click
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            tbCartella.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btCompra_Click(sender As Object, e As EventArgs) Handles btCompra.Click
        Dim frm As New frmLicenza
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            btCompra.Visible = False
            lbRegistrato.Text = "Copia attivata"
        Else
            Me.Close()
        End If
    End Sub
End Class


