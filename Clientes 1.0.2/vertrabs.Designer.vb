<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vertrabs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vertrabs))
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.TrabajosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TrabajosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodjobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontorepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrabajosBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(33, 525)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo"
        '
        'cc
        '
        Me.cc.Location = New System.Drawing.Point(123, 520)
        Me.cc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(110, 26)
        Me.cc.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 514)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1050, 525)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.CodjobDataGridViewTextBoxColumn, Me.ProblemaDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn, Me.SolucionDataGridViewTextBoxColumn, Me.RealizadoDataGridViewTextBoxColumn, Me.MontorepDataGridViewTextBoxColumn, Me.MontojobDataGridViewTextBoxColumn, Me.MonttotalDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 51)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1160, 440)
        Me.DataGridView1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(452, 514)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Ver Todo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha ingreso"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'CodjobDataGridViewTextBoxColumn
        '
        Me.CodjobDataGridViewTextBoxColumn.DataPropertyName = "codjob"
        Me.CodjobDataGridViewTextBoxColumn.HeaderText = "codigo Item"
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
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        Me.DiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiagnosticoDataGridViewTextBoxColumn.Width = 150
        '
        'SolucionDataGridViewTextBoxColumn
        '
        Me.SolucionDataGridViewTextBoxColumn.DataPropertyName = "solucion"
        Me.SolucionDataGridViewTextBoxColumn.HeaderText = "solucion"
        Me.SolucionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SolucionDataGridViewTextBoxColumn.Name = "SolucionDataGridViewTextBoxColumn"
        Me.SolucionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SolucionDataGridViewTextBoxColumn.Width = 150
        '
        'RealizadoDataGridViewTextBoxColumn
        '
        Me.RealizadoDataGridViewTextBoxColumn.DataPropertyName = "realizado"
        Me.RealizadoDataGridViewTextBoxColumn.HeaderText = "realizado"
        Me.RealizadoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RealizadoDataGridViewTextBoxColumn.Name = "RealizadoDataGridViewTextBoxColumn"
        Me.RealizadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RealizadoDataGridViewTextBoxColumn.Width = 150
        '
        'MontorepDataGridViewTextBoxColumn
        '
        Me.MontorepDataGridViewTextBoxColumn.DataPropertyName = "montorep"
        Me.MontorepDataGridViewTextBoxColumn.HeaderText = "montorep"
        Me.MontorepDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MontorepDataGridViewTextBoxColumn.Name = "MontorepDataGridViewTextBoxColumn"
        Me.MontorepDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontorepDataGridViewTextBoxColumn.Width = 150
        '
        'MontojobDataGridViewTextBoxColumn
        '
        Me.MontojobDataGridViewTextBoxColumn.DataPropertyName = "montojob"
        Me.MontojobDataGridViewTextBoxColumn.HeaderText = "montojob"
        Me.MontojobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MontojobDataGridViewTextBoxColumn.Name = "MontojobDataGridViewTextBoxColumn"
        Me.MontojobDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontojobDataGridViewTextBoxColumn.Width = 150
        '
        'MonttotalDataGridViewTextBoxColumn
        '
        Me.MonttotalDataGridViewTextBoxColumn.DataPropertyName = "monttotal"
        Me.MonttotalDataGridViewTextBoxColumn.HeaderText = "monttotal"
        Me.MonttotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MonttotalDataGridViewTextBoxColumn.Name = "MonttotalDataGridViewTextBoxColumn"
        Me.MonttotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonttotalDataGridViewTextBoxColumn.Width = 150
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 150
        '
        'vertrabs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 595)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrabajosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "vertrabs"
        Me.Text = "Todos los Trabajos"
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrabajosBindingNavigator.ResumeLayout(False)
        Me.TrabajosBindingNavigator.PerformLayout()
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
    Friend WithEvents cc As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodjobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SolucionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RealizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontorepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonttotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
