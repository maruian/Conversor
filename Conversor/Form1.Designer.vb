<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.gbSistemaOrigen = New System.Windows.Forms.GroupBox()
        Me.rbOrigenHexadecimal = New System.Windows.Forms.RadioButton()
        Me.rbOrigenBinario = New System.Windows.Forms.RadioButton()
        Me.rbOrigenDecimal = New System.Windows.Forms.RadioButton()
        Me.gbSistemaDestino = New System.Windows.Forms.GroupBox()
        Me.rbDestinoHexadecimal = New System.Windows.Forms.RadioButton()
        Me.rbDestinoBinario = New System.Windows.Forms.RadioButton()
        Me.rbDestinoDecimal = New System.Windows.Forms.RadioButton()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.gbSistemaOrigen.SuspendLayout()
        Me.gbSistemaDestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino:"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(88, 32)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(155, 20)
        Me.txtOrigen.TabIndex = 2
        '
        'txtDestino
        '
        Me.txtDestino.Enabled = False
        Me.txtDestino.Location = New System.Drawing.Point(337, 32)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(155, 20)
        Me.txtDestino.TabIndex = 3
        '
        'gbSistemaOrigen
        '
        Me.gbSistemaOrigen.Controls.Add(Me.rbOrigenHexadecimal)
        Me.gbSistemaOrigen.Controls.Add(Me.rbOrigenBinario)
        Me.gbSistemaOrigen.Controls.Add(Me.rbOrigenDecimal)
        Me.gbSistemaOrigen.Location = New System.Drawing.Point(55, 92)
        Me.gbSistemaOrigen.Name = "gbSistemaOrigen"
        Me.gbSistemaOrigen.Size = New System.Drawing.Size(199, 168)
        Me.gbSistemaOrigen.TabIndex = 4
        Me.gbSistemaOrigen.TabStop = False
        Me.gbSistemaOrigen.Text = "Sistema Origen"
        '
        'rbOrigenHexadecimal
        '
        Me.rbOrigenHexadecimal.AutoSize = True
        Me.rbOrigenHexadecimal.Location = New System.Drawing.Point(23, 105)
        Me.rbOrigenHexadecimal.Name = "rbOrigenHexadecimal"
        Me.rbOrigenHexadecimal.Size = New System.Drawing.Size(86, 17)
        Me.rbOrigenHexadecimal.TabIndex = 2
        Me.rbOrigenHexadecimal.TabStop = True
        Me.rbOrigenHexadecimal.Text = "Hexadecimal"
        Me.rbOrigenHexadecimal.UseVisualStyleBackColor = True
        '
        'rbOrigenBinario
        '
        Me.rbOrigenBinario.AutoSize = True
        Me.rbOrigenBinario.Location = New System.Drawing.Point(23, 72)
        Me.rbOrigenBinario.Name = "rbOrigenBinario"
        Me.rbOrigenBinario.Size = New System.Drawing.Size(57, 17)
        Me.rbOrigenBinario.TabIndex = 1
        Me.rbOrigenBinario.TabStop = True
        Me.rbOrigenBinario.Text = "Binario"
        Me.rbOrigenBinario.UseVisualStyleBackColor = True
        '
        'rbOrigenDecimal
        '
        Me.rbOrigenDecimal.AutoSize = True
        Me.rbOrigenDecimal.Location = New System.Drawing.Point(23, 40)
        Me.rbOrigenDecimal.Name = "rbOrigenDecimal"
        Me.rbOrigenDecimal.Size = New System.Drawing.Size(63, 17)
        Me.rbOrigenDecimal.TabIndex = 0
        Me.rbOrigenDecimal.TabStop = True
        Me.rbOrigenDecimal.Text = "Decimal"
        Me.rbOrigenDecimal.UseVisualStyleBackColor = True
        '
        'gbSistemaDestino
        '
        Me.gbSistemaDestino.Controls.Add(Me.rbDestinoHexadecimal)
        Me.gbSistemaDestino.Controls.Add(Me.rbDestinoBinario)
        Me.gbSistemaDestino.Controls.Add(Me.rbDestinoDecimal)
        Me.gbSistemaDestino.Location = New System.Drawing.Point(299, 92)
        Me.gbSistemaDestino.Name = "gbSistemaDestino"
        Me.gbSistemaDestino.Size = New System.Drawing.Size(183, 168)
        Me.gbSistemaDestino.TabIndex = 5
        Me.gbSistemaDestino.TabStop = False
        Me.gbSistemaDestino.Text = "Sistema Destino"
        '
        'rbDestinoHexadecimal
        '
        Me.rbDestinoHexadecimal.AutoSize = True
        Me.rbDestinoHexadecimal.Location = New System.Drawing.Point(34, 105)
        Me.rbDestinoHexadecimal.Name = "rbDestinoHexadecimal"
        Me.rbDestinoHexadecimal.Size = New System.Drawing.Size(86, 17)
        Me.rbDestinoHexadecimal.TabIndex = 5
        Me.rbDestinoHexadecimal.TabStop = True
        Me.rbDestinoHexadecimal.Text = "Hexadecimal"
        Me.rbDestinoHexadecimal.UseVisualStyleBackColor = True
        '
        'rbDestinoBinario
        '
        Me.rbDestinoBinario.AutoSize = True
        Me.rbDestinoBinario.Location = New System.Drawing.Point(34, 72)
        Me.rbDestinoBinario.Name = "rbDestinoBinario"
        Me.rbDestinoBinario.Size = New System.Drawing.Size(57, 17)
        Me.rbDestinoBinario.TabIndex = 4
        Me.rbDestinoBinario.TabStop = True
        Me.rbDestinoBinario.Text = "Binario"
        Me.rbDestinoBinario.UseVisualStyleBackColor = True
        '
        'rbDestinoDecimal
        '
        Me.rbDestinoDecimal.AutoSize = True
        Me.rbDestinoDecimal.Location = New System.Drawing.Point(34, 40)
        Me.rbDestinoDecimal.Name = "rbDestinoDecimal"
        Me.rbDestinoDecimal.Size = New System.Drawing.Size(63, 17)
        Me.rbDestinoDecimal.TabIndex = 3
        Me.rbDestinoDecimal.TabStop = True
        Me.rbDestinoDecimal.Text = "Decimal"
        Me.rbDestinoDecimal.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(55, 292)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(299, 292)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 362)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gbSistemaDestino)
        Me.Controls.Add(Me.gbSistemaOrigen)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Conversor"
        Me.gbSistemaOrigen.ResumeLayout(False)
        Me.gbSistemaOrigen.PerformLayout()
        Me.gbSistemaDestino.ResumeLayout(False)
        Me.gbSistemaDestino.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents gbSistemaOrigen As GroupBox
    Friend WithEvents rbOrigenHexadecimal As RadioButton
    Friend WithEvents rbOrigenBinario As RadioButton
    Friend WithEvents rbOrigenDecimal As RadioButton
    Friend WithEvents gbSistemaDestino As GroupBox
    Friend WithEvents rbDestinoHexadecimal As RadioButton
    Friend WithEvents rbDestinoBinario As RadioButton
    Friend WithEvents rbDestinoDecimal As RadioButton
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
End Class
