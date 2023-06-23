Public Class nuevotrabajo
    Private Sub nuevotrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        'Me.TrabajosTableAdapter.Fill(Me.BasededatosclientesDataSet.trabajos)
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Codigos' Puede moverla o quitarla según sea necesario.
        'Me.CodigosTableAdapter.Fill(Me.BasededatosclientesDataSet.Codigos)
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.BasededatosclientesDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        ' Me.ClientesTableAdapter.Fill(Me.BasededatosclientesDataSet.Clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer



        ClientesTableAdapter.FillBy(BasededatosclientesDataSet.Clientes, casd.Text)
        resultado = ClientesTableAdapter.FillBy(BasededatosclientesDataSet.Clientes, casd.Text)
        verif.Text = casd.Text

        'Verifica si se encontro cliente y devuelve las pc's asociadas a el
        If (resultado) Then
            CodigosTableAdapter.FillBydoc(BasededatosclientesDataSet.Codigos, casd.Text)
            bnpc.Visible = True
        Else
            MsgBox("No se encontro cliente", vbExclamation, "Aviso")
            Button2.Visible = True
        End If

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub casn_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub casd_TextChanged(sender As Object, e As EventArgs) Handles casd.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numdoc As String
        numdoc = casd.Text
        nuevocliente.Show()

        nuevocliente.TextBox3.Text = numdoc
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mt1, mt2, mt3 As String
        Dim resul1, resul2 As Boolean

        'Verifica que los campos no esten vacios
        If (codItem.Text = "") Then
            mt1 = MsgBox("Por favor, elija una pc para trabajar", vbCritical, "Campo 'codigo pc' vacio")
        ElseIf (probox.Text = "") Then
            mt2 = MsgBox("Por favor, ingrese un problema (esto se usara para saber como proceder)")

            'Verifica si el codigo esta dentro de las pc's de la base de datos
        Else
            resul1 = CodigosTableAdapter.FillBycod(BasededatosclientesDataSet.Codigos, codItem.Text)
            If (resul1) Then
                resul2 = CodigosTableAdapter.FillByboth(BasededatosclientesDataSet.Codigos, verif.Text, codItem.Text)

                If (resul2) Then


                    TrabajosTableAdapter.INSERTAR(Today, codItem.Text, probox.Text, "-vacío-", "No")
                    Close()
                    Trabajos.Show()
                Else
                    mt3 = MsgBox("El codigo ingresado es de una pc de otro cliente, por favor verifique", vbExclamation, "Codigo erroneo")
                    CodigosTableAdapter.FillBydoc(BasededatosclientesDataSet.Codigos, verif.Text)

                End If

            Else
                mt3 = MsgBox("Codigo de pc Inexistente", vbExclamation, "Error")
                CodigosTableAdapter.FillBydoc(BasededatosclientesDataSet.Codigos, verif.Text)
            End If
        End If
    End Sub

    Private Sub bnpc_Click(sender As Object, e As EventArgs) Handles bnpc.Click

        nuevapc.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateString

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItems.CellContentClick

        Dim textItem As Object = DGItems.Rows(e.RowIndex).Cells(0).Value

        If textItem IsNot Nothing Then
            codItem.Text = textItem.ToString()
        Else
            codItem.Text = ""
        End If

    End Sub
End Class