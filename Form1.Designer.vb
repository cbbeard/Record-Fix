<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fix))
        Me.FixButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Sig1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FixButton
        '
        Me.FixButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.FixButton.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FixButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FixButton.Location = New System.Drawing.Point(70, 51)
        Me.FixButton.Name = "FixButton"
        Me.FixButton.Size = New System.Drawing.Size(151, 62)
        Me.FixButton.TabIndex = 0
        Me.FixButton.Text = "Fix"
        Me.FixButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CloseButton.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(70, 151)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(151, 62)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Sig1
        '
        Me.Sig1.AutoSize = True
        Me.Sig1.BackColor = System.Drawing.Color.Transparent
        Me.Sig1.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sig1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Sig1.Location = New System.Drawing.Point(263, 246)
        Me.Sig1.Name = "Sig1"
        Me.Sig1.Size = New System.Drawing.Size(23, 15)
        Me.Sig1.TabIndex = 2
        Me.Sig1.Text = "CB"
        '
        'Fix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Sig1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.FixButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "Fix"
        Me.Text = "Fix Hard Drive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FixButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Sig1 As Label
End Class
