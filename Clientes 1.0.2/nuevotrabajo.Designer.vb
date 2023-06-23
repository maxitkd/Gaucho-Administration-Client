<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nuevotrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevotrabajo))
        Me.casd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGItems = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codItem = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Probl = New System.Windows.Forms.Label()
        Me.probox = New System.Windows.Forms.TextBox()
        Me.bnpc = New System.Windows.Forms.Button()
        Me.verif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.CodigosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.CodigosTableAdapter()
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'casd
        '
        Me.casd.Location = New System.Drawing.Point(165, 34)
        Me.casd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.casd.Name = "casd"
        Me.casd.Size = New System.Drawing.Size(188, 26)
        Me.casd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 31)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasededatosclientesDataSetBindingSource
        '
        'BasededatosclientesDataSetBindingSource
        '
        Me.BasededatosclientesDataSetBindingSource.DataSource = Me.BasededatosclientesDataSet
        Me.BasededatosclientesDataSetBindingSource.Position = 0
        '
        'BasededatosclientesDataSet
        '
        Me.BasededatosclientesDataSet.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Nuevo Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.ObservDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(46, 80)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(816, 106)
        Me.DataGridView1.TabIndex = 9
        '
        'DocDataGridViewTextBoxColumn
        '
        Me.DocDataGridViewTextBoxColumn.DataPropertyName = "doc"
        Me.DocDataGridViewTextBoxColumn.HeaderText = "documento"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Items Asociados"
        '
        'DGItems
        '
        Me.DGItems.AllowUserToAddRows = False
        Me.DGItems.AllowUserToDeleteRows = False
        Me.DGItems.AutoGenerateColumns = False
        Me.DGItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.ObservDataGridViewTextBoxColumn1})
        Me.DGItems.DataSource = Me.CodigosBindingSource
        Me.DGItems.Location = New System.Drawing.Point(46, 240)
        Me.DGItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGItems.MultiSelect = False
        Me.DGItems.Name = "DGItems"
        Me.DGItems.ReadOnly = True
        Me.DGItems.RowHeadersWidth = 62
        Me.DGItems.Size = New System.Drawing.Size(816, 206)
        Me.DGItems.TabIndex = 13
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 150
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Width = 150
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 150
        '
        'ObservDataGridViewTextBoxColumn1
        '
        Me.ObservDataGridViewTextBoxColumn1.DataPropertyName = "observ"
        Me.ObservDataGridViewTextBoxColumn1.HeaderText = "observ"
        Me.ObservDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.ObservDataGridViewTextBoxColumn1.Name = "ObservDataGridViewTextBoxColumn1"
        Me.ObservDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ObservDataGridViewTextBoxColumn1.Width = 150
        '
        'CodigosBindingSource
        '
        Me.CodigosBindingSource.DataMember = "Codigos"
        Me.CodigosBindingSource.DataSource = Me.BasededatosclientesDataSetBindingSource
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 460)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Codigo"
        '
        'codItem
        '
        Me.codItem.Location = New System.Drawing.Point(116, 455)
        Me.codItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.codItem.Name = "codItem"
        Me.codItem.ReadOnly = True
        Me.codItem.Size = New System.Drawing.Size(144, 26)
        Me.codItem.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(789, 592)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 52)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Aceptar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Probl
        '
        Me.Probl.AutoSize = True
        Me.Probl.Location = New System.Drawing.Point(46, 537)
        Me.Probl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Probl.Name = "Probl"
        Me.Probl.Size = New System.Drawing.Size(76, 20)
        Me.Probl.TabIndex = 17
        Me.Probl.Text = "Problema"
        '
        'probox
        '
        Me.probox.Location = New System.Drawing.Point(132, 534)
        Me.probox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.probox.Name = "probox"
        Me.probox.Size = New System.Drawing.Size(728, 26)
        Me.probox.TabIndex = 5
        '
        'bnpc
        '
        Me.bnpc.Location = New System.Drawing.Point(740, 460)
        Me.bnpc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bnpc.Name = "bnpc"
        Me.bnpc.Size = New System.Drawing.Size(112, 35)
        Me.bnpc.TabIndex = 4
        Me.bnpc.Text = "Nuevo Item"
        Me.bnpc.UseVisualStyleBackColor = True
        Me.bnpc.Visible = False
        '
        'verif
        '
        Me.verif.Location = New System.Drawing.Point(422, 195)
        Me.verif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.verif.Name = "verif"
        Me.verif.Size = New System.Drawing.Size(148, 26)
        Me.verif.TabIndex = 20
        Me.verif.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 609)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 609)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "(Día)"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.CodigosTableAdapter = Nothing
        Me.TableAdapterManager.trabajosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CodigosTableAdapter
        '
        Me.CodigosTableAdapter.ClearBeforeFill = True
        '
        'TrabajosBindingSource
        '
        Me.TrabajosBindingSource.DataMember = "trabajos"
        Me.TrabajosBindingSource.DataSource = Me.BasededatosclientesDataSet
        '
        'TrabajosTableAdapter
        '
        Me.TrabajosTableAdapter.ClearBeforeFill = True
        '
        'nuevotrabajo
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 666)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.verif)
        Me.Controls.Add(Me.bnpc)
        Me.Controls.Add(Me.probox)
        Me.Controls.Add(Me.Probl)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.codItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGItems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.casd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevotrabajo"
        Me.Text = "Nuevo Trabajo"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents casd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BasededatosclientesDataSetBindingSource As BindingSource
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As basededatosclientesDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents DGItems As DataGridView
    Friend WithEvents CodigosBindingSource As BindingSource
    Friend WithEvents CodigosTableAdapter As basededatosclientesDataSetTableAdapters.CodigosTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents codItem As TextBox
    Friend WithEvents DocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Probl As Label
    Friend WithEvents probox As TextBox
    Friend WithEvents TrabajosBindingSource As BindingSource
    Friend WithEvents TrabajosTableAdapter As basededatosclientesDataSetTableAdapters.trabajosTableAdapter
    Friend WithEvents bnpc As Button
    Friend WithEvents verif As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
