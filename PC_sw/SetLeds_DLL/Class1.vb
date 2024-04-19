Imports System.Threading
Imports System
Imports System.Diagnostics

Partial Public NotInheritable Class Main




    Public Shared Function set_led(ByVal port As String, ByVal led1 As Byte, ByVal led2 As Byte, ByVal led3 As Byte, ByVal led4 As Byte _
   , ByVal led5 As Byte, ByVal led6 As Byte, ByVal led7 As Byte, ByVal led8 As Byte, ByVal led9 As Byte _
   , ByVal led10 As Byte, ByVal led11 As Byte, ByVal led12 As Byte, ByVal led13 As Byte, ByVal led14 As Byte _
   , ByVal led15 As Byte, ByVal led16 As Byte) As String
        Dim SerialPort1 = New System.IO.Ports.SerialPort()
        Dim out_str As String = "$led" & Format(led1, "000") & Format(led2, "000") & Format(led3, "000") & Format(led4, "000") _
        & Format(led5, "000") & Format(led6, "000") & Format(led7, "000") & Format(led8, "000") & Format(led9, "000") & Format(led10, "000") _
        & Format(led11, "000") & Format(led12, "000") & Format(led13, "000") & Format(led14, "000") & Format(led15, "000") & Format(led16, "000")

        If Mid(port, 1, 3) = "COM" And Len(port) < 6 Then
            Try
                SerialPort1.PortName = port
                SerialPort1.BaudRate = 38400
                SerialPort1.Open()
            Catch ex As Exception
                set_led = "error, missing port or access denied"
            End Try

            set_led = "data writing complete"
            Try
                SerialPort1.WriteLine(out_str & vbCrLf)
            Catch ex As Exception
                set_led = "error, missing port or access denied"
            End Try
            'If SerialPort1.IsOpen Then
            '    SerialPort1.WriteLine(out_str & vbCrLf)
            '    set_led = "missing serial port"
            'End If
        Else
            set_led = "error, not valid port"
        End If
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Function

End Class