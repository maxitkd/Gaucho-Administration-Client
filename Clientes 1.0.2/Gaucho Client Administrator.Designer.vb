<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class G
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(G))
        Me.bt = New System.Windows.Forms.Button()
        Me.butc = New System.Windows.Forms.Button()
        Me.butsal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.BasededatosclientesDataSet = New Clientes_1._0._2.basededatosclientesDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Clientes_1._0._2.basededatosclientesDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt
        '
        Me.bt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt.Location = New System.Drawing.Point(142, 352)
        Me.bt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt.Name = "bt"
        Me.bt.Size = New System.Drawing.Size(231, 71)
        Me.bt.TabIndex = 4
        Me.bt.Text = "Trabajos"
        Me.bt.UseVisualStyleBackColor = True
        '
        'butc
        '
        Me.butc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butc.Location = New System.Drawing.Point(117, 205)
        Me.butc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.butc.Name = "butc"
        Me.butc.Size = New System.Drawing.Size(284, 88)
        Me.butc.TabIndex = 1
        Me.butc.Text = "Agregar Trabajo"
        Me.butc.UseVisualStyleBackColor = True
        '
        'butsal
        '
        Me.butsal.Location = New System.Drawing.Point(935, 595)
        Me.butsal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.butsal.Name = "butsal"
        Me.butsal.Size = New System.Drawing.Size(231, 48)
        Me.butsal.TabIndex = 3
        Me.butsal.Text = "Salir"
        Me.butsal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 614)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "V 1.0.2"
        '
        'btnclientes
        '
        Me.btnclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.Location = New System.Drawing.Point(162, 483)
        Me.btnclientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(192, 48)
        Me.btnclientes.TabIndex = 6
        Me.btnclientes.Text = "Ver Clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'BasededatosclientesDataSet
        '
        Me.BasededatosclientesDataSet.DataSetName = "basededatosclientesDataSet"
        Me.BasededatosclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasededatosclientesDataSet
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
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.BasededatosclientesDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(390, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 50)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Gaucho Client Administrator"
        '
        'G
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1191, 666)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butsal)
        Me.Controls.Add(Me.butc)
        Me.Controls.Add(Me.bt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1213, 722)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1213, 722)
        Me.Name = "G"
        Me.Text = "Principal"
        CType(Me.BasededatosclientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasededatosclientesDataSet As basededatosclientesDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As basededatosclientesDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As basededatosclientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents bt As Button
    Friend WithEvents butc As Button
    Friend WithEvents butsal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclientes As Button
    Friend WithEvents Label2 As Label
End Class
