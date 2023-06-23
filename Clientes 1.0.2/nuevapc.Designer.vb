<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nuevapc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevapc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.CodigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.CodigosTableAdapter()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 11)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(150, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 57)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 26)
        Me.TextBox2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Modelo"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 100)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 26)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(112, 143)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 26)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(216, 185)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(280, 26)
        Me.TextBox5.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña/observaciones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 246)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CodigosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(531, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(216, 286)
        Me.DataGridView1.TabIndex = 1
        '
        'CodigosBindingSource1
        '
        Me.CodigosBindingSource1.DataMember = "Codigos"
        Me.CodigosBindingSource1.DataSource = Me.BasededatosclientesDataSet
        '
        'BasededatosclientesDataSet
        '
        Me.BasededatosclientesDataSet.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigosBindingSource
        '
        Me.CodigosBindingSource.DataMember = "Codigos"
        Me.CodigosBindingSource.DataSource = Me.BasededatosclientesDataSet
        '
        'CodigosTableAdapter
        '
        Me.CodigosTableAdapter.ClearBeforeFill = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.CodigoDataGridViewTextBoxColumn.Width = 150
        '
        'nuevapc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 311)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevapc"
        Me.Text = "Nuevo Item"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents CodigosBindingSource As BindingSource
    Friend WithEvents CodigosTableAdapter As basededatosclientesDataSetTableAdapters.CodigosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodigosBindingSource1 As BindingSource
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
