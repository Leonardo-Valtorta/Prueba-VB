<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.BtnNumeros = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNumeros
        '
        Me.BtnNumeros.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNumeros.Image = CType(resources.GetObject("BtnNumeros.Image"), System.Drawing.Image)
        Me.BtnNumeros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNumeros.Location = New System.Drawing.Point(40, 15)
        Me.BtnNumeros.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnNumeros.Name = "BtnNumeros"
        Me.BtnNumeros.Size = New System.Drawing.Size(112, 122)
        Me.BtnNumeros.TabIndex = 0
        Me.BtnNumeros.Text = "Numeros"
        Me.BtnNumeros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNumeros.UseVisualStyleBackColor = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 258)
        Me.Controls.Add(Me.BtnNumeros)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNumeros As System.Windows.Forms.Button

End Class
