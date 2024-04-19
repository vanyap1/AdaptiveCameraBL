$regfile = "m328pbdef.dat"
$crystal = 8000000
$hwstack = 64
$swstack = 32
$framesize = 80
$baud = 38400



Config Scl = Portc.5
Config Sda = Portc.4
Config Twi = 400000
I2cinit



'Config Pinb.5 = Input

'Ir Alias Pinb.5
'Set Ir




Const Pwmic_all_w = &HD0 : Const Pwmic_all_r = &HCF
Dim X As Byte


Dim S As String * 255 , Ns As Byte , Rs As Byte , Color_tmp As String * 4
Config Serialin = Buffered , Size = 100
Declare Sub Init_pwm()
Declare Sub Getline(s_dan As String)
Declare Sub Flushbuf()
'Flushbuf


'Enable Interrupts

Dim Led(16) As Byte
Dim Tmp As String * 3

'Config Clockdiv = 1
'Config Com1 = Dummy , Synchrone = 0 , Parity = None , Stopbits = 1 , Databits = 8 , Clockpol = 0
'Config Com2 = 19200 , Synchrone = 0 , Parity = None , Stopbits = 1 , Databits = 8 , Clockpol = 0




'Config Watchdog = 4096                                 'reconfig to 4 sec
'Start Watchdog



Call Init_pwm
Dim Count As Byte


Dim Effect1 As Byte
Dim Effect2 As Byte

Dim Y As Byte
Dim Var As Byte
Var = 0

Dim Auto As Byte






do
'reset watchdog


for y = 0 to 255
I2cstart
waitms 5
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte y
   Next
   I2cstop
next



I2cstart
waitms 5
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16 step 2
   I2cwbyte 255
   I2cwbyte 127
   Next
   I2cstop
waitms 500


I2cstart
waitms 5
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16 step 2
   I2cwbyte 127
   I2cwbyte 255
   Next
   I2cstop
waitms 500


for y = 255 to 0 step - 1
I2cstart
waitms 5
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte y
   Next
   I2cstop
next


waitms 500
loop

do


If Ischarwaiting() = 1 Then
Waitms 15
Auto = 10
Getline S
'print s
Flushbuf
If Mid(s , 1 , 4) = "$led" Then
'$led001001001001001001001001001001001001001001001001
    Tmp = Mid(s , 5 , 3)
    Led(1) = Val(tmp)

    Tmp = Mid(s , 8 , 3)
    Led(2) = Val(tmp)

    Tmp = Mid(s , 11 , 3)
    Led(3) = Val(tmp)

    Tmp = Mid(s , 14 , 3)
    Led(4) = Val(tmp)

    Tmp = Mid(s , 17 , 3)
    Led(5) = Val(tmp)

    Tmp = Mid(s , 20 , 3)
    Led(6) = Val(tmp)

    Tmp = Mid(s , 23 , 3)
    Led(7) = Val(tmp)

    Tmp = Mid(s , 26 , 3)
    Led(8) = Val(tmp)

    Tmp = Mid(s , 29 , 3)
    Led(9) = Val(tmp)

    Tmp = Mid(s , 32 , 3)
    Led(10) = Val(tmp)

    Tmp = Mid(s , 35 , 3)
    Led(11) = Val(tmp)

    Tmp = Mid(s , 38 , 3)
    Led(12) = Val(tmp)

    Tmp = Mid(s , 41 , 3)
    Led(13) = Val(tmp)

    Tmp = Mid(s , 44 , 3)
    Led(14) = Val(tmp)

    Tmp = Mid(s , 47 , 3)
    Led(15) = Val(tmp)

    Tmp = Mid(s , 50 , 3)
    Led(16) = Val(tmp)


   I2cstart
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16

   I2cwbyte Led(x)
   Next
   I2cstop

End If


If Mid(s , 1 , 1) = "r" Then
'Print Ir
End If


If Mid(s , 1 , 1) = "t" Then
I2cstart
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte 255
   Next
   I2cstop
print "ON"
End If

If Mid(s , 1 , 1) = "f" Then
I2cstart
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte 0
   Next
   I2cstop
print "OFF"
End If


If Mid(s , 1 , 3) = "$on" Then
   I2cstart
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte 255
   Next
   I2cstop
end if

If Mid(s , 1 , 3) = "$of" Then
   I2cstart
   I2cwbyte Pwmic_all_w
   I2cwbyte &B10100010
   For X = 1 To 16
   I2cwbyte 0
   Next
   I2cstop
end if


End If

Loop




Sub Init_pwm()
I2cstart
I2cwbyte Pwmic_all_w
I2cwbyte &HA5
I2cwbyte &H5A
I2cstop

I2cstart
I2cwbyte Pwmic_all_w
I2cwbyte &B10000000
I2cwbyte &B00000001
I2cwbyte &B00000000
For X = 0 To 15
   I2cwbyte 0
Next
I2cwbyte 255
I2cwbyte 0
For X = 0 To 3
   I2cwbyte &B10101010
Next
I2cstop
End Sub


Sub Getline(s As String)
S = ""
Ns = Inkey()
If Ns <> 10 Then
$timeout = 100
Input S Noecho
If Ns <> 10 Then S = Chr(ns) + S
End If
End Sub

Sub Flushbuf()
Waitms 10
Do
Ns = Inkey()
Loop Until Ns = 0
End Sub