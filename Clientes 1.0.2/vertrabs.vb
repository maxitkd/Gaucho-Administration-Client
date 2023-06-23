Public Class vertrabs
    Private Sub TrabajosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrabajosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrabajosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasededatosclientesDataSet)

    End Sub

    Private Sub vertrabs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        Me.TrabajosTableAdapter.Fill(Me.BasededatosclientesDataSet.trabajos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cc.Text = "") Then
            MsgBox("Introduzca el codigo a buscar", vbCritical, "Error")
        Else
            TrabajosTableAdapter.FillBycod(Me.BasededatosclientesDataSet.trabajos, cc.Text)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TrabajosTableAdapter.Fill(Me.BasededatosclientesDataSet.trabajos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

End Class