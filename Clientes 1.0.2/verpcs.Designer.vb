<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verpcs
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verpcs))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.CodigosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.CodigosTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.CodigosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CodigoLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CodigosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(11, 378)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(59, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo Pc:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.ObservDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CodigosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(769, 357)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "documento"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'ObservDataGridViewTextBoxColumn
        '
        Me.ObservDataGridViewTextBoxColumn.DataPropertyName = "observ"
        Me.ObservDataGridViewTextBoxColumn.HeaderText = "observ"
        Me.ObservDataGridViewTextBoxColumn.Name = "ObservDataGridViewTextBoxColumn"
        '
        'CodigosBindingSource
        '
        Me.CodigosBindingSource.DataMember = "Codigos"
        Me.CodigosBindingSource.DataSource = Me.BasededatosclientesDataSet
        '
        'BasededatosclientesDataSet
        '
        Me.BasededatosclientesDataSet.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodigosTableAdapter
        '
        Me.CodigosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CodigosTableAdapter = Me.CodigosTableAdapter
        Me.TableAdapterManager.trabajosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CodigosBindingNavigator
        '
        Me.CodigosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CodigosBindingNavigator.BindingSource = Me.CodigosBindingSource
        Me.CodigosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CodigosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CodigosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CodigosBindingNavigatorSaveItem})
        Me.CodigosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CodigosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CodigosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CodigosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CodigosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CodigosBindingNavigator.Name = "CodigosBindingNavigator"
        Me.CodigosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CodigosBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.CodigosBindingNavigator.TabIndex = 1
        Me.CodigosBindingNavigator.Text = "BindingNavigator1"
        Me.CodigosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CodigosBindingNavigatorSaveItem
        '
        Me.CodigosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CodigosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CodigosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CodigosBindingNavigatorSaveItem.Name = "CodigosBindingNavigatorSaveItem"
        Me.CodigosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CodigosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodigosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(76, 375)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(706, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'verpcs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 404)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.CodigosBindingNavigator)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "verpcs"
        Me.Text = "Ver pcs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CodigosBindingNavigator.ResumeLayout(False)
        Me.CodigosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents CodigosBindingSource As BindingSource
    Friend WithEvents CodigosTableAdapter As basededatosclientesDataSetTableAdapters.CodigosTableAdapter
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodigosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CodigosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
