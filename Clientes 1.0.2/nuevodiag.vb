Public Class nuevodiag
    Private Sub TrabajosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrabajosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrabajosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasededatosclientesDataSet)

    End Sub

    Private Sub nuevodiag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasededatosclientesDataSet.trabajos' Puede moverla o quitarla según sea necesario.
        'Me.TrabajosTableAdapter.Fill(Me.BasededatosclientesDataSet.trabajos)

    End Sub

    Private Sub CodjobComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodjobLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim asd As Integer
        Dim verif As Boolean

        If (IsNumeric(ccod.Text)) Then
            asd = ccod.Text
            verif = TrabajosTableAdapter.FillByid(BasededatosclientesDataSet.trabajos, asd)
            If (verif) Then
                casverif.Text = asd
            End If
        Else
            MsgBox("Introduca solo el numero de identificacion del trabajo", vbCritical, "Error")
        End If
    End Sub

    Private Sub IdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verifid As Boolean
        Dim casvacio As String
        Dim verifnum As Integer

        casvacio = "-vacío-"
        verifnum = casverif.Text


        If (casverif.Text = "") Then
            MsgBox("Asigne un trabajo antes", vbCritical, "Error")
        ElseIf (casdiag.Text = "") Then
            MsgBox("Casilla diagnostico vacia", vbCritical, "Error")
        Else


            verifid = TrabajosTableAdapter.FillBydiag(BasededatosclientesDataSet.trabajos, verifnum, casvacio)
            If (verifid) Then
                TrabajosTableAdapter.modifdiag(casdiag.Text, casverif.Text)
                Me.Close()
                Trabajos.TrabajosTableAdapter.FillBynotf(Trabajos.BasededatosclientesDataSet.trabajos, "No")
            Else
                MsgBox("Este trabajo ya posee un diagnostico, contacte con el administrador para modificarlo", vbCritical, "Error")

            End If
        End If
    End Sub
End Class