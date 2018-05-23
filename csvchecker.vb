Public Class csvchecker
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
    Friend WithEvents Button_ok As System.Windows.Forms.Button
    Friend WithEvents Button_cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(csvchecker))
        Me.Button_ok = New System.Windows.Forms.Button
        Me.Button_cancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button_ok
        '
        Me.Button_ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button_ok.Location = New System.Drawing.Point(32, 224)
        Me.Button_ok.Name = "Button_ok"
        Me.Button_ok.Size = New System.Drawing.Size(312, 40)
        Me.Button_ok.TabIndex = 0
        Me.Button_ok.Text = "This looks OK - Load this data"
        '
        'Button_cancel
        '
        Me.Button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_cancel.Location = New System.Drawing.Point(408, 224)
        Me.Button_cancel.Name = "Button_cancel"
        Me.Button_cancel.Size = New System.Drawing.Size(296, 40)
        Me.Button_cancel.TabIndex = 1
        Me.Button_cancel.Text = "Don't load this - I need to change the CSV file first"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Below are the first 5 lines from the file you selected. Check that the fields are" & _
        " in the correct columns and that the program has identified any header row."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'csvchecker
        '
        Me.AcceptButton = Me.Button_ok
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button_cancel
        Me.ClientSize = New System.Drawing.Size(760, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_cancel)
        Me.Controls.Add(Me.Button_ok)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "csvchecker"
        Me.Text = "Rowing Timer - Check CSV file"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public mydata(8), mydata1(8), mydata2(8), mydata3(8), mydata4(8), mydata5(8) As String
    Public headerrow As Boolean
    Dim rowlabel(5)
    Dim cell(5, 5) As Label
    Private Sub setuplabels()
        Dim i, x, y As Integer
        For i = 0 To 4
            rowlabel(i) = New Label
            rowlabel(i).width = 36
            rowlabel(i).backcolor = Color.Wheat
            rowlabel(i).Location = New System.Drawing.Point(10, 90 + 26 * i)
            rowlabel(i).text = "line " & (i + 1).ToString
            Me.Controls.Add(rowlabel(i))
        Next
        Dim headings As Label
        For i = 0 To 4
            headings = New Label
            headings.Width = 100
            headings.BackColor = Color.Wheat
            headings.Location = New System.Drawing.Point(50 + 105 * i, 50)
            Select Case i
                Case 0
                    headings.Text = "Bow Number"
                Case 1
                    headings.Text = "Club"
                Case 2
                    headings.Text = "Category"
                Case 3
                    headings.Text = "Stroke"
                Case 4
                    headings.Text = "Handicap (opt.)"
            End Select
            Me.Controls.Add(headings)
        Next
        For y = 0 To 4
            For x = 0 To 4
                cell(x, y) = New Label
                cell(x, y).Width = 100
                cell(x, y).Location = New System.Drawing.Point(50 + 105 * x, 90 + 26 * y)
                cell(x, y).BackColor = Color.WhiteSmoke
                Me.Controls.Add(cell(x, y))
            Next
        Next
        Dim chkbox As New CheckBox
        chkbox.Width = 150
        chkbox.BackColor = Color.WhiteSmoke
        chkbox.Text = "ignore this header row"
        chkbox.Location = New Point(580, 84)
        chkbox.Checked = Me.headerrow
        Me.Controls.Add(chkbox)
        AddHandler chkbox.CheckedChanged, AddressOf checked

    End Sub
    Private Sub checked(ByVal sender As Object, ByVal e As System.EventArgs)
        headerrow = sender.checked
    End Sub

    Private Sub displaydata()
        Dim col As Integer
        For col = 0 To 4
            cell(col, 0).Text = mydata(col)
            cell(col, 1).Text = mydata1(col)
            cell(col, 2).Text = mydata2(col)
            cell(col, 3).Text = mydata3(col)
            cell(col, 4).Text = mydata4(col)
        Next
    End Sub

    Private Sub on_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setuplabels()
        displaydata()
    End Sub
End Class
