Public Class Trabajos
    Private Sub Trabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Codigos' Puede moverla o quitarla según sea necesario.
        Me.CodigosTableAdapter.Fill(Me.BasededatosclientesDataSet.Codigos)
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        Me.TrabajosTableAdapter.FillBynotf(Me.BasededatosclientesDataSet.trabajos, "No")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (cc.Text = "") Then
            MsgBox("Ingrese un codigo a buscar", vbCritical, "Error")
        Else
            TrabajosTableAdapter.FillBycodf(Me.BasededatosclientesDataSet.trabajos, cc.Text, "No")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vertrabs.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nuevodiag.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fintrabajo.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pass As String
        Dim cor As Boolean

        If (cc.Text = "") Then
            MsgBox("introduzca un codigo en la casilla", vbCritical, "Error")
        Else
            cor = CodigosTableAdapter.FillBycod(Me.BasededatosclientesDataSet.Codigos, cc.Text)
            If cor Then
                pass = DataGridView2.CurrentCell.Value.ToString
                cres.Text = pass
            Else
                MsgBox("No se encontro ninguna contraseña u observacion en esta Pc", vbExclamation, "Aviso")
            End If

        End If
    End Sub
End Class