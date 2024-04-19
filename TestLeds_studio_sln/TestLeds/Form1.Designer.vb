<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown11 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown12 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown13 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown14 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown15 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown16 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LD1 = New System.Windows.Forms.CheckBox()
        Me.LD2 = New System.Windows.Forms.CheckBox()
        Me.LD3 = New System.Windows.Forms.CheckBox()
        Me.LD4 = New System.Windows.Forms.CheckBox()
        Me.LD5 = New System.Windows.Forms.CheckBox()
        Me.LD6 = New System.Windows.Forms.CheckBox()
        Me.LD7 = New System.Windows.Forms.CheckBox()
        Me.LD8 = New System.Windows.Forms.CheckBox()
        Me.LD9 = New System.Windows.Forms.CheckBox()
        Me.LD10 = New System.Windows.Forms.CheckBox()
        Me.LD11 = New System.Windows.Forms.CheckBox()
        Me.LD12 = New System.Windows.Forms.CheckBox()
        Me.LD13 = New System.Windows.Forms.CheckBox()
        Me.LD14 = New System.Windows.Forms.CheckBox()
        Me.LD15 = New System.Windows.Forms.CheckBox()
        Me.LD16 = New System.Windows.Forms.CheckBox()
        Me.cmbPorts = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 38400
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open Port"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close Port"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 13)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No data"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 56)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(12, 82)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown2.TabIndex = 6
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(12, 108)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown3.TabIndex = 7
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(12, 134)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown4.TabIndex = 8
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(12, 160)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown5.TabIndex = 9
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(12, 186)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown6.TabIndex = 10
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(12, 212)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown7.TabIndex = 11
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(12, 238)
        Me.NumericUpDown8.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown8.TabIndex = 12
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(72, 56)
        Me.NumericUpDown9.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown9.TabIndex = 13
        '
        'NumericUpDown10
        '
        Me.NumericUpDown10.Location = New System.Drawing.Point(72, 82)
        Me.NumericUpDown10.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown10.Name = "NumericUpDown10"
        Me.NumericUpDown10.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown10.TabIndex = 14
        '
        'NumericUpDown11
        '
        Me.NumericUpDown11.Location = New System.Drawing.Point(72, 108)
        Me.NumericUpDown11.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown11.Name = "NumericUpDown11"
        Me.NumericUpDown11.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown11.TabIndex = 15
        '
        'NumericUpDown12
        '
        Me.NumericUpDown12.Location = New System.Drawing.Point(72, 134)
        Me.NumericUpDown12.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown12.Name = "NumericUpDown12"
        Me.NumericUpDown12.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown12.TabIndex = 16
        '
        'NumericUpDown13
        '
        Me.NumericUpDown13.Location = New System.Drawing.Point(72, 160)
        Me.NumericUpDown13.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown13.Name = "NumericUpDown13"
        Me.NumericUpDown13.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown13.TabIndex = 17
        '
        'NumericUpDown14
        '
        Me.NumericUpDown14.Location = New System.Drawing.Point(72, 186)
        Me.NumericUpDown14.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown14.Name = "NumericUpDown14"
        Me.NumericUpDown14.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown14.TabIndex = 18
        '
        'NumericUpDown15
        '
        Me.NumericUpDown15.Location = New System.Drawing.Point(72, 212)
        Me.NumericUpDown15.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown15.Name = "NumericUpDown15"
        Me.NumericUpDown15.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown15.TabIndex = 19
        '
        'NumericUpDown16
        '
        Me.NumericUpDown16.Location = New System.Drawing.Point(72, 238)
        Me.NumericUpDown16.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown16.Name = "NumericUpDown16"
        Me.NumericUpDown16.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown16.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 264)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 20)
        Me.TextBox2.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(132, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "SetAll"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(132, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "ResetAll"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(292, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(352, 336)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Label2"
        '
        'LD1
        '
        Me.LD1.AutoSize = True
        Me.LD1.Location = New System.Drawing.Point(606, 162)
        Me.LD1.Name = "LD1"
        Me.LD1.Size = New System.Drawing.Size(15, 14)
        Me.LD1.TabIndex = 27
        Me.LD1.UseVisualStyleBackColor = True
        '
        'LD2
        '
        Me.LD2.AutoSize = True
        Me.LD2.Location = New System.Drawing.Point(596, 218)
        Me.LD2.Name = "LD2"
        Me.LD2.Size = New System.Drawing.Size(15, 14)
        Me.LD2.TabIndex = 28
        Me.LD2.UseVisualStyleBackColor = True
        '
        'LD3
        '
        Me.LD3.AutoSize = True
        Me.LD3.Location = New System.Drawing.Point(570, 264)
        Me.LD3.Name = "LD3"
        Me.LD3.Size = New System.Drawing.Size(15, 14)
        Me.LD3.TabIndex = 29
        Me.LD3.UseVisualStyleBackColor = True
        '
        'LD4
        '
        Me.LD4.AutoSize = True
        Me.LD4.Location = New System.Drawing.Point(503, 310)
        Me.LD4.Name = "LD4"
        Me.LD4.Size = New System.Drawing.Size(15, 14)
        Me.LD4.TabIndex = 30
        Me.LD4.UseVisualStyleBackColor = True
        '
        'LD5
        '
        Me.LD5.AutoSize = True
        Me.LD5.Location = New System.Drawing.Point(449, 318)
        Me.LD5.Name = "LD5"
        Me.LD5.Size = New System.Drawing.Size(15, 14)
        Me.LD5.TabIndex = 31
        Me.LD5.UseVisualStyleBackColor = True
        '
        'LD6
        '
        Me.LD6.AutoSize = True
        Me.LD6.Location = New System.Drawing.Point(388, 309)
        Me.LD6.Name = "LD6"
        Me.LD6.Size = New System.Drawing.Size(15, 14)
        Me.LD6.TabIndex = 32
        Me.LD6.UseVisualStyleBackColor = True
        '
        'LD7
        '
        Me.LD7.AutoSize = True
        Me.LD7.Location = New System.Drawing.Point(345, 277)
        Me.LD7.Name = "LD7"
        Me.LD7.Size = New System.Drawing.Size(15, 14)
        Me.LD7.TabIndex = 33
        Me.LD7.UseVisualStyleBackColor = True
        '
        'LD8
        '
        Me.LD8.AutoSize = True
        Me.LD8.Location = New System.Drawing.Point(305, 212)
        Me.LD8.Name = "LD8"
        Me.LD8.Size = New System.Drawing.Size(15, 14)
        Me.LD8.TabIndex = 34
        Me.LD8.UseVisualStyleBackColor = True
        '
        'LD9
        '
        Me.LD9.AutoSize = True
        Me.LD9.Location = New System.Drawing.Point(300, 157)
        Me.LD9.Name = "LD9"
        Me.LD9.Size = New System.Drawing.Size(15, 14)
        Me.LD9.TabIndex = 35
        Me.LD9.UseVisualStyleBackColor = True
        '
        'LD10
        '
        Me.LD10.AutoSize = True
        Me.LD10.Location = New System.Drawing.Point(313, 109)
        Me.LD10.Name = "LD10"
        Me.LD10.Size = New System.Drawing.Size(15, 14)
        Me.LD10.TabIndex = 36
        Me.LD10.UseVisualStyleBackColor = True
        '
        'LD11
        '
        Me.LD11.AutoSize = True
        Me.LD11.Location = New System.Drawing.Point(340, 68)
        Me.LD11.Name = "LD11"
        Me.LD11.Size = New System.Drawing.Size(15, 14)
        Me.LD11.TabIndex = 37
        Me.LD11.UseVisualStyleBackColor = True
        '
        'LD12
        '
        Me.LD12.AutoSize = True
        Me.LD12.Location = New System.Drawing.Point(399, 30)
        Me.LD12.Name = "LD12"
        Me.LD12.Size = New System.Drawing.Size(15, 14)
        Me.LD12.TabIndex = 38
        Me.LD12.UseVisualStyleBackColor = True
        '
        'LD13
        '
        Me.LD13.AutoSize = True
        Me.LD13.Location = New System.Drawing.Point(454, 17)
        Me.LD13.Name = "LD13"
        Me.LD13.Size = New System.Drawing.Size(15, 14)
        Me.LD13.TabIndex = 39
        Me.LD13.UseVisualStyleBackColor = True
        '
        'LD14
        '
        Me.LD14.AutoSize = True
        Me.LD14.Location = New System.Drawing.Point(508, 26)
        Me.LD14.Name = "LD14"
        Me.LD14.Size = New System.Drawing.Size(15, 14)
        Me.LD14.TabIndex = 40
        Me.LD14.UseVisualStyleBackColor = True
        '
        'LD15
        '
        Me.LD15.AutoSize = True
        Me.LD15.Location = New System.Drawing.Point(554, 51)
        Me.LD15.Name = "LD15"
        Me.LD15.Size = New System.Drawing.Size(15, 14)
        Me.LD15.TabIndex = 41
        Me.LD15.UseVisualStyleBackColor = True
        '
        'LD16
        '
        Me.LD16.AutoSize = True
        Me.LD16.Location = New System.Drawing.Point(595, 107)
        Me.LD16.Name = "LD16"
        Me.LD16.Size = New System.Drawing.Size(15, 14)
        Me.LD16.TabIndex = 42
        Me.LD16.UseVisualStyleBackColor = True
        '
        'cmbPorts
        '
        Me.cmbPorts.FormattingEnabled = True
        Me.cmbPorts.Location = New System.Drawing.Point(175, 28)
        Me.cmbPorts.Name = "cmbPorts"
        Me.cmbPorts.Size = New System.Drawing.Size(75, 21)
        Me.cmbPorts.TabIndex = 43
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip1.TabIndex = 44
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 290)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 380)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmbPorts)
        Me.Controls.Add(Me.LD16)
        Me.Controls.Add(Me.LD15)
        Me.Controls.Add(Me.LD14)
        Me.Controls.Add(Me.LD13)
        Me.Controls.Add(Me.LD12)
        Me.Controls.Add(Me.LD11)
        Me.Controls.Add(Me.LD10)
        Me.Controls.Add(Me.LD9)
        Me.Controls.Add(Me.LD8)
        Me.Controls.Add(Me.LD7)
        Me.Controls.Add(Me.LD6)
        Me.Controls.Add(Me.LD5)
        Me.Controls.Add(Me.LD4)
        Me.Controls.Add(Me.LD3)
        Me.Controls.Add(Me.LD2)
        Me.Controls.Add(Me.LD1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NumericUpDown16)
        Me.Controls.Add(Me.NumericUpDown15)
        Me.Controls.Add(Me.NumericUpDown14)
        Me.Controls.Add(Me.NumericUpDown13)
        Me.Controls.Add(Me.NumericUpDown12)
        Me.Controls.Add(Me.NumericUpDown11)
        Me.Controls.Add(Me.NumericUpDown10)
        Me.Controls.Add(Me.NumericUpDown9)
        Me.Controls.Add(Me.NumericUpDown8)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.NumericUpDown6)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents NumericUpDown10 As NumericUpDown
    Friend WithEvents NumericUpDown11 As NumericUpDown
    Friend WithEvents NumericUpDown12 As NumericUpDown
    Friend WithEvents NumericUpDown13 As NumericUpDown
    Friend WithEvents NumericUpDown14 As NumericUpDown
    Friend WithEvents NumericUpDown15 As NumericUpDown
    Friend WithEvents NumericUpDown16 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LD1 As CheckBox
    Friend WithEvents LD2 As CheckBox
    Friend WithEvents LD3 As CheckBox
    Friend WithEvents LD4 As CheckBox
    Friend WithEvents LD5 As CheckBox
    Friend WithEvents LD6 As CheckBox
    Friend WithEvents LD7 As CheckBox
    Friend WithEvents LD8 As CheckBox
    Friend WithEvents LD9 As CheckBox
    Friend WithEvents LD10 As CheckBox
    Friend WithEvents LD11 As CheckBox
    Friend WithEvents LD12 As CheckBox
    Friend WithEvents LD13 As CheckBox
    Friend WithEvents LD14 As CheckBox
    Friend WithEvents LD15 As CheckBox
    Friend WithEvents LD16 As CheckBox
    Friend WithEvents cmbPorts As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextBox1 As TextBox
End Class
