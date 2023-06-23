<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trabajos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trabajos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodjobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ObservDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cres = New System.Windows.Forms.TextBox()
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.CodigosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.CodigosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "En Proceso"
        '
        'cc
        '
        Me.cc.Location = New System.Drawing.Point(961, 123)
        Me.cc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(184, 26)
        Me.cc.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(858, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo Item"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 465)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Agregar Diagnostico"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(960, 454)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 75)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Finalizar Trabajo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(34, 465)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 65)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Todos los Trabajos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.CodjobDataGridViewTextBoxColumn, Me.ProblemaDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 55)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(816, 400)
        Me.DataGridView1.TabIndex = 11
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Cod trabajo"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'CodjobDataGridViewTextBoxColumn
        '
        Me.CodjobDataGridViewTextBoxColumn.DataPropertyName = "codjob"
        Me.CodjobDataGridViewTextBoxColumn.HeaderText = "Codigo Item"
        Me.CodjobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodjobDataGridViewTextBoxColumn.Name = "CodjobDataGridViewTextBoxColumn"
        Me.CodjobDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodjobDataGridViewTextBoxColumn.Width = 150
        '
        'ProblemaDataGridViewTextBoxColumn
        '
        Me.ProblemaDataGridViewTextBoxColumn.DataPropertyName = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.HeaderText = "Problema"
        Me.ProblemaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProblemaDataGridViewTextBoxColumn.Name = "ProblemaDataGridViewTextBoxColumn"
        Me.ProblemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProblemaDataGridViewTextBoxColumn.Width = 150
        '
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        Me.DiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiagnosticoDataGridViewTextBoxColumn.Width = 150
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(860, 163)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(285, 52)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Buscar Contraseña/observacion"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ObservDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CodigosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(860, 342)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.Size = New System.Drawing.Size(248, 88)
        Me.DataGridView2.TabIndex = 13
        Me.DataGridView2.Visible = False
        '
        'ObservDataGridViewTextBoxColumn
        '
        Me.ObservDataGridViewTextBoxColumn.DataPropertyName = "observ"
        Me.ObservDataGridViewTextBoxColumn.HeaderText = "Contraseña - Observaciones"
        Me.ObservDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ObservDataGridViewTextBoxColumn.Name = "ObservDataGridViewTextBoxColumn"
        Me.ObservDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservDataGridViewTextBoxColumn.Width = 150
        '
        'CodigosBindingSource
        '
        Me.CodigosBindingSource.DataMember = "Codigos"
        Me.CodigosBindingSource.DataSource = Me.BasededatosclientesDataSet
        '
        'cres
        '
        Me.cres.Location = New System.Drawing.Point(860, 225)
        Me.cres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cres.Multiline = True
        Me.cres.Name = "cres"
        Me.cres.ReadOnly = True
        Me.cres.ShortcutsEnabled = False
        Me.cres.Size = New System.Drawing.Size(283, 107)
        Me.cres.TabIndex = 14
        Me.cres.Text = "Contraseña / Observaciones del pc"
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
        'CodigosTableAdapter
        '
        Me.CodigosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label2.Location = New System.Drawing.Point(1074, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "V 1.0.2"
        '
        'Trabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 540)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cres)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cc)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Trabajos"
        Me.Text = "Trabajos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents TrabajosBindingSource As BindingSource
    Friend WithEvents TrabajosTableAdapter As basededatosclientesDataSetTableAdapters.trabajosTableAdapter
    Friend WithEvents cc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodigosBindingSource As BindingSource
    Friend WithEvents CodigosTableAdapter As basededatosclientesDataSetTableAdapters.CodigosTableAdapter
    Friend WithEvents Button5 As Button
    Friend WithEvents ObservDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cres As TextBox
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodjobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
