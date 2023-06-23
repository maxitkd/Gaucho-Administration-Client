Public Class verpcs
    Private Sub CodigosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CodigosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CodigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasededatosclientesDataSet)

    End Sub

    Private Sub verpcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Codigos' Puede moverla o quitarla según sea necesario.
        Me.CodigosTableAdapter.Fill(Me.BasededatosclientesDataSet.Codigos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CodigosTableAdapter.FillBycod(BasededatosclientesDataSet.Codigos, CodigoTextBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

End Class