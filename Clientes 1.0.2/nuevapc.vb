Public Class nuevapc
    Private Sub nuevapc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Codigos' Puede moverla o quitarla según sea necesario.
        Me.CodigosTableAdapter.Fill(Me.BasededatosclientesDataSet.Codigos)

        TextBox1.Text = nuevotrabajo.verif.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As Boolean
        Dim numcod As String

        If (TextBox3.Text = "") Then
            MsgBox("Por favor, ingrese una marca", vbCritical, "Casilla vacia")
        ElseIf (TextBox4.Text = "") Then
            MsgBox("Por favor, ingrese un modelo", vbCritical, "Casilla vacia")
        ElseIf (TextBox2.Text = "") Then
            MsgBox("Falta el codigo!", vbCritical, "Casilla vacia")


        Else
            result = CodigosTableAdapter.FillBycod(Me.BasededatosclientesDataSet.Codigos, TextBox2.Text)
            If Not (result) Then
                numcod = TextBox2.Text
                CodigosTableAdapter.INSERTAR(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                Close()
                nuevotrabajo.codItem.Text = numcod
                CodigosTableAdapter.FillBycod(nuevotrabajo.BasededatosclientesDataSet.Codigos, numcod)

            Else
                MsgBox("El codigo ya existe, por favor revise la lista y elija un numero superior al mayor de la lista", vbCritical, "Error")
                Me.CodigosTableAdapter.Fill(Me.BasededatosclientesDataSet.Codigos)
            End If



        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Sort(DataGridView1.Columns("Codigo"), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class