Public Class fintrabajo
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles cmm.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verifid As Boolean

        If (cs.Text = "") Then
            MsgBox("Ingrese la solucion (que es lo que debe hacerse o se hizo)", vbCritical, "Error")
        ElseIf (cmr.Text = "") Then
            MsgBox("Ingrese monto de repuestos sin signos ni letras. Ej: 23.59", vbCritical, "Error")
        ElseIf (cmm.Text = "") Then
            MsgBox("Ingrese monto de mano de obra sin signos ni letras. Ej: 23.59", vbCritical, "Error")
        ElseIf (casr.Text = "") Then
            MsgBox("Ingrese Nº de remito", vbCritical, "Error")
        ElseIf (Not IsNumeric(cverif.text)) Then
            MsgBox("El codigo de trabajo es incorrecto, ingrese un codigo de trabajo y presione 'buscar'", vbCritical, "Error")
        ElseIf (Not IsNumeric(cmr.Text)) Then
            MsgBox("Ingrese monto de repuestos sin signos ni letras. Ej: 23.59", vbCritical, "Error")
        ElseIf (Not IsNumeric(cmm.Text)) Then
            MsgBox("Ingrese monto mano de obra sin signos ni letras. Ej: 23.59", vbCritical, "Error")


        Else
            verifid = Trabajos.TrabajosTableAdapter.FillByrealiz(Trabajos.BasededatosclientesDataSet.trabajos, cverif.Text, "No")
            If (verifid) Then
                Trabajos.TrabajosTableAdapter.MODIFICARfinal(cs.Text, cr.Text, cmr.Text, cmm.Text, cmt.Text, cob.Text, casr.Text, cverif.Text)
                Close()
                Trabajos.TrabajosTableAdapter.FillBynotf(Trabajos.BasededatosclientesDataSet.trabajos, "No")
            Else
                MsgBox("Este trabajo se encuentra finalizado, contacte con el administrador para modificarlo", vbCritical, "Error")
            End If
        End If
    End Sub

    Private Sub fintrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        Trabajos.TrabajosTableAdapter.FillBynotf(Trabajos.BasededatosclientesDataSet.trabajos, "No")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codN As Integer
        Dim verif As Boolean



        If (IsNumeric(ccod.Text)) Then
            codN = ccod.Text
            verif = TrabajosTableAdapter.FillByrealiz(BasededatosclientesDataSet.trabajos, codN, "No")

            If (verif) Then
                cverif.Text = codN
            Else
                MsgBox("Introducir un codigo de trabajo valido", vbCritical, "Error")
            End If

        Else
            MsgBox("por favor introduzca un codigo de trabajo valido", vbCritical, "Error")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim montoa, montob, result As Decimal


        If (IsNumeric(cmr.Text)) Then
            If (IsNumeric(cmm.Text)) Then
                montoa = cmr.Text
                montob = cmm.Text
                result = montoa + montob
                cmt.Text = result
            Else
                MsgBox("Agregar numeros a las casillas de montos (las letras no se pueden sumar)", vbCritical, "Error")
            End If
        Else
            MsgBox("Agregar numeros a las casillas de montos (las letras no se pueden sumar)", vbCritical, "Error")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class