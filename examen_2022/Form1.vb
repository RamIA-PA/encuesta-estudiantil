Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    'variable para limitar (limitador)'
    Dim iInput As Integer

    Private Sub txtp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtp.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limitador'
        iInput = InputBox("Introduzca la cantidad de estudiantes", "Lista de estudiantes", 1)

        'TODO: esta línea de código carga datos en la tabla 'SEMESTRAL_2022DataSet.encuesta' Puede moverla o quitarla según sea necesario.
        Me.EncuestaTableAdapter.Fill(Me.SEMESTRAL_2022DataSet.encuesta)

    End Sub
    Dim limite = 0

    Private Sub BEE_Click(sender As Object, e As EventArgs) Handles BEE.Click

        Try
            limite += 1

            If limite = iInput Then
                BEE.Enabled = False
            End If

            Me.EncuestaTableAdapter.Insert(txtp.Text, txtn.Text, txta.Text, txt1.Text, txt2.Text,
                                           txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text,
                                           txt8.Text, txt9.Text, txt10.Text, txt11.Text, txt12.Text,
                                           txt13.Text, txt14.Text, txt15.Text, txt16.Text, txt17.Text,
                                           txt18.Text, txt19.Text, txt20.Text, promedio.Text, obser.Text)

            txtp.Text = ""
            txtn.Text = ""
            txta.Text = ""
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txt4.Text = ""
            txt5.Text = ""
            txt6.Text = ""
            txt7.Text = ""
            txt8.Text = ""
            txt9.Text = ""
            txt10.Text = ""
            txt11.Text = ""
            txt12.Text = ""
            txt13.Text = ""
            txt14.Text = ""
            txt15.Text = ""
            txt16.Text = ""
            txt17.Text = ""
            txt18.Text = ""
            txt19.Text = ""
            txt20.Text = ""
            promedio.Text = ""


        Catch ex As Exception

            MsgBox("responda o rellene todas las casillas")

        End Try
    End Sub

    Private Sub txt1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt20.SelectedIndexChanged, txt19.SelectedIndexChanged, txt18.SelectedIndexChanged, txt17.SelectedIndexChanged, txt16.SelectedIndexChanged, txt15.SelectedIndexChanged, txt14.SelectedIndexChanged, txt13.SelectedIndexChanged, txt12.SelectedIndexChanged, txt11.SelectedIndexChanged, txt10.SelectedIndexChanged, txt9.SelectedIndexChanged, txt8.SelectedIndexChanged, txt7.SelectedIndexChanged, txt6.SelectedIndexChanged, txt5.SelectedIndexChanged, txt4.SelectedIndexChanged, txt3.SelectedIndexChanged, txt2.SelectedIndexChanged, txt1.SelectedIndexChanged
        Try
            'variables'
            Dim pregunta1 As Integer
            Dim pregunta2 As Integer
            Dim pregunta3 As Integer
            Dim pregunta4 As Integer
            Dim pregunta5 As Integer
            Dim pregunta6 As Integer
            Dim pregunta7 As Integer
            Dim pregunta8 As Integer
            Dim pregunta9 As Integer
            Dim pregunta10 As Integer
            Dim pregunta11 As Integer
            Dim pregunta12 As Integer
            Dim pregunta13 As Integer
            Dim pregunta14 As Integer
            Dim pregunta15 As Integer
            Dim pregunta16 As Integer
            Dim pregunta17 As Integer
            Dim pregunta18 As Integer
            Dim pregunta19 As Integer
            Dim pregunta20 As Integer
            Dim promediof As Double


            'puntos de primera nota'

            If txt1.Text = "" Then
                pregunta1 = 0

            ElseIf txt1.Text = 1 Then
                pregunta1 = 4

            ElseIf txt1.Text = 2 Then
                pregunta1 = 3

            ElseIf txt1.Text = 3 Then
                pregunta1 = 2

            ElseIf txt1.Text = "" Then
                pregunta1 = 0

            Else
                pregunta1 = 1

            End If



            'puntos de segunda nota'

            If txt2.Text = "" Then
                pregunta2 = 0

            ElseIf txt2.Text = 1 Then
                pregunta2 = 4


            ElseIf txt2.Text = 2 Then
                pregunta2 = 3


            ElseIf txt2.Text = 3 Then
                pregunta2 = 2


            Else
                pregunta2 = 1

            End If

            'puntos de tercera nota'


            If txt3.Text = "" Then
                pregunta3 = 0

            ElseIf txt3.Text = 1 Then
                pregunta3 = 1


            ElseIf txt3.Text = 2 Then
                pregunta3 = 2


            ElseIf txt3.Text = 3 Then
                pregunta3 = 3


            Else
                pregunta3 = 4

            End If

            'puntos de cuarta nota'

            If txt4.Text = "" Then
                pregunta4 = 0

            ElseIf txt4.Text = 1 Then
                pregunta4 = 1


            ElseIf txt4.Text = 2 Then
                pregunta4 = 2


            ElseIf txt4.Text = 3 Then
                pregunta4 = 3


            Else
                pregunta4 = 4

            End If

            'puntos de quinta nota'


            If txt5.Text = "" Then
                pregunta5 = 0

            ElseIf txt5.Text = 1 Then
                pregunta5 = 4


            ElseIf txt5.Text = 2 Then
                pregunta5 = 3


            ElseIf txt5.Text = 3 Then
                pregunta5 = 2


            Else
                pregunta5 = 1

            End If

            'puntos de sexta nota'

            If txt6.Text = "" Then
                pregunta6 = 0

            ElseIf txt6.Text = 1 Then
                pregunta6 = 4


            ElseIf txt6.Text = 2 Then
                pregunta6 = 3


            ElseIf txt6.Text = 3 Then
                pregunta6 = 2


            Else
                pregunta6 = 1

            End If

            'puntos de ceptima nota'


            If txt7.Text = "" Then
                pregunta7 = 0

            ElseIf txt7.Text = 1 Then
                pregunta7 = 4


            ElseIf txt7.Text = 2 Then
                pregunta7 = 3


            ElseIf txt7.Text = 3 Then
                pregunta7 = 2


            Else
                pregunta7 = 1

            End If

            'puntos de octava nota'

            If txt8.Text = "" Then
                pregunta8 = 0

            ElseIf txt8.Text = 1 Then
                pregunta8 = 1


            ElseIf txt8.Text = 2 Then
                pregunta8 = 2


            ElseIf txt8.Text = 3 Then
                pregunta8 = 3


            Else
                pregunta8 = 4

            End If

            'puntos de 9 nota'

            If txt9.Text = "" Then
                pregunta9 = 0

            ElseIf txt9.Text = 1 Then
                pregunta9 = 4


            ElseIf txt9.Text = 2 Then
                pregunta9 = 3


            ElseIf txt9.Text = 3 Then
                pregunta9 = 2


            Else
                pregunta9 = 1

            End If

            'puntos de 10 nota'

            If txt10.Text = "" Then
                pregunta10 = 0

            ElseIf txt10.Text = 1 Then
                pregunta10 = 4


            ElseIf txt10.Text = 2 Then
                pregunta10 = 3


            ElseIf txt10.Text = 3 Then
                pregunta10 = 2


            Else
                pregunta10 = 1

            End If

            'puntos de 11 nota'

            If txt11.Text = "" Then
                pregunta11 = 0

            ElseIf txt11.Text = 1 Then
                pregunta11 = 4


            ElseIf txt11.Text = 2 Then
                pregunta11 = 3


            ElseIf txt11.Text = 3 Then
                pregunta11 = 2


            Else
                pregunta11 = 1

            End If

            'puntos de 12 nota'

            If txt12.Text = "" Then
                pregunta12 = 0

            ElseIf txt12.Text = 1 Then
                pregunta12 = 4


            ElseIf txt12.Text = 2 Then
                pregunta12 = 3


            ElseIf txt12.Text = 3 Then
                pregunta12 = 2


            Else
                pregunta12 = 1

            End If

            'puntos de 13 nota'

            If txt13.Text = "" Then
                pregunta13 = 0

            ElseIf txt13.Text = 1 Then
                pregunta13 = 4


            ElseIf txt13.Text = 2 Then
                pregunta13 = 3


            ElseIf txt13.Text = 3 Then
                pregunta13 = 2


            Else
                pregunta13 = 1

            End If

            'puntos de 14 nota'


            If txt14.Text = "" Then
                pregunta14 = 0

            ElseIf txt14.Text = 1 Then
                pregunta14 = 4


            ElseIf txt14.Text = 2 Then
                pregunta14 = 3


            ElseIf txt14.Text = 3 Then
                pregunta14 = 2


            Else
                pregunta14 = 1

            End If

            'puntos de 15 nota'

            If txt15.Text = "" Then
                pregunta15 = 0

            ElseIf txt15.Text = 1 Then
                pregunta15 = 4


            ElseIf txt15.Text = 2 Then
                pregunta15 = 3


            ElseIf txt15.Text = 3 Then
                pregunta15 = 2


            Else
                pregunta15 = 1

            End If

            'puntos de 16 nota'

            If txt16.Text = "" Then
                pregunta16 = 0

            ElseIf txt16.Text = 1 Then
                pregunta16 = 4


            ElseIf txt16.Text = 2 Then
                pregunta16 = 3


            ElseIf txt16.Text = 3 Then
                pregunta16 = 2


            Else
                pregunta16 = 1

            End If

            'puntos de 17 nota'

            If txt17.Text = "" Then
                pregunta17 = 0

            ElseIf txt17.Text = 1 Then
                pregunta17 = 4


            ElseIf txt17.Text = 2 Then
                pregunta17 = 3


            ElseIf txt17.Text = 3 Then
                pregunta17 = 2


            Else
                pregunta17 = 1

            End If

            'puntos de 18 nota'

            If txt18.Text = "" Then
                pregunta18 = 0

            ElseIf txt18.Text = 1 Then
                pregunta18 = 4


            ElseIf txt18.Text = 2 Then
                pregunta18 = 3


            ElseIf txt18.Text = 3 Then
                pregunta18 = 2


            Else
                pregunta18 = 1

            End If

            'puntos de 19 nota'

            If txt19.Text = "" Then
                pregunta19 = 0

            ElseIf txt19.Text = 1 Then
                pregunta19 = 4


            ElseIf txt19.Text = 2 Then
                pregunta19 = 3


            ElseIf txt19.Text = 3 Then
                pregunta19 = 2


            Else
                pregunta19 = 1

            End If

            'puntos de 20 nota'

            If txt20.Text = "" Then
                pregunta20 = 0

            ElseIf txt20.Text = 1 Then
                pregunta20 = 4


            ElseIf txt20.Text = 2 Then
                pregunta20 = 3


            ElseIf txt20.Text = 3 Then
                pregunta20 = 2


            Else
                pregunta20 = 1

            End If

            If (txt1.Text = "") And (txt2.Text = "") And (txt3.Text = "") And (txt4.Text = "") And (txt5.Text = "") And (txt6.Text = "") And (txt7.Text = "") And (txt8.Text = "") And (txt9.Text = "") And (txt10.Text = "") And (txt11.Text = "") And (txt12.Text = "") And (txt13.Text = "") And (txt14.Text = "") And (txt15.Text = "") And (txt16.Text = "") And (txt17.Text = "") And (txt18.Text = "") And (txt19.Text = "") And (txt20.Text = "") Then
                MsgBox("rellene todas las casillas porfa")
            Else


                promediof = (pregunta1 + pregunta2 + pregunta3 + pregunta4 + pregunta5 + pregunta6 + pregunta7 + pregunta8 + pregunta9 + pregunta10 + pregunta11 + pregunta12 + pregunta13 + pregunta14 + pregunta15 + pregunta16 + pregunta17 + pregunta18 + pregunta19 + pregunta20)
                promedio.Text = promediof
            End If



        Catch ex As Exception

            MsgBox("responda o rellene todas las casillas")

        End Try



    End Sub

    Private Sub txt3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt3.SelectedIndexChanged

    End Sub

    Private Sub promedio_TextChanged(sender As Object, e As EventArgs) Handles promedio.TextChanged

    End Sub

    Private Sub txtprome_TextChanged(sender As Object, e As EventArgs) Handles txtprome.TextChanged

    End Sub

    Private Sub BGP_Click(sender As Object, e As EventArgs) Handles BGP.Click

        txtprome.Text = Me.EncuestaTableAdapter.promediog()
        Dim letra As String


        If txtprome.Text <= 60 Then
            letra = "F"
        End If

        If txtprome.Text >= 61 And txtprome.Text < 71 Then
            letra = "D"
        End If

        If txtprome.Text >= 71 And txtprome.Text < 81 Then
            letra = "C"
        End If

        If txtprome.Text >= 81 And txtprome.Text < 91 Then
            letra = "B"
        End If

        If txtprome.Text >= 91 Then
            letra = "A"
        End If

        letrav.Text = letra

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub
End Class
