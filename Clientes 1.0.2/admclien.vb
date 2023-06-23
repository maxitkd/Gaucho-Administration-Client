Public Class admclien
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub admclien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasededatosclientesDataSet1.Clientes)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ClientesTableAdapter.FillBy(BasededatosclientesDataSet1.Clientes, tbdoc.Text)
    End Sub

    Private Sub btnPc_Click(sender As Object, e As EventArgs) Handles btnPc.Click
        verpcs.Show()
    End Sub

    Private Sub btnTrabajos_Click(sender As Object, e As EventArgs) Handles btnTrabajos.Click
        vertrabs.Show()
    End Sub
End Class