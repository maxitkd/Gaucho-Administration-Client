<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fintrabajo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fintrabajo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cs = New System.Windows.Forms.TextBox()
        Me.cr = New System.Windows.Forms.TextBox()
        Me.cmr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cverif = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cob = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ccod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.casr = New System.Windows.Forms.TextBox()
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solucion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Repuestos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto Mano de Obra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto total"
        '
        'cs
        '
        Me.cs.Location = New System.Drawing.Point(18, 101)
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(371, 20)
        Me.cs.TabIndex = 3
        '
        'cr
        '
        Me.cr.Location = New System.Drawing.Point(12, 276)
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Size = New System.Drawing.Size(18, 20)
        Me.cr.TabIndex = 5
        Me.cr.Text = "Si"
        Me.cr.Visible = False
        '
        'cmr
        '
        Me.cmr.Location = New System.Drawing.Point(39, 154)
        Me.cmr.Name = "cmr"
        Me.cmr.Size = New System.Drawing.Size(64, 20)
        Me.cmr.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "$"
        '
        'cmm
        '
        Me.cmm.Location = New System.Drawing.Point(39, 197)
        Me.cmm.Name = "cmm"
        Me.cmm.Size = New System.Drawing.Size(64, 20)
        Me.cmm.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(183, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "$"
        '
        'cverif
        '
        Me.cverif.Location = New System.Drawing.Point(39, 276)
        Me.cverif.Name = "cverif"
        Me.cverif.ReadOnly = True
        Me.cverif.Size = New System.Drawing.Size(64, 20)
        Me.cverif.TabIndex = 10
        Me.cverif.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Garantia/Observaciones"
        '
        'cob
        '
        Me.cob.Location = New System.Drawing.Point(12, 250)
        Me.cob.Name = "cob"
        Me.cob.Size = New System.Drawing.Size(377, 20)
        Me.cob.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Finalizar trabajo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ccod
        '
        Me.ccod.Location = New System.Drawing.Point(12, 25)
        Me.ccod.Name = "ccod"
        Me.ccod.Size = New System.Drawing.Size(75, 20)
        Me.ccod.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Codigo de trabajo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProblemaDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(105, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(284, 80)
        Me.DataGridView1.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Codigo de trabajo"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProblemaDataGridViewTextBoxColumn
        '
        Me.ProblemaDataGridViewTextBoxColumn.DataPropertyName = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.HeaderText = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.Name = "ProblemaDataGridViewTextBoxColumn"
        Me.ProblemaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        Me.DiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrabajosBindingSource
        '
        Me.TrabajosBindingSource.DataMember = "trabajos"
        Me.TrabajosBindingSource.DataSource = Me.BasededatosclientesDataSet
        '
        'BasededatosclientesDataSet
        '
        Me.BasededatosclientesDataSet.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmt
        '
        Me.cmt.Location = New System.Drawing.Point(202, 154)
        Me.cmt.Name = "cmt"
        Me.cmt.ReadOnly = True
        Me.cmt.Size = New System.Drawing.Size(75, 20)
        Me.cmt.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(283, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(181, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nº de Remito"
        '
        'casr
        '
        Me.casr.Location = New System.Drawing.Point(186, 200)
        Me.casr.Name = "casr"
        Me.casr.Size = New System.Drawing.Size(172, 20)
        Me.casr.TabIndex = 21
        '
        'TrabajosTableAdapter
        '
        Me.TrabajosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CodigosTableAdapter = Nothing
        Me.TableAdapterManager.trabajosTableAdapter = Me.TrabajosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'fintrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 317)
        Me.Controls.Add(Me.casr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ccod)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cob)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cverif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmr)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.cs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fintrabajo"
        Me.Text = "Finalizar trabajo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cs As TextBox
    Friend WithEvents cr As TextBox
    Friend WithEvents cmr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmm As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cverif As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cob As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ccod As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents TrabajosBindingSource As BindingSource
    Friend WithEvents TrabajosTableAdapter As basededatosclientesDataSetTableAdapters.trabajosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents cmt As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents casr As TextBox
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
End Class
