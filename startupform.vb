Imports System.IO 'for filestream/streamreader class

Public Class startupform
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
        '  Application.ExitThread() done by the other form
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(startupform))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rowing Timer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inverness Rowing Club"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'startupform
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "startupform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rowing Timer - Startup"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
     Public chosenfilepath As String = ""
    Public settingsarray(5) As Boolean
    Dim mainform As Form1

    Private Sub loadini()
        Dim path As String
        path = Application.StartupPath & "\rowingtimer_settings.ini"
        If File.Exists(path) Then
            Try
                'open the file using the streamreader class
                Dim sr As StreamReader = File.OpenText(path)
                Dim input As String
                input = sr.ReadLine
                Do Until input = "<<lastfilesaved>>" Or input Is Nothing
                    input = sr.ReadLine()
                Loop
                input = sr.ReadLine
                Do Until input = "<<options>>" Or input Is Nothing
                    input = sr.ReadLine
                Loop
                Dim i As Integer = 0
                input = sr.ReadLine
                Do Until input = "<</options>>" Or input Is Nothing
                    settingsarray(i) = CBool(input)
                    input = sr.ReadLine
                    i += 1
                Loop
                sr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            settingsarray(0) = True 'this is the detailed button option
            settingsarray(2) = True ' this is the autowinners box.
        End If
         End Sub
    Private Sub startupform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadini()
        mainform = New Form1
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static count As Integer
        count += 1
        If count = 100 Then mainform.Show()
    End Sub
End Class
