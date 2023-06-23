<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admjob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admjob))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.TrabajosTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.trabajosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodjobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontorepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontojobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodjobDataGridViewTextBoxColumn, Me.ProblemaDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn, Me.SolucionDataGridViewTextBoxColumn, Me.RealizadoDataGridViewTextBoxColumn, Me.MontorepDataGridViewTextBoxColumn, Me.MontojobDataGridViewTextBoxColumn, Me.MonttotalDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(966, 406)
        Me.DataGridView1.TabIndex = 0
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 434)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Codigo de Trbajo"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'CodjobDataGridViewTextBoxColumn
        '
        Me.CodjobDataGridViewTextBoxColumn.DataPropertyName = "codjob"
        Me.CodjobDataGridViewTextBoxColumn.HeaderText = "Codigo Item"
        Me.CodjobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CodjobDataGridViewTextBoxColumn.Name = "CodjobDataGridViewTextBoxColumn"
        Me.CodjobDataGridViewTextBoxColumn.Width = 150
        '
        'ProblemaDataGridViewTextBoxColumn
        '
        Me.ProblemaDataGridViewTextBoxColumn.DataPropertyName = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.HeaderText = "problema"
        Me.ProblemaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProblemaDataGridViewTextBoxColumn.Name = "ProblemaDataGridViewTextBoxColumn"
        Me.ProblemaDataGridViewTextBoxColumn.Width = 150
        '
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        Me.DiagnosticoDataGridViewTextBoxColumn.Width = 150
        '
        'SolucionDataGridViewTextBoxColumn
        '
        Me.SolucionDataGridViewTextBoxColumn.DataPropertyName = "solucion"
        Me.SolucionDataGridViewTextBoxColumn.HeaderText = "solucion"
        Me.SolucionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SolucionDataGridViewTextBoxColumn.Name = "SolucionDataGridViewTextBoxColumn"
        Me.SolucionDataGridViewTextBoxColumn.Width = 150
        '
        'RealizadoDataGridViewTextBoxColumn
        '
        Me.RealizadoDataGridViewTextBoxColumn.DataPropertyName = "realizado"
        Me.RealizadoDataGridViewTextBoxColumn.HeaderText = "realizado"
        Me.RealizadoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RealizadoDataGridViewTextBoxColumn.Name = "RealizadoDataGridViewTextBoxColumn"
        Me.RealizadoDataGridViewTextBoxColumn.Width = 150
        '
        'MontorepDataGridViewTextBoxColumn
        '
        Me.MontorepDataGridViewTextBoxColumn.DataPropertyName = "montorep"
        Me.MontorepDataGridViewTextBoxColumn.HeaderText = "montorep"
        Me.MontorepDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MontorepDataGridViewTextBoxColumn.Name = "MontorepDataGridViewTextBoxColumn"
        Me.MontorepDataGridViewTextBoxColumn.Width = 150
        '
        'MontojobDataGridViewTextBoxColumn
        '
        Me.MontojobDataGridViewTextBoxColumn.DataPropertyName = "montojob"
        Me.MontojobDataGridViewTextBoxColumn.HeaderText = "montojob"
        Me.MontojobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MontojobDataGridViewTextBoxColumn.Name = "MontojobDataGridViewTextBoxColumn"
        Me.MontojobDataGridViewTextBoxColumn.Width = 150
        '
        'MonttotalDataGridViewTextBoxColumn
        '
        Me.MonttotalDataGridViewTextBoxColumn.DataPropertyName = "monttotal"
        Me.MonttotalDataGridViewTextBoxColumn.HeaderText = "monttotal"
        Me.MonttotalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MonttotalDataGridViewTextBoxColumn.Name = "MonttotalDataGridViewTextBoxColumn"
        Me.MonttotalDataGridViewTextBoxColumn.Width = 150
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 150
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'admjob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admjob"
        Me.Text = "Administrar Trabajos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents TrabajosBindingSource As BindingSource
    Friend WithEvents TrabajosTableAdapter As basededatosclientesDataSetTableAdapters.trabajosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodjobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SolucionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RealizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontorepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontojobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonttotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
