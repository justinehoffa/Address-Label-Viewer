<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelViewerForm
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
        Me.MailingAddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddressLabelGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabelButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.MailingAddressGroupBox.SuspendLayout()
        Me.AddressLabelGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MailingAddressGroupBox
        '
        Me.MailingAddressGroupBox.Controls.Add(Me.ZipLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.StateLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.CityLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.StreetAddressLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.LastNameLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.MailingAddressGroupBox.Controls.Add(Me.ZipTextBox)
        Me.MailingAddressGroupBox.Controls.Add(Me.StateTextBox)
        Me.MailingAddressGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.MailingAddressGroupBox.Controls.Add(Me.CityTextBox)
        Me.MailingAddressGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.MailingAddressGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.MailingAddressGroupBox.Location = New System.Drawing.Point(78, 66)
        Me.MailingAddressGroupBox.Name = "MailingAddressGroupBox"
        Me.MailingAddressGroupBox.Size = New System.Drawing.Size(668, 370)
        Me.MailingAddressGroupBox.TabIndex = 0
        Me.MailingAddressGroupBox.TabStop = False
        Me.MailingAddressGroupBox.Text = "Mailing Address"
        '
        'AddressLabelGroupBox
        '
        Me.AddressLabelGroupBox.Controls.Add(Me.DisplayLabel)
        Me.AddressLabelGroupBox.Location = New System.Drawing.Point(78, 452)
        Me.AddressLabelGroupBox.Name = "AddressLabelGroupBox"
        Me.AddressLabelGroupBox.Size = New System.Drawing.Size(668, 321)
        Me.AddressLabelGroupBox.TabIndex = 1
        Me.AddressLabelGroupBox.TabStop = False
        Me.AddressLabelGroupBox.Text = "Address Label"
        '
        'DisplayLabelButton
        '
        Me.DisplayLabelButton.Location = New System.Drawing.Point(958, 83)
        Me.DisplayLabelButton.Name = "DisplayLabelButton"
        Me.DisplayLabelButton.Size = New System.Drawing.Size(196, 112)
        Me.DisplayLabelButton.TabIndex = 2
        Me.DisplayLabelButton.Text = "DIsplay Label"
        Me.DisplayLabelButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(958, 230)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(196, 112)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(958, 387)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(196, 112)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(182, 15)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 31)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(182, 69)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 31)
        Me.LastNameTextBox.TabIndex = 6
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(182, 124)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(100, 31)
        Me.StreetAddressTextBox.TabIndex = 7
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(173, 181)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 31)
        Me.CityTextBox.TabIndex = 8
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(182, 240)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 31)
        Me.StateTextBox.TabIndex = 9
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(191, 303)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 31)
        Me.ZipTextBox.TabIndex = 10
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(23, 42)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(616, 255)
        Me.DisplayLabel.TabIndex = 0
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(336, 17)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(116, 25)
        Me.FirstNameLabel.TabIndex = 11
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(336, 75)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(115, 25)
        Me.LastNameLabel.TabIndex = 12
        Me.LastNameLabel.Text = "Last Name"
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(336, 130)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(154, 25)
        Me.StreetAddressLabel.TabIndex = 13
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(336, 187)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(49, 25)
        Me.CityLabel.TabIndex = 14
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(336, 251)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(62, 25)
        Me.StateLabel.TabIndex = 15
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(336, 309)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(42, 25)
        Me.ZipLabel.TabIndex = 16
        Me.ZipLabel.Text = "Zip"
        '
        'AddressLabelViewerForm
        '
        Me.AcceptButton = Me.DisplayLabelButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1307, 812)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayLabelButton)
        Me.Controls.Add(Me.AddressLabelGroupBox)
        Me.Controls.Add(Me.MailingAddressGroupBox)
        Me.Name = "AddressLabelViewerForm"
        Me.Text = "Form1"
        Me.MailingAddressGroupBox.ResumeLayout(False)
        Me.MailingAddressGroupBox.PerformLayout()
        Me.AddressLabelGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MailingAddressGroupBox As GroupBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents AddressLabelGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents DisplayLabelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
