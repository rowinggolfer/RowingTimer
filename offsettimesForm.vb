Public Class offsettimesForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents mycancelButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hours_updown As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutes_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents seconds_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents hundredths_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents earlierRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents laterRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(offsettimesForm))
        Me.hours_updown = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.minutes_UpDown = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.seconds_UpDown = New System.Windows.Forms.NumericUpDown
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.mycancelButton = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.hundredths_UpDown = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.earlierRadioButton = New System.Windows.Forms.RadioButton
        Me.laterRadioButton = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.hours_updown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutes_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seconds_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hundredths_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hours_updown
        '
        Me.hours_updown.Location = New System.Drawing.Point(40, 224)
        Me.hours_updown.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.hours_updown.Name = "hours_updown"
        Me.hours_updown.Size = New System.Drawing.Size(48, 20)
        Me.hours_updown.TabIndex = 6
        Me.hours_updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hours"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(96, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Minutes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutes_UpDown
        '
        Me.minutes_UpDown.Location = New System.Drawing.Point(104, 224)
        Me.minutes_UpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minutes_UpDown.Name = "minutes_UpDown"
        Me.minutes_UpDown.Size = New System.Drawing.Size(48, 20)
        Me.minutes_UpDown.TabIndex = 8
        Me.minutes_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(160, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Seconds"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'seconds_UpDown
        '
        Me.seconds_UpDown.Location = New System.Drawing.Point(168, 224)
        Me.seconds_UpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.seconds_UpDown.Name = "seconds_UpDown"
        Me.seconds_UpDown.Size = New System.Drawing.Size(48, 20)
        Me.seconds_UpDown.TabIndex = 10
        Me.seconds_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(24, 312)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(120, 32)
        Me.ApplyButton.TabIndex = 14
        Me.ApplyButton.Text = "Apply"
        '
        'mycancelButton
        '
        Me.mycancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.mycancelButton.Location = New System.Drawing.Point(176, 312)
        Me.mycancelButton.Name = "mycancelButton"
        Me.mycancelButton.Size = New System.Drawing.Size(120, 32)
        Me.mycancelButton.TabIndex = 15
        Me.mycancelButton.Text = "Cancel"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 80)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "The purpose of this form is to allow for post event synchronisation of clocks.   " & _
        "                                                     (For instance if different " & _
        "devices/PCs were used at different time points, and their clocks show difference" & _
        "s)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(224, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Hundredths"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hundredths_UpDown
        '
        Me.hundredths_UpDown.Location = New System.Drawing.Point(232, 224)
        Me.hundredths_UpDown.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.hundredths_UpDown.Name = "hundredths_UpDown"
        Me.hundredths_UpDown.Size = New System.Drawing.Size(48, 20)
        Me.hundredths_UpDown.TabIndex = 17
        Me.hundredths_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 56)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'earlierRadioButton
        '
        Me.earlierRadioButton.Location = New System.Drawing.Point(48, 280)
        Me.earlierRadioButton.Name = "earlierRadioButton"
        Me.earlierRadioButton.Size = New System.Drawing.Size(248, 24)
        Me.earlierRadioButton.TabIndex = 21
        Me.earlierRadioButton.Text = "Adjust to Earlier times  (ie. clock was fast)"
        '
        'laterRadioButton
        '
        Me.laterRadioButton.Checked = True
        Me.laterRadioButton.Location = New System.Drawing.Point(48, 256)
        Me.laterRadioButton.Name = "laterRadioButton"
        Me.laterRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.laterRadioButton.Size = New System.Drawing.Size(248, 24)
        Me.laterRadioButton.TabIndex = 22
        Me.laterRadioButton.TabStop = True
        Me.laterRadioButton.Text = "Adjust to Later Times (ie. clock was slow)"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Set the values to offset the times by"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'offsettimesForm
        '
        Me.AcceptButton = Me.ApplyButton
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.mycancelButton
        Me.ClientSize = New System.Drawing.Size(328, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.laterRadioButton)
        Me.Controls.Add(Me.earlierRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hundredths_UpDown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mycancelButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.seconds_UpDown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.minutes_UpDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hours_updown)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "offsettimesForm"
        Me.Text = "Offset Times Wizard"
        Me.TopMost = True
        CType(Me.hours_updown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutes_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seconds_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hundredths_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mymainform As Form1 = Form1.ActiveForm
    Public watchstr As String

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mycancelButton.Click
        MyBase.Dispose()
    End Sub

    Private Sub offsettimesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        Try
            Me.hours_updown.Validate()
            Me.minutes_UpDown.Validate()
            Me.seconds_UpDown.Validate()
            Me.hundredths_UpDown.Validate()
    
            Dim offsettime As String
            offsettime &= Me.hours_updown.Value.ToString("00") & ":" & Me.minutes_UpDown.Value.ToString("00") & ":" & Me.seconds_UpDown.Value.ToString("00") & "." & Me.hundredths_UpDown.Value.ToString("00")

            If MsgBox(watchstr & " times will be offset by " & offsettime, MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            If Me.laterRadioButton.Checked = True Then offsettime = "-" & offsettime
            Dim dt As DataTable
            Select Case watchstr
                Case "Start"
                    dt = mymainform.startdataTable
                Case "Split1"
                    dt = mymainform.split1DataTable
                Case "Split2"
                    dt = mymainform.split2DataTable
                Case "Finish"
                    dt = mymainform.finishDataTable
                Case Else
                    MsgBox("Rowing Timer didn't know which watch to apply changes to") : Exit Sub
            End Select

            Dim dr As DataRow
            For Each dr In dt.Rows
                dr.Item("time") = mymainform.timedifferenceproc(dr.Item("time"), offsettime)
            Next
            MsgBox(watchstr & " Times adjusted sucessfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MyBase.Dispose()

    End Sub

    Private Sub offsettimesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = watchstr
    End Sub
End Class
