<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nuevodiag
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevodiag))
        Me.TrabajosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
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
        Me.TrabajosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.casdiag = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ccod = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.casverif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodjobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.TrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrabajosBindingNavigator.SuspendLayout()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(18, 14)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(108, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id diagnostico"
        '
        'TrabajosBindingNavigator
        '
        Me.TrabajosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TrabajosBindingNavigator.BindingSource = Me.TrabajosBindingSource
        Me.TrabajosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TrabajosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TrabajosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TrabajosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TrabajosBindingNavigatorSaveItem})
        Me.TrabajosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TrabajosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TrabajosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TrabajosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TrabajosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TrabajosBindingNavigator.Name = "TrabajosBindingNavigator"
        Me.TrabajosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.TrabajosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TrabajosBindingNavigator.Size = New System.Drawing.Size(1200, 38)
        Me.TrabajosBindingNavigator.TabIndex = 1
        Me.TrabajosBindingNavigator.Text = "BindingNavigator1"
        Me.TrabajosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 33)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'TrabajosBindingNavigatorSaveItem
        '
        Me.TrabajosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TrabajosBindingNavigatorSaveItem.Image = CType(resources.GetObject("TrabajosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TrabajosBindingNavigatorSaveItem.Name = "TrabajosBindingNavigatorSaveItem"
        Me.TrabajosBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 33)
        Me.TrabajosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Diagnostico"
        '
        'casdiag
        '
        Me.casdiag.Location = New System.Drawing.Point(22, 289)
        Me.casdiag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.casdiag.Name = "casdiag"
        Me.casdiag.Size = New System.Drawing.Size(626, 26)
        Me.casdiag.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 352)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(387, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ccod
        '
        Me.ccod.Location = New System.Drawing.Point(168, 9)
        Me.ccod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ccod.Name = "ccod"
        Me.ccod.Size = New System.Drawing.Size(148, 26)
        Me.ccod.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodjobDataGridViewTextBoxColumn, Me.ProblemaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(80, 66)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(516, 94)
        Me.DataGridView1.TabIndex = 2
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
        'casverif
        '
        Me.casverif.Location = New System.Drawing.Point(303, 208)
        Me.casverif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.casverif.Name = "casverif"
        Me.casverif.ReadOnly = True
        Me.casverif.Size = New System.Drawing.Size(110, 26)
        Me.casverif.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Id asignado:"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id diagnostico"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'CodjobDataGridViewTextBoxColumn
        '
        Me.CodjobDataGridViewTextBoxColumn.DataPropertyName = "codjob"
        Me.CodjobDataGridViewTextBoxColumn.HeaderText = "Id trabajo"
        Me.CodjobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodjobDataGridViewTextBoxColumn.Name = "CodjobDataGridViewTextBoxColumn"
        Me.CodjobDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodjobDataGridViewTextBoxColumn.Width = 150
        '
        'ProblemaDataGridViewTextBoxColumn
        '
        Me.ProblemaDataGridViewTextBoxColumn.DataPropertyName = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.HeaderText = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProblemaDataGridViewTextBoxColumn.Name = "ProblemaDataGridViewTextBoxColumn"
        Me.ProblemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProblemaDataGridViewTextBoxColumn.Width = 150
        '
        'nuevodiag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 412)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.casverif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ccod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.casdiag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.TrabajosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevodiag"
        Me.Text = "Agregar Diagnostico"
        CType(Me.TrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrabajosBindingNavigator.ResumeLayout(False)
        Me.TrabajosBindingNavigator.PerformLayout()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents TrabajosBindingSource As BindingSource
    Friend WithEvents TrabajosTableAdapter As basededatosclientesDataSetTableAdapters.trabajosTableAdapter
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrabajosBindingNavigator As BindingNavigator
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
    Friend WithEvents TrabajosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents casdiag As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ccod As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents casverif As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodjobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
