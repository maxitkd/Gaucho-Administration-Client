Public Class nuevocliente
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged



    End Sub

    Private Sub nuevocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg1, msg2, msg3, msg4 As String
        If (TextBox1.Text = "") Then
            msg1 = MsgBox("El campo nombre esta vacio", vbCritical, "Error")
        ElseIf (TextBox2.Text = "") Then
            msg2 = MsgBox("El campo apellido esta vacio", vbCritical, "Error")
        ElseIf (TextBox3.Text = "") Then
            msg3 = MsgBox("ingrese un telefono de contacto", vbCritical, "Error")
        Else
            nuevotrabajo.ClientesTableAdapter.INSERTAR(TextBox3.Text, TextBox2.Text, TextBox1.Text, TextBox4.Text, TextBox5.Text)
            Me.Close()
            msg4 = MsgBox("Cliente agregado", vbInformation, "Nuevo cliente")
            nuevotrabajo.Button1.PerformClick()

        End If
    End Sub
End Class