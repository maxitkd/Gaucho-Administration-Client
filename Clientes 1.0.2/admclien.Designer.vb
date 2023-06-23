<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admclien
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admclien))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbdoc = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnPc = New System.Windows.Forms.Button()
        Me.btnTrabajos = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BasededatosclientesDataSet1 = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.ClientesTableAdapter()
        CType(Me.BasededatosclientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 622)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento"
        '
        'tbdoc
        '
        Me.tbdoc.Location = New System.Drawing.Point(150, 620)
        Me.tbdoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbdoc.Name = "tbdoc"
        Me.tbdoc.Size = New System.Drawing.Size(148, 26)
        Me.tbdoc.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(328, 617)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnPc
        '
        Me.btnPc.Location = New System.Drawing.Point(760, 638)
        Me.btnPc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPc.Name = "btnPc"
        Me.btnPc.Size = New System.Drawing.Size(112, 35)
        Me.btnPc.TabIndex = 3
        Me.btnPc.Text = "Items"
        Me.btnPc.UseVisualStyleBackColor = True
        '
        'btnTrabajos
        '
        Me.btnTrabajos.Location = New System.Drawing.Point(882, 638)
        Me.btnTrabajos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTrabajos.Name = "btnTrabajos"
        Me.btnTrabajos.Size = New System.Drawing.Size(152, 35)
        Me.btnTrabajos.TabIndex = 4
        Me.btnTrabajos.Text = "Trabajos"
        Me.btnTrabajos.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1056, 638)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Salir"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BasededatosclientesDataSet1
        '
        Me.BasededatosclientesDataSet1.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DocDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.ObservDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1130, 589)
        Me.DataGridView1.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'DocDataGridViewTextBoxColumn
        '
        Me.DocDataGridViewTextBoxColumn.DataPropertyName = "doc"
        Me.DocDataGridViewTextBoxColumn.HeaderText = "doc"
        Me.DocDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DocDataGridViewTextBoxColumn.Name = "DocDataGridViewTextBoxColumn"
        Me.DocDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocDataGridViewTextBoxColumn.Width = 150
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 150
        '
        'ObservDataGridViewTextBoxColumn
        '
        Me.ObservDataGridViewTextBoxColumn.DataPropertyName = "observ"
        Me.ObservDataGridViewTextBoxColumn.HeaderText = "observ"
        Me.ObservDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ObservDataGridViewTextBoxColumn.Name = "ObservDataGridViewTextBoxColumn"
        Me.ObservDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservDataGridViewTextBoxColumn.Width = 150
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasededatosclientesDataSet1
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'admclien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTrabajos)
        Me.Controls.Add(Me.btnPc)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbdoc)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admclien"
        Me.Text = "Ver Clientes"
        CType(Me.BasededatosclientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbdoc As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnPc As Button
    Friend WithEvents btnTrabajos As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents BasededatosclientesDataSet1 As basededatosclientesDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As basededatosclientesDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
