Imports System.Drawing
Imports System.Diagnostics
Imports System.IO
Imports System
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public NotInheritable Class Code128Rendering
    Private Sub New()
    End Sub

#Region "Code patterns"

    Private Shared ReadOnly cPatterns As Integer(,) = {{2, 1, 2, 2, 2, 2, _
        0, 0}, {2, 2, 2, 1, 2, 2, _
        0, 0}, {2, 2, 2, 2, 2, 1, _
        0, 0}, {1, 2, 1, 2, 2, 3, _
        0, 0}, {1, 2, 1, 3, 2, 2, _
        0, 0}, {1, 3, 1, 2, 2, 2, _
        0, 0}, _
        {1, 2, 2, 2, 1, 3, _
        0, 0}, {1, 2, 2, 3, 1, 2, _
        0, 0}, {1, 3, 2, 2, 1, 2, _
        0, 0}, {2, 2, 1, 2, 1, 3, _
        0, 0}, {2, 2, 1, 3, 1, 2, _
        0, 0}, {2, 3, 1, 2, 1, 2, _
        0, 0}, _
        {1, 1, 2, 2, 3, 2, _
        0, 0}, {1, 2, 2, 1, 3, 2, _
        0, 0}, {1, 2, 2, 2, 3, 1, _
        0, 0}, {1, 1, 3, 2, 2, 2, _
        0, 0}, {1, 2, 3, 1, 2, 2, _
        0, 0}, {1, 2, 3, 2, 2, 1, _
        0, 0}, _
        {2, 2, 3, 2, 1, 1, _
        0, 0}, {2, 2, 1, 1, 3, 2, _
        0, 0}, {2, 2, 1, 2, 3, 1, _
        0, 0}, {2, 1, 3, 2, 1, 2, _
        0, 0}, {2, 2, 3, 1, 1, 2, _
        0, 0}, {3, 1, 2, 1, 3, 1, _
        0, 0}, _
        {3, 1, 1, 2, 2, 2, _
        0, 0}, {3, 2, 1, 1, 2, 2, _
        0, 0}, {3, 2, 1, 2, 2, 1, _
        0, 0}, {3, 1, 2, 2, 1, 2, _
        0, 0}, {3, 2, 2, 1, 1, 2, _
        0, 0}, {3, 2, 2, 2, 1, 1, _
        0, 0}, _
        {2, 1, 2, 1, 2, 3, _
        0, 0}, {2, 1, 2, 3, 2, 1, _
        0, 0}, {2, 3, 2, 1, 2, 1, _
        0, 0}, {1, 1, 1, 3, 2, 3, _
        0, 0}, {1, 3, 1, 1, 2, 3, _
        0, 0}, {1, 3, 1, 3, 2, 1, _
        0, 0}, _
        {1, 1, 2, 3, 1, 3, _
        0, 0}, {1, 3, 2, 1, 1, 3, _
        0, 0}, {1, 3, 2, 3, 1, 1, _
        0, 0}, {2, 1, 1, 3, 1, 3, _
        0, 0}, {2, 3, 1, 1, 1, 3, _
        0, 0}, {2, 3, 1, 3, 1, 1, _
        0, 0}, _
        {1, 1, 2, 1, 3, 3, _
        0, 0}, {1, 1, 2, 3, 3, 1, _
        0, 0}, {1, 3, 2, 1, 3, 1, _
        0, 0}, {1, 1, 3, 1, 2, 3, _
        0, 0}, {1, 1, 3, 3, 2, 1, _
        0, 0}, {1, 3, 3, 1, 2, 1, _
        0, 0}, _
        {3, 1, 3, 1, 2, 1, _
        0, 0}, {2, 1, 1, 3, 3, 1, _
        0, 0}, {2, 3, 1, 1, 3, 1, _
        0, 0}, {2, 1, 3, 1, 1, 3, _
        0, 0}, {2, 1, 3, 3, 1, 1, _
        0, 0}, {2, 1, 3, 1, 3, 1, _
        0, 0}, _
        {3, 1, 1, 1, 2, 3, _
        0, 0}, {3, 1, 1, 3, 2, 1, _
        0, 0}, {3, 3, 1, 1, 2, 1, _
        0, 0}, {3, 1, 2, 1, 1, 3, _
        0, 0}, {3, 1, 2, 3, 1, 1, _
        0, 0}, {3, 3, 2, 1, 1, 1, _
        0, 0}, _
        {3, 1, 4, 1, 1, 1, _
        0, 0}, {2, 2, 1, 4, 1, 1, _
        0, 0}, {4, 3, 1, 1, 1, 1, _
        0, 0}, {1, 1, 1, 2, 2, 4, _
        0, 0}, {1, 1, 1, 4, 2, 2, _
        0, 0}, {1, 2, 1, 1, 2, 4, _
        0, 0}, _
        {1, 2, 1, 4, 2, 1, _
        0, 0}, {1, 4, 1, 1, 2, 2, _
        0, 0}, {1, 4, 1, 2, 2, 1, _
        0, 0}, {1, 1, 2, 2, 1, 4, _
        0, 0}, {1, 1, 2, 4, 1, 2, _
        0, 0}, {1, 2, 2, 1, 1, 4, _
        0, 0}, _
        {1, 2, 2, 4, 1, 1, _
        0, 0}, {1, 4, 2, 1, 1, 2, _
        0, 0}, {1, 4, 2, 2, 1, 1, _
        0, 0}, {2, 4, 1, 2, 1, 1, _
        0, 0}, {2, 2, 1, 1, 1, 4, _
        0, 0}, {4, 1, 3, 1, 1, 1, _
        0, 0}, _
        {2, 4, 1, 1, 1, 2, _
        0, 0}, {1, 3, 4, 1, 1, 1, _
        0, 0}, {1, 1, 1, 2, 4, 2, _
        0, 0}, {1, 2, 1, 1, 4, 2, _
        0, 0}, {1, 2, 1, 2, 4, 1, _
        0, 0}, {1, 1, 4, 2, 1, 2, _
        0, 0}, _
        {1, 2, 4, 1, 1, 2, _
        0, 0}, {1, 2, 4, 2, 1, 1, _
        0, 0}, {4, 1, 1, 2, 1, 2, _
        0, 0}, {4, 2, 1, 1, 1, 2, _
        0, 0}, {4, 2, 1, 2, 1, 1, _
        0, 0}, {2, 1, 2, 1, 4, 1, _
        0, 0}, _
        {2, 1, 4, 1, 2, 1, _
        0, 0}, {4, 1, 2, 1, 2, 1, _
        0, 0}, {1, 1, 1, 1, 4, 3, _
        0, 0}, {1, 1, 1, 3, 4, 1, _
        0, 0}, {1, 3, 1, 1, 4, 1, _
        0, 0}, {1, 1, 4, 1, 1, 3, _
        0, 0}, _
        {1, 1, 4, 3, 1, 1, _
        0, 0}, {4, 1, 1, 1, 1, 3, _
        0, 0}, {4, 1, 1, 3, 1, 1, _
        0, 0}, {1, 1, 3, 1, 4, 1, _
        0, 0}, {1, 1, 4, 1, 3, 1, _
        0, 0}, {3, 1, 1, 1, 4, 1, _
        0, 0}, _
        {4, 1, 1, 1, 3, 1, _
        0, 0}, {2, 1, 1, 4, 1, 2, _
        0, 0}, {2, 1, 1, 2, 1, 4, _
        0, 0}, {2, 1, 1, 2, 3, 2, _
        0, 0}, {2, 3, 3, 1, 1, 1, _
        2, 0}}

#End Region

    Private Const cQuietWidth As Integer = 10

    Public Shared Function MakeBarcodeImage(InputData As String, BarWeight As Integer, AddQuietZone As Boolean) As System.Drawing.Image
        ' get the Code128 codes to represent the message
        Dim content As New Codice128Contenuto(InputData)
        Dim codes As Integer() = content.Codes

        Dim width As Integer, height As Integer
        width = ((codes.Length - 3) * 11 + 35) * BarWeight
        height = Convert.ToInt32(System.Math.Ceiling(Convert.ToSingle(width) * 0.15F))

        If AddQuietZone Then
            ' on both sides
            width += 2 * cQuietWidth * BarWeight
        End If

        ' get surface to draw on
        Dim myimg As System.Drawing.Image = New System.Drawing.Bitmap(width, height)
        Using gr As Graphics = Graphics.FromImage(myimg)

            ' set to white so we don't have to fill the spaces with white
            gr.FillRectangle(System.Drawing.Brushes.White, 0, 0, width, height)

            ' skip quiet zone
            Dim cursor As Integer = If(AddQuietZone, cQuietWidth * BarWeight, 0)

            For codeidx As Integer = 0 To codes.Length - 1
                Dim code As Integer = codes(codeidx)
                'Debug.Print("code : " + code.ToString())

                ' take the bars two at a time: a black and a white
                For bar As Integer = 0 To 7 Step 2
                    Dim barwidth As Integer = cPatterns(code, bar) * BarWeight
                    Dim spcwidth As Integer = cPatterns(code, bar + 1) * BarWeight

                    ' if width is zero, don't try to draw it
                    If barwidth > 0 Then
                        gr.FillRectangle(System.Drawing.Brushes.Black, cursor, 0, barwidth, height)
                    End If

                    ' note that we never need to draw the space, since we 
                    ' initialized the graphics to all white

                    ' advance cursor beyond this pair
                    cursor += (barwidth + spcwidth)
                Next
            Next
        End Using

        Return myimg

    End Function

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

    Public Shared Sub MakeBarcodePDF(InputData As String, BarWeight As Integer, AddQuietZone As Boolean, directory As String)
        'Dim dpiDEF As Double = 72 / 25.4
        Dim dpiDEF As Double = 1
        Dim dpi As Double = 300 / 25.4
        Dim rapportoDpi As Double = dpi / dpiDEF

        ' get the Code128 codes to represent the message
        Dim content As New Codice128Contenuto(InputData)
        Dim codes As Integer() = content.Codes

        Dim width As Integer, height As Integer
        width = ((codes.Length - 3) * 11 + 35) * BarWeight
        height = Convert.ToInt32(System.Math.Ceiling(Convert.ToSingle(width) * 0.15F))

        If AddQuietZone Then
            ' on both sides
            width += 2 * cQuietWidth * BarWeight
        End If
        'Verifica che il testo possa essere il nome del file


        Dim pageSize As iTextSharp.text.Rectangle = New iTextSharp.text.Rectangle(width * dpiDEF, height * dpiDEF)
        Dim OutputFile As String = Path.Combine(directory, FileNameValido(InputData) & ".pdf")


        Using FS As New FileStream(OutputFile, FileMode.Create, FileAccess.Write, FileShare.None)
            Using Doc As New Document(pageSize)
                Using writer = PdfWriter.GetInstance(Doc, FS)
                    ''//Open the PDF for writing
                    Doc.Open()
                    Doc.AddAuthor("Archistico di Emilie Rollandin")
                    Doc.AddCreator("BARCODE128 - Archistico di Emilie Rollandin")
                    Doc.AddKeywords("PDF, Codice a barre, CODE128")
                    Doc.AddSubject(InputData)
                    Doc.AddTitle(InputData)

                    Dim cb As PdfContentByte = writer.DirectContent

                    ''//Save the current state so that we can restore it later. This is not required but it makes it easier to undo things later
                    cb.SaveState()

                    '----------------FACCIAMO A 72 dpi-----------------
                    'Setto spessore e colore
                    cb.SetCMYKColorStroke(0, 0, 0, 0)
                    cb.SetCMYKColorFill(0, 0, 0, 0)
                    cb.SetLineWidth(1.0F)
                    'Zona Bianca nel fondo
                    cb.Rectangle(0 * dpiDEF, 0 * dpiDEF, width * dpiDEF, height * dpiDEF)
                    cb.Fill()

                    'Setto spessore e colore
                    cb.SetCMYKColorStroke(255, 255, 255, 255)
                    cb.SetCMYKColorFill(255, 255, 255, 255)
                    cb.SetLineWidth(1.0F)

                    Dim cursor As Integer = If(AddQuietZone, cQuietWidth * BarWeight, 0)

                    For codeidx As Integer = 0 To codes.Length - 1
                        Dim code As Integer = codes(codeidx)

                        ' take the bars two at a time: a black and a white
                        For bar As Integer = 0 To 7 Step 2
                            Dim barwidth As Integer = cPatterns(code, bar) * BarWeight
                            Dim spcwidth As Integer = cPatterns(code, bar + 1) * BarWeight

                            ' if width is zero, don't try to draw it
                            If barwidth > 0 Then
                                cb.Rectangle(cursor * dpiDEF, 0 * dpiDEF, barwidth * dpiDEF, height * dpiDEF)
                                cb.Fill()
                            End If

                            ' note that we never need to draw the space, since we 
                            ' initialized the graphics to all white

                            ' advance cursor beyond this pair
                            cursor += (barwidth + spcwidth)
                        Next
                    Next
                    cb.RestoreState()
                    Doc.Close()
                End Using
            End Using
        End Using
    End Sub

End Class

