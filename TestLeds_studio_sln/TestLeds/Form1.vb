Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Management
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nameArray() As String
        PictureBox1.BackColor = Color.Orange
        nameArray = SerialPort.GetPortNames
        Array.Sort(nameArray)
        cmbPorts.DataSource = nameArray
        cmbPorts.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPorts.SelectedIndex = 1

        TextBox2.Enabled = False
        Dim path As String = Directory.GetCurrentDirectory()
        Dim img_filename As String = path & "\bot.jpg"
        Label2.Text = img_filename
        PictureBox2.Image = Image.FromFile(img_filename)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        open_port()
    End Sub



    Sub open_port()
        Try
            SerialPort1.PortName = cmbPorts.SelectedItem.ToString
            SerialPort1.BaudRate = 38400
            SerialPort1.Open()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        If SerialPort1.IsOpen Then
            PictureBox1.BackColor = Color.Lime
        End If
    End Sub

    Sub close_port()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            PictureBox1.BackColor = Color.Red
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        close_port()
    End Sub
    Sub generate_led_data()


        TextBox2.Text = SetLeds_DLL.Main.set_led(cmbPorts.SelectedItem.ToString, NumericUpDown1.Value, NumericUpDown2.Value, NumericUpDown3.Value, NumericUpDown4.Value, NumericUpDown5.Value, NumericUpDown6.Value,
                 NumericUpDown7.Value, NumericUpDown8.Value, NumericUpDown9.Value, NumericUpDown10.Value, NumericUpDown11.Value, NumericUpDown12.Value, NumericUpDown13.Value,
                 NumericUpDown14.Value, NumericUpDown15.Value, NumericUpDown16.Value)
    End Sub



    Sub generate_led_box()
        Dim led1 As Byte
        Dim led2 As Byte
        Dim led3 As Byte
        Dim led4 As Byte
        Dim led5 As Byte
        Dim led6 As Byte
        Dim led7 As Byte
        Dim led8 As Byte
        Dim led9 As Byte
        Dim led10 As Byte
        Dim led11 As Byte
        Dim led12 As Byte
        Dim led13 As Byte
        Dim led14 As Byte
        Dim led15 As Byte
        Dim led16 As Byte
        If LD1.Checked = True Then : led1 = 255 : Else : led1 = 0 : End If
        If LD2.Checked = True Then : led2 = 255 : Else : led2 = 0 : End If
        If LD3.Checked = True Then : led3 = 255 : Else : led3 = 0 : End If
        If LD4.Checked = True Then : led4 = 255 : Else : led4 = 0 : End If
        If LD5.Checked = True Then : led5 = 255 : Else : led5 = 0 : End If
        If LD6.Checked = True Then : led6 = 255 : Else : led6 = 0 : End If
        If LD7.Checked = True Then : led7 = 255 : Else : led7 = 0 : End If
        If LD8.Checked = True Then : led8 = 255 : Else : led8 = 0 : End If
        If LD9.Checked = True Then : led9 = 255 : Else : led9 = 0 : End If
        If LD10.Checked = True Then : led10 = 255 : Else : led10 = 0 : End If
        If LD11.Checked = True Then : led11 = 255 : Else : led11 = 0 : End If
        If LD12.Checked = True Then : led12 = 255 : Else : led12 = 0 : End If
        If LD13.Checked = True Then : led13 = 255 : Else : led13 = 0 : End If
        If LD14.Checked = True Then : led14 = 255 : Else : led14 = 0 : End If
        If LD15.Checked = True Then : led15 = 255 : Else : led15 = 0 : End If
        If LD16.Checked = True Then : led16 = 255 : Else : led16 = 0 : End If

        TextBox2.Text = SetLeds_DLL.Main.set_led(cmbPorts.SelectedItem.ToString, led1, led2, led3, led4, led5, led6, led7, led8 _
        , led9, led10, led11, led12, led13, led14, led15, led16)
    End Sub



    'Function set_led(ByVal port As String, ByVal led1 As Byte, ByVal led2 As Byte, ByVal led3 As Byte, ByVal led4 As Byte _
    ', ByVal led5 As Byte, ByVal led6 As Byte, ByVal led7 As Byte, ByVal led8 As Byte, ByVal led9 As Byte _
    ', ByVal led10 As Byte, ByVal led11 As Byte, ByVal led12 As Byte, ByVal led13 As Byte, ByVal led14 As Byte _
    ', ByVal led15 As Byte, ByVal led16 As Byte) As String

    '    Dim out_str As String = "$led" & Format(led1, "000") & Format(led2, "000") & Format(led3, "000") & Format(led4, "000") _
    '    & Format(led5, "000") & Format(led6, "000") & Format(led7, "000") & Format(led8, "000") & Format(led9, "000") & Format(led10, "000") _
    '    & Format(led11, "000") & Format(led12, "000") & Format(led13, "000") & Format(led14, "000") & Format(led15, "000") & Format(led16, "000")
    '    Label1.Text = out_str
    '    If Mid(port, 1, 3) = "COM" And Len(port) < 6 Then
    '        Try
    '            SerialPort1.PortName = port
    '            SerialPort1.BaudRate = 38400
    '            SerialPort1.Open()
    '        Catch ex As Exception
    '            set_led = "error, missing port or access denied"
    '        End Try

    '        set_led = "data writing complete"
    '        If SerialPort1.IsOpen Then
    '            SerialPort1.WriteLine(out_str & vbCrLf)

    '        End If
    '    Else
    '        set_led = "error, not valid port"
    '    End If
    '    If SerialPort1.IsOpen Then
    '        SerialPort1.Close()
    '    End If
    'End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown14_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown14.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown15_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown15.ValueChanged
        generate_led_data()
    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        generate_led_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = SetLeds_DLL.Main.set_led(cmbPorts.SelectedItem.ToString, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = SetLeds_DLL.Main.set_led(cmbPorts.SelectedItem.ToString, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
    End Sub

    Private Sub LD1_CheckedChanged(sender As Object, e As EventArgs) Handles LD1.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD2_CheckedChanged(sender As Object, e As EventArgs) Handles LD2.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD3_CheckedChanged(sender As Object, e As EventArgs) Handles LD3.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD4_CheckedChanged(sender As Object, e As EventArgs) Handles LD4.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD5_CheckedChanged(sender As Object, e As EventArgs) Handles LD5.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD6_CheckedChanged(sender As Object, e As EventArgs) Handles LD6.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD7_CheckedChanged(sender As Object, e As EventArgs) Handles LD7.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD8_CheckedChanged(sender As Object, e As EventArgs) Handles LD8.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD9_CheckedChanged(sender As Object, e As EventArgs) Handles LD9.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD10_CheckedChanged(sender As Object, e As EventArgs) Handles LD10.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD11_CheckedChanged(sender As Object, e As EventArgs) Handles LD11.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD12_CheckedChanged(sender As Object, e As EventArgs) Handles LD12.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD13_CheckedChanged(sender As Object, e As EventArgs) Handles LD13.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD14_CheckedChanged(sender As Object, e As EventArgs) Handles LD14.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD15_CheckedChanged(sender As Object, e As EventArgs) Handles LD15.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub LD16_CheckedChanged(sender As Object, e As EventArgs) Handles LD16.CheckedChanged
        generate_led_box()
    End Sub

    Private Sub cmbPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPorts.SelectedIndexChanged
        Dim namearray(255) As String
        Dim elements As Byte
        Try
            Dim searcher As New ManagementObjectSearcher(
           "root\cimv2",
           "SELECT * FROM Win32_SerialPort")

            For Each queryObj As ManagementObject In searcher.Get()
                namearray(elements) = queryObj("Name")



                elements = elements + 1
            Next

            If Len(namearray(cmbPorts.SelectedIndex)) = 0 Then
                namearray(cmbPorts.SelectedIndex) = "Serial port (" & cmbPorts.SelectedValue & ")"

            End If


            Label1.Text = namearray(cmbPorts.SelectedIndex)

        Catch err As ManagementException
            Label1.Text = "error"
        End Try

        StatusStrip1.Text = "No settings file found."

    End Sub
End Class
