Public Class Form1
    'Matias Ruiz
    '2 DAM
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDestino.Text = ""
        txtOrigen.Text = ""

        rbOrigenBinario.Checked = False
        rbOrigenDecimal.Checked = False
        rbOrigenHexadecimal.Checked = False
        rbDestinoBinario.Checked = False
        rbDestinoDecimal.Checked = False
        rbDestinoHexadecimal.Checked = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbOrigenDecimal.Checked And rbDestinoBinario.Checked Then
            Try
                Dim cadenaOrigen As Integer = Integer.Parse(txtOrigen.Text) 'convierte la cadena origen en un entero
                txtDestino.Text = Convert.ToString(cadenaOrigen, 2) 'convierte la cadena origen a binario
            Catch ex As Exception 'captura y trata la excepcion
                MessageBox.Show("Error en el formato de entrada: ", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If rbOrigenDecimal.Checked And rbDestinoHexadecimal.Checked Then
            Try
                Dim cadenaOrigen As Integer = Integer.Parse(txtOrigen.Text) 'convierte la cadena origen en un entero
                txtDestino.Text = Convert.ToString(cadenaOrigen, 16) 'convierte la cadena origen especificandole que su base es hexadecimal y lo asigna al campo de destino
                txtDestino.Text = txtDestino.Text.ToUpper() 'formatea el texto en mayusculas
            Catch ex As Exception
                MessageBox.Show("Error en el formato de entrada", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        If rbOrigenBinario.Checked And rbDestinoDecimal.Checked Then
            Try
                Dim cadenaOrigen As String = txtOrigen.Text 'asigna el texto del campo origen a la variable de tipo String cadenaOrigen
                Dim cadenaDestino As Integer = Convert.ToInt32(cadenaOrigen, 2) 'convierte la cadena de caracteres especificandole que es de base 2 a un entero de 32bits
                txtDestino.Text = cadenaDestino.ToString 'convierte la cadena el entero de base 2 a una cadena de texto y lo asigna al campo de destino
            Catch ex As Exception
                MessageBox.Show("Error en el formato de entrada", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If rbOrigenBinario.Checked And rbDestinoHexadecimal.Checked Then
            Try
                Dim cadenaOrigen As String = txtOrigen.Text 'asigna el texto del campo origen a la variable de tipo String cadenaOrigen
                Dim cadenaDestino As Integer = Convert.ToInt32(cadenaOrigen, 2) 'convierte la cadena de caracteres a la que se especifica que tiene base 2 a un entero de 32bits
                txtDestino.Text = Convert.ToString(cadenaDestino, 16).ToUpper 'convierte la cadena destino especificandole que su base es hexadecimal a texto y la asigna al campo de destino
            Catch ex As Exception
                MessageBox.Show("Error en el formato de entrada", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If rbOrigenHexadecimal.Checked And rbDestinoDecimal.Checked Then
            Try
                Dim cadenaOrigen As String = txtOrigen.Text 'asigna el texto del campo origen a la variable de tipo String cadenaOrigen
                Dim cadenaDestino As Integer = Convert.ToInt32(cadenaOrigen, 16) 'convierte la cadena de caracteres a la que se le especifica que tiene base hexadecimal a un entero de 32bits
                txtDestino.Text = cadenaDestino.ToString 'asigna al campo destino la cadena que antes convierte en un String
            Catch ex As Exception
                MessageBox.Show("Error en el formato de entrada", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If rbOrigenHexadecimal.Checked And rbDestinoBinario.Checked Then
            Try
                Dim cadenaOrigen As String = txtOrigen.Text 'Toma la cadena del campo origen y lo asigna a la variable cadenaOrigen
                Dim cadenaDestino As Integer = Convert.ToInt32(cadenaOrigen, 16) 'Convierte a entero de 32 bits la cadenaOrigen que representa un valor hexadecimal
                txtDestino.Text = Convert.ToString(cadenaDestino, 2) 'Convierte a una cadena de tipo String la cadena hexadecimal representada en base 2
            Catch ex As Exception
                MessageBox.Show("Error en el formato de entrada", "Conversor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub

End Class
