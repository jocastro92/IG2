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
		Me.LabelBienvenida = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LabelBienvenida
		'
		Me.LabelBienvenida.AutoSize = True
		Me.LabelBienvenida.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.LabelBienvenida.Location = New System.Drawing.Point(88, 67)
		Me.LabelBienvenida.Name = "LabelBienvenida"
		Me.LabelBienvenida.Size = New System.Drawing.Size(245, 45)
		Me.LabelBienvenida.TabIndex = 0
		Me.LabelBienvenida.Text = "Proyecto IG2"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(385, 236)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(245, 45)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Proyecto IG2"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.LabelBienvenida)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelBienvenida As Label
	Friend WithEvents Label1 As Label
End Class
