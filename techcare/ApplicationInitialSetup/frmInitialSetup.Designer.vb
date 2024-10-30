<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitialSetup
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInitialSetup))
        Me.xamppRestoreFromLocationDialog = New System.Windows.Forms.OpenFileDialog()
        Me.xamppLocationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.step4b = New System.Windows.Forms.Panel()
        Me.btnStep4BPrevious = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbStep4BConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbStep4BPassword = New System.Windows.Forms.TextBox()
        Me.tbStep4BFname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbStep4BTitle = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbStep4BSurname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnStep4BNext = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnStep4aFinish = New System.Windows.Forms.Button()
        Me.step4a = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnStep3Previous = New System.Windows.Forms.Button()
        Me.btnStep3RestoreFromBackup = New System.Windows.Forms.Button()
        Me.btnStep3StartFromScratch = New System.Windows.Forms.Button()
        Me.step3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnStep6Finish = New System.Windows.Forms.Button()
        Me.step1 = New System.Windows.Forms.Panel()
        Me.btnStep1Next = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.step6 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStep2Next = New System.Windows.Forms.Button()
        Me.btnStep2Prev = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbStep2DbPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbStep2DbUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbStep2DbLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.step2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnStep5Next = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbStep5BusRepairTnC = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbStep5BusContact = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbStep5BusAddress = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbStep5BusName = New System.Windows.Forms.TextBox()
        Me.step5 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.step4b.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step4a.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.step6.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.step2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.step5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xamppRestoreFromLocationDialog
        '
        Me.xamppRestoreFromLocationDialog.Filter = "SQL Dump File (*sql)|*.sql|All Files(*.*)|*.*"
        '
        'xamppLocationDialog
        '
        Me.xamppLocationDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.xamppLocationDialog.ShowNewFolderButton = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(596, 28)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Restauración completada!"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'step4b
        '
        Me.step4b.Controls.Add(Me.btnStep4BPrevious)
        Me.step4b.Controls.Add(Me.GroupBox2)
        Me.step4b.Controls.Add(Me.btnStep4BNext)
        Me.step4b.Controls.Add(Me.Label11)
        Me.step4b.Controls.Add(Me.Label12)
        Me.step4b.Controls.Add(Me.PictureBox5)
        Me.step4b.Location = New System.Drawing.Point(362, 281)
        Me.step4b.Name = "step4b"
        Me.step4b.Size = New System.Drawing.Size(620, 437)
        Me.step4b.TabIndex = 15
        Me.step4b.TabStop = True
        Me.step4b.Visible = False
        '
        'btnStep4BPrevious
        '
        Me.btnStep4BPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep4BPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep4BPrevious.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep4BPrevious.Location = New System.Drawing.Point(368, 394)
        Me.btnStep4BPrevious.Name = "btnStep4BPrevious"
        Me.btnStep4BPrevious.Size = New System.Drawing.Size(117, 31)
        Me.btnStep4BPrevious.TabIndex = 7
        Me.btnStep4BPrevious.TabStop = False
        Me.btnStep4BPrevious.Text = "Anterior"
        Me.btnStep4BPrevious.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.tbStep4BConfirmPassword)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tbStep4BPassword)
        Me.GroupBox2.Controls.Add(Me.tbStep4BFname)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.tbStep4BTitle)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.tbStep4BSurname)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(13, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 153)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información personal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 14)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Confirmar contraseña:"
        '
        'tbStep4BConfirmPassword
        '
        Me.tbStep4BConfirmPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep4BConfirmPassword.Location = New System.Drawing.Point(139, 116)
        Me.tbStep4BConfirmPassword.Name = "tbStep4BConfirmPassword"
        Me.tbStep4BConfirmPassword.Size = New System.Drawing.Size(450, 22)
        Me.tbStep4BConfirmPassword.TabIndex = 5
        Me.tbStep4BConfirmPassword.UseSystemPasswordChar = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 14)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Contraseña:"
        '
        'tbStep4BPassword
        '
        Me.tbStep4BPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep4BPassword.Location = New System.Drawing.Point(139, 88)
        Me.tbStep4BPassword.Name = "tbStep4BPassword"
        Me.tbStep4BPassword.Size = New System.Drawing.Size(450, 22)
        Me.tbStep4BPassword.TabIndex = 4
        Me.tbStep4BPassword.UseSystemPasswordChar = True
        '
        'tbStep4BFname
        '
        Me.tbStep4BFname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep4BFname.Location = New System.Drawing.Point(383, 23)
        Me.tbStep4BFname.Name = "tbStep4BFname"
        Me.tbStep4BFname.Size = New System.Drawing.Size(206, 22)
        Me.tbStep4BFname.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(312, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 14)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Nombre:"
        '
        'tbStep4BTitle
        '
        Me.tbStep4BTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep4BTitle.Location = New System.Drawing.Point(81, 23)
        Me.tbStep4BTitle.Name = "tbStep4BTitle"
        Me.tbStep4BTitle.Size = New System.Drawing.Size(206, 22)
        Me.tbStep4BTitle.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 14)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Apellido:"
        '
        'tbStep4BSurname
        '
        Me.tbStep4BSurname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep4BSurname.Location = New System.Drawing.Point(72, 51)
        Me.tbStep4BSurname.Name = "tbStep4BSurname"
        Me.tbStep4BSurname.Size = New System.Drawing.Size(517, 22)
        Me.tbStep4BSurname.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 14)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Pronombre:"
        '
        'btnStep4BNext
        '
        Me.btnStep4BNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep4BNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep4BNext.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep4BNext.Location = New System.Drawing.Point(491, 394)
        Me.btnStep4BNext.Name = "btnStep4BNext"
        Me.btnStep4BNext.Size = New System.Drawing.Size(117, 31)
        Me.btnStep4BNext.TabIndex = 6
        Me.btnStep4BNext.Text = "Siguiente"
        Me.btnStep4BNext.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(596, 106)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(596, 28)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Crea una cuenta de administrador"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox5.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(596, 169)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tu copia anterior se ha importa a Techcare." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Configuración completada. Toca FIN" &
    "ALIZAR, la aplicación se reiniciará y te permitirá iniciar sesión." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0010101"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStep4aFinish
        '
        Me.btnStep4aFinish.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep4aFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep4aFinish.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep4aFinish.Location = New System.Drawing.Point(491, 394)
        Me.btnStep4aFinish.Name = "btnStep4aFinish"
        Me.btnStep4aFinish.Size = New System.Drawing.Size(117, 31)
        Me.btnStep4aFinish.TabIndex = 1
        Me.btnStep4aFinish.Text = "Finalizar"
        Me.btnStep4aFinish.UseVisualStyleBackColor = False
        '
        'step4a
        '
        Me.step4a.Controls.Add(Me.btnStep4aFinish)
        Me.step4a.Controls.Add(Me.Label9)
        Me.step4a.Controls.Add(Me.Label10)
        Me.step4a.Controls.Add(Me.PictureBox4)
        Me.step4a.Location = New System.Drawing.Point(409, 244)
        Me.step4a.Name = "step4a"
        Me.step4a.Size = New System.Drawing.Size(620, 437)
        Me.step4a.TabIndex = 14
        Me.step4a.TabStop = True
        Me.step4a.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox4.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(596, 28)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "¿De que forma querés configurar Techcare?"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(596, 46)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Seleccione una opción:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStep3Previous
        '
        Me.btnStep3Previous.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep3Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep3Previous.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep3Previous.Location = New System.Drawing.Point(491, 394)
        Me.btnStep3Previous.Name = "btnStep3Previous"
        Me.btnStep3Previous.Size = New System.Drawing.Size(117, 31)
        Me.btnStep3Previous.TabIndex = 2
        Me.btnStep3Previous.Text = "Volver"
        Me.btnStep3Previous.UseVisualStyleBackColor = False
        '
        'btnStep3RestoreFromBackup
        '
        Me.btnStep3RestoreFromBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep3RestoreFromBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep3RestoreFromBackup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep3RestoreFromBackup.Location = New System.Drawing.Point(13, 196)
        Me.btnStep3RestoreFromBackup.Name = "btnStep3RestoreFromBackup"
        Me.btnStep3RestoreFromBackup.Size = New System.Drawing.Size(595, 58)
        Me.btnStep3RestoreFromBackup.TabIndex = 3
        Me.btnStep3RestoreFromBackup.TabStop = False
        Me.btnStep3RestoreFromBackup.Text = "Restaurar Techcare desde un backup"
        Me.btnStep3RestoreFromBackup.UseVisualStyleBackColor = False
        '
        'btnStep3StartFromScratch
        '
        Me.btnStep3StartFromScratch.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep3StartFromScratch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep3StartFromScratch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep3StartFromScratch.Location = New System.Drawing.Point(13, 266)
        Me.btnStep3StartFromScratch.Name = "btnStep3StartFromScratch"
        Me.btnStep3StartFromScratch.Size = New System.Drawing.Size(595, 58)
        Me.btnStep3StartFromScratch.TabIndex = 1
        Me.btnStep3StartFromScratch.Text = "Configurar Techcare desde cero"
        Me.btnStep3StartFromScratch.UseVisualStyleBackColor = False
        '
        'step3
        '
        Me.step3.Controls.Add(Me.btnStep3StartFromScratch)
        Me.step3.Controls.Add(Me.btnStep3RestoreFromBackup)
        Me.step3.Controls.Add(Me.btnStep3Previous)
        Me.step3.Controls.Add(Me.Label13)
        Me.step3.Controls.Add(Me.Label14)
        Me.step3.Controls.Add(Me.PictureBox3)
        Me.step3.Location = New System.Drawing.Point(497, 213)
        Me.step3.Name = "step3"
        Me.step3.Size = New System.Drawing.Size(620, 437)
        Me.step3.TabIndex = 2
        Me.step3.TabStop = True
        Me.step3.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox3.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(596, 28)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Configuración completada!"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(596, 132)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "La configuración está completa. Haga clic en Finalizar para finalizar con la conf" &
    "iguración. La aplicación se reiniciará y le pedirá que inicie sesión." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStep6Finish
        '
        Me.btnStep6Finish.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep6Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep6Finish.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep6Finish.Location = New System.Drawing.Point(491, 394)
        Me.btnStep6Finish.Name = "btnStep6Finish"
        Me.btnStep6Finish.Size = New System.Drawing.Size(117, 31)
        Me.btnStep6Finish.TabIndex = 1
        Me.btnStep6Finish.Text = "Finalizar"
        Me.btnStep6Finish.UseVisualStyleBackColor = False
        '
        'step1
        '
        Me.step1.Controls.Add(Me.btnStep1Next)
        Me.step1.Controls.Add(Me.Label2)
        Me.step1.Controls.Add(Me.Label1)
        Me.step1.Controls.Add(Me.PictureBox1)
        Me.step1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.step1.Location = New System.Drawing.Point(209, 388)
        Me.step1.Name = "step1"
        Me.step1.Size = New System.Drawing.Size(624, 441)
        Me.step1.TabIndex = 0
        Me.step1.TabStop = True
        Me.step1.Visible = False
        '
        'btnStep1Next
        '
        Me.btnStep1Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep1Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep1Next.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep1Next.Location = New System.Drawing.Point(475, 380)
        Me.btnStep1Next.Name = "btnStep1Next"
        Me.btnStep1Next.Size = New System.Drawing.Size(117, 31)
        Me.btnStep1Next.TabIndex = 1
        Me.btnStep1Next.Text = "Siguiente"
        Me.btnStep1Next.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(596, 191)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Este asistente te ayudará a configurar Techcare." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asegurate de que este corrien" &
    "do tu servidor XAMPP / MySQL antes de seguir con la configuración." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para conti" &
    "nuar, presiona Siguiente."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(596, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido a Techcare!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'step6
        '
        Me.step6.Controls.Add(Me.btnStep6Finish)
        Me.step6.Controls.Add(Me.Label24)
        Me.step6.Controls.Add(Me.Label27)
        Me.step6.Controls.Add(Me.PictureBox7)
        Me.step6.Location = New System.Drawing.Point(256, 358)
        Me.step6.Name = "step6"
        Me.step6.Size = New System.Drawing.Size(620, 437)
        Me.step6.TabIndex = 17
        Me.step6.TabStop = True
        Me.step6.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox7.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(596, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Configuración de base de datos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(596, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingresar la información requerida para conectarnos a su base de datos."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStep2Next
        '
        Me.btnStep2Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep2Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep2Next.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep2Next.Location = New System.Drawing.Point(491, 394)
        Me.btnStep2Next.Name = "btnStep2Next"
        Me.btnStep2Next.Size = New System.Drawing.Size(117, 31)
        Me.btnStep2Next.TabIndex = 4
        Me.btnStep2Next.Text = "Siguiente"
        Me.btnStep2Next.UseVisualStyleBackColor = False
        '
        'btnStep2Prev
        '
        Me.btnStep2Prev.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep2Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep2Prev.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep2Prev.Location = New System.Drawing.Point(368, 394)
        Me.btnStep2Prev.Name = "btnStep2Prev"
        Me.btnStep2Prev.Size = New System.Drawing.Size(117, 31)
        Me.btnStep2Prev.TabIndex = 5
        Me.btnStep2Prev.Text = "Anterior"
        Me.btnStep2Prev.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbStep2DbPassword)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbStep2DbUsername)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbStep2DbLocation)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 144)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credenciales de conexión a su base de datos"
        '
        'tbStep2DbPassword
        '
        Me.tbStep2DbPassword.AcceptsTab = True
        Me.tbStep2DbPassword.Location = New System.Drawing.Point(150, 102)
        Me.tbStep2DbPassword.Name = "tbStep2DbPassword"
        Me.tbStep2DbPassword.Size = New System.Drawing.Size(439, 26)
        Me.tbStep2DbPassword.TabIndex = 3
        Me.tbStep2DbPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "MySQL Contraseña:"
        '
        'tbStep2DbUsername
        '
        Me.tbStep2DbUsername.AcceptsTab = True
        Me.tbStep2DbUsername.Location = New System.Drawing.Point(150, 70)
        Me.tbStep2DbUsername.Name = "tbStep2DbUsername"
        Me.tbStep2DbUsername.Size = New System.Drawing.Size(439, 26)
        Me.tbStep2DbUsername.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Usuario MySQL:"
        '
        'tbStep2DbLocation
        '
        Me.tbStep2DbLocation.AcceptsTab = True
        Me.tbStep2DbLocation.Location = New System.Drawing.Point(151, 28)
        Me.tbStep2DbLocation.Name = "tbStep2DbLocation"
        Me.tbStep2DbLocation.Size = New System.Drawing.Size(438, 26)
        Me.tbStep2DbLocation.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ubicación:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(596, 46)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Clic a SIGUIENTE para intentar la conexión a la base de datos."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'step2
        '
        Me.step2.Controls.Add(Me.Label6)
        Me.step2.Controls.Add(Me.GroupBox1)
        Me.step2.Controls.Add(Me.btnStep2Prev)
        Me.step2.Controls.Add(Me.btnStep2Next)
        Me.step2.Controls.Add(Me.Label3)
        Me.step2.Controls.Add(Me.Label4)
        Me.step2.Controls.Add(Me.PictureBox2)
        Me.step2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.step2.Location = New System.Drawing.Point(544, 155)
        Me.step2.Name = "step2"
        Me.step2.Size = New System.Drawing.Size(624, 441)
        Me.step2.TabIndex = 1
        Me.step2.TabStop = True
        Me.step2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox2.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(596, 28)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Detalles de tu negocio/empresa:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(596, 54)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Los detalles de tu empresa o negocio se mostrarán en la ventana principal de Tech" &
    "care, los términos y condiciones se mostrarán cuando agregues nuevas reparacione" &
    "s."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStep5Next
        '
        Me.btnStep5Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnStep5Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStep5Next.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep5Next.Location = New System.Drawing.Point(491, 394)
        Me.btnStep5Next.Name = "btnStep5Next"
        Me.btnStep5Next.Size = New System.Drawing.Size(117, 31)
        Me.btnStep5Next.TabIndex = 5
        Me.btnStep5Next.Text = "Siguiente"
        Me.btnStep5Next.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.tbStep5BusRepairTnC)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.tbStep5BusContact)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.tbStep5BusAddress)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.tbStep5BusName)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(595, 202)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de tu negocio"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 14)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Términos y Condiciones:"
        '
        'tbStep5BusRepairTnC
        '
        Me.tbStep5BusRepairTnC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep5BusRepairTnC.Location = New System.Drawing.Point(163, 119)
        Me.tbStep5BusRepairTnC.Multiline = True
        Me.tbStep5BusRepairTnC.Name = "tbStep5BusRepairTnC"
        Me.tbStep5BusRepairTnC.Size = New System.Drawing.Size(426, 76)
        Me.tbStep5BusRepairTnC.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 14)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Número del negocio:"
        '
        'tbStep5BusContact
        '
        Me.tbStep5BusContact.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep5BusContact.Location = New System.Drawing.Point(163, 82)
        Me.tbStep5BusContact.Name = "tbStep5BusContact"
        Me.tbStep5BusContact.Size = New System.Drawing.Size(426, 22)
        Me.tbStep5BusContact.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 14)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Dirección del negocio:"
        '
        'tbStep5BusAddress
        '
        Me.tbStep5BusAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep5BusAddress.Location = New System.Drawing.Point(163, 54)
        Me.tbStep5BusAddress.Name = "tbStep5BusAddress"
        Me.tbStep5BusAddress.Size = New System.Drawing.Size(426, 22)
        Me.tbStep5BusAddress.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 14)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Nombre del negocio:"
        '
        'tbStep5BusName
        '
        Me.tbStep5BusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep5BusName.Location = New System.Drawing.Point(163, 26)
        Me.tbStep5BusName.Name = "tbStep5BusName"
        Me.tbStep5BusName.Size = New System.Drawing.Size(426, 22)
        Me.tbStep5BusName.TabIndex = 1
        '
        'step5
        '
        Me.step5.Controls.Add(Me.GroupBox3)
        Me.step5.Controls.Add(Me.btnStep5Next)
        Me.step5.Controls.Add(Me.Label25)
        Me.step5.Controls.Add(Me.Label26)
        Me.step5.Controls.Add(Me.PictureBox6)
        Me.step5.Location = New System.Drawing.Point(302, 330)
        Me.step5.Name = "step5"
        Me.step5.Size = New System.Drawing.Size(616, 433)
        Me.step5.TabIndex = 16
        Me.step5.TabStop = True
        Me.step5.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.techcare.My.Resources.Resources.croppedLogo
        Me.PictureBox6.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(595, 58)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'frmInitialSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.step6)
        Me.Controls.Add(Me.step5)
        Me.Controls.Add(Me.step4b)
        Me.Controls.Add(Me.step4a)
        Me.Controls.Add(Me.step3)
        Me.Controls.Add(Me.step2)
        Me.Controls.Add(Me.step1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInitialSetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración inicial"
        Me.TopMost = True
        Me.step4b.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step4a.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.step6.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.step2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.step5.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xamppRestoreFromLocationDialog As OpenFileDialog
    Friend WithEvents xamppLocationDialog As FolderBrowserDialog
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents step4b As System.Windows.Forms.Panel
    Friend WithEvents btnStep4BPrevious As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbStep4BConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbStep4BPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbStep4BFname As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbStep4BTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbStep4BSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnStep4BNext As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnStep4aFinish As System.Windows.Forms.Button
    Friend WithEvents step4a As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnStep3Previous As System.Windows.Forms.Button
    Friend WithEvents btnStep3RestoreFromBackup As System.Windows.Forms.Button
    Friend WithEvents btnStep3StartFromScratch As System.Windows.Forms.Button
    Friend WithEvents step3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnStep6Finish As System.Windows.Forms.Button
    Friend WithEvents step1 As System.Windows.Forms.Panel
    Friend WithEvents btnStep1Next As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents step6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStep2Next As System.Windows.Forms.Button
    Friend WithEvents btnStep2Prev As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbStep2DbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbStep2DbUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbStep2DbLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents step2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnStep5Next As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbStep5BusRepairTnC As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbStep5BusContact As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbStep5BusAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbStep5BusName As System.Windows.Forms.TextBox
    Friend WithEvents step5 As System.Windows.Forms.Panel
End Class
