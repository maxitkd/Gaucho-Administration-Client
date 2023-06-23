Public Class admjob
    Private Sub admjob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        Me.TrabajosTableAdapter.Fill(Me.BasededatosclientesDataSet.trabajos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class