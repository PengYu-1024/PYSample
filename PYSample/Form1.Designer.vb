<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDetele = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CustomerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PostalCodeDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.ExtensionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(265, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(243, 242)
        Me.DataGridView1.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "firstName", True))
        Me.txtName.Location = New System.Drawing.Point(125, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 17
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerId", True))
        Me.txtId.Location = New System.Drawing.Point(125, 65)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "FirstName"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(58, 68)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 14
        Me.ID.Text = "ID"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(153, 176)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(72, 35)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(153, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 35)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDetele
        '
        Me.btnDetele.Location = New System.Drawing.Point(153, 217)
        Me.btnDetele.Name = "btnDetele"
        Me.btnDetele.Size = New System.Drawing.Size(72, 35)
        Me.btnDetele.TabIndex = 11
        Me.btnDetele.Text = "Detele"
        Me.btnDetele.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(153, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 35)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CustomerIdDataGridViewTextBoxColumn
        '
        Me.CustomerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId"
        Me.CustomerIdDataGridViewTextBoxColumn.HeaderText = "customerId"
        Me.CustomerIdDataGridViewTextBoxColumn.Name = "CustomerIdDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'PostalCodeDataGridViewTextBoxColumn
        '
        Me.PostalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.HeaderText = "postalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.Name = "PostalCodeDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'ExtensionDataGridViewTextBoxColumn
        '
        Me.ExtensionDataGridViewTextBoxColumn.DataPropertyName = "extension"
        Me.ExtensionDataGridViewTextBoxColumn.HeaderText = "extension"
        Me.ExtensionDataGridViewTextBoxColumn.Name = "ExtensionDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(PYSample.customer)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDetele)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDetele As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource As BindingSource
End Class
