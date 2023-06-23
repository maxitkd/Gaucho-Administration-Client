Public Class G

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasededatosclientesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasededatosclientesDataSet.Clientes)

    End Sub


    Private Sub butclien_Click(sender As Object, e As EventArgs) Handles butc.Click
        nuevotrabajo.Show()

    End Sub

    Private Sub butmodif_Click(sender As Object, e As EventArgs) Handles bt.Click
        Trabajos.Show()
    End Sub

    Private Sub butsal_Click(sender As Object, e As EventArgs) Handles butsal.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        admclien.Show()
    End Sub
End Class
