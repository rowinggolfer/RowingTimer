Imports System.IO 'for filestream/streamreader class
Imports System.Windows.Forms


Public Class Form1
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
        If Me.warningLabel.Visible Then
            Dim result As MsgBoxResult
            result = MsgBox("Save The Event before Leaving?", MsgBoxStyle.YesNoCancel)
            If result = MsgBoxResult.Cancel Then Exit Sub
            If result = MsgBoxResult.Yes Then
                If MenuItem_save.Enabled Then
                    MenuItem_save.PerformClick()
                Else
                    MenuItem_saveas.PerformClick()
                End If
                Dispose(True)
                Exit Sub
            End If
        End If
        unregister_f_keys()
        savesettings()
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
        Application.ExitThread()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents ClockLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents startwhistleButton As System.Windows.Forms.Button
    Friend WithEvents finishwhistleButton As System.Windows.Forms.Button
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents split1Button As System.Windows.Forms.Button
    Friend WithEvents split2Button As System.Windows.Forms.Button
    Friend WithEvents finishDataTable As System.Data.DataTable
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents startdataTable As System.Data.DataTable
    Friend WithEvents split1DataTable As System.Data.DataTable
    Friend WithEvents split2DataTable As System.Data.DataTable
    Friend WithEvents resultsDataTable As System.Data.DataTable
    Friend WithEvents warningLabel As System.Windows.Forms.Label
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents handicapTable As System.Data.DataTable
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents headoftheriverDataSet As System.Data.DataSet
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents floatButton As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem_file As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_new As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_open As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_save As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_saveas As System.Windows.Forms.MenuItem
    Friend WithEvents Menuitem_help As System.Windows.Forms.MenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents HelpMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_versionhistory As System.Windows.Forms.MenuItem
    Friend WithEvents HelpProvider2 As System.Windows.Forms.HelpProvider
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DataColumn_1 As System.Data.DataColumn
    Friend WithEvents DataColumn_2 As System.Data.DataColumn
    Friend WithEvents DataColumn_3 As System.Data.DataColumn
    Friend WithEvents DataColumn_4 As System.Data.DataColumn
    Friend WithEvents DataColumn_5 As System.Data.DataColumn
    Friend WithEvents DataColumn_6 As System.Data.DataColumn
    Friend WithEvents DataColumn_7 As System.Data.DataColumn
    Friend WithEvents DataColumn_8 As System.Data.DataColumn
    Friend WithEvents DataColumn_9 As System.Data.DataColumn
    Friend WithEvents DataColumn_10 As System.Data.DataColumn
    Friend WithEvents DataColumn_13 As System.Data.DataColumn
    Friend WithEvents DataColumn_16 As System.Data.DataColumn
    Friend WithEvents DataColumn_17 As System.Data.DataColumn
    Friend WithEvents DataColumn_14 As System.Data.DataColumn
    Friend WithEvents DataColumn_11 As System.Data.DataColumn
    Friend WithEvents DataColumn_12 As System.Data.DataColumn
    Friend WithEvents DataColumn_20 As System.Data.DataColumn
    Friend WithEvents DataColumn_21 As System.Data.DataColumn
    Friend WithEvents DataColumn_19 As System.Data.DataColumn
    Friend WithEvents DataColumn_18 As System.Data.DataColumn
    Friend WithEvents DataColumn_19a As System.Data.DataColumn
    Friend WithEvents DataColumn_19b As System.Data.DataColumn
    Friend WithEvents topLabel1 As System.Windows.Forms.Label
    Friend WithEvents topLabel2 As System.Windows.Forms.Label
    Friend WithEvents topLabel3 As System.Windows.Forms.Label
    Friend WithEvents DataColumn_0 As System.Data.DataColumn
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents Label_data As System.Windows.Forms.Label
    Friend WithEvents eventsetupTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents versionLabel As System.Windows.Forms.Label
    Friend WithEvents distanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents eventlocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents eventsponsorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents eventdivisionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents eventnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents eventDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents batchstartLabel As System.Windows.Forms.Label
    Friend WithEvents crewTabPage As System.Windows.Forms.TabPage
    Friend WithEvents crewDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents startTabPage As System.Windows.Forms.TabPage
    Friend WithEvents startLabel As System.Windows.Forms.Label
    Friend WithEvents tabstartwhistleButton As System.Windows.Forms.Button
    Friend WithEvents startDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents startPanel As System.Windows.Forms.Panel
    Friend WithEvents startlockCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents split1TabPage As System.Windows.Forms.TabPage
    Friend WithEvents split1Label As System.Windows.Forms.Label
    Friend WithEvents tabsplit1whistleButton As System.Windows.Forms.Button
    Friend WithEvents split1lockCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents split1DataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents split1Panel As System.Windows.Forms.Panel
    Friend WithEvents split2TabPage As System.Windows.Forms.TabPage
    Friend WithEvents split2Label As System.Windows.Forms.Label
    Friend WithEvents tabsplit2whistleButton As System.Windows.Forms.Button
    Friend WithEvents split2lockCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents split2DataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents split2Panel As System.Windows.Forms.Panel
    Friend WithEvents finishTabPage As System.Windows.Forms.TabPage
    Friend WithEvents finishLabel As System.Windows.Forms.Label
    Friend WithEvents tabfinishwhistleButton As System.Windows.Forms.Button
    Friend WithEvents finishlockCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents finishPanel As System.Windows.Forms.Panel
    Friend WithEvents finishDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents handicapTabPage As System.Windows.Forms.TabPage
    Friend WithEvents handicaptopLabel As System.Windows.Forms.Label
    Friend WithEvents handicapDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents optionsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox_categories As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_goldmedaloption As System.Windows.Forms.CheckBox
    Friend WithEvents startinbatches_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents startinbatchesCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents defaultsettingsButton As System.Windows.Forms.Button
    Friend WithEvents autowinnercheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents bigbuttonCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents fulleditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents resultsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents colwidthButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clipboardButton As System.Windows.Forms.Button
    Friend WithEvents resultsDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents printingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Panel_choosecols As System.Windows.Forms.Panel
    Friend WithEvents CheckBox_start As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_adjtime As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_winners As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_handtime As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_pos As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Bow As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_cat As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_club As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_hand As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_split1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_pen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_time As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_stroke As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_split2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_col_decide As System.Windows.Forms.CheckBox
    Friend WithEvents cattimeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cluborderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents finishorderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents startorderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents printpagesetupButton As System.Windows.Forms.Button
    Friend WithEvents printpreviewButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents tabpage_html As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents htmlButton As System.Windows.Forms.Button
    Friend WithEvents TabControl As Rowing_Timer.TabControlEx
    Friend WithEvents MenuItem_crew_rotimport As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_crew_importcsv As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_importstart As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_importsplit1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_importsplit2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_importfinish As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_crews_displaypanel As System.Windows.Forms.MenuItem
    Friend WithEvents crewDataTable As System.Data.DataTable
    Friend WithEvents Button_crewcheck As System.Windows.Forms.Button
    Friend WithEvents MenuItem_offset_start As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_offset_split1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_offset_split2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_offset_finish As System.Windows.Forms.MenuItem
    Friend WithEvents Menuitem_backup_start As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ClockLabel = New System.Windows.Forms.Label
        Me.startwhistleButton = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.finishDataTable = New System.Data.DataTable
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.finishwhistleButton = New System.Windows.Forms.Button
        Me.headoftheriverDataSet = New System.Data.DataSet
        Me.startdataTable = New System.Data.DataTable
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.split1DataTable = New System.Data.DataTable
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.split2DataTable = New System.Data.DataTable
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.resultsDataTable = New System.Data.DataTable
        Me.DataColumn_0 = New System.Data.DataColumn
        Me.DataColumn_1 = New System.Data.DataColumn
        Me.DataColumn_2 = New System.Data.DataColumn
        Me.DataColumn_3 = New System.Data.DataColumn
        Me.DataColumn_4 = New System.Data.DataColumn
        Me.DataColumn_5 = New System.Data.DataColumn
        Me.DataColumn_6 = New System.Data.DataColumn
        Me.DataColumn_7 = New System.Data.DataColumn
        Me.DataColumn_8 = New System.Data.DataColumn
        Me.DataColumn_9 = New System.Data.DataColumn
        Me.DataColumn_10 = New System.Data.DataColumn
        Me.DataColumn_11 = New System.Data.DataColumn
        Me.DataColumn_12 = New System.Data.DataColumn
        Me.DataColumn_13 = New System.Data.DataColumn
        Me.DataColumn_14 = New System.Data.DataColumn
        Me.DataColumn_16 = New System.Data.DataColumn
        Me.DataColumn_17 = New System.Data.DataColumn
        Me.DataColumn_18 = New System.Data.DataColumn
        Me.DataColumn_19 = New System.Data.DataColumn
        Me.DataColumn_19a = New System.Data.DataColumn
        Me.DataColumn_19b = New System.Data.DataColumn
        Me.DataColumn_20 = New System.Data.DataColumn
        Me.DataColumn_21 = New System.Data.DataColumn
        Me.crewDataTable = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.handicapTable = New System.Data.DataTable
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.split1Button = New System.Windows.Forms.Button
        Me.split2Button = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.warningLabel = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.floatButton = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem_file = New System.Windows.Forms.MenuItem
        Me.MenuItem_new = New System.Windows.Forms.MenuItem
        Me.MenuItem_open = New System.Windows.Forms.MenuItem
        Me.MenuItem_save = New System.Windows.Forms.MenuItem
        Me.MenuItem_saveas = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem_crew_rotimport = New System.Windows.Forms.MenuItem
        Me.MenuItem_crew_importcsv = New System.Windows.Forms.MenuItem
        Me.MenuItem_crews_displaypanel = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem_importstart = New System.Windows.Forms.MenuItem
        Me.MenuItem_offset_start = New System.Windows.Forms.MenuItem
        Me.Menuitem_backup_start = New System.Windows.Forms.MenuItem
        Me.MenuItem_importsplit1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem_offset_split1 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem_importsplit2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem_offset_split2 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem_importfinish = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem_offset_finish = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.Menuitem_help = New System.Windows.Forms.MenuItem
        Me.HelpMenuItem = New System.Windows.Forms.MenuItem
        Me.MenuItem_versionhistory = New System.Windows.Forms.MenuItem
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.topLabel1 = New System.Windows.Forms.Label
        Me.topLabel2 = New System.Windows.Forms.Label
        Me.topLabel3 = New System.Windows.Forms.Label
        Me.Label_data = New System.Windows.Forms.Label
        Me.eventsetupTabPage = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.versionLabel = New System.Windows.Forms.Label
        Me.distanceTextBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.eventlocationTextBox = New System.Windows.Forms.TextBox
        Me.eventsponsorTextBox = New System.Windows.Forms.TextBox
        Me.eventdivisionTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.eventnameTextBox = New System.Windows.Forms.TextBox
        Me.eventDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.batchstartLabel = New System.Windows.Forms.Label
        Me.crewTabPage = New System.Windows.Forms.TabPage
        Me.Button_crewcheck = New System.Windows.Forms.Button
        Me.crewDataGrid = New System.Windows.Forms.DataGrid
        Me.startTabPage = New System.Windows.Forms.TabPage
        Me.startLabel = New System.Windows.Forms.Label
        Me.tabstartwhistleButton = New System.Windows.Forms.Button
        Me.startDataGrid = New System.Windows.Forms.DataGrid
        Me.startPanel = New System.Windows.Forms.Panel
        Me.startlockCheckBox = New System.Windows.Forms.CheckBox
        Me.split1TabPage = New System.Windows.Forms.TabPage
        Me.split1Label = New System.Windows.Forms.Label
        Me.tabsplit1whistleButton = New System.Windows.Forms.Button
        Me.split1lockCheckBox = New System.Windows.Forms.CheckBox
        Me.split1DataGrid = New System.Windows.Forms.DataGrid
        Me.split1Panel = New System.Windows.Forms.Panel
        Me.split2TabPage = New System.Windows.Forms.TabPage
        Me.split2Label = New System.Windows.Forms.Label
        Me.tabsplit2whistleButton = New System.Windows.Forms.Button
        Me.split2lockCheckBox = New System.Windows.Forms.CheckBox
        Me.split2DataGrid = New System.Windows.Forms.DataGrid
        Me.split2Panel = New System.Windows.Forms.Panel
        Me.finishTabPage = New System.Windows.Forms.TabPage
        Me.finishLabel = New System.Windows.Forms.Label
        Me.tabfinishwhistleButton = New System.Windows.Forms.Button
        Me.finishlockCheckBox = New System.Windows.Forms.CheckBox
        Me.finishPanel = New System.Windows.Forms.Panel
        Me.finishDataGrid = New System.Windows.Forms.DataGrid
        Me.handicapTabPage = New System.Windows.Forms.TabPage
        Me.handicaptopLabel = New System.Windows.Forms.Label
        Me.handicapDataGrid = New System.Windows.Forms.DataGrid
        Me.optionsTabPage = New System.Windows.Forms.TabPage
        Me.CheckBox_categories = New System.Windows.Forms.CheckBox
        Me.CheckBox_goldmedaloption = New System.Windows.Forms.CheckBox
        Me.startinbatches_NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.startinbatchesCheckbox = New System.Windows.Forms.CheckBox
        Me.defaultsettingsButton = New System.Windows.Forms.Button
        Me.autowinnercheckbox = New System.Windows.Forms.CheckBox
        Me.bigbuttonCheckBox = New System.Windows.Forms.CheckBox
        Me.fulleditCheckBox = New System.Windows.Forms.CheckBox
        Me.resultsTabPage = New System.Windows.Forms.TabPage
        Me.colwidthButton = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.clipboardButton = New System.Windows.Forms.Button
        Me.resultsDataGrid = New System.Windows.Forms.DataGrid
        Me.printingTabPage = New System.Windows.Forms.TabPage
        Me.Panel_choosecols = New System.Windows.Forms.Panel
        Me.CheckBox_start = New System.Windows.Forms.CheckBox
        Me.CheckBox_adjtime = New System.Windows.Forms.CheckBox
        Me.CheckBox_winners = New System.Windows.Forms.CheckBox
        Me.CheckBox_handtime = New System.Windows.Forms.CheckBox
        Me.CheckBox_pos = New System.Windows.Forms.CheckBox
        Me.CheckBox_Bow = New System.Windows.Forms.CheckBox
        Me.CheckBox_cat = New System.Windows.Forms.CheckBox
        Me.CheckBox_club = New System.Windows.Forms.CheckBox
        Me.CheckBox_hand = New System.Windows.Forms.CheckBox
        Me.CheckBox_split1 = New System.Windows.Forms.CheckBox
        Me.CheckBox_pen = New System.Windows.Forms.CheckBox
        Me.CheckBox_time = New System.Windows.Forms.CheckBox
        Me.CheckBox_stroke = New System.Windows.Forms.CheckBox
        Me.CheckBox_split2 = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CheckBox_col_decide = New System.Windows.Forms.CheckBox
        Me.cattimeRadioButton = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.cluborderRadioButton = New System.Windows.Forms.RadioButton
        Me.finishorderRadioButton = New System.Windows.Forms.RadioButton
        Me.startorderRadioButton = New System.Windows.Forms.RadioButton
        Me.printpagesetupButton = New System.Windows.Forms.Button
        Me.printpreviewButton = New System.Windows.Forms.Button
        Me.printButton = New System.Windows.Forms.Button
        Me.tabpage_html = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.htmlButton = New System.Windows.Forms.Button
        Me.TabControl = New Rowing_Timer.TabControlEx
        CType(Me.finishDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headoftheriverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startdataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.split1DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.split2DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resultsDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crewDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.handicapTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.eventsetupTabPage.SuspendLayout()
        Me.crewTabPage.SuspendLayout()
        CType(Me.crewDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.startTabPage.SuspendLayout()
        CType(Me.startDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.split1TabPage.SuspendLayout()
        CType(Me.split1DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.split2TabPage.SuspendLayout()
        CType(Me.split2DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.finishTabPage.SuspendLayout()
        CType(Me.finishDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.handicapTabPage.SuspendLayout()
        CType(Me.handicapDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.optionsTabPage.SuspendLayout()
        CType(Me.startinbatches_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.resultsTabPage.SuspendLayout()
        CType(Me.resultsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.printingTabPage.SuspendLayout()
        Me.Panel_choosecols.SuspendLayout()
        Me.tabpage_html.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockLabel
        '
        Me.ClockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockLabel.Location = New System.Drawing.Point(230, 0)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(232, 48)
        Me.ClockLabel.TabIndex = 0
        Me.ClockLabel.Text = "00:00:00"
        Me.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startwhistleButton
        '
        Me.startwhistleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.startwhistleButton.BackColor = System.Drawing.Color.Green
        Me.startwhistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startwhistleButton.ForeColor = System.Drawing.Color.White
        Me.startwhistleButton.Location = New System.Drawing.Point(80, 432)
        Me.startwhistleButton.Name = "startwhistleButton"
        Me.startwhistleButton.Size = New System.Drawing.Size(104, 64)
        Me.startwhistleButton.TabIndex = 1
        Me.startwhistleButton.TabStop = False
        Me.startwhistleButton.Text = "Start Whistle   (F1 key)"
        '
        'Timer1
        '
        '
        'finishDataTable
        '
        Me.finishDataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn6})
        Me.finishDataTable.TableName = "finishTable"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Time"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.AllowDBNull = False
        Me.DataColumn3.ColumnName = "Valid"
        Me.DataColumn3.DataType = GetType(System.Boolean)
        Me.DataColumn3.DefaultValue = True
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Bow Number"
        Me.DataColumn4.DefaultValue = ""
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Comments"
        Me.DataColumn6.ColumnName = "Comments"
        Me.DataColumn6.DefaultValue = ""
        '
        'finishwhistleButton
        '
        Me.finishwhistleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.finishwhistleButton.BackColor = System.Drawing.Color.Red
        Me.finishwhistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishwhistleButton.ForeColor = System.Drawing.Color.White
        Me.finishwhistleButton.Location = New System.Drawing.Point(512, 432)
        Me.finishwhistleButton.Name = "finishwhistleButton"
        Me.finishwhistleButton.Size = New System.Drawing.Size(104, 64)
        Me.finishwhistleButton.TabIndex = 4
        Me.finishwhistleButton.TabStop = False
        Me.finishwhistleButton.Text = "Finish Whistle   (F4 key)"
        '
        'headoftheriverDataSet
        '
        Me.headoftheriverDataSet.DataSetName = "NewDataSet"
        Me.headoftheriverDataSet.Locale = New System.Globalization.CultureInfo("en-GB")
        Me.headoftheriverDataSet.Tables.AddRange(New System.Data.DataTable() {Me.finishDataTable, Me.startdataTable, Me.split1DataTable, Me.split2DataTable, Me.resultsDataTable, Me.crewDataTable, Me.handicapTable})
        '
        'startdataTable
        '
        Me.startdataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn19})
        Me.startdataTable.TableName = "startTable"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Time"
        Me.DataColumn15.DefaultValue = ""
        '
        'DataColumn16
        '
        Me.DataColumn16.AllowDBNull = False
        Me.DataColumn16.ColumnName = "Valid"
        Me.DataColumn16.DataType = GetType(System.Boolean)
        Me.DataColumn16.DefaultValue = True
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Bow Number"
        Me.DataColumn17.DefaultValue = ""
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Comments"
        Me.DataColumn19.DefaultValue = ""
        '
        'split1DataTable
        '
        Me.split1DataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn34})
        Me.split1DataTable.TableName = "split1Table"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Time"
        Me.DataColumn30.DefaultValue = ""
        '
        'DataColumn31
        '
        Me.DataColumn31.AllowDBNull = False
        Me.DataColumn31.ColumnName = "Valid"
        Me.DataColumn31.DataType = GetType(System.Boolean)
        Me.DataColumn31.DefaultValue = True
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Bow Number"
        Me.DataColumn32.DefaultValue = ""
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Comments"
        Me.DataColumn34.DefaultValue = ""
        '
        'split2DataTable
        '
        Me.split2DataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn40})
        Me.split2DataTable.TableName = "split2Table"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Time"
        Me.DataColumn36.DefaultValue = ""
        '
        'DataColumn37
        '
        Me.DataColumn37.AllowDBNull = False
        Me.DataColumn37.ColumnName = "Valid"
        Me.DataColumn37.DataType = GetType(System.Boolean)
        Me.DataColumn37.DefaultValue = True
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Bow Number"
        Me.DataColumn38.DefaultValue = ""
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Comments"
        Me.DataColumn40.DefaultValue = ""
        '
        'resultsDataTable
        '
        Me.resultsDataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn_0, Me.DataColumn_1, Me.DataColumn_2, Me.DataColumn_3, Me.DataColumn_4, Me.DataColumn_5, Me.DataColumn_6, Me.DataColumn_7, Me.DataColumn_8, Me.DataColumn_9, Me.DataColumn_10, Me.DataColumn_11, Me.DataColumn_12, Me.DataColumn_13, Me.DataColumn_14, Me.DataColumn_16, Me.DataColumn_17, Me.DataColumn_18, Me.DataColumn_19, Me.DataColumn_19a, Me.DataColumn_19b, Me.DataColumn_20, Me.DataColumn_21})
        Me.resultsDataTable.TableName = "resultsTable"
        '
        'DataColumn_0
        '
        Me.DataColumn_0.ColumnName = "position"
        Me.DataColumn_0.DefaultValue = ""
        '
        'DataColumn_1
        '
        Me.DataColumn_1.ColumnName = "Bow Number"
        Me.DataColumn_1.DataType = GetType(System.Int32)
        '
        'DataColumn_2
        '
        Me.DataColumn_2.ColumnName = "Club"
        Me.DataColumn_2.DefaultValue = ""
        '
        'DataColumn_3
        '
        Me.DataColumn_3.ColumnName = "Category"
        Me.DataColumn_3.DefaultValue = ""
        '
        'DataColumn_4
        '
        Me.DataColumn_4.ColumnName = "Stroke"
        Me.DataColumn_4.DefaultValue = ""
        '
        'DataColumn_5
        '
        Me.DataColumn_5.ColumnName = "Time Started"
        Me.DataColumn_5.DefaultValue = ""
        '
        'DataColumn_6
        '
        Me.DataColumn_6.ColumnName = "Split 1"
        Me.DataColumn_6.DefaultValue = ""
        '
        'DataColumn_7
        '
        Me.DataColumn_7.ColumnName = "Split 2"
        Me.DataColumn_7.DefaultValue = ""
        '
        'DataColumn_8
        '
        Me.DataColumn_8.ColumnName = "Time"
        Me.DataColumn_8.DefaultValue = ""
        '
        'DataColumn_9
        '
        Me.DataColumn_9.ColumnName = "Pen"
        Me.DataColumn_9.DefaultValue = ""
        '
        'DataColumn_10
        '
        Me.DataColumn_10.ColumnName = "Adj Time"
        Me.DataColumn_10.DefaultValue = ""
        '
        'DataColumn_11
        '
        Me.DataColumn_11.ColumnName = "Hcp"
        Me.DataColumn_11.DefaultValue = ""
        '
        'DataColumn_12
        '
        Me.DataColumn_12.ColumnName = "Hcp Time"
        Me.DataColumn_12.DefaultValue = ""
        '
        'DataColumn_13
        '
        Me.DataColumn_13.ColumnName = "Winners"
        Me.DataColumn_13.DefaultValue = ""
        '
        'DataColumn_14
        '
        Me.DataColumn_14.ColumnName = "autowinner"
        Me.DataColumn_14.DefaultValue = ""
        '
        'DataColumn_16
        '
        Me.DataColumn_16.ColumnName = "adjpos_sort"
        Me.DataColumn_16.DataType = GetType(System.Int32)
        Me.DataColumn_16.DefaultValue = 0
        '
        'DataColumn_17
        '
        Me.DataColumn_17.ColumnName = "cat_sort"
        Me.DataColumn_17.DataType = GetType(System.Int32)
        Me.DataColumn_17.DefaultValue = 0
        '
        'DataColumn_18
        '
        Me.DataColumn_18.ColumnName = "cat_pos_sort"
        Me.DataColumn_18.DataType = GetType(System.Int32)
        Me.DataColumn_18.DefaultValue = 0
        '
        'DataColumn_19
        '
        Me.DataColumn_19.ColumnName = "club_sort"
        Me.DataColumn_19.DataType = GetType(System.Int32)
        Me.DataColumn_19.DefaultValue = 0
        '
        'DataColumn_19a
        '
        Me.DataColumn_19a.ColumnName = "club_pos_sort"
        Me.DataColumn_19a.DataType = GetType(System.Int32)
        Me.DataColumn_19a.DefaultValue = 0
        '
        'DataColumn_19b
        '
        Me.DataColumn_19b.Caption = "boat_type"
        Me.DataColumn_19b.ColumnName = "boat_type"
        Me.DataColumn_19b.DataType = GetType(System.Int32)
        Me.DataColumn_19b.DefaultValue = 0
        '
        'DataColumn_20
        '
        Me.DataColumn_20.ColumnName = "boat_pos_sort"
        Me.DataColumn_20.DataType = GetType(System.Int32)
        Me.DataColumn_20.DefaultValue = 0
        '
        'DataColumn_21
        '
        Me.DataColumn_21.ColumnName = "pos hcp"
        Me.DataColumn_21.DataType = GetType(System.Int32)
        Me.DataColumn_21.DefaultValue = 0
        '
        'crewDataTable
        '
        Me.crewDataTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn23, Me.DataColumn25, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn46, Me.DataColumn47})
        Me.crewDataTable.TableName = "crewTable"
        '
        'DataColumn20
        '
        Me.DataColumn20.AllowDBNull = False
        Me.DataColumn20.ColumnName = "Bow Number"
        Me.DataColumn20.DataType = GetType(System.Int16)
        Me.DataColumn20.DefaultValue = CType(0, Short)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Club"
        Me.DataColumn21.DefaultValue = ""
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Category"
        Me.DataColumn23.DefaultValue = ""
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Stroke"
        Me.DataColumn25.DefaultValue = ""
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "Handicap"
        Me.DataColumn41.DataType = GetType(System.Int16)
        Me.DataColumn41.DefaultValue = CType(0, Short)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "Penalty"
        Me.DataColumn42.DataType = GetType(System.Int16)
        Me.DataColumn42.DefaultValue = CType(0, Short)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "Scratched"
        Me.DataColumn43.DataType = GetType(System.Boolean)
        Me.DataColumn43.DefaultValue = False
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "DQ"
        Me.DataColumn46.DataType = GetType(System.Boolean)
        Me.DataColumn46.DefaultValue = False
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "Winners"
        Me.DataColumn47.DefaultValue = ""
        '
        'handicapTable
        '
        Me.handicapTable.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn5})
        Me.handicapTable.TableName = "handicapTable"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "Bow Number"
        Me.DataColumn26.DataType = GetType(System.Int64)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Crew Information"
        Me.DataColumn27.DefaultValue = ""
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Handicap (secs)"
        Me.DataColumn28.DataType = GetType(System.Int32)
        Me.DataColumn28.DefaultValue = 0
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Handicap (mm:ss)"
        Me.DataColumn5.ColumnName = "Handicap (mm:ss)"
        '
        'split1Button
        '
        Me.split1Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.split1Button.BackColor = System.Drawing.Color.MidnightBlue
        Me.split1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.split1Button.ForeColor = System.Drawing.Color.White
        Me.split1Button.Location = New System.Drawing.Point(224, 432)
        Me.split1Button.Name = "split1Button"
        Me.split1Button.Size = New System.Drawing.Size(104, 64)
        Me.split1Button.TabIndex = 5
        Me.split1Button.TabStop = False
        Me.split1Button.Text = "Split 1 Whistle   (F2 key)"
        '
        'split2Button
        '
        Me.split2Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.split2Button.BackColor = System.Drawing.Color.Purple
        Me.split2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.split2Button.ForeColor = System.Drawing.Color.White
        Me.split2Button.Location = New System.Drawing.Point(368, 432)
        Me.split2Button.Name = "split2Button"
        Me.split2Button.Size = New System.Drawing.Size(104, 64)
        Me.split2Button.TabIndex = 6
        Me.split2Button.TabStop = False
        Me.split2Button.Text = "Split 2 Whistle   (F3 key)"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "Application.StartupPath & ""\files\"""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "Application.StartupPath & ""\examples\"""
        '
        'warningLabel
        '
        Me.warningLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.warningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warningLabel.ForeColor = System.Drawing.Color.Red
        Me.warningLabel.Location = New System.Drawing.Point(16, 8)
        Me.warningLabel.Name = "warningLabel"
        Me.warningLabel.Size = New System.Drawing.Size(152, 16)
        Me.warningLabel.TabIndex = 12
        Me.warningLabel.Text = "You have unsaved Data!"
        Me.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.warningLabel.Visible = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "results"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(309, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ""
        '
        'floatButton
        '
        Me.floatButton.Enabled = False
        Me.floatButton.Location = New System.Drawing.Point(552, 16)
        Me.floatButton.Name = "floatButton"
        Me.floatButton.Size = New System.Drawing.Size(56, 23)
        Me.floatButton.TabIndex = 16
        Me.floatButton.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_file, Me.MenuItem1, Me.MenuItem3, Me.MenuItem2, Me.MenuItem_importsplit1, Me.MenuItem_importsplit2, Me.MenuItem_importfinish, Me.Menuitem_help})
        '
        'MenuItem_file
        '
        Me.MenuItem_file.Index = 0
        Me.MenuItem_file.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_new, Me.MenuItem_open, Me.MenuItem_save, Me.MenuItem_saveas})
        Me.MenuItem_file.Text = "&File"
        '
        'MenuItem_new
        '
        Me.MenuItem_new.Index = 0
        Me.MenuItem_new.Text = "&New"
        '
        'MenuItem_open
        '
        Me.MenuItem_open.Index = 1
        Me.MenuItem_open.Text = "&Open"
        '
        'MenuItem_save
        '
        Me.MenuItem_save.Index = 2
        Me.MenuItem_save.Text = "&Save"
        '
        'MenuItem_saveas
        '
        Me.MenuItem_saveas.Index = 3
        Me.MenuItem_saveas.Text = "Save &As"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12})
        Me.MenuItem1.Text = "&Setup"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "&Import setup data from ROT file"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_crew_rotimport, Me.MenuItem_crew_importcsv, Me.MenuItem_crews_displaypanel})
        Me.MenuItem3.Text = "&Crews"
        '
        'MenuItem_crew_rotimport
        '
        Me.MenuItem_crew_rotimport.Index = 0
        Me.MenuItem_crew_rotimport.Text = "&Import crews from  ROT file"
        '
        'MenuItem_crew_importcsv
        '
        Me.MenuItem_crew_importcsv.Index = 1
        Me.MenuItem_crew_importcsv.Text = "Import crews from CS&V file"
        '
        'MenuItem_crews_displaypanel
        '
        Me.MenuItem_crews_displaypanel.Index = 2
        Me.MenuItem_crews_displaypanel.Text = "Crew &Wizard"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem_importstart, Me.MenuItem_offset_start, Me.Menuitem_backup_start})
        Me.MenuItem2.Text = "&Start"
        '
        'MenuItem_importstart
        '
        Me.MenuItem_importstart.Index = 0
        Me.MenuItem_importstart.Text = "&Import Start Data from ROT file"
        '
        'MenuItem_offset_start
        '
        Me.MenuItem_offset_start.Index = 1
        Me.MenuItem_offset_start.Text = "Apply &Offset Times Wizard"
        '
        'Menuitem_backup_start
        '
        Me.Menuitem_backup_start.Index = 2
        Me.Menuitem_backup_start.Text = "&Manually Enter Start times"
        '
        'MenuItem_importsplit1
        '
        Me.MenuItem_importsplit1.Index = 4
        Me.MenuItem_importsplit1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem_offset_split1, Me.MenuItem7})
        Me.MenuItem_importsplit1.Text = "Split&1"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&Import Split1 Data from ROT file"
        '
        'MenuItem_offset_split1
        '
        Me.MenuItem_offset_split1.Index = 1
        Me.MenuItem_offset_split1.Text = "Apply &Offset Times Wizard"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "&Manually Enter Split1 Times"
        '
        'MenuItem_importsplit2
        '
        Me.MenuItem_importsplit2.Index = 5
        Me.MenuItem_importsplit2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem_offset_split2, Me.MenuItem8})
        Me.MenuItem_importsplit2.Text = "Split&2"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "&Import Split2 Data from ROT file"
        '
        'MenuItem_offset_split2
        '
        Me.MenuItem_offset_split2.Index = 1
        Me.MenuItem_offset_split2.Text = "Apply &Offset Times Wizard"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "&Manually Enter Split2 Times"
        '
        'MenuItem_importfinish
        '
        Me.MenuItem_importfinish.Index = 6
        Me.MenuItem_importfinish.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem_offset_finish, Me.MenuItem9})
        Me.MenuItem_importfinish.Text = "&Finish"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "&Import Finish Data from ROT file"
        '
        'MenuItem_offset_finish
        '
        Me.MenuItem_offset_finish.Index = 1
        Me.MenuItem_offset_finish.Text = "Apply &Offset Times Wizard"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Text = "&Manually Enter Finish Times"
        '
        'Menuitem_help
        '
        Me.Menuitem_help.Index = 7
        Me.Menuitem_help.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HelpMenuItem, Me.MenuItem_versionhistory})
        Me.Menuitem_help.Text = "&About"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.Index = 0
        Me.HelpMenuItem.Text = "&Help (opens in a web browser)"
        '
        'MenuItem_versionhistory
        '
        Me.MenuItem_versionhistory.Index = 1
        Me.MenuItem_versionhistory.Text = "&Version History"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'topLabel1
        '
        Me.topLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.topLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel1.Location = New System.Drawing.Point(16, 56)
        Me.topLabel1.Name = "topLabel1"
        Me.topLabel1.Size = New System.Drawing.Size(240, 23)
        Me.topLabel1.TabIndex = 17
        Me.topLabel1.Text = "(------------------Data Entry Tabs-----------------)"
        Me.topLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'topLabel2
        '
        Me.topLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.topLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel2.Location = New System.Drawing.Point(256, 56)
        Me.topLabel2.Name = "topLabel2"
        Me.topLabel2.Size = New System.Drawing.Size(136, 23)
        Me.topLabel2.TabIndex = 18
        Me.topLabel2.Text = "(-----Manipulate Data-----)"
        Me.topLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'topLabel3
        '
        Me.topLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.topLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLabel3.Location = New System.Drawing.Point(400, 56)
        Me.topLabel3.Name = "topLabel3"
        Me.topLabel3.Size = New System.Drawing.Size(112, 23)
        Me.topLabel3.TabIndex = 19
        Me.topLabel3.Text = "(----Output----)"
        Me.topLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_data
        '
        Me.Label_data.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_data.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label_data.Location = New System.Drawing.Point(16, 32)
        Me.Label_data.Name = "Label_data"
        Me.Label_data.Size = New System.Drawing.Size(152, 16)
        Me.Label_data.TabIndex = 20
        Me.Label_data.Text = "Data contains errors!"
        Me.Label_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_data.Visible = False
        '
        'eventsetupTabPage
        '
        Me.eventsetupTabPage.Controls.Add(Me.PictureBox2)
        Me.eventsetupTabPage.Controls.Add(Me.PictureBox1)
        Me.eventsetupTabPage.Controls.Add(Me.versionLabel)
        Me.eventsetupTabPage.Controls.Add(Me.distanceTextBox)
        Me.eventsetupTabPage.Controls.Add(Me.Label14)
        Me.eventsetupTabPage.Controls.Add(Me.eventlocationTextBox)
        Me.eventsetupTabPage.Controls.Add(Me.eventsponsorTextBox)
        Me.eventsetupTabPage.Controls.Add(Me.eventdivisionTextBox)
        Me.eventsetupTabPage.Controls.Add(Me.Label5)
        Me.eventsetupTabPage.Controls.Add(Me.Label4)
        Me.eventsetupTabPage.Controls.Add(Me.Label3)
        Me.eventsetupTabPage.Controls.Add(Me.Label2)
        Me.eventsetupTabPage.Controls.Add(Me.Label1)
        Me.eventsetupTabPage.Controls.Add(Me.eventnameTextBox)
        Me.eventsetupTabPage.Controls.Add(Me.eventDateTimePicker)
        Me.eventsetupTabPage.Controls.Add(Me.batchstartLabel)
        Me.eventsetupTabPage.Location = New System.Drawing.Point(4, 22)
        Me.eventsetupTabPage.Name = "eventsetupTabPage"
        Me.eventsetupTabPage.Size = New System.Drawing.Size(668, 318)
        Me.eventsetupTabPage.TabIndex = 6
        Me.eventsetupTabPage.Text = "Setup"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(464, 136)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 96)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(464, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 96)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'versionLabel
        '
        Me.versionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.versionLabel.Location = New System.Drawing.Point(536, 272)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(96, 23)
        Me.versionLabel.TabIndex = 17
        '
        'distanceTextBox
        '
        Me.distanceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.distanceTextBox.Location = New System.Drawing.Point(136, 184)
        Me.distanceTextBox.Name = "distanceTextBox"
        Me.distanceTextBox.Size = New System.Drawing.Size(96, 20)
        Me.distanceTextBox.TabIndex = 11
        Me.distanceTextBox.Text = ""
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(32, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Distance"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'eventlocationTextBox
        '
        Me.eventlocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eventlocationTextBox.Location = New System.Drawing.Point(136, 152)
        Me.eventlocationTextBox.Name = "eventlocationTextBox"
        Me.eventlocationTextBox.Size = New System.Drawing.Size(288, 20)
        Me.eventlocationTextBox.TabIndex = 9
        Me.eventlocationTextBox.Text = ""
        '
        'eventsponsorTextBox
        '
        Me.eventsponsorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eventsponsorTextBox.Location = New System.Drawing.Point(136, 120)
        Me.eventsponsorTextBox.Name = "eventsponsorTextBox"
        Me.eventsponsorTextBox.Size = New System.Drawing.Size(288, 20)
        Me.eventsponsorTextBox.TabIndex = 8
        Me.eventsponsorTextBox.Text = ""
        '
        'eventdivisionTextBox
        '
        Me.eventdivisionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eventdivisionTextBox.Location = New System.Drawing.Point(136, 88)
        Me.eventdivisionTextBox.Name = "eventdivisionTextBox"
        Me.eventdivisionTextBox.Size = New System.Drawing.Size(152, 20)
        Me.eventdivisionTextBox.TabIndex = 7
        Me.eventdivisionTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(32, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Location"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(32, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sponsor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Division"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Event Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'eventnameTextBox
        '
        Me.eventnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eventnameTextBox.Location = New System.Drawing.Point(136, 24)
        Me.eventnameTextBox.Name = "eventnameTextBox"
        Me.eventnameTextBox.Size = New System.Drawing.Size(288, 20)
        Me.eventnameTextBox.TabIndex = 1
        Me.eventnameTextBox.Text = ""
        '
        'eventDateTimePicker
        '
        Me.eventDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eventDateTimePicker.Location = New System.Drawing.Point(136, 56)
        Me.eventDateTimePicker.Name = "eventDateTimePicker"
        Me.eventDateTimePicker.Size = New System.Drawing.Size(288, 20)
        Me.eventDateTimePicker.TabIndex = 0
        Me.eventDateTimePicker.Value = New Date(2005, 1, 1, 0, 0, 0, 0)
        '
        'batchstartLabel
        '
        Me.batchstartLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.batchstartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchstartLabel.ForeColor = System.Drawing.Color.Red
        Me.batchstartLabel.Location = New System.Drawing.Point(40, 232)
        Me.batchstartLabel.Name = "batchstartLabel"
        Me.batchstartLabel.Size = New System.Drawing.Size(136, 32)
        Me.batchstartLabel.TabIndex = 17
        Me.batchstartLabel.Text = "Start in Batches of 1"
        Me.batchstartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.batchstartLabel.Visible = False
        '
        'crewTabPage
        '
        Me.crewTabPage.Controls.Add(Me.Button_crewcheck)
        Me.crewTabPage.Controls.Add(Me.crewDataGrid)
        Me.crewTabPage.Location = New System.Drawing.Point(4, 22)
        Me.crewTabPage.Name = "crewTabPage"
        Me.crewTabPage.Size = New System.Drawing.Size(668, 318)
        Me.crewTabPage.TabIndex = 5
        Me.crewTabPage.Text = "Crews"
        '
        'Button_crewcheck
        '
        Me.Button_crewcheck.BackColor = System.Drawing.Color.Wheat
        Me.Button_crewcheck.Location = New System.Drawing.Point(208, 8)
        Me.Button_crewcheck.Name = "Button_crewcheck"
        Me.Button_crewcheck.Size = New System.Drawing.Size(352, 23)
        Me.Button_crewcheck.TabIndex = 2
        Me.Button_crewcheck.Text = "Open Crew Wizard Form - This has a lot of functionality"
        '
        'crewDataGrid
        '
        Me.crewDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crewDataGrid.CaptionVisible = False
        Me.crewDataGrid.DataMember = ""
        Me.crewDataGrid.DataSource = Me.crewDataTable
        Me.crewDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.crewDataGrid.Location = New System.Drawing.Point(0, 32)
        Me.crewDataGrid.Name = "crewDataGrid"
        Me.crewDataGrid.ParentRowsVisible = False
        Me.crewDataGrid.ReadOnly = True
        Me.crewDataGrid.RowHeadersVisible = False
        Me.crewDataGrid.Size = New System.Drawing.Size(664, 288)
        Me.crewDataGrid.TabIndex = 1
        Me.crewDataGrid.Tag = ""
        '
        'startTabPage
        '
        Me.startTabPage.Controls.Add(Me.startLabel)
        Me.startTabPage.Controls.Add(Me.tabstartwhistleButton)
        Me.startTabPage.Controls.Add(Me.startDataGrid)
        Me.startTabPage.Controls.Add(Me.startPanel)
        Me.startTabPage.Controls.Add(Me.startlockCheckBox)
        Me.startTabPage.Location = New System.Drawing.Point(4, 22)
        Me.startTabPage.Name = "startTabPage"
        Me.startTabPage.Size = New System.Drawing.Size(668, 318)
        Me.startTabPage.TabIndex = 0
        Me.startTabPage.Text = "Start"
        '
        'startLabel
        '
        Me.startLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.startLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.startLabel.Location = New System.Drawing.Point(328, 0)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(328, 32)
        Me.startLabel.TabIndex = 18
        Me.startLabel.Text = "Start"
        Me.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabstartwhistleButton
        '
        Me.tabstartwhistleButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabstartwhistleButton.BackColor = System.Drawing.Color.Green
        Me.tabstartwhistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabstartwhistleButton.ForeColor = System.Drawing.Color.White
        Me.tabstartwhistleButton.Location = New System.Drawing.Point(8, 8)
        Me.tabstartwhistleButton.Name = "tabstartwhistleButton"
        Me.tabstartwhistleButton.Size = New System.Drawing.Size(56, 304)
        Me.tabstartwhistleButton.TabIndex = 6
        Me.tabstartwhistleButton.TabStop = False
        Me.tabstartwhistleButton.Text = "Start Whistle"
        '
        'startDataGrid
        '
        Me.startDataGrid.AllowDrop = True
        Me.startDataGrid.AllowSorting = False
        Me.startDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startDataGrid.BackColor = System.Drawing.SystemColors.Control
        Me.startDataGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.startDataGrid.CaptionVisible = False
        Me.startDataGrid.DataMember = ""
        Me.startDataGrid.DataSource = Me.startdataTable
        Me.startDataGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.startDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.startDataGrid.Location = New System.Drawing.Point(72, 8)
        Me.startDataGrid.Name = "startDataGrid"
        Me.startDataGrid.PreferredColumnWidth = 80
        Me.startDataGrid.ReadOnly = True
        Me.startDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.startDataGrid.RowHeaderWidth = 15
        Me.startDataGrid.Size = New System.Drawing.Size(248, 272)
        Me.startDataGrid.TabIndex = 5
        '
        'startPanel
        '
        Me.startPanel.AllowDrop = True
        Me.startPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startPanel.AutoScroll = True
        Me.startPanel.BackColor = System.Drawing.SystemColors.Control
        Me.startPanel.Location = New System.Drawing.Point(328, 32)
        Me.startPanel.Name = "startPanel"
        Me.startPanel.Size = New System.Drawing.Size(332, 272)
        Me.startPanel.TabIndex = 4
        '
        'startlockCheckBox
        '
        Me.startlockCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.startlockCheckBox.Location = New System.Drawing.Point(96, 288)
        Me.startlockCheckBox.Name = "startlockCheckBox"
        Me.startlockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.startlockCheckBox.Size = New System.Drawing.Size(160, 24)
        Me.startlockCheckBox.TabIndex = 16
        Me.startlockCheckBox.Text = "Don't let me leave this tab"
        '
        'split1TabPage
        '
        Me.split1TabPage.Controls.Add(Me.split1Label)
        Me.split1TabPage.Controls.Add(Me.tabsplit1whistleButton)
        Me.split1TabPage.Controls.Add(Me.split1lockCheckBox)
        Me.split1TabPage.Controls.Add(Me.split1DataGrid)
        Me.split1TabPage.Controls.Add(Me.split1Panel)
        Me.split1TabPage.Location = New System.Drawing.Point(4, 22)
        Me.split1TabPage.Name = "split1TabPage"
        Me.split1TabPage.Size = New System.Drawing.Size(668, 318)
        Me.split1TabPage.TabIndex = 2
        Me.split1TabPage.Text = "Split1"
        '
        'split1Label
        '
        Me.split1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.split1Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.split1Label.Location = New System.Drawing.Point(256, 0)
        Me.split1Label.Name = "split1Label"
        Me.split1Label.Size = New System.Drawing.Size(272, 32)
        Me.split1Label.TabIndex = 21
        Me.split1Label.Text = "split 1"
        Me.split1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabsplit1whistleButton
        '
        Me.tabsplit1whistleButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabsplit1whistleButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.tabsplit1whistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabsplit1whistleButton.ForeColor = System.Drawing.Color.White
        Me.tabsplit1whistleButton.Location = New System.Drawing.Point(8, 8)
        Me.tabsplit1whistleButton.Name = "tabsplit1whistleButton"
        Me.tabsplit1whistleButton.Size = New System.Drawing.Size(56, 304)
        Me.tabsplit1whistleButton.TabIndex = 20
        Me.tabsplit1whistleButton.TabStop = False
        Me.tabsplit1whistleButton.Text = "Split 1 Whistle"
        '
        'split1lockCheckBox
        '
        Me.split1lockCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.split1lockCheckBox.Location = New System.Drawing.Point(104, 16)
        Me.split1lockCheckBox.Name = "split1lockCheckBox"
        Me.split1lockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.split1lockCheckBox.Size = New System.Drawing.Size(160, 16)
        Me.split1lockCheckBox.TabIndex = 18
        Me.split1lockCheckBox.Text = "Don't let me leave this tab"
        '
        'split1DataGrid
        '
        Me.split1DataGrid.AllowDrop = True
        Me.split1DataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.split1DataGrid.BackColor = System.Drawing.SystemColors.Control
        Me.split1DataGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.split1DataGrid.CaptionVisible = False
        Me.split1DataGrid.DataMember = ""
        Me.split1DataGrid.DataSource = Me.split1DataTable
        Me.split1DataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.split1DataGrid.Location = New System.Drawing.Point(72, 32)
        Me.split1DataGrid.Name = "split1DataGrid"
        Me.split1DataGrid.PreferredColumnWidth = 80
        Me.split1DataGrid.ReadOnly = True
        Me.split1DataGrid.Size = New System.Drawing.Size(200, 280)
        Me.split1DataGrid.TabIndex = 6
        '
        'split1Panel
        '
        Me.split1Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.split1Panel.AutoScroll = True
        Me.split1Panel.Location = New System.Drawing.Point(280, 40)
        Me.split1Panel.Name = "split1Panel"
        Me.split1Panel.Size = New System.Drawing.Size(380, 216)
        Me.split1Panel.TabIndex = 2
        '
        'split2TabPage
        '
        Me.split2TabPage.Controls.Add(Me.split2Label)
        Me.split2TabPage.Controls.Add(Me.tabsplit2whistleButton)
        Me.split2TabPage.Controls.Add(Me.split2lockCheckBox)
        Me.split2TabPage.Controls.Add(Me.split2DataGrid)
        Me.split2TabPage.Controls.Add(Me.split2Panel)
        Me.split2TabPage.Location = New System.Drawing.Point(4, 22)
        Me.split2TabPage.Name = "split2TabPage"
        Me.split2TabPage.Size = New System.Drawing.Size(668, 318)
        Me.split2TabPage.TabIndex = 3
        Me.split2TabPage.Text = "Split 2"
        '
        'split2Label
        '
        Me.split2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.split2Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.split2Label.Location = New System.Drawing.Point(256, 0)
        Me.split2Label.Name = "split2Label"
        Me.split2Label.Size = New System.Drawing.Size(272, 32)
        Me.split2Label.TabIndex = 21
        Me.split2Label.Text = "split 2"
        Me.split2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabsplit2whistleButton
        '
        Me.tabsplit2whistleButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabsplit2whistleButton.BackColor = System.Drawing.Color.Purple
        Me.tabsplit2whistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabsplit2whistleButton.ForeColor = System.Drawing.Color.White
        Me.tabsplit2whistleButton.Location = New System.Drawing.Point(8, 8)
        Me.tabsplit2whistleButton.Name = "tabsplit2whistleButton"
        Me.tabsplit2whistleButton.Size = New System.Drawing.Size(48, 304)
        Me.tabsplit2whistleButton.TabIndex = 20
        Me.tabsplit2whistleButton.TabStop = False
        Me.tabsplit2whistleButton.Text = "Split 2 Whistle"
        '
        'split2lockCheckBox
        '
        Me.split2lockCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.split2lockCheckBox.Location = New System.Drawing.Point(88, 16)
        Me.split2lockCheckBox.Name = "split2lockCheckBox"
        Me.split2lockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.split2lockCheckBox.Size = New System.Drawing.Size(160, 16)
        Me.split2lockCheckBox.TabIndex = 18
        Me.split2lockCheckBox.Text = "Don't let me leave this tab"
        '
        'split2DataGrid
        '
        Me.split2DataGrid.AllowDrop = True
        Me.split2DataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.split2DataGrid.BackColor = System.Drawing.SystemColors.Control
        Me.split2DataGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.split2DataGrid.CaptionVisible = False
        Me.split2DataGrid.DataMember = ""
        Me.split2DataGrid.DataSource = Me.split2DataTable
        Me.split2DataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.split2DataGrid.Location = New System.Drawing.Point(64, 24)
        Me.split2DataGrid.Name = "split2DataGrid"
        Me.split2DataGrid.PreferredColumnWidth = 80
        Me.split2DataGrid.ReadOnly = True
        Me.split2DataGrid.Size = New System.Drawing.Size(208, 288)
        Me.split2DataGrid.TabIndex = 6
        '
        'split2Panel
        '
        Me.split2Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.split2Panel.AutoScroll = True
        Me.split2Panel.Location = New System.Drawing.Point(280, 40)
        Me.split2Panel.Name = "split2Panel"
        Me.split2Panel.Size = New System.Drawing.Size(364, 192)
        Me.split2Panel.TabIndex = 2
        '
        'finishTabPage
        '
        Me.finishTabPage.Controls.Add(Me.finishLabel)
        Me.finishTabPage.Controls.Add(Me.tabfinishwhistleButton)
        Me.finishTabPage.Controls.Add(Me.finishlockCheckBox)
        Me.finishTabPage.Controls.Add(Me.finishPanel)
        Me.finishTabPage.Controls.Add(Me.finishDataGrid)
        Me.finishTabPage.Location = New System.Drawing.Point(4, 22)
        Me.finishTabPage.Name = "finishTabPage"
        Me.finishTabPage.Size = New System.Drawing.Size(668, 318)
        Me.finishTabPage.TabIndex = 1
        Me.finishTabPage.Text = "Finish"
        '
        'finishLabel
        '
        Me.finishLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.finishLabel.Location = New System.Drawing.Point(256, 0)
        Me.finishLabel.Name = "finishLabel"
        Me.finishLabel.Size = New System.Drawing.Size(272, 32)
        Me.finishLabel.TabIndex = 21
        Me.finishLabel.Text = "finish"
        Me.finishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabfinishwhistleButton
        '
        Me.tabfinishwhistleButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabfinishwhistleButton.BackColor = System.Drawing.Color.Red
        Me.tabfinishwhistleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabfinishwhistleButton.ForeColor = System.Drawing.Color.White
        Me.tabfinishwhistleButton.Location = New System.Drawing.Point(8, 8)
        Me.tabfinishwhistleButton.Name = "tabfinishwhistleButton"
        Me.tabfinishwhistleButton.Size = New System.Drawing.Size(48, 304)
        Me.tabfinishwhistleButton.TabIndex = 20
        Me.tabfinishwhistleButton.TabStop = False
        Me.tabfinishwhistleButton.Text = "Finish Whistle"
        '
        'finishlockCheckBox
        '
        Me.finishlockCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.finishlockCheckBox.Location = New System.Drawing.Point(88, 16)
        Me.finishlockCheckBox.Name = "finishlockCheckBox"
        Me.finishlockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.finishlockCheckBox.Size = New System.Drawing.Size(160, 16)
        Me.finishlockCheckBox.TabIndex = 18
        Me.finishlockCheckBox.Text = "Don't let me leave this tab"
        '
        'finishPanel
        '
        Me.finishPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.finishPanel.AutoScroll = True
        Me.finishPanel.Location = New System.Drawing.Point(272, 40)
        Me.finishPanel.Name = "finishPanel"
        Me.finishPanel.Size = New System.Drawing.Size(380, 192)
        Me.finishPanel.TabIndex = 1
        '
        'finishDataGrid
        '
        Me.finishDataGrid.AllowDrop = True
        Me.finishDataGrid.AllowSorting = False
        Me.finishDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.finishDataGrid.BackColor = System.Drawing.SystemColors.Control
        Me.finishDataGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.finishDataGrid.CaptionVisible = False
        Me.finishDataGrid.DataMember = ""
        Me.finishDataGrid.DataSource = Me.finishDataTable
        Me.finishDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.finishDataGrid.Location = New System.Drawing.Point(64, 32)
        Me.finishDataGrid.Name = "finishDataGrid"
        Me.finishDataGrid.PreferredColumnWidth = 80
        Me.finishDataGrid.ReadOnly = True
        Me.finishDataGrid.Size = New System.Drawing.Size(200, 272)
        Me.finishDataGrid.TabIndex = 0
        '
        'handicapTabPage
        '
        Me.handicapTabPage.Controls.Add(Me.handicaptopLabel)
        Me.handicapTabPage.Controls.Add(Me.handicapDataGrid)
        Me.handicapTabPage.Location = New System.Drawing.Point(4, 22)
        Me.handicapTabPage.Name = "handicapTabPage"
        Me.handicapTabPage.Size = New System.Drawing.Size(668, 318)
        Me.handicapTabPage.TabIndex = 9
        Me.handicapTabPage.Text = "Veterans"
        '
        'handicaptopLabel
        '
        Me.handicaptopLabel.Location = New System.Drawing.Point(8, 8)
        Me.handicaptopLabel.Name = "handicaptopLabel"
        Me.handicaptopLabel.Size = New System.Drawing.Size(496, 56)
        Me.handicaptopLabel.TabIndex = 6
        '
        'handicapDataGrid
        '
        Me.handicapDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.handicapDataGrid.DataMember = ""
        Me.handicapDataGrid.DataSource = Me.handicapTable
        Me.handicapDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.handicapDataGrid.Location = New System.Drawing.Point(8, 72)
        Me.handicapDataGrid.Name = "handicapDataGrid"
        Me.handicapDataGrid.PreferredColumnWidth = 100
        Me.handicapDataGrid.Size = New System.Drawing.Size(652, 240)
        Me.handicapDataGrid.TabIndex = 1
        '
        'optionsTabPage
        '
        Me.optionsTabPage.Controls.Add(Me.CheckBox_categories)
        Me.optionsTabPage.Controls.Add(Me.CheckBox_goldmedaloption)
        Me.optionsTabPage.Controls.Add(Me.startinbatches_NumericUpDown)
        Me.optionsTabPage.Controls.Add(Me.startinbatchesCheckbox)
        Me.optionsTabPage.Controls.Add(Me.defaultsettingsButton)
        Me.optionsTabPage.Controls.Add(Me.autowinnercheckbox)
        Me.optionsTabPage.Controls.Add(Me.bigbuttonCheckBox)
        Me.optionsTabPage.Controls.Add(Me.fulleditCheckBox)
        Me.optionsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.optionsTabPage.Name = "optionsTabPage"
        Me.optionsTabPage.Size = New System.Drawing.Size(668, 318)
        Me.optionsTabPage.TabIndex = 8
        Me.optionsTabPage.Text = "Options"
        '
        'CheckBox_categories
        '
        Me.CheckBox_categories.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_categories.Location = New System.Drawing.Point(96, 112)
        Me.CheckBox_categories.Name = "CheckBox_categories"
        Me.CheckBox_categories.Size = New System.Drawing.Size(464, 32)
        Me.CheckBox_categories.TabIndex = 27
        Me.CheckBox_categories.Text = "Applt Settings from Cat sort wizard"
        '
        'CheckBox_goldmedaloption
        '
        Me.CheckBox_goldmedaloption.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_goldmedaloption.Location = New System.Drawing.Point(96, 80)
        Me.CheckBox_goldmedaloption.Name = "CheckBox_goldmedaloption"
        Me.CheckBox_goldmedaloption.Size = New System.Drawing.Size(464, 32)
        Me.CheckBox_goldmedaloption.TabIndex = 26
        Me.CheckBox_goldmedaloption.Text = "Apply Gold Medal Times Automatically"
        '
        'startinbatches_NumericUpDown
        '
        Me.startinbatches_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.startinbatches_NumericUpDown.Location = New System.Drawing.Point(224, 200)
        Me.startinbatches_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.startinbatches_NumericUpDown.Name = "startinbatches_NumericUpDown"
        Me.startinbatches_NumericUpDown.Size = New System.Drawing.Size(56, 20)
        Me.startinbatches_NumericUpDown.TabIndex = 25
        Me.startinbatches_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'startinbatchesCheckbox
        '
        Me.startinbatchesCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.startinbatchesCheckbox.Location = New System.Drawing.Point(96, 200)
        Me.startinbatchesCheckbox.Name = "startinbatchesCheckbox"
        Me.startinbatchesCheckbox.Size = New System.Drawing.Size(128, 24)
        Me.startinbatchesCheckbox.TabIndex = 24
        Me.startinbatchesCheckbox.Text = "Start in Batches of"
        '
        'defaultsettingsButton
        '
        Me.defaultsettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.defaultsettingsButton.BackColor = System.Drawing.Color.Wheat
        Me.defaultsettingsButton.Location = New System.Drawing.Point(96, 232)
        Me.defaultsettingsButton.Name = "defaultsettingsButton"
        Me.defaultsettingsButton.Size = New System.Drawing.Size(176, 32)
        Me.defaultsettingsButton.TabIndex = 16
        Me.defaultsettingsButton.Text = "Restore Default settings"
        '
        'autowinnercheckbox
        '
        Me.autowinnercheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.autowinnercheckbox.Checked = True
        Me.autowinnercheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autowinnercheckbox.Location = New System.Drawing.Point(94, 32)
        Me.autowinnercheckbox.Name = "autowinnercheckbox"
        Me.autowinnercheckbox.Size = New System.Drawing.Size(464, 40)
        Me.autowinnercheckbox.TabIndex = 15
        Me.autowinnercheckbox.Text = "Use ""autowinner"" to fill ""Winners"" Column.           If this is giving erratic re" & _
        "sults - check for typos and spaces in the category field on your crew tab."
        '
        'bigbuttonCheckBox
        '
        Me.bigbuttonCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bigbuttonCheckBox.Checked = True
        Me.bigbuttonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.bigbuttonCheckBox.Location = New System.Drawing.Point(94, 8)
        Me.bigbuttonCheckBox.Name = "bigbuttonCheckBox"
        Me.bigbuttonCheckBox.Size = New System.Drawing.Size(464, 24)
        Me.bigbuttonCheckBox.TabIndex = 12
        Me.bigbuttonCheckBox.Text = "Detailed Crew Buttons (includes the name of stroke)"
        '
        'fulleditCheckBox
        '
        Me.fulleditCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fulleditCheckBox.Location = New System.Drawing.Point(96, 160)
        Me.fulleditCheckBox.Name = "fulleditCheckBox"
        Me.fulleditCheckBox.Size = New System.Drawing.Size(464, 32)
        Me.fulleditCheckBox.TabIndex = 7
        Me.fulleditCheckBox.Text = "Allow full edit and sort - allows altering of ALL important data cells. Backup yo" & _
        "ur data before using this and use with care - watch formats etc."
        '
        'resultsTabPage
        '
        Me.resultsTabPage.Controls.Add(Me.colwidthButton)
        Me.resultsTabPage.Controls.Add(Me.Label6)
        Me.resultsTabPage.Controls.Add(Me.clipboardButton)
        Me.resultsTabPage.Controls.Add(Me.resultsDataGrid)
        Me.resultsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.resultsTabPage.Name = "resultsTabPage"
        Me.resultsTabPage.Size = New System.Drawing.Size(668, 318)
        Me.resultsTabPage.TabIndex = 7
        Me.resultsTabPage.Text = "Results"
        '
        'colwidthButton
        '
        Me.colwidthButton.BackColor = System.Drawing.Color.Wheat
        Me.colwidthButton.Location = New System.Drawing.Point(8, 8)
        Me.colwidthButton.Name = "colwidthButton"
        Me.colwidthButton.Size = New System.Drawing.Size(112, 23)
        Me.colwidthButton.TabIndex = 14
        Me.colwidthButton.Text = "Auto Adjust widths"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(240, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(416, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clipboardButton
        '
        Me.clipboardButton.BackColor = System.Drawing.Color.Wheat
        Me.clipboardButton.Location = New System.Drawing.Point(128, 8)
        Me.clipboardButton.Name = "clipboardButton"
        Me.clipboardButton.Size = New System.Drawing.Size(112, 24)
        Me.clipboardButton.TabIndex = 12
        Me.clipboardButton.Text = "Copy to Clipboard"
        '
        'resultsDataGrid
        '
        Me.resultsDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resultsDataGrid.DataMember = ""
        Me.resultsDataGrid.DataSource = Me.resultsDataTable
        Me.resultsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.resultsDataGrid.Location = New System.Drawing.Point(0, 36)
        Me.resultsDataGrid.Name = "resultsDataGrid"
        Me.resultsDataGrid.ReadOnly = True
        Me.resultsDataGrid.RowHeadersVisible = False
        Me.resultsDataGrid.Size = New System.Drawing.Size(668, 278)
        Me.resultsDataGrid.TabIndex = 0
        '
        'printingTabPage
        '
        Me.printingTabPage.Controls.Add(Me.Panel_choosecols)
        Me.printingTabPage.Controls.Add(Me.cattimeRadioButton)
        Me.printingTabPage.Controls.Add(Me.Label8)
        Me.printingTabPage.Controls.Add(Me.cluborderRadioButton)
        Me.printingTabPage.Controls.Add(Me.finishorderRadioButton)
        Me.printingTabPage.Controls.Add(Me.startorderRadioButton)
        Me.printingTabPage.Controls.Add(Me.printpagesetupButton)
        Me.printingTabPage.Controls.Add(Me.printpreviewButton)
        Me.printingTabPage.Controls.Add(Me.printButton)
        Me.printingTabPage.Location = New System.Drawing.Point(4, 22)
        Me.printingTabPage.Name = "printingTabPage"
        Me.printingTabPage.Size = New System.Drawing.Size(668, 318)
        Me.printingTabPage.TabIndex = 10
        Me.printingTabPage.Text = "Printing"
        '
        'Panel_choosecols
        '
        Me.Panel_choosecols.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_start)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_adjtime)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_winners)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_handtime)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_pos)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_Bow)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_cat)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_club)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_hand)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_split1)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_pen)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_time)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_stroke)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_split2)
        Me.Panel_choosecols.Controls.Add(Me.Label16)
        Me.Panel_choosecols.Controls.Add(Me.CheckBox_col_decide)
        Me.Panel_choosecols.Location = New System.Drawing.Point(16, 8)
        Me.Panel_choosecols.Name = "Panel_choosecols"
        Me.Panel_choosecols.Size = New System.Drawing.Size(632, 112)
        Me.Panel_choosecols.TabIndex = 40
        '
        'CheckBox_start
        '
        Me.CheckBox_start.Enabled = False
        Me.CheckBox_start.Location = New System.Drawing.Point(128, 56)
        Me.CheckBox_start.Name = "CheckBox_start"
        Me.CheckBox_start.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_start.TabIndex = 26
        Me.CheckBox_start.Text = "Start Time"
        '
        'CheckBox_adjtime
        '
        Me.CheckBox_adjtime.Enabled = False
        Me.CheckBox_adjtime.Location = New System.Drawing.Point(144, 80)
        Me.CheckBox_adjtime.Name = "CheckBox_adjtime"
        Me.CheckBox_adjtime.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox_adjtime.TabIndex = 31
        Me.CheckBox_adjtime.Text = "Time (inc. Penalties)"
        '
        'CheckBox_winners
        '
        Me.CheckBox_winners.Enabled = False
        Me.CheckBox_winners.Location = New System.Drawing.Point(496, 80)
        Me.CheckBox_winners.Name = "CheckBox_winners"
        Me.CheckBox_winners.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_winners.TabIndex = 34
        Me.CheckBox_winners.Text = "Winners"
        '
        'CheckBox_handtime
        '
        Me.CheckBox_handtime.Enabled = False
        Me.CheckBox_handtime.Location = New System.Drawing.Point(368, 80)
        Me.CheckBox_handtime.Name = "CheckBox_handtime"
        Me.CheckBox_handtime.Size = New System.Drawing.Size(120, 24)
        Me.CheckBox_handtime.TabIndex = 33
        Me.CheckBox_handtime.Text = "Handicapped Time"
        '
        'CheckBox_pos
        '
        Me.CheckBox_pos.Enabled = False
        Me.CheckBox_pos.Location = New System.Drawing.Point(104, 32)
        Me.CheckBox_pos.Name = "CheckBox_pos"
        Me.CheckBox_pos.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_pos.TabIndex = 38
        Me.CheckBox_pos.Text = "Position"
        '
        'CheckBox_Bow
        '
        Me.CheckBox_Bow.Enabled = False
        Me.CheckBox_Bow.Location = New System.Drawing.Point(192, 32)
        Me.CheckBox_Bow.Name = "CheckBox_Bow"
        Me.CheckBox_Bow.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_Bow.TabIndex = 20
        Me.CheckBox_Bow.Text = "Bow No."
        '
        'CheckBox_cat
        '
        Me.CheckBox_cat.Enabled = False
        Me.CheckBox_cat.Location = New System.Drawing.Point(352, 32)
        Me.CheckBox_cat.Name = "CheckBox_cat"
        Me.CheckBox_cat.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_cat.TabIndex = 22
        Me.CheckBox_cat.Text = "Category"
        '
        'CheckBox_club
        '
        Me.CheckBox_club.Enabled = False
        Me.CheckBox_club.Location = New System.Drawing.Point(280, 32)
        Me.CheckBox_club.Name = "CheckBox_club"
        Me.CheckBox_club.Size = New System.Drawing.Size(72, 24)
        Me.CheckBox_club.TabIndex = 21
        Me.CheckBox_club.Text = "Club"
        '
        'CheckBox_hand
        '
        Me.CheckBox_hand.Enabled = False
        Me.CheckBox_hand.Location = New System.Drawing.Point(280, 80)
        Me.CheckBox_hand.Name = "CheckBox_hand"
        Me.CheckBox_hand.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_hand.TabIndex = 32
        Me.CheckBox_hand.Text = "Handicaps"
        '
        'CheckBox_split1
        '
        Me.CheckBox_split1.Enabled = False
        Me.CheckBox_split1.Location = New System.Drawing.Point(216, 56)
        Me.CheckBox_split1.Name = "CheckBox_split1"
        Me.CheckBox_split1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_split1.TabIndex = 27
        Me.CheckBox_split1.Text = "Split1"
        '
        'CheckBox_pen
        '
        Me.CheckBox_pen.Enabled = False
        Me.CheckBox_pen.Location = New System.Drawing.Point(56, 80)
        Me.CheckBox_pen.Name = "CheckBox_pen"
        Me.CheckBox_pen.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_pen.TabIndex = 30
        Me.CheckBox_pen.Text = "Penalties"
        '
        'CheckBox_time
        '
        Me.CheckBox_time.Enabled = False
        Me.CheckBox_time.Location = New System.Drawing.Point(392, 56)
        Me.CheckBox_time.Name = "CheckBox_time"
        Me.CheckBox_time.Size = New System.Drawing.Size(152, 24)
        Me.CheckBox_time.TabIndex = 29
        Me.CheckBox_time.Text = "Actual Time over course"
        '
        'CheckBox_stroke
        '
        Me.CheckBox_stroke.Enabled = False
        Me.CheckBox_stroke.Location = New System.Drawing.Point(440, 32)
        Me.CheckBox_stroke.Name = "CheckBox_stroke"
        Me.CheckBox_stroke.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_stroke.TabIndex = 23
        Me.CheckBox_stroke.Text = "Stroke"
        '
        'CheckBox_split2
        '
        Me.CheckBox_split2.Enabled = False
        Me.CheckBox_split2.Location = New System.Drawing.Point(304, 56)
        Me.CheckBox_split2.Name = "CheckBox_split2"
        Me.CheckBox_split2.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox_split2.TabIndex = 28
        Me.CheckBox_split2.Text = "Split2"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Wheat
        Me.Label16.Location = New System.Drawing.Point(32, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(264, 23)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "What Columns do you want to include?"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox_col_decide
        '
        Me.CheckBox_col_decide.BackColor = System.Drawing.Color.Wheat
        Me.CheckBox_col_decide.Checked = True
        Me.CheckBox_col_decide.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_col_decide.Location = New System.Drawing.Point(360, 8)
        Me.CheckBox_col_decide.Name = "CheckBox_col_decide"
        Me.CheckBox_col_decide.Size = New System.Drawing.Size(248, 24)
        Me.CheckBox_col_decide.TabIndex = 39
        Me.CheckBox_col_decide.Text = "Let Rowing Timer decide based on the data"
        Me.CheckBox_col_decide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cattimeRadioButton
        '
        Me.cattimeRadioButton.Location = New System.Drawing.Point(328, 232)
        Me.cattimeRadioButton.Name = "cattimeRadioButton"
        Me.cattimeRadioButton.Size = New System.Drawing.Size(152, 24)
        Me.cattimeRadioButton.TabIndex = 18
        Me.cattimeRadioButton.Text = "By Category"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Wheat
        Me.Label8.Location = New System.Drawing.Point(264, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "And in what order?"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cluborderRadioButton
        '
        Me.cluborderRadioButton.Location = New System.Drawing.Point(328, 208)
        Me.cluborderRadioButton.Name = "cluborderRadioButton"
        Me.cluborderRadioButton.Size = New System.Drawing.Size(96, 24)
        Me.cluborderRadioButton.TabIndex = 16
        Me.cluborderRadioButton.Text = "By Club"
        '
        'finishorderRadioButton
        '
        Me.finishorderRadioButton.Checked = True
        Me.finishorderRadioButton.Location = New System.Drawing.Point(328, 184)
        Me.finishorderRadioButton.Name = "finishorderRadioButton"
        Me.finishorderRadioButton.Size = New System.Drawing.Size(96, 24)
        Me.finishorderRadioButton.TabIndex = 15
        Me.finishorderRadioButton.TabStop = True
        Me.finishorderRadioButton.Text = "By Position"
        '
        'startorderRadioButton
        '
        Me.startorderRadioButton.Location = New System.Drawing.Point(328, 160)
        Me.startorderRadioButton.Name = "startorderRadioButton"
        Me.startorderRadioButton.Size = New System.Drawing.Size(128, 24)
        Me.startorderRadioButton.TabIndex = 14
        Me.startorderRadioButton.Text = "By Bow Number"
        '
        'printpagesetupButton
        '
        Me.printpagesetupButton.BackColor = System.Drawing.Color.Wheat
        Me.printpagesetupButton.Location = New System.Drawing.Point(432, 272)
        Me.printpagesetupButton.Name = "printpagesetupButton"
        Me.printpagesetupButton.Size = New System.Drawing.Size(100, 32)
        Me.printpagesetupButton.TabIndex = 8
        Me.printpagesetupButton.Text = "Page Setup"
        '
        'printpreviewButton
        '
        Me.printpreviewButton.BackColor = System.Drawing.Color.Wheat
        Me.printpreviewButton.Location = New System.Drawing.Point(304, 272)
        Me.printpreviewButton.Name = "printpreviewButton"
        Me.printpreviewButton.Size = New System.Drawing.Size(100, 32)
        Me.printpreviewButton.TabIndex = 7
        Me.printpreviewButton.Text = "Print Preview"
        '
        'printButton
        '
        Me.printButton.BackColor = System.Drawing.Color.Wheat
        Me.printButton.Location = New System.Drawing.Point(184, 272)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(100, 32)
        Me.printButton.TabIndex = 6
        Me.printButton.Text = "Print"
        '
        'tabpage_html
        '
        Me.tabpage_html.Controls.Add(Me.Label7)
        Me.tabpage_html.Controls.Add(Me.htmlButton)
        Me.tabpage_html.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_html.Name = "tabpage_html"
        Me.tabpage_html.Size = New System.Drawing.Size(668, 318)
        Me.tabpage_html.TabIndex = 12
        Me.tabpage_html.Text = "HTML"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(200, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(392, 72)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'htmlButton
        '
        Me.htmlButton.BackColor = System.Drawing.Color.Wheat
        Me.htmlButton.Location = New System.Drawing.Point(80, 184)
        Me.htmlButton.Name = "htmlButton"
        Me.htmlButton.Size = New System.Drawing.Size(100, 72)
        Me.htmlButton.TabIndex = 13
        Me.htmlButton.Text = "Save Results Website"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.eventsetupTabPage)
        Me.TabControl.Controls.Add(Me.crewTabPage)
        Me.TabControl.Controls.Add(Me.startTabPage)
        Me.TabControl.Controls.Add(Me.split1TabPage)
        Me.TabControl.Controls.Add(Me.split2TabPage)
        Me.TabControl.Controls.Add(Me.finishTabPage)
        Me.TabControl.Controls.Add(Me.handicapTabPage)
        Me.TabControl.Controls.Add(Me.optionsTabPage)
        Me.TabControl.Controls.Add(Me.resultsTabPage)
        Me.TabControl.Controls.Add(Me.printingTabPage)
        Me.TabControl.Controls.Add(Me.tabpage_html)
        Me.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl.HotTrack = True
        Me.TabControl.ItemSize = New System.Drawing.Size(71, 18)
        Me.TabControl.Location = New System.Drawing.Point(8, 80)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(676, 344)
        Me.TabControl.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(692, 527)
        Me.Controls.Add(Me.Label_data)
        Me.Controls.Add(Me.topLabel3)
        Me.Controls.Add(Me.topLabel2)
        Me.Controls.Add(Me.topLabel1)
        Me.Controls.Add(Me.floatButton)
        Me.Controls.Add(Me.warningLabel)
        Me.Controls.Add(Me.split2Button)
        Me.Controls.Add(Me.split1Button)
        Me.Controls.Add(Me.finishwhistleButton)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.startwhistleButton)
        Me.Controls.Add(Me.ClockLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(700, 561)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rowing Timer"
        CType(Me.finishDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headoftheriverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startdataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.split1DataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.split2DataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resultsDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crewDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.handicapTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.eventsetupTabPage.ResumeLayout(False)
        Me.crewTabPage.ResumeLayout(False)
        CType(Me.crewDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.startTabPage.ResumeLayout(False)
        CType(Me.startDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.split1TabPage.ResumeLayout(False)
        CType(Me.split1DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.split2TabPage.ResumeLayout(False)
        CType(Me.split2DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.finishTabPage.ResumeLayout(False)
        CType(Me.finishDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.handicapTabPage.ResumeLayout(False)
        CType(Me.handicapDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.optionsTabPage.ResumeLayout(False)
        CType(Me.startinbatches_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.resultsTabPage.ResumeLayout(False)
        CType(Me.resultsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.printingTabPage.ResumeLayout(False)
        Me.Panel_choosecols.ResumeLayout(False)
        Me.tabpage_html.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim version As String = "v3.4.8"
#Region "variables"
    Dim nocrewslabel As New Label
    Dim whistletime As String
    Dim gridrowdragstartedin As Integer
    Dim mouseisdown, gridmouseisdown As Boolean
    Dim savefilepath As String = ""
    Dim startform As startupform
    Dim versionstring As String = System.Windows.Forms.Application.ProductVersion.ToString ' this is used is the settings file
    Dim loading As Boolean = True
    Dim butcolor As Color = Color.Wheat
    Private disabledtextbrush As Brush
    Private importantcolumnbrush As Brush
    Dim copies As Integer 'for printing
    Dim padding As Single 'for printing
    Dim tablock As Boolean
    Dim mouseX, mouseY As Integer

    Dim no_clubs, no_cats As Integer


    ' Windows API functions and constants for the keypress events
    Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    Private Declare Function GlobalAddAtom Lib "kernel32" Alias "GlobalAddAtomA" (ByVal lpString As String) As Short
    Private Declare Function GlobalDeleteAtom Lib "kernel32" (ByVal nAtom As Short) As Short
    '//    Private Const MOD_ALT As Integer = 1
    '// Private Const MOD_CONTROL As Integer = 2
    '//Private Const MOD_SHIFT As Integer = 4
    '//Private Const MOD_WIN As Integer = 8
    ' the id for the hotkey
    Dim activekeys As New ArrayList 'contains the list of keys registered.
    Dim activekeysID As New ArrayList 'contains their unique IDS.

#End Region
    Dim hdpchanged As Boolean ' set to true if a handicap is changed on the vet tab
    Dim htmlfolderpath As String
    Dim errors As Integer
    Dim tablecols As Integer
    Dim printcolbool(30) As Boolean ' 20 is arbitrary, but must be more than resultsdatatable.cols.count
    Dim mysecretpanel As New secretpanel

  
#Region "start up stuff"
    Private Sub loadoptions()
        savefilepath = startform.chosenfilepath
        If savefilepath <> "" Then
            Try
                loadstartupexample(savefilepath)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub helpsub(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenuItem.Click
        Try
            Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
        Catch
            MsgBox("helppages not found")
        End Try
    End Sub
    Private Sub setuppageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles distanceTextBox.TextChanged, eventlocationTextBox.TextChanged, eventsponsorTextBox.TextChanged, eventdivisionTextBox.TextChanged, eventnameTextBox.TextChanged, eventDateTimePicker.ValueChanged
        alert(Nothing, Nothing)
    End Sub
   
    Private Sub initiatemessagelabels()
        Me.eventDateTimePicker.Value = Today
        Me.handicaptopLabel.Text = "The following crews are categorised as 'Vet'" & vbCrLf & "You can enter any Handicaps you wish to apply here (as number of seconds)."
        Me.fulleditCheckBox.Text = "Check this to allow full edit and sort - allows altering of ALL important data cells. This can be useful in case of mistakes which cannot otherwise be handled." _
            & vbCrLf & "However, use with care. Save your data before use and consider that incorrect string formats, for example, may cause unexpected results !" _
            & vbCrLf & "It is advisable to Uncheck this again ASAP."
        Me.Label6.Text = "This puts a copy of the results datatable onto the windows clipboard." _
        & vbCrLf & "you can paste into Excel for further analysis or customised printing."
        Me.Label7.Text = "Click to save an Folder of HTML and other assocaited files." & vbCrLf & "You should link to the file 'index.html'" & vbCrLf & vbCrLf & "NB- it is a wise precaution to save your data before performing this operation."
        Me.fulleditCheckBox.Text = "Allow full edit and sort - allows typed altering of ALL key data cells." _
     & " This include times." & vbCrLf _
     & " Whilst useful for error correction, please be cautious. Input data in correct format." & vbCrLf _
     & "It is also advisable to backup your data (i.e. click save) before doing this."
        nocrewsyetlabelsetup()
        Me.warningLabel.Visible = False

    End Sub
    Private Sub nocrewsyetlabelsetup()
        'nocrewslabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ' nocrewslabel.BackColor = Color.Red
        nocrewslabel.Size = New Size(startPanel.Width - 2, 200)
        nocrewslabel.Name = "nocrewslabel"
        nocrewslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        nocrewslabel.Text = "There are no buttons here because" & vbCrLf & "you haven't entered any crews yet." & vbCrLf & vbCrLf _
                & "This can be done at any time."
    End Sub
    Private Sub uniformwatches()

        Dim mystring As String = "W" & vbCrLf & "H" & vbCrLf & "I" & vbCrLf & "S" & vbCrLf & "T" & vbCrLf & "L" & vbCrLf & "E" & vbCrLf & vbCrLf
        tabstartwhistleButton.Text = mystring & "(F1 key)"

        'Me.tabstartwhistleButton.ForeColor = tabstartwhistleButton.BackColor

        Me.split1lockCheckBox.Size = Me.startlockCheckBox.Size
        Me.split1Panel.Size = Me.startPanel.Size
        Me.split1Label.Size = Me.startLabel.Size
        Me.tabsplit1whistleButton.Size = tabstartwhistleButton.Size
        Me.tabsplit1whistleButton.Text = mystring & "(F2 key)"
        Me.split1DataGrid.Size = Me.startDataGrid.Size
        Me.split1Panel.Size = Me.startPanel.Size
        Me.split1lockCheckBox.Location = Me.startlockCheckBox.Location
        Me.split1Panel.Location = Me.startPanel.Location
        Me.split1Label.Location = Me.startLabel.Location
        Me.tabsplit1whistleButton.Location = tabstartwhistleButton.Location
        Me.split1DataGrid.Location = Me.startDataGrid.Location
        Me.split1Panel.Location = Me.startPanel.Location

        Me.split2lockCheckBox.Size = Me.startlockCheckBox.Size
        Me.split2Panel.Size = Me.startPanel.Size
        Me.split2Label.Size = Me.startLabel.Size
        Me.tabsplit2whistleButton.Size = tabstartwhistleButton.Size
        Me.tabsplit2whistleButton.Text = mystring & "(F3 key)"
        Me.split2DataGrid.Size = Me.startDataGrid.Size
        Me.split2Panel.Size = Me.startPanel.Size
        Me.split2lockCheckBox.Location = Me.startlockCheckBox.Location
        Me.split2Panel.Location = Me.startPanel.Location
        Me.split2Label.Location = Me.startLabel.Location
        Me.tabsplit2whistleButton.Location = tabstartwhistleButton.Location
        Me.split2DataGrid.Location = Me.startDataGrid.Location
        Me.split2Panel.Location = Me.startPanel.Location


        Me.finishlockCheckBox.Size = Me.startlockCheckBox.Size
        Me.finishPanel.Size = Me.startPanel.Size
        Me.finishLabel.Size = Me.startLabel.Size
        Me.tabfinishwhistleButton.Size = tabstartwhistleButton.Size
        Me.tabfinishwhistleButton.Text = mystring & "(F4 key)"
        Me.finishDataGrid.Size = Me.startDataGrid.Size
        Me.finishPanel.Size = Me.startPanel.Size
        Me.finishlockCheckBox.Location = Me.startlockCheckBox.Location
        Me.finishPanel.Location = Me.startPanel.Location
        Me.finishLabel.Location = Me.startLabel.Location
        Me.tabfinishwhistleButton.Location = tabstartwhistleButton.Location
        Me.finishDataGrid.Location = Me.startDataGrid.Location
        Me.finishPanel.Location = Me.startPanel.Location

    End Sub
#End Region
#Region "main form events - clocks and whistles"
    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'updates the "stopwatches" called for by timer 1_elasped
        ClockLabel.Text = Now.ToString("HH:mm:ss")

    End Sub

    Private Sub starttabclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabstartwhistleButton.Click
        startwhistleButton.PerformClick()
    End Sub

    Private Sub split1tabclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabsplit1whistleButton.Click
        split1Button.PerformClick()
    End Sub

    Private Sub split2tabclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabsplit2whistleButton.Click
        split2Button.PerformClick()
    End Sub
    Private Sub finishtabclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabfinishwhistleButton.Click
        finishwhistleButton.PerformClick()
    End Sub
    Private Sub whistleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    startwhistleButton.Click, finishwhistleButton.Click, split1Button.Click, split2Button.Click

        'record time as a string first... in case the tabpage change event involves some processing (eg leave handicap tab)
        whistletime = Now.ToString("HH:mm:ss.ff")
        Try
            Dim dt As DataTable
            Dim dg As DataGrid

            Select Case sender.text
                Case "Start Whistle   (F1 key)"
                    Me.TabControl.SelectedTab = Me.startTabPage : dt = startdataTable : dg = startDataGrid
                Case "Split 1 Whistle   (F2 key)"
                    Me.TabControl.SelectedTab = Me.split1TabPage : dt = split1DataTable : dg = split1DataGrid
                Case "Split 2 Whistle   (F3 key)"
                    Me.TabControl.SelectedTab = Me.split2TabPage : dt = split2DataTable : dg = split2DataGrid
                Case "Finish Whistle   (F4 key)"
                    Me.TabControl.SelectedTab = Me.finishTabPage : dt = finishDataTable : dg = finishDataGrid
            End Select
            dt.AcceptChanges()

            Dim batch As Integer = 0
            Dim batchfinished As Boolean
            Do Until batchfinished
                Dim used As Boolean
                Dim dr As DataRow
                Dim i As Integer
                For Each dr In dt.Rows
                    i += 1
                    If dr.Item("time") = "" Then
                        dr.Item("time") = whistletime
                        dr.Item("valid") = True
                        used = True
                        dg.CurrentRowIndex = i - 1
                        Exit For
                    End If
                Next
                If Not used Then
                    dr = dt.NewRow()
                    dr.Item("time") = whistletime
                    dt.Rows.Add(dr)
                    dt.AcceptChanges()
                    dg.CurrentRowIndex = dt.Rows.Count - 1
                End If
                batch += 1
                If Not (Me.startinbatchesCheckbox.Checked And batch < Me.startinbatches_NumericUpDown.Value And dg Is startDataGrid) Then
                    batchfinished = True
                End If
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function getcrewsynopsisstring(ByVal bownumber As Integer, ByVal strokeonly As Boolean)
        Dim crewsynopsis As String
        Dim dr As DataRow
        For Each dr In crewDataTable.Rows
            If Val(dr.Item("Bow number")) = bownumber Then
                If strokeonly Then
                    crewsynopsis = dr.Item("stroke")
                Else
                    crewsynopsis = dr.Item("club") & " " & dr.Item("category") & " (" & dr.Item("stroke") & ")"
                End If
            End If
        Next
        Return crewsynopsis
    End Function

#End Region 'main form events whistles etc...
#Region "keypress"
    ' register a global hot key 
    Sub RegisterGlobalHotKey(ByVal hotkey As Keys, ByVal modifiers As Integer)
        Try
            ' use the GlobalAddAtom API to get a unique ID (as suggested by MSDN docs)
            Dim atomName As String

            atomName = GlobalAddAtom(hotkey.ToString)
            If atomName = 0 Then
                Throw New Exception("Unable to generate unique hotkey ID")
            End If
            If RegisterHotKey(Me.Handle, atomName, modifiers, CInt(hotkey)) = 0 Then
                ' register the hotkey, throw if any error
                Throw New Exception("Unable to register hotkey")
            Else
                activekeys.Add(hotkey)
                activekeysID.Add(atomName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ' clean up if hotkey registration failed
            ' UnregisterGlobalHotKey(atomName)
        End Try
    End Sub

    ' unregister a global hotkey
    Sub UnregisterGlobalHotKey(ByVal id As String)
        If activekeysID.Contains(id) Then
            UnregisterHotKey(Me.Handle, id)
            ' clean up the atom list
            GlobalDeleteAtom(id)
        End If
    End Sub


    Private Sub register_f_keys()
        ' register the Shift+Ctrl+F6 hot key
        ' RegisterGlobalHotKey(Keys.F6, MOD_SHIFT Or MOD_CONTROL)
        RegisterGlobalHotKey(Keys.F1, 0)
        RegisterGlobalHotKey(Keys.F2, 0)
        RegisterGlobalHotKey(Keys.F3, 0)
        RegisterGlobalHotKey(Keys.F4, 0)
    End Sub

    Private Sub unregister_f_keys()
        ' unregister the hotkey (NEVER FORGET THIS!)
        Dim id As String
        For Each id In activekeysID
            UnregisterGlobalHotKey(id)
        Next
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' let the base class process the message
        MyBase.WndProc(m)
        ' if this is a WM_HOTKEY message, notify the parent object
        Const WM_HOTKEY As Integer = &H312
        If m.Msg = WM_HOTKEY Then
            ' do whatever you wish to do when the hotkey is pressed
            ' in this example we activate the form and display a messagebox
            Me.Activate()
            ' MsgBox(m.ToString)
            Select Case m.LParam.ToInt32
                Case 7340032 'f1
                    Me.startwhistleButton.PerformClick()
                Case 7405568 'f2
                    Me.split1Button.PerformClick()
                Case 7471104 'f3
                    Me.split2Button.PerformClick()
                Case 7536640 'f4
                    Me.finishwhistleButton.PerformClick()
                
            End Select
        End If
    End Sub

#End Region
#Region "crewbutton events"
    Private Sub crewbutton_Mouseenter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim crew As String
        crew = Val(sender.Text).ToString
        If startPanel.Controls.Contains(sender) Then startLabel.Text = crew & " - " & getcrewsynopsisstring(Val(crew), False)
        If split1Panel.Controls.Contains(sender) Then split1Label.Text = crew & " - " & getcrewsynopsisstring(Val(crew), False)
        If split2Panel.Controls.Contains(sender) Then split2Label.Text = crew & " - " & getcrewsynopsisstring(Val(crew), False)
        If finishPanel.Controls.Contains(sender) Then finishLabel.Text = crew & " - " & getcrewsynopsisstring(Val(crew), False)
    End Sub
    'drag and drop subroutines
    Private Sub butmousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        mouseisdown = True
        mouseX = Cursor.Position.X - sender.location.x - startPanel.Location.X - TabControl.Location.X - startTabPage.Location.X ' should be specific, but all the panels have the same locations anyway!!
        mouseY = Cursor.Position.Y - sender.Location.Y - startPanel.Location.Y - TabControl.Location.Y - startTabPage.Location.Y
        sender.Cursor = Cursors.Hand
        floatButton.Size = sender.size
        floatButton.Text = sender.text
        floatButton.BackColor = sender.backColor
        floatButton.Show()
        floatButton.BringToFront()
    End Sub
    Private Sub butmousemove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If mouseisdown Then
            floatButton.Location = New System.Drawing.Point(Cursor.Position.X - mouseX, Cursor.Position.Y - mouseY)
        End If
    End Sub
    Private Sub butmouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        mouseisdown = False
        If floatButton.Visible And floatButton.Location.X < startPanel.Location.X Then ' this is to avoid the try-catch loop delay if the drop is miles off (i.e. if a buton has been "clicked")
            Dim dg As DataGrid
            If startPanel.Controls.Contains(sender) Then dg = startDataGrid
            If split1Panel.Controls.Contains(sender) Then dg = split1DataGrid
            If split2Panel.Controls.Contains(sender) Then dg = split2DataGrid
            If finishPanel.Controls.Contains(sender) Then dg = finishDataGrid
            Dim pt As Point
            pt = dg.PointToClient(Cursor.Position)
            Dim myhitinfo As DataGrid.HitTestInfo
            myhitinfo = dg.HitTest(pt)
            Dim y As Integer
            y = myhitinfo.Row
            If Not y = -1 Then
                Try
                    dg.Item(y, 2) = Val(floatButton.Text).ToString
                    dg.DataSource.acceptchanges()
                Catch : Beep()
                End Try
            End If
        End If
        floatButton.Hide()
    End Sub 'butmouseup
    Private Sub dg_BN_pickup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles startDataGrid.MouseDown, split1DataGrid.MouseDown, split2DataGrid.MouseDown, finishDataGrid.MouseDown
        'handles a drag event FROM the datagrids
        Try
            Dim dg As DataGrid
            dg = sender
            Dim pt As Point
            pt = dg.PointToClient(Cursor.Position)
            Dim myhitinfo As DataGrid.HitTestInfo
            myhitinfo = dg.HitTest(pt)
            If myhitinfo.Column = 2 Then
                gridrowdragstartedin = myhitinfo.Row
                gridmouseisdown = True
                floatButton.Text = dg.Item(myhitinfo.Row, 2)
                If floatButton.Text = "" Then Exit Sub
                gridmouseisdown = True
                mouseX = Cursor.Position.X - dg.Location.X - pt.X - TabControl.Location.X - startTabPage.Location.X + floatButton.Width / 2
                mouseY = Cursor.Position.Y - dg.Location.Y - pt.Y - TabControl.Location.Y - startTabPage.Location.Y + floatButton.Height / 2
                floatButton.BackColor = Color.Yellow
                floatButton.Show()
                floatButton.BringToFront()
            End If
        Catch
        End Try
    End Sub 'BN pickup
    Private Sub dg_BN_mousemove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles startDataGrid.MouseMove, split1DataGrid.MouseMove, split2DataGrid.MouseMove, finishDataGrid.MouseMove
        If gridmouseisdown Then
            floatButton.Location = New System.Drawing.Point(Cursor.Position.X - mouseX, Cursor.Position.Y - mouseY)
        End If
    End Sub
    Private Sub DGmouseup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles startDataGrid.MouseUp, split1DataGrid.MouseUp, split2DataGrid.MouseUp, finishDataGrid.MouseUp
        gridmouseisdown = False
        If floatButton.Visible And floatButton.Location.X >= startPanel.Location.X + TabControl.Location.X + startTabPage.Location.X Then
            Dim dt As DataTable
            dt = sender.datasource
            Dim dr As DataRow
            For Each dr In dt.Rows
                If dr.Item("Bow Number") = floatButton.Text Then dr.Item("Bow Number") = ""
            Next
        End If
        floatButton.Hide()
    End Sub

    Private Sub addbuttons(ByVal watch)
        Try
            Dim mypanel As New Panel
            Select Case (watch)
                Case 1
                    mypanel = startPanel
                Case 2
                    mypanel = split1Panel
                Case 3
                    mypanel = split2Panel
                Case 4
                    mypanel = finishPanel
            End Select
            'remove any buttons already there
            mypanel.Controls.Clear()
            Dim bownumber As Integer
            Dim butsizex, butsizey, xpadding, ypadding, minx, miny, maxx, maxy, xpos, ypos As Single
            If Me.bigbuttonCheckBox.Checked = True Then
                butsizex = 120
                butsizey = 20
            Else
                butsizex = 28
                butsizey = 18
            End If
            minx = 0
            maxx = mypanel.Width
            miny = 0
            maxy = mypanel.Height - (butsizey + 20)
            xpos = minx
            ypos = miny
            xpadding = 4
            ypadding = 2
            Dim enable As Boolean
            Dim dr, dr2 As DataRow
            For Each dr In crewDataTable.Rows
                bownumber = Val(dr.Item("bow number"))
                If dr.Item("Scratched") = False Then
                    enable = True
                    Select Case (watch)
                        Case 1
                            For Each dr2 In startdataTable.Rows
                                If bownumber = Val(dr2.Item("bow number")) Then enable = False : Exit Select
                            Next
                        Case 2
                            For Each dr2 In split1DataTable.Rows
                                If bownumber = Val(dr2.Item("bow number")) Then enable = False : Exit Select
                            Next
                        Case 3
                            For Each dr2 In split2DataTable.Rows
                                If bownumber = Val(dr2.Item("bow number")) Then enable = False : Exit Select
                            Next
                        Case 4
                            For Each dr2 In finishDataTable.Rows
                                If bownumber = Val(dr2.Item("bow number")) Then enable = False : Exit Select
                            Next
                    End Select
                    If bownumber > 99 Then
                        If Not Me.bigbuttonCheckBox.Checked Then
                            butsizex = 34
                        End If
                    End If
                    If ypos > maxy Then ypos = miny : xpos += butsizex + xpadding
                    Dim crewbutton As Button
                    crewbutton = New System.Windows.Forms.Button
                    crewbutton.Location = New System.Drawing.Point(xpos, ypos)
                    crewbutton.Size = New Size(butsizex, butsizey)
                    'crewbutton.Name = bownumber.ToString
                    If Me.bigbuttonCheckBox.Checked Then
                        crewbutton.Text = bownumber.ToString & " -" & getcrewsynopsisstring(bownumber, True)
                        If crewbutton.Text = bownumber.ToString & " -" Then crewbutton.Text &= "no details"
                    Else : crewbutton.Text = bownumber.ToString
                    End If
                    crewbutton.BackColor = butcolor
                    crewbutton.Cursor = System.Windows.Forms.Cursors.Hand
                    crewbutton.TextAlign = ContentAlignment.MiddleCenter
                    crewbutton.TabStop = False
                    AddHandler crewbutton.MouseEnter, AddressOf crewbutton_Mouseenter
                    AddHandler crewbutton.MouseDown, AddressOf butmousedown
                    AddHandler crewbutton.MouseMove, AddressOf butmousemove
                    AddHandler crewbutton.MouseUp, AddressOf butmouseup
                    If Not enable Then
                        crewbutton.Enabled = False
                        crewbutton.BackColor = mypanel.BackColor
                    End If
                    mypanel.Controls.Add(crewbutton)
                    ypos += butsizey + ypadding
                End If
            Next
            If mypanel.Controls.Count = 0 Then
                mypanel.Controls.Add(nocrewslabel)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region 'crewbutton events
#Region "bownumber handling"
    Private Sub bownumber_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) _
    Handles startdataTable.ColumnChanging, split1DataTable.ColumnChanging, split2DataTable.ColumnChanging, finishDataTable.ColumnChanging
        If loading Then Exit Sub
        If e.Column.ColumnName = "Bow Number" Then
            'don't allow a bownumber if there is an error in the time column (i.e. the check box is empty)
            If e.Row.Item("valid") = False Then
                e.ProposedValue = ""
            End If
            Dim oldval, newval As String
            newval = e.ProposedValue
            oldval = e.Row.Item(e.Column)
            If newval = oldval Then Exit Sub
            If Not e.Row.GetColumnError(2) = "duplicate" Then
                Dim mypanel As Panel
                If sender Is startdataTable Then mypanel = startPanel
                If sender Is split1DataTable Then mypanel = split1Panel
                If sender Is split2DataTable Then mypanel = split2Panel
                If sender Is finishDataTable Then mypanel = finishPanel
                Dim btn As Button
                For Each btn In mypanel.Controls
                    If Val(btn.Text).ToString = oldval Then
                        btn.Enabled = True
                        btn.BackColor = butcolor
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub bownumber_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) _
    Handles startdataTable.ColumnChanged, split1DataTable.ColumnChanged, split2DataTable.ColumnChanged, finishDataTable.ColumnChanged
        If loading Then Exit Sub
        Dim BN As String
        BN = e.Row.Item(e.Column)
        Try
            Dim dr As DataRow
            'BN column
            If e.Column.ColumnName = "Bow Number" Then
                'don't allow a bownumber if there is an error in the time column (i.e. the check box is empty)
                If Not (BN = "") Then
                    Dim found As Boolean = False
                    For Each dr In crewDataTable.Rows
                        If Val(dr.Item("Bow Number")) = Val(BN) Then
                            found = True
                            Exit For
                        End If
                    Next
                    If found Then
                        e.Row.ClearErrors()
                    Else
                        e.Row.SetColumnError("Bow Number", "Bow Number not present in crew table")
                    End If
                End If
                'check for duplicates
                checkforbownumberduplicates(sender)
                'if there are no errors then refresh the buttons on the form 
                'i.e. don't refresh the buttons if there is a duplicate number entered... 
                ' and not necessary if BN isn;t in crewtable.
                'If Not e.Row.HasErrors Then
                Dim mypanel As Panel
                If sender Is startdataTable Then mypanel = startPanel
                If sender Is split1DataTable Then mypanel = split1Panel
                If sender Is split2DataTable Then mypanel = split2Panel
                If sender Is finishDataTable Then mypanel = finishPanel
                If Not mypanel.Controls.Contains(nocrewslabel) Then
                    Dim btn As Button
                    For Each btn In mypanel.Controls
                        If BN = Val(btn.Text).ToString Then
                            btn.Enabled = False
                            btn.BackColor = mypanel.BackColor
                        End If
                    Next
                End If
            End If
            If e.Column.ColumnName = "Valid" AndAlso e.ProposedValue = False Then
                e.Row.Item("Bow Number") = ""
                e.Row.ClearErrors()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub 'BN column changing
    Private Sub checkforbownumberduplicates(ByVal dt As DataTable)
        Dim testrow, otherrow As DataRow
        Dim unique As Boolean
        Dim testBN As String
        Dim timeerror, BNerror As String
        Dim i As Integer
        For Each testrow In dt.Rows
            unique = True
            For Each otherrow In dt.Rows
                testBN = testrow.Item("Bow Number")
                If testBN <> "" And testBN = otherrow.Item("Bow Number") And Not otherrow Is testrow Then
                    unique = False
                End If
            Next
            If Not unique Then
                testrow.SetColumnError("Bow Number", "duplicate")
            Else
                If testrow.GetColumnError("Bow Number") = "duplicate" Then testrow.ClearErrors()
            End If
        Next
    End Sub
#End Region 'bownumber handling
#Region "crewform"
    Private Sub addcrewrowbutton(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            crewDataTable.AcceptChanges()
            Dim dtrow, newdatarow As DataRow
            newdatarow = crewDataTable.NewRow
            Dim newbownumber As Integer = 1
            For Each dtrow In crewDataTable.Rows
                If dtrow.Item("Bow Number") >= newbownumber Then newbownumber = dtrow.Item("Bow Number") + 1
            Next
            newdatarow.Item("Bow Number") = newbownumber
            crewDataTable.Rows.Add(newdatarow)
            crewDataTable.AcceptChanges()
            crewDataGrid.CurrentRowIndex = crewDataTable.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem_crew_import(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_crew_rotimport.Click
        If crewDataTable.Rows.Count = 0 Then
            loadcrewdata("rot", True)
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Overwrite existing Crew data?" & vbCrLf & "'click 'No' to add crews to existing items", MsgBoxStyle.YesNoCancel)
            If result = MsgBoxResult.Yes Then
                loadcrewdata("rot", True)
            ElseIf result = MsgBoxResult.No Then
                loadcrewdata("rot", False)
            End If
        End If
        sortcrewtable()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        'import setup data from rot file
        Try
            'get the filename
            OpenFileDialog1.Filter = "Rowing Timer files (*.rot)|*.rot"
            Dim filepath As String
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            If OpenFileDialog1.FileName <> "" Then
                filepath = OpenFileDialog1.FileName
            End If
            loadevent(filepath, "event", True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub sortcrewtable()
        Dim crewtableview As New DataView(crewDataTable)
        crewtableview.Sort = "[Bow Number]"
        Dim crewclone As New DataTable
        crewclone = crewDataTable.Clone
        Dim crewrowview As DataRowView
        For Each crewrowview In crewtableview
            crewclone.ImportRow(crewrowview.Row)
        Next
        crewclone.AcceptChanges()
        crewDataTable.Clear()
        Dim dr As DataRow
        For Each dr In crewclone.Rows
            crewDataTable.ImportRow(dr)
        Next
        crewclone.Dispose()
    End Sub


    Private Sub MenuItem_crew_csv_replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_crew_importcsv.Click
        If crewDataTable.Rows.Count = 0 Then
            loadcrewdata("csv", True)
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Overwrite existing Crew data?", MsgBoxStyle.YesNoCancel)
            If result = MsgBoxResult.Yes Then
                loadcrewdata("csv", True)
            ElseIf result = MsgBoxResult.No Then
                loadcrewdata("csv", False)
            End If
        End If
    End Sub

    Private Sub loadcrewdata(ByVal ftype As String, ByVal replace As Boolean)
        loading = True
        Try
            Dim csvfilepath As String
            If ftype = "csv" Then
                OpenFileDialog1.Filter = "Comma Separated Files(*.csv)|*.csv"
            Else
                OpenFileDialog1.Filter = "Rowing Timer Files(*.rot)|*.rot"
                '"All Supported Files(*.rot,*.csv)|*.rot;*.csv|Rowing Timer Files(*.rot)|*.rot|Comma Separated Files(*.csv)|*.csv"
            End If
            'mydir = Application.StartupPath & "\rot_files"
            'OpenFileDialog1.InitialDirectory = mydir
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            If OpenFileDialog1.FileName <> "" Then
                csvfilepath = OpenFileDialog1.FileName
            End If


            If csvfilepath.EndsWith(".rot") Then  '////  load from rot file
                loadevent(csvfilepath, "crew", replace) ' true means we are importing

            Else
                '///// load from CSV
                If Not File.Exists(csvfilepath) Then
                    MsgBox("File not found!")
                    Return
                End If
                Dim sr As StreamReader = File.OpenText(csvfilepath)
                'open the file using the streamreader class
                Dim input, checkforheader As String 'input is a string to put the file into
                Dim mycsv As New csvchecker
                input = sr.ReadLine()
                If input Is Nothing Then Throw New Exception("no usable data in the csv file")
                checkforheader = input.Chars(0) ' 1st letter of the file checked  to see if a header row is likely.
                Try
                    mycsv.mydata = splitstring(input, False)
                    input = sr.ReadLine()
                    If Not input Is Nothing Then mycsv.mydata1 = splitstring(input, False)
                    input = sr.ReadLine()
                    If Not input Is Nothing Then mycsv.mydata2 = splitstring(input, False)
                    input = sr.ReadLine()
                    If Not input Is Nothing Then mycsv.mydata3 = splitstring(input, False)
                    input = sr.ReadLine()
                    If Not input Is Nothing Then mycsv.mydata4 = splitstring(input, False)
                    input = sr.ReadLine()
                    If Not input Is Nothing Then mycsv.mydata5 = splitstring(input, False)
                Catch ex As Exception
                End Try
                If Val(checkforheader) = 0 Then
                    mycsv.headerrow = True
                Else : mycsv.headerrow = False
                End If
                'new procedure for 3.4.4 - check to see if the data is correct
                If mycsv.ShowDialog() = DialogResult.Cancel Then
                    MsgBox("no file loaded - crewtable unaltered")
                    sr.Close()
                Else
                    'ok now go onto the file loading
                    sr.Close()
                    sr = File.OpenText(csvfilepath)
                    errors = 0
                    input = sr.ReadLine
                    If mycsv.headerrow Then input = sr.ReadLine
                    If replace Then crewDataTable.Clear() 'assuming we've got this far - seems safe to empty the table.
                    'read each line
                    Do Until input Is Nothing
                        Try
                            'send each input string to a subroutine
                            populatecrewtable(input, False, False)
                            ' false,false means don't enter winners and not tabseparated 
                        Catch
                            errors += 1
                        End Try
                        input = sr.ReadLine()
                    Loop
                    sr.Close()

                    If errors > 0 Then MsgBox("Rowing Timer encountered " & errors.ToString & " error(s) loading the CSV file." & vbCrLf & "It may still be usable, please check before continuing.")
                End If
                mycsv.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.message)
        End Try
        crewDataTable.AcceptChanges()
        loading = False
    End Sub
    Private Sub crewdatatable_rowchanged(ByVal sender As System.Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles crewDataTable.RowChanged
        'if loading Exit Sub
        Dim rowerror, olderror As Boolean
        Dim dr As DataRow
        dr = e.Row
        If dr.HasErrors Then olderror = True

        If dr.Item("Penalty") > 3599 Or dr.Item("Penalty") < 0 Then
            dr.SetColumnError("Penalty", "Penalty is out of range")
            rowerror = True
        End If
        If dr.Item("Handicap") > 3599 Or dr.Item("Handicap") < 0 Then
            dr.SetColumnError("Handicap", "Handicap is out of range")
            rowerror = True
        End If
        If Val(dr.Item("Bow Number")) < 1 Or Val(dr.Item("Bow Number")) > 999 Then
            dr.SetColumnError("Bow Number", "Bow No. must be a number and in the range 0 to 999")
            rowerror = True
        End If
        Dim cdr As DataRow
        For Each cdr In crewDataTable.Rows
            If cdr.Item("Bow Number") = dr.Item("Bow Number") And Not cdr Is dr Then
                dr.SetColumnError("Bow Number", "This value is not unique!")
                cdr.SetColumnError("Bow Number", "This value is not unique!")
                rowerror = True
            End If
        Next
        If Not rowerror Then dr.ClearErrors()
        If crewDataTable.HasErrors And olderror Then
            For Each cdr In crewDataTable.Rows
                rowerror = False
                If cdr.GetColumnError("Bow Number") = "This value is not unique!" Then
                    For Each dr In crewDataTable.Rows
                        If dr.Item("Bow Number") = cdr.Item("Bow Number") Then
                            rowerror = True
                        End If
                    Next
                End If
                If Not rowerror Then cdr.ClearErrors()
            Next
        End If
        alert(Nothing, Nothing)
    End Sub
#End Region 'crewtab
#Region "handicap page"
    Private Sub handicapPageExit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles handicapTabPage.VisibleChanged
        Try
            If handicapTabPage.Visible Then 'on page enter show all vet crews
                handicapTable.Clear()
                Dim i As Integer
                Dim vetcat As String
                Dim newresultrow As DataRow
                Do Until i = crewDataTable.Rows.Count
                    vetcat = crewDataTable.Rows(i).Item("Category")
                    vetcat = vetcat.ToLower
                    Do Until Len(vetcat) < 3
                        If vetcat.StartsWith("vet") Then
                            newresultrow = Me.handicapTable.NewRow()
                            newresultrow.Item("Bow Number") = crewDataTable.Rows(i).Item("Bow Number")
                            newresultrow.Item("Crew Information") = crewDataTable.Rows(i).Item("club") & " - " & crewDataTable.Rows(i).Item("category") & " - (" & crewDataTable.Rows(i).Item("stroke") & ")"
                            newresultrow.Item("Handicap (secs)") = Val(crewDataTable.Rows(i).Item("handicap"))
                            'newresultrow.Item("handicap (mm:ss)") = Me.converthandicap(Val(crewDataTable.Rows(i).Item("handicap")))
                            handicapTable.Rows.Add(newresultrow)
                            Exit Do
                        End If
                        vetcat = vetcat.Remove(0, 1)
                    Loop
                    i += 1
                Loop
            ElseIf hdpchanged = True Then
                Dim dr, cdr As DataRow
                For Each dr In handicapTable.Rows
                    For Each cdr In crewDataTable.Rows
                        If cdr.Item("Bow Number") = dr.Item("Bow Number") Then
                            cdr.Item("Handicap") = dr.Item("Handicap (secs)")
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub handicapptable_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles handicapTable.ColumnChanged
        Try
            If e.Column.ColumnName = "Handicap (secs)" Then
                hdpchanged = True
                e.Row.Item("Handicap (mm:ss)") = Me.converthandicap(e.Row.Item(e.Column))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region 'handicap tab
#Region "results page"
    Private Sub resultsPage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultsTabPage.VisibleChanged, printingTabPage.VisibleChanged, tabpage_html.VisibleChanged

        If Not (resultsTabPage.Visible Or printingTabPage.Visible Or tabpage_html.Visible) Then Exit Sub
        Cursor.Current = Cursors.WaitCursor
        Try
            crewDataTable.AcceptChanges()
            startdataTable.AcceptChanges()
            split1DataTable.AcceptChanges()
            split2DataTable.AcceptChanges()
            finishDataTable.AcceptChanges()
            resultsDataGrid.CaptionText = eventnameTextBox.Text & "  -  " & Me.eventdivisionTextBox.Text & "   -   " & Me.eventDateTimePicker.Text
            Dim i, i2, row, startnumrows, split1numrows, split2numrows, finishnumrows As Integer
            Dim startfound, split1found, split2found, finishfound As Boolean 'true if bow number found
            Dim tstart, tsplit1, tsplit2, tfinish As String 'time values
            Dim cdr As DataRow
            Me.resultsDataTable.Clear()
            startnumrows = Me.startdataTable.Rows.Count
            split1numrows = Me.split1DataTable.Rows.Count
            split2numrows = Me.split2DataTable.Rows.Count
            finishnumrows = Me.finishDataTable.Rows.Count
            For i = 1 To 1000 ' assumes bow numbers of 1 to 1000 - may change this
                startfound = False : split1found = False : split2found = False : finishfound = False
                For Each cdr In startdataTable.Rows
                    If Val(cdr.Item("bow number")) = i Then
                        startfound = True
                        tstart = cdr.Item("time")
                        Exit For
                    End If
                Next
                For Each cdr In split1DataTable.Rows
                    If Val(cdr.Item("bow number")) = i Then
                        split1found = True
                        tsplit1 = cdr.Item("time")
                        Exit For
                    End If
                Next
                For Each cdr In split2DataTable.Rows
                    If Val(cdr.Item("bow number")) = i Then
                        split2found = True
                        tsplit2 = cdr.Item("time")
                        Exit For
                    End If
                Next
                For Each cdr In finishDataTable.Rows
                    If Val(cdr.Item("bow number")) = i Then
                        finishfound = True
                        tfinish = cdr.Item("time")
                        Exit For
                    End If
                Next
                Dim tstring As String
                If startfound Or split1found Or split2found Or finishfound Then
                    Dim newresultrow As DataRow
                    newresultrow = Me.resultsDataTable.NewRow()
                    newresultrow.Item("bow number") = i
                    If Not startfound Then
                        newresultrow.Item("Time Started") = "no start!"
                    Else : newresultrow.Item("Time Started") = tstart
                    End If
                    If startfound And split1found Then
                        tstring = timedifferenceproc(tsplit1, tstart)
                        If tstring.StartsWith("00:") Then tstring = tstring.Remove(0, 3)
                        newresultrow.Item("Split 1") = tstring
                    End If
                    If startfound And split2found Then
                        tstring = timedifferenceproc(tsplit2, tstart)
                        If tstring.StartsWith("00:") Then tstring = tstring.Remove(0, 3)
                        newresultrow.Item("Split 2") = tstring
                    End If
                    If startfound And finishfound Then
                        tstring = timedifferenceproc(tfinish, tstart)
                        If tstring.StartsWith("00:") Then tstring = tstring.Remove(0, 3)
                        newresultrow.Item("time") = tstring
                    End If

                    '// add penalties so that column "adjtime" takes these into account
                    Dim pen As Integer
                    Dim penstring As String ' for formatting
                    Dim adjtime As String = ""

                    Dim hcp As Integer
                    Dim hcpstring As String
                    Dim hcptime As String = ""

                    For Each cdr In crewDataTable.Rows
                        If Val(cdr.Item("Bow number")) = i Then
                            newresultrow.Item("club") = cdr.Item("club")
                            newresultrow.Item("stroke") = cdr.Item("stroke")
                            newresultrow.Item("category") = cdr.Item("category")
                            newresultrow.Item("Winners") = cdr.Item("winners")

                            '// penalties
                            pen = cdr.Item("penalty")
                            'convert to mm:ss format
                            If pen > 0 Then
                                penstring = Me.converthandicap(pen)
                                newresultrow.Item("pen") = penstring
                                'now calculate adj time (adding penalties)
                                tstring = newresultrow.Item("time")
                                If Len(tstring) = 8 Then tstring = "00:" & tstring
                                pen = pen * -1
                                adjtime = timedifferenceproc(tstring, "-00:" & converthandicap(pen))
                                If adjtime.StartsWith("00:") Then adjtime = adjtime.Remove(0, 3)
                                newresultrow.Item("adj time") = adjtime
                            Else
                                newresultrow.Item("adj time") = newresultrow.Item("time")
                            End If

                            If Not finishfound Then
                                newresultrow.Item("time") = "failed to finish"
                                newresultrow.Item("adj time") = "n/a"
                            End If

                            If newresultrow.Item("Time Started") = "no start!" Then newresultrow.Item("adj time") = "n/a"

                            If cdr.Item("DQ") = True Then
                                newresultrow.Item("adj time") = "n/a"
                                newresultrow.Item("time") = "DQ"
                                newresultrow.Item("split 1") = ""
                                newresultrow.Item("split 2") = ""
                                newresultrow.Item("time started") = "DQ"
                            End If
                            If cdr.Item("Scratched") = True Then
                                newresultrow.Item("adj time") = "n/a"
                                newresultrow.Item("time") = "Scratched"
                                newresultrow.Item("split 1") = ""
                                newresultrow.Item("split 2") = ""
                                newresultrow.Item("time started") = "Scratched"
                            End If

                            'handicaps
                            hcp = cdr.Item("handicap")
                            '//convert to mm:ss format
                            If hcp > 0 Then
                                hcpstring = Me.converthandicap(hcp)
                                newresultrow.Item("hcp") = hcpstring
                                '//now calculate adj time (adding penalties)
                                tstring = newresultrow.Item("adj time")
                                If Len(tstring) = 8 Then tstring = "00:" & tstring
                                hcptime = timedifferenceproc(tstring, "00:" & converthandicap(hcp))
                                If hcptime.StartsWith("00:") Then hcptime = hcptime.Remove(0, 3)
                                newresultrow.Item("hcp time") = hcptime
                            Else
                                newresultrow.Item("hcp time") = newresultrow.Item("adj time")
                            End If

                        End If
                    Next
                    resultsDataTable.Rows.Add(newresultrow)
                End If
            Next

            'add any "scratched" crews and DQ'd crews who didn't start.
            Dim found As Boolean
            For Each cdr In crewDataTable.Rows
                If cdr.Item("Scratched") = True Then
                    Dim myrow As DataRow
                    found = False
                    For Each myrow In resultsDataTable.Rows
                        If myrow.Item("bow number") = cdr.Item("bow number") Then found = True : Exit For
                    Next
                    If Not found Then
                        Dim newresultrow As DataRow
                        newresultrow = Me.resultsDataTable.NewRow()
                        newresultrow.Item("bow number") = Val(cdr.Item("bow number"))
                        newresultrow.Item("club") = cdr.Item("club")
                        newresultrow.Item("stroke") = cdr.Item("stroke")
                        newresultrow.Item("category") = cdr.Item("category")
                        newresultrow.Item("Winners") = cdr.Item("winners")
                        newresultrow.Item("adj time") = "n/a"
                        newresultrow.Item("hcp time") = "n/a"
                        newresultrow.Item("time") = "Scratched"
                        newresultrow.Item("split 1") = ""
                        newresultrow.Item("split 2") = ""
                        newresultrow.Item("time started") = "Scratched"
                        resultsDataTable.Rows.Add(newresultrow)
                    End If
                End If
            Next
            For Each cdr In crewDataTable.Rows
                If cdr.Item("DQ") = True Then
                    Dim myrow As DataRow
                    found = False
                    For Each myrow In resultsDataTable.Rows
                        If myrow.Item("bow number") = cdr.Item("bow number") Then found = True : Exit For
                    Next
                    If Not found Then
                        Dim newresultrow As DataRow
                        newresultrow = Me.resultsDataTable.NewRow()
                        newresultrow.Item("bow number") = Val(cdr.Item("bow number"))
                        newresultrow.Item("club") = cdr.Item("club")
                        newresultrow.Item("stroke") = cdr.Item("stroke")
                        newresultrow.Item("category") = cdr.Item("category")
                        newresultrow.Item("Winners") = cdr.Item("winners")
                        newresultrow.Item("adj time") = "DQ"
                        newresultrow.Item("hcp time") = "n/a"
                        newresultrow.Item("time") = "DQ"
                        newresultrow.Item("split 1") = ""
                        newresultrow.Item("split 2") = ""
                        newresultrow.Item("time started") = "n/a"
                        resultsDataTable.Rows.Add(newresultrow)
                    End If
                End If
            Next
            'now find a ranking for each crew by adjtime,club and category.
            sortcrews()
            autowinners()
            If Me.autowinnercheckbox.Checked Then
                For Each cdr In resultsDataTable.Rows
                    cdr.Item("Winners") = cdr.Item("autowinner")
                Next
            End If


            '######################################################################################################################################

            'AutoSize(resultsDataGrid, resultsDataTable.TableName, 2)

            '#################################################################################################################################################

            'I took this out.... autowinner might as well be seen.

            ' If Me.autowinnercheckbox.Checked Then
            'Me.resultsDataGrid.TableStyles(0).GridColumnStyles("autowinner").Width = 0
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub sortcrews()
        'sort results.
        Dim dr As DataRow
        Dim pos As Integer
        Dim sortstring As String

        Dim sortlist As New ArrayList
        Dim equaltimefound, foundagain
        Dim equaltimes As New ArrayList
        'sort by adj time
        For Each dr In resultsDataTable.Rows
            If Not sortlist.Contains(dr.Item("adj time")) Then
                sortlist.Add(dr.Item("adj time"))
            Else
                If Not dr.Item("adj time") = "n/a" Then
                    equaltimefound = True
                    equaltimes.Add(dr.Item("adj time"))
                End If
            End If
        Next
        sortlist.Sort()
        For Each dr In resultsDataTable.Rows
            pos = sortlist.IndexOf(dr.Item("adj time")) + 1
            dr.Item("adjpos_sort") = pos
        Next
        If equaltimefound Then
            pos = 0
            Dim rowno As Integer
            Dim duplicate As Integer
            For rowno = 1 To resultsDataTable.Rows.Count
                duplicate = -1
                For Each dr In resultsDataTable.Rows
                    If dr.Item("adjpos_sort") = rowno Then
                        dr.Item("cat_sort") = rowno + pos  'cat_sort field used as t is spare for the moment
                        duplicate += 1
                    End If
                Next
                pos += duplicate
            Next
            '// now transfer the values back in from the temporary field
            For Each dr In resultsDataTable.Rows
                dr.Item("adjpos_sort") = dr.Item("cat_sort")
            Next
        End If
        For Each dr In resultsDataTable.Rows
            If dr.Item("adj time") = "n/a" Then
                dr.Item("position") = " - "
            Else
                pos = dr.Item("adjpos_sort")
                sortstring = pos.ToString
                Do Until pos < 100
                    pos -= 100
                Loop
                Select Case pos
                    Case 1, 21, 31, 41, 51, 61, 71, 81, 91
                        sortstring += "st"
                    Case 2, 22, 32, 42, 52, 62, 72, 82, 92
                        sortstring += "nd"
                    Case 3, 23, 33, 43, 53, 63, 73, 83, 93
                        sortstring += "rd"
                    Case Else
                        sortstring += "th"
                End Select
                If equaltimes.Contains(dr.Item("adj time")) Then sortstring += "="
                dr.Item("position") = sortstring

            End If
        Next


        sortlist.Clear()
        'sort by hcp time
        For Each dr In resultsDataTable.Rows
            If Not sortlist.Contains(dr.Item("hcp time")) Then
                sortlist.Add(dr.Item("hcp time"))
            End If
        Next
        sortlist.Sort()
        For Each dr In resultsDataTable.Rows
            pos = sortlist.IndexOf(dr.Item("hcp time")) + 1
            dr.Item("pos hcp") = pos
        Next

        sortlist.Clear()
        '//sort by cat column and put a numerical order in "cat_sort"

        '//note - "cat sort" field used fleetingly in finding equal times.


        For Each dr In resultsDataTable.Rows
            sortstring = dr.Item("category").ToLower
            If Not sortlist.Contains(sortstring) Then sortlist.Add(sortstring)
        Next
        'sortlist.Sort() '// this put cats in alphabetical order - may be better simply to keep them in the order they are on the draw.
        For Each dr In resultsDataTable.Rows
            sortstring = dr.Item("category").ToLower
            dr.Item("cat_sort") = sortlist.IndexOf(sortstring) + 1
            If Val(dr.Item("cat_sort")) > no_cats Then no_cats = Val(dr.Item("cat_sort"))
        Next

        'sort by cluborder and put a numerical order in column 3
        Try
            sortlist.Clear()
            For Each dr In resultsDataTable.Rows
                sortstring = dr.Item("club").ToLower
                If Not sortlist.Contains(sortstring) Then sortlist.Add(sortstring)
            Next
            sortlist.Sort() ' puts clubs in alphabetical order??
            For Each dr In resultsDataTable.Rows
                sortstring = dr.Item("club").ToLower
                dr.Item("club_sort") = sortlist.IndexOf(sortstring) + 1
                If Val(dr.Item("club_sort")) > no_clubs Then no_clubs = Val(dr.Item("club_sort"))
            Next
            sortlist.Clear()
            For Each dr In resultsDataTable.Rows
                pos = dr.Item("club_sort") * 1000 + dr.Item("adjpos_sort")
                sortlist.Add(pos)
                dr.Item("club_pos_sort") = pos
            Next
            sortlist.Sort() ' puts the numbers in order
            For Each dr In resultsDataTable.Rows
                dr.Item("club_pos_sort") = sortlist.IndexOf(dr.Item("club_pos_sort")) + 1
            Next
        Catch
            MsgBox("error sorting by club order")
        End Try



        Try
            '//sort by cat and then by time
            sortlist.Clear()
            For Each dr In resultsDataTable.Rows
                pos = dr.Item("cat_sort") * 1000 + dr.Item("adjpos_sort")
                'pos = dr.Item("pos_sort") * 1000000 + dr.Item("cat_sort") * 1000 + dr.Item("pos_sort")
                sortlist.Add(pos)
                dr.Item("cat_pos_sort") = pos
            Next
            sortlist.Sort() ' puts the numbers in order
            For Each dr In resultsDataTable.Rows
                dr.Item("cat_pos_sort") = sortlist.IndexOf(dr.Item("cat_pos_sort")) + 1
            Next
        Catch
            MsgBox("error sorting by category")
        End Try


        '// sort by boat class
        Try
            sortlist.Clear()
            For Each dr In resultsDataTable.Rows
                sortstring = dr.Item("category")
                If sortstring.EndsWith("8+") Then dr.Item("boat_type") = 1
                If sortstring.EndsWith("4x") Then dr.Item("boat_type") = 2
                If sortstring.EndsWith("4x-") Then dr.Item("boat_type") = 2
                If sortstring.EndsWith("4x+") Then dr.Item("boat_type") = 3
                If sortstring.EndsWith("4-") Then dr.Item("boat_type") = 4
                If sortstring.EndsWith("4+") Then dr.Item("boat_type") = 5
                If sortstring.EndsWith("2x") Then dr.Item("boat_type") = 6
                If sortstring.EndsWith("2-") Then dr.Item("boat_type") = 7
                If sortstring.EndsWith("2+") Then dr.Item("boat_type") = 8
                If sortstring.EndsWith("1x") Then dr.Item("boat_type") = 9
            Next

            '//sort by cat and then by time
            sortlist.Clear()
            For Each dr In resultsDataTable.Rows
                pos = dr.Item("boat_type") * 1000 + dr.Item("adjpos_sort")
                sortlist.Add(pos)
                dr.Item("boat_pos_sort") = pos
            Next
            sortlist.Sort() ' puts the numbers in order
            For Each dr In resultsDataTable.Rows
                dr.Item("boat_pos_sort") = sortlist.IndexOf(dr.Item("boat_pos_sort")) + 1
            Next

        Catch ex As Exception
            MsgBox("error sorting by boat type" & ex.ToString)
        End Try

    End Sub

    Private Sub autowinners()
        Dim dr, dr2 As DataRow
        Dim pos As Integer
        Dim numberincategory As Integer

        Dim newcat As Integer
        Dim crewcount As Integer = resultsDataTable.Rows.Count
        For newcat = 0 To crewcount ' potentially there are as many categories as crews
            numberincategory = 0
            pos = crewcount
            For Each dr In resultsDataTable.Rows
                If dr.Item("cat_sort") = newcat Then
                    numberincategory += 1
                    If dr.Item("pos hcp") < pos Then pos = dr.Item("pos hcp")
                End If
            Next
            If numberincategory > 0 Then
                For Each dr In resultsDataTable.Rows
                    If Len(dr.Item("adj time")) > 4 Then  ' this means ignore "n/a", "dQ" etc...
                        If dr.Item("cat_sort") = newcat And dr.Item("pos hcp") = pos Then
                            dr.Item("autowinner") = "Fastest " & dr.Item("category") & " of " & numberincategory.ToString
                            'Exit For
                        End If
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub winners_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles resultsDataTable.ColumnChanged
        If Not e.Column.ColumnName.Equals("Winners") Then Exit Sub
        If Me.autowinnercheckbox.Checked Then Exit Sub ' this sub is if program detects a user input into the winners column
        Dim BN As Integer
        BN = e.Row.Item("Bow Number")
        Dim cdr As DataRow
        For Each cdr In crewDataTable.Rows
            If Val(cdr.Item("Bow number")) = BN Then
                cdr.Item("Winners") = e.Row.Item("Winners")
                crewDataTable.AcceptChanges()
            End If
        Next
    End Sub
    Public Function timedifferenceproc(ByVal finish, ByVal start)
        Dim timediff As String
        'takes the first value from the second one
        If finish = "" Or start = "" Then Return ("") : Exit Function
        Dim interval1 As DateTime = finish
        Dim interval2 As DateTime = start
        Dim formattime As DateTime
        Dim difference, difference2 As TimeSpan
        Dim zerotime As DateTime = "00:00:00.00"
        If start.ToString.StartsWith("-") = False And finish.ToString.StartsWith("-") = False Then
            difference = interval1.Subtract(interval2)
            formattime = difference.ToString
            timediff = formattime.ToString("HH:mm:ss.ff")
            If interval2 > interval1 Then timediff = "-" & timediff
            ' "+ / +"
        End If
        If start.ToString.StartsWith("-") = False And finish.ToString.StartsWith("-") Then
            ' "+ / -"
            difference = interval1.Subtract(zerotime)
            difference2 = interval2.Subtract(zerotime)
            difference = difference.Add(difference2)
            formattime = difference.ToString
            timediff = formattime.ToString("HH:mm:ss.ff")
            timediff = "-" & timediff
        End If
        If start.ToString.StartsWith("-") = True And finish.ToString.StartsWith("-") = False Then
            'this works when int1 positive and int2 is negative
            ' "- / +"
            difference = interval1.Subtract(zerotime)
            difference2 = interval2.Subtract(zerotime)
            difference = difference.Add(difference2)
            formattime = difference.ToString
            timediff = formattime.ToString("HH:mm:ss.ff")
        End If
        If start.ToString.StartsWith("-") = True And finish.ToString.StartsWith("-") = True Then
            ' "- / - "
            difference = interval1.Subtract(interval2)
            formattime = difference.ToString
            timediff = formattime.ToString("HH:mm:ss.ff")
            If interval2 < interval1 Then timediff = "-" & timediff
        End If
        Return (timediff)
    End Function
    Function converthandicap(ByVal input As Integer)
        If input < 0 Then input = input * -1
        Dim handicapstring As String
        Dim minute, second As Integer
        minute = input / 60 - 0.49
        second = input Mod 60
        If minute >= 0 And minute < 10 Then handicapstring = "0" & minute.ToString
        If minute > 9 Then handicapstring = minute.ToString
        If second >= 0 And second < 10 Then handicapstring &= ":0" & second.ToString
        If second > 9 Then handicapstring &= ":" & second.ToString
        Return (handicapstring)
    End Function
#End Region 'results tab
#Region "print results"
    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        Me.PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings.Collate = False
        Dim result As DialogResult = PrintDialog1.ShowDialog
        Dim i As Integer
        If result = DialogResult.OK Then
            Try
                For i = 1 To PrintDialog1.PrinterSettings.Copies
                    PrintDocument1.Print()
                Next
            Catch ex As Exception
                MessageBox.Show("sorry - there is a problem printing", ex.Message)
            End Try
        End If
    End Sub

    Private Sub printpagesetupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printpagesetupButton.Click
        Try
            PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
            If Me.PageSetupDialog1.ShowDialog = DialogResult.OK Then
                'here comes a fudge because microsoft made a cock of page settings... 
                PageSetupDialog1.PageSettings.Margins = System.Drawing.Printing.PrinterUnitConvert.Convert(PageSetupDialog1.PageSettings.Margins, _
                       System.Drawing.Printing.PrinterUnit.ThousandthsOfAnInch, System.Drawing.Printing.PrinterUnit.HundredthsOfAMillimeter)
                Me.PrintDocument1.DefaultPageSettings = Me.PageSetupDialog1.PageSettings
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub printpreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printpreviewButton.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub print(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Me.getcolumnsforoutput()
        Dim headerborders As Boolean = False
        Static page As Integer
        Static rownumber As Integer

        Dim dr As DataRow
        Dim dc As DataColumn
        Static colwidth(resultsDataTable.Columns.Count) As Single
        Static myfontsize As Integer
        Static myfont As Font

        Dim fontstring As String = "arial"
        Dim originx, originy As Single
        originx = PrintDocument1.DefaultPageSettings.Margins.Left
        originy = PrintDocument1.DefaultPageSettings.Margins.Top

        Dim totalwidth, availablewidth, itemwidth As Single
        availablewidth = Me.PrintDocument1.DefaultPageSettings.Bounds.Width
        availablewidth -= originx + Me.PrintDocument1.DefaultPageSettings.Margins.Right

        Dim availableheight As Single
        availableheight = Me.PrintDocument1.DefaultPageSettings.Bounds.Height
        availableheight -= originy + Me.PrintDocument1.DefaultPageSettings.Margins.Bottom

        ' e.Graphics.DrawRectangle(Pens.Red, originx, originy, availablewidth, availableheight)
        Dim rectanglex, rectangley, rowheight, textx, texty As Single

        rectanglex = originx
        rectangley = originy

        'headers
        If page < 1 Then
            myfontsize = 10
            myfont = New Font(fontstring, myfontsize)
            padding = myfontsize / 3

            ' OK so now we know which columns we are printing... let's get a font to allow them all to fit onto our given page dimensions

            Dim fitspagewidth As Boolean
            Do Until fitspagewidth
                Try
                    ReDim colwidth(resultsDataTable.Columns.Count)
                    myfontsize -= 1
                    padding = myfontsize / 3
                    myfont = New Font(fontstring, myfontsize, FontStyle.Regular)
                    For Each dc In resultsDataTable.Columns
                        If printcolbool(dc.Ordinal) Then
                            For Each dr In resultsDataTable.Rows
                                itemwidth = e.Graphics.MeasureString(dr.Item(dc.Ordinal), myfont).Width
                                If colwidth(dc.Ordinal) < itemwidth Then colwidth(dc.Ordinal) = itemwidth
                            Next
                        End If
                    Next
                    'now work out what the width is (for arial size 10)
                    totalwidth = 0
                    myfont = New Font(fontstring, myfontsize, FontStyle.Bold) ' swap to a bold font to check the header widths

                    For Each dc In resultsDataTable.Columns
                        If printcolbool(dc.Ordinal) Then  ' if we are printing this column then check if there is room for a header
                            If Not dc.ColumnName = "Bow Number" Or dc.ColumnName = "Position" Then
                                itemwidth = e.Graphics.MeasureString(dc.ColumnName, myfont).Width
                                If colwidth(dc.Ordinal) < itemwidth Then colwidth(dc.Ordinal) = itemwidth
                            Else
                                itemwidth = e.Graphics.MeasureString("Bow No.", myfont).Width
                                If colwidth(dc.Ordinal) < itemwidth Then colwidth(dc.Ordinal) = itemwidth
                            End If
                            colwidth(dc.Ordinal) += padding
                            totalwidth += colwidth(dc.Ordinal)
                        End If
                    Next
                    If totalwidth < availablewidth Then fitspagewidth = True ' it'll fit when the font is small enough
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop

            'now expand the columns so that in total they fit the whole page
            If totalwidth > 0 Then
                For Each dc In resultsDataTable.Columns
                    colwidth(dc.Ordinal) *= availablewidth / totalwidth
                Next
            End If
            ' we are going to print a series of rectangles.... these variable store the origins of those rectangles.
            'rectangle 1.

            myfont = New Font(fontstring, myfontsize + 6, FontStyle.Bold)
            If Me.eventnameTextBox.TextLength > 0 Then
                rectangley += Me.rectprint(eventnameTextBox.Text, myfont, rectanglex, rectangley, availablewidth, True, headerborders, e)
            End If
            myfont = New Font(fontstring, myfontsize + 4, FontStyle.Bold)
            If Me.eventsponsorTextBox.TextLength > 0 Then
                rectangley += Me.rectprint("Sponsored by - " & eventsponsorTextBox.Text, myfont, rectanglex, rectangley, availablewidth, True, headerborders, e)
            End If
            myfont = New Font(fontstring, myfontsize + 2, FontStyle.Bold)
            If Me.eventlocationTextBox.TextLength > 0 Then
                rectangley += Me.rectprint(eventlocationTextBox.Text, myfont, rectanglex, rectangley, availablewidth, True, headerborders, e)
            End If
            rectangley += Me.rectprint(eventDateTimePicker.Text, myfont, rectanglex, rectangley, availablewidth, True, headerborders, e)
            Dim nextstring As String
            If Me.eventdivisionTextBox.TextLength > 0 Then
                nextstring = eventdivisionTextBox.Text & " "
            End If
            nextstring &= "Results "
            If Me.cluborderRadioButton.Checked Then nextstring &= "by Club Order"
            If Me.finishorderRadioButton.Checked Then nextstring &= "by Finish Order"
            If Me.startorderRadioButton.Checked Then nextstring &= "by Bownumber Order"
            If Me.cattimeRadioButton.Checked Then nextstring &= "by Category and then by Time"
            rectangley += Me.rectprint(nextstring, myfont, rectanglex, rectangley, availablewidth, True, headerborders, e) ' added padding to this one
            If Not headerborders Then rectangley += padding
            myfont = New Font(fontstring, myfontsize, FontStyle.Bold)

            'ColumnHeaders
            For Each dc In resultsDataTable.Columns

                If printcolbool(dc.Ordinal) Then                    ' don't print a header for the bownumber column
                    If dc.Ordinal = 0 Then
                        Me.rectprint("Pos", myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                        rectanglex += colwidth(dc.Ordinal)
                    ElseIf dc.Ordinal = 1 Then
                        Me.rectprint("Bow No.", myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                        rectanglex += colwidth(dc.Ordinal)
                    Else
                        rowheight = Me.rectprint(dc.ColumnName, myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                        rectanglex += colwidth(dc.Ordinal)
                    End If
                End If
            Next
            rectangley += rowheight
            rectanglex = originx

            myfont = New Font(fontstring, myfontsize, FontStyle.Regular)
        End If

        '///and now onto the results!!!!
        '//////////////////////////////////////////////////////////////////////////////////////
        'this is by "start order"

        If Me.startorderRadioButton.Checked Then
            Do Until rectangley > Me.PrintDocument1.DefaultPageSettings.Bounds.Top + availableheight Or rownumber = resultsDataTable.Rows.Count
                dr = resultsDataTable.Rows(rownumber)
                For Each dc In resultsDataTable.Columns
                    If printcolbool(dc.Ordinal) Then
                        rowheight = Me.rectprint(dr.Item(dc.Ordinal), myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                        rectanglex += colwidth(dc.Ordinal)
                    End If
                Next
                rectangley += rowheight
                rectanglex = originx
                rownumber += 1
            Loop
        End If

        '//sorted by cat and time
        If Me.cattimeRadioButton.Checked Then
            'Dim pos As Integer      use rownumber as "POSITION" - there are as many positions as rows anyway.
            Do Until rectangley > Me.PrintDocument1.DefaultPageSettings.Bounds.Top + availableheight Or rownumber > resultsDataTable.Rows.Count
                For Each dr In resultsDataTable.Rows
                    If dr.Item("cat_pos_sort") = rownumber Then
                        For Each dc In resultsDataTable.Columns
                            If printcolbool(dc.Ordinal) Then
                                rowheight = Me.rectprint(dr.Item(dc.Ordinal), myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                                rectanglex += colwidth(dc.Ordinal)
                            End If
                        Next
                        rectangley += rowheight
                        rectanglex = originx
                    End If
                Next
                rownumber += 1
            Loop
        End If

        If Me.finishorderRadioButton.Checked Then
            'Dim pos As Integer      use rownumber as "POSITION" - there are as many positions as rows anyway.
            Do Until rectangley > Me.PrintDocument1.DefaultPageSettings.Bounds.Top + availableheight Or rownumber > resultsDataTable.Rows.Count
                For Each dr In resultsDataTable.Rows
                    If dr.Item("adjpos_sort") = rownumber Then
                        For Each dc In resultsDataTable.Columns
                            If printcolbool(dc.Ordinal) Then
                                rowheight = Me.rectprint(dr.Item(dc.Ordinal), myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                                rectanglex += colwidth(dc.Ordinal)
                            End If
                        Next
                        rectangley += rowheight
                        rectanglex = originx
                    End If
                Next
                rownumber += 1
            Loop
        End If

        If Me.cluborderRadioButton.Checked Then
            'Dim pos As Integer      use rownumber as "CLUB" - there are as many positions as rows anyway.
            Do Until rectangley > Me.PrintDocument1.DefaultPageSettings.Bounds.Top + availableheight Or rownumber > resultsDataTable.Rows.Count
                For Each dr In resultsDataTable.Rows
                    If dr.Item("club_sort") = rownumber Then
                        For Each dc In resultsDataTable.Columns
                            If printcolbool(dc.Ordinal) Then
                                rowheight = Me.rectprint(dr.Item(dc.Ordinal), myfont, rectanglex, rectangley, colwidth(dc.Ordinal), True, True, e)
                                rectanglex += colwidth(dc.Ordinal)
                            End If
                        Next
                        rectangley += rowheight
                        rectanglex = originx
                    End If
                Next
                rownumber += 1
            Loop
        End If

        If page > 0 Then
            Me.rectprint("Page -" & (page + 1).ToString, myfont, originx, originy + availableheight, availablewidth, True, False, e)
        End If
        If rownumber < resultsDataTable.Rows.Count Then 'then Or (rownumber < maxcolumn4value And Me.cattimeRadioButton.Checked) Then
            page += 1
            e.HasMorePages = True
        Else
            page = 0
            rownumber = 0
            e.HasMorePages = False
        End If
    End Sub

    Function rectprint(ByVal mystring As String, ByVal myfont As Font, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal center As Boolean, ByVal border As Boolean, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Static lastxpos, lastypos As Integer
        'If lastypos = y + 1 Then y = y - 1
        'If lastxpos = x + 1 Then x = x - 1
        Try
            Dim rowheight As Integer
            Dim mysize As System.Drawing.SizeF
            rowheight = e.Graphics.MeasureString("Example", myfont).Height + padding
            mysize = e.Graphics.MeasureString(mystring, myfont)
            If border Then
                Dim myrectangle As New Rectangle(x, y, width, rowheight)
                e.Graphics.DrawRectangle(Pens.Gray, myrectangle)
            End If

            If center Then
                x = x + (width - mysize.Width) / 2
            Else : x = x + padding / 2
            End If
            y = y + (rowheight - mysize.Height) / 2
            e.Graphics.DrawString(mystring, myfont, Brushes.Black, x, y)
            Return rowheight
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function



#End Region ' printing
#Region "file save"
    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_save.Click, MenuItem_saveas.Click
        If savefilepath = "" Or sender.text = "Save &As" Then
            SaveFileDialog1.Filter = "Rowing Timer Files (*.rot)|*.rot"
            Dim result As DialogResult = SaveFileDialog1.ShowDialog()
            If result = DialogResult.OK And Not SaveFileDialog1.FileName = "" Then
                savefilepath = SaveFileDialog1.FileName
            Else : MsgBox("file not saved") : Exit Sub
            End If
        End If
        savealldata()
        'change the form text
        MyBase.Text = savefilepath.Substring(savefilepath.LastIndexOf("\") + 1)
        MenuItem_save.Enabled = True
    End Sub
    Private Sub savealldata()

        Dim dt As DataTable
        For Each dt In headoftheriverDataSet.Tables
            dt.AcceptChanges()
        Next

        Try
            Dim swr As StreamWriter = File.CreateText(savefilepath)
            Dim linestring As String
            Dim numRows, numcols, row, col As Integer
            Dim dr As DataRow
            'file version
            swr.WriteLine("file version 1.2")
            'header
            swr.WriteLine("<<header_start>>")
            swr.WriteLine(Me.eventnameTextBox.Text)
            swr.WriteLine(Me.eventdivisionTextBox.Text)
            swr.WriteLine(Me.eventlocationTextBox.Text)
            swr.WriteLine(Me.eventsponsorTextBox.Text)
            swr.WriteLine(Me.eventDateTimePicker.Text)
            swr.WriteLine(Me.distanceTextBox.Text)
            swr.WriteLine("<<header_ends>>")
            'crewform
            swr.WriteLine("<<crewform_start>>")
            numcols = Me.crewDataTable.Columns.Count

            For Each dr In crewDataTable.Rows
                col = 0
                linestring = ""
                Do While col < numcols
                    linestring &= dr.Item(col) & vbTab
                    col += 1
                Loop

                swr.WriteLine(linestring)
            Next
            swr.WriteLine("<<crewform_ends>>")
            swr.WriteLine("<<start_start>>")
            For Each dr In startdataTable.Rows
                linestring = ""
                linestring &= dr.Item("time") & vbTab
                linestring &= dr.Item("bow number") & vbTab
                linestring &= dr.Item("valid") & vbTab
                linestring &= dr.Item("comments")
                swr.WriteLine(linestring)
            Next
            swr.WriteLine("<<start_ends>>")
            'split1
            swr.WriteLine("<<split1_start>>")
            For Each dr In split1DataTable.Rows
                linestring = ""
                linestring &= dr.Item("time") & vbTab
                linestring &= dr.Item("bow number") & vbTab
                linestring &= dr.Item("valid") & vbTab
                linestring &= dr.Item("comments")
                swr.WriteLine(linestring)
            Next
            swr.WriteLine("<<split1_ends>>")
            'split2
            swr.WriteLine("<<split2_start>>")
            For Each dr In split2DataTable.Rows
                linestring = ""
                linestring &= dr.Item("time") & vbTab
                linestring &= dr.Item("bow number") & vbTab
                linestring &= dr.Item("valid") & vbTab
                linestring &= dr.Item("comments")
                swr.WriteLine(linestring)
            Next
            swr.WriteLine("<<split2_ends>>")
            'finish
            swr.WriteLine("<<finish_start>>")
            For Each dr In finishDataTable.Rows
                linestring = ""
                linestring &= dr.Item("time") & vbTab
                linestring &= dr.Item("bow number") & vbTab
                linestring &= dr.Item("valid") & vbTab
                linestring &= dr.Item("comments")
                swr.WriteLine(linestring)
            Next
            swr.WriteLine("<<finish_ends>>")
            'put any extra stuff here
            swr.WriteLine("<<end_of_file>>")
            swr.Close()
            endalert()
        Catch ex As Exception
            MsgBox("There was an error saving the file" & vbCrLf & ex.Message)
        End Try
    End Sub

#End Region ' file save
#Region "open file"
    Private Sub MenuItem_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_new.Click
        Dim result As MsgBoxResult
        result = MsgBox("Do you want to clear event setup details?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            MenuItem_save.Enabled = False
            Me.eventnameTextBox.Text = ""
            Me.eventdivisionTextBox.Text = ""
            Me.eventlocationTextBox.Text = ""
            Me.eventsponsorTextBox.Text = ""
            Me.eventDateTimePicker.Text = Now.Today
            Me.distanceTextBox.Text = ""
            Me.eventsetupTabPage.Select()
        End If

        If startdataTable.Rows.Count > 0 Then
            result = MsgBox("Do you want to clear start time data?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                startdataTable.Clear()
            End If
        End If

        If split1DataTable.Rows.Count > 0 Then
            result = MsgBox("Do you want to clear split 1t data?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                split1DataTable.Clear()
            End If
        End If

        If split2DataTable.Rows.Count > 0 Then
            result = MsgBox("Do you want to clear split 2 data?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                split2DataTable.Clear()
            End If
        End If

        If finishDataTable.Rows.Count > 0 Then
            result = MsgBox("Do you want to clear finish time data?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                finishDataTable.Clear()
            End If
        End If

        If crewDataTable.Rows.Count > 0 Then
            result = MsgBox("Do you want to clear all crew details?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                crewDataTable.Clear()
            End If
        End If

        If Not savefilepath = "" Then
            MsgBox("File name reset")
            savefilepath = ""
            MyBase.Text = "Rowing Timer"
            MenuItem_save.Enabled = False
        End If
        startLabel.Text = ""
        split1Label.Text = ""
        split2Label.Text = ""
        finishLabel.Text = ""
        endalert()
    End Sub
    Private Sub loadstartupexample(ByVal filepath As String)
        If Not File.Exists(filepath) Then MsgBox("File not found!" & vbCrLf & filepath) : Exit Sub
        Try
            'open the file using the streamreader class
            Dim sr As StreamReader = File.OpenText(filepath)
            Dim input, shortpath As String
            input = sr.ReadLine
            Do Until input.StartsWith("<<header_start>>") Or input Is Nothing
                input = sr.ReadLine()
            Loop
            Me.eventnameTextBox.Text = sr.ReadLine
            Me.eventdivisionTextBox.Text = sr.ReadLine
            Me.eventlocationTextBox.Text = sr.ReadLine
            Me.eventsponsorTextBox.Text = sr.ReadLine
            shortpath = filepath.Substring(filepath.LastIndexOf("\") + 1)
            If shortpath.StartsWith("example") Then
                sr.ReadLine() ' leave today's date in the datetime picker for the two example files.... otherwise load the date
            Else
                Try
                    Me.eventDateTimePicker.Text = sr.ReadLine
                Catch
                    MsgBox("error loading date - please check manually")
                End Try
            End If
            Me.distanceTextBox.Text = sr.ReadLine
            '    crewDataTable.Clear() - not necessary - this sub only called at startup
            'read each line
            Do Until input.StartsWith("<<crewform_start>>")
                input = sr.ReadLine()
            Loop
            input = sr.ReadLine
            Do Until input.StartsWith("<<crewform_ends>>") Or input Is Nothing
                Try
                    'send each input string to a subroutine
                    populatecrewtable(input, True, True)
                Catch
                    MsgBox("error populating crewtable with input " & input)
                    sr.Close()
                    Exit Sub
                End Try
                input = sr.ReadLine()
            Loop
            'now for the watch data in the form
            Dim watch As Integer  '0=start, 1=split1, 2=split2,3=finish
            Dim watchstartstring, watchendstring As String
            Dim skip As Boolean
            Do Until watch = 4
                Select Case watch
                    Case 0  'start watch
                        watchstartstring = "<<start_start>>"
                        watchendstring = "<<start_ends>>"
                    Case 1   'split1
                        watchstartstring = "<<split1_start>>"
                        watchendstring = "<<split1_ends>>"
                    Case 2   'split2
                        watchstartstring = "<<split2_start>>"
                        watchendstring = "<<split2_ends>>"
                    Case 3   'finish
                        watchstartstring = "<<finish_start>>"
                        watchendstring = "<<finish_ends>>"
                End Select
                Do Until input.StartsWith(watchstartstring) Or input Is Nothing
                    input = sr.ReadLine()
                Loop
                input = sr.ReadLine()
                Do Until input.StartsWith(watchendstring) Or input Is Nothing
                    Try
                        loadwatchdata(input, watch)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        sr.Close()
                        Exit Sub
                    End Try
                    input = sr.ReadLine()
                Loop
                watch += 1
            Loop
            sr.Close()
            MyBase.Text = filepath.Substring(filepath.LastIndexOf("\") + 1)
        Catch 'ex As Exception
            MsgBox("error loading file - " & filepath)
        End Try
    End Sub

    Private Sub File_open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_open.Click
        'Dim import As Boolean = True
        ' If sender.text = "Open" Then checkall(True) : import = False
        'If Not (Me.importsetupCheckBox.Checked Or Me.importstartCheckBox.Checked Or Me.importsplit1CheckBox.Checked Or _
        '  Me.importsplit2CheckBox.Checked Or Me.importfinishCheckBox.Checked Or _
        ' Me.importcrewCheckBox.Checked) Then
        'MsgBox("Nothing checked to import!!")
        'Exit Sub
        'End If
        If warningLabel.Visible Then
            If (MsgBox("warning - this will erase any relevant data", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel) Then Exit Sub
        End If
        loading = True
        Try
            'get the filename
            OpenFileDialog1.Filter = "Rowing Timer files (*.rot)|*.rot"
            Dim filepath As String
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            If OpenFileDialog1.FileName <> "" Then
                filepath = OpenFileDialog1.FileName
            End If
            loadevent(filepath, "all", True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'checkall(False)
        endalert()
    End Sub
    Private Sub loadevent(ByVal filepath As String, ByVal importstr As String, ByVal replace As Boolean)

        '//the next 5 lines remove the influence of the datagrids to the underlyng datatables. Restored at the end of the sub.
        '//this bug caused an error at the IRC 8s head feb 07
        Me.crewDataGrid.DataSource = Nothing
        Me.startDataGrid.DataSource = Nothing
        Me.split1DataGrid.DataSource = Nothing
        Me.split2DataGrid.DataSource = Nothing
        Me.finishDataGrid.DataSource = Nothing
        '//importstr options are "all,event,crew,start.split1,split2,finish"

        '// remember that this sub is responsible for "import" as well as "open"
        Try
            If Not File.Exists(filepath) Then
                MsgBox(filepath & " does not exist.")
                Exit Sub
            End If
            'open the file using the streamreader class
            Dim sr As StreamReader = File.OpenText(filepath)
            Dim input As String
            input = ""
            If importstr = "all" Or importstr = "event" Then
                Do Until input.StartsWith("<<header_start>>")
                    input = sr.ReadLine()
                Loop
                Me.eventnameTextBox.Text = sr.ReadLine
                Me.eventdivisionTextBox.Text = sr.ReadLine
                Me.eventlocationTextBox.Text = sr.ReadLine
                Me.eventsponsorTextBox.Text = sr.ReadLine
                Me.eventDateTimePicker.Text = sr.ReadLine
                Me.distanceTextBox.Text = sr.ReadLine
            End If

            If importstr = "crew" Or importstr = "all" Then
                errors = 0
                'scroll down to crewformdata, and load it.
                Do Until input.StartsWith("<<crewform_start>>")
                    input = sr.ReadLine()
                Loop
                'crewform needs to be checked as active.
                If replace Then crewDataTable.Clear()

                input = sr.ReadLine()
                'read each line
                Do Until input.StartsWith("<<crewform_ends>>")
                    Try
                        'send each input string to a subroutine
                        populatecrewtable(input, True, True)
                    Catch
                        errors += 1
                    End Try
                    input = sr.ReadLine()
                Loop
                If errors > 0 Then MsgBox(errors.ToString & " errors occured loading crewtable.")
            End If
            'now for the watch data in the form
            Dim watch As Integer  '0=start, 1=split1, 2=split2,3=finish
            Dim watchstartstring, watchendstring, watchstr As String
            Dim skip As Boolean
            Do Until watch = 4
                skip = False
                errors = 0
                Select Case watch
                    Case 0  'start watch
                        If Not (importstr = "all" Or importstr = "Start") Then skip = True : Exit Select
                        watchstartstring = "<<start_start>>"
                        watchendstring = "<<start_ends>>"
                        watchstr = "Start"
                        If replace Then Me.startdataTable.Clear()
                    Case 1   'split1
                        If Not (importstr = "all" Or importstr = "Split1") Then skip = True : Exit Select
                        watchstartstring = "<<split1_start>>"
                        watchendstring = "<<split1_ends>>"
                        watchstr = "Split One"
                        If replace Then Me.split1DataTable.Clear()
                    Case 2   'split2
                        If Not (importstr = "all" Or importstr = "Split2") Then skip = True : Exit Select
                        watchstartstring = "<<split2_start>>"
                        watchendstring = "<<split2_ends>>"
                        watchstr = "Split Two"
                        If replace Then Me.split2DataTable.Clear()
                    Case 3   'finish
                        If Not (importstr = "all" Or importstr = "Finish") Then skip = True : Exit Select
                        watchstartstring = "<<finish_start>>"
                        watchendstring = "<<finish_ends>>"
                        watchstr = "Finish"
                        If replace Then Me.finishDataTable.Clear()
                End Select
                If skip = False Then
                    Do Until input.StartsWith(watchstartstring)
                        input = sr.ReadLine()
                    Loop
                    input = sr.ReadLine()
                    Do Until input.StartsWith(watchendstring)
                        Try
                            loadwatchdata(input, watch)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                            errors += 1
                        End Try
                        input = sr.ReadLine()
                    Loop
                End If
                If errors > 0 Then MsgBox(errors.ToString & " errors occured loading " & watchstr & " data")
                watch += 1
            Loop
            sr.Close()
            If importstr = "all" Then
                Me.savefilepath = filepath
                MyBase.Text = savefilepath.Substring(savefilepath.LastIndexOf("\") + 1)
            End If
        Catch ex As Exception
            MsgBox("Sorry-- there is a problem opening the file" & vbCrLf & ex.message)
            Me.savefilepath = ""
            MyBase.Text = "Rowing Timer"
            Me.MenuItem_save.Enabled = False
        End Try
        Me.TabControl.SelectedIndex = 0 'necessary to refresh tab data
        crewDataTable.AcceptChanges()
        startdataTable.AcceptChanges()
        split1DataTable.AcceptChanges()
        split2DataTable.AcceptChanges()
        finishDataTable.AcceptChanges()

        Me.crewDataGrid.DataSource = Me.crewDataTable
        Me.startDataGrid.DataSource = Me.startdataTable
        Me.split1DataGrid.DataSource = Me.split1DataTable
        Me.split2DataGrid.DataSource = Me.split2DataTable
        Me.finishDataGrid.DataSource = Me.finishDataTable
        loading = False
    End Sub
    Sub loadwatchdata(ByVal input, ByVal watch)
        Dim i, i2, length As Integer
        Dim datastring As String = ""
        Dim newdatarow As DataRow
        Select Case watch
            Case 0
                newdatarow = Me.startdataTable.NewRow
            Case 1
                newdatarow = Me.split1DataTable.NewRow
            Case 2
                newdatarow = Me.split2DataTable.NewRow
            Case 3
                newdatarow = Me.finishDataTable.NewRow
        End Select
        length = Len(input)
        'create a character array to hold the string
        Dim chararray(length) As Char
        ' Create an instance of StringReader and attach it to the string.
        Dim str_read As New StringReader(input)
        ' Read 13 characters from the array that holds the string, starting
        ' from the first array member.
        Do Until i = length + 1
            str_read.Read(chararray, i, 1)
            If chararray(i).ToString = vbTab Or i = length Then
                Select Case i2
                    Case 0
                        newdatarow("Time") = datastring
                    Case 1
                        newdatarow("Bow number") = datastring
                    Case 2
                        newdatarow("valid") = datastring
                    Case 3
                        newdatarow("comments") = datastring
                End Select
                'put in crew information
                i2 += 1
                datastring = ""
            Else : datastring &= chararray(i)
            End If
            i += 1
        Loop
        Select Case watch
            Case 0
                startdataTable.Rows.Add(newdatarow)
            Case 1
                split1DataTable.Rows.Add(newdatarow)
            Case 2
                split2DataTable.Rows.Add(newdatarow)
            Case 3
                finishDataTable.Rows.Add(newdatarow)
        End Select
    End Sub
    Function splitstring(ByVal input As String, ByVal tabsep As Boolean)
        Try
            Dim field(8) As String
            Dim i As Integer
            Dim include_char As Boolean
            'two routines to load into the string array - 1st one is for tab. second is for .csv
            'create a string array to hold the fields contained within the line "input"
            'the routine allows for quotes in .csv file (where sepchar = ",")
            ' i.e. "Wallace,Neil" is identified as one field.
            'this is EXCEL compatible.

            If tabsep = True Then
                For Each chra As Char In input
                    If Not chra = vbTab Then
                        field(i) &= chra
                    Else
                        If field(i) Is Nothing Then field(i) = ""
                        i += 1
                        If i > 9 Then Exit For
                    End If
                Next
            Else
                Dim ignore_commas As Boolean = False
                For Each chra As Char In input
                    include_char = True
                    If chra = Chr(34) Then 'chr(34) is a quotemark
                        ignore_commas = Not ignore_commas
                        include_char = False
                    End If
                    If (Not chra = Chr(44) Or ignore_commas) Then 'chr(44)=,
                        If include_char Then
                            field(i) &= chra
                        End If
                    Else
                        If field(i) Is Nothing Then field(i) = ""
                        i += 1
                        If i > 8 Then Exit For
                    End If
                Next
            End If
            Return field
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Sub populatecrewtable(ByVal input As String, ByVal sep As Boolean, ByVal winners As Boolean)
        Dim f(8) As String
        f = splitstring(input, sep)

        Dim newdatarow As DataRow
        newdatarow = crewDataTable.NewRow
        Try
            newdatarow("Bow number") = f(0)
            newdatarow("Club") = f(1)
            newdatarow("Category") = f(2)
            newdatarow("Stroke") = f(3)
            newdatarow("handicap") = Val(f(4))
            newdatarow("penalty") = Val(f(5))
            If Len(f(6)) > 0 Then newdatarow("Scratched") = CType(f(6), Boolean)
            If Len(f(7)) > 0 Then newdatarow("DQ") = CType(f(7), Boolean)
            If winners And Len(f(8)) > 0 Then
                newdatarow("winners") = f(8)
            End If
            crewDataTable.Rows.Add(newdatarow) ' local
        Catch ex As Exception
            errors += 1
        End Try
    End Sub
#End Region 'import and new
#Region "tab changes and form resizing"

    'todo check these
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Popup
        TabControl.SelectedTab = Me.crewTabPage
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Popup, MenuItem_file.Popup
        TabControl.SelectedTab = Me.eventsetupTabPage
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Popup
        TabControl.SelectedTab = Me.startTabPage
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_importsplit1.Popup
        TabControl.SelectedTab = Me.split1TabPage
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_importsplit2.Popup
        TabControl.SelectedTab = Me.split2TabPage
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_importfinish.Popup
        TabControl.SelectedTab = Me.finishTabPage
    End Sub
    Private Sub lockCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startlockCheckBox.CheckedChanged, split1lockCheckBox.CheckedChanged, split2lockCheckBox.CheckedChanged, finishlockCheckBox.CheckedChanged
        If sender.Checked Then
            tablock = True
            Me.TabControl.Height += 75
            Me.TabControl.BringToFront()
            startwhistleButton.Enabled = False
            split1Button.Enabled = False
            split2Button.Enabled = False
            finishwhistleButton.Enabled = False
            If sender Is startlockCheckBox Then startwhistleButton.Enabled = True
            If sender Is split1lockCheckBox Then split1Button.Enabled = True
            If sender Is split2lockCheckBox Then split2Button.Enabled = True
            If sender Is finishlockCheckBox Then finishwhistleButton.Enabled = True
        Else
            tablock = False
            Me.TabControl.Height -= 75
            startwhistleButton.Enabled = True
            split1Button.Enabled = True
            split2Button.Enabled = True
            finishwhistleButton.Enabled = True
        End If
    End Sub
    Private Sub tabpagechanging(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TabControl.SelectedIndexChanging
        If tablock Then
            e.Cancel = True
            Beep()
            Me.startlockCheckBox.BackColor = Color.Red
            Me.split1lockCheckBox.BackColor = Color.Red
            Me.split2lockCheckBox.BackColor = Color.Red
            Me.finishlockCheckBox.BackColor = Color.Red
            Timer2.Start()
        Else
            If TabControl.SelectedTab.Name = "crewTabPage" Then
                crewDataTable.AcceptChanges()
            End If
        End If
        Cursor = Cursors.WaitCursor

    End Sub
    Private Sub tabpagechanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        If tablock Then 'this is needed in case a file is opened when a tab is 'locked'
            MsgBox("Warning - the action you have just performed has removed a 'lock me to this tab' protection")
            Me.startlockCheckBox.Checked = False
            Me.split1lockCheckBox.Checked = False
            Me.split2lockCheckBox.Checked = False
            Me.finishlockCheckBox.Checked = False
            Cursor = Cursors.Default
        End If

        Select Case TabControl.SelectedTab.Name
            Case "startTabPage"
                addbuttons(1)
            Case "split1TabPage"
                addbuttons(2)
            Case "split2TabPage"
                addbuttons(3)
            Case "finishTabPage"
                addbuttons(4)
            Case "tabpage_html"
                Me.tabpage_html.Controls.Add(Me.Panel_choosecols)
                If Me.CheckBox_col_decide.Checked Then Me.whichcolumns()
            Case "printingTabPage"
                Me.printingTabPage.Controls.Add(Me.Panel_choosecols)
                If Me.CheckBox_col_decide.Checked Then Me.whichcolumns()
        End Select
        Cursor = Cursors.Default
    End Sub
    Private Sub panelresize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SizeChanged
        'this sub is necessary because a change in the form size meant crew buttons were hidden
        'addbuttons procedure disposes of them and re-adds them.
        ' stands to reason that if the startpanel has changed size, then so have all the others!!
        If startTabPage.Visible Then addbuttons(1)
        If split1TabPage.Visible Then addbuttons(2)
        If split2TabPage.Visible Then addbuttons(3)
        If finishTabPage.Visible Then addbuttons(4)
    End Sub
#End Region ' tab changes
#Region "tablestyles"
    Private Sub tablestyles(ByVal allowtimeedit As Boolean)
        Dim i As Integer
        Dim dg As DataGrid
        For i = 1 To 4
            Dim wts As New DataGridTableStyle
            wts.AlternatingBackColor = Color.White
            wts.BackColor = Color.Wheat

            Select Case i
                Case 1
                    dg = startDataGrid
                Case 2
                    dg = split1DataGrid
                Case 3
                    dg = split2DataGrid
                Case 4
                    dg = finishDataGrid
            End Select

            Dim wbc As New ClickableBooleanColumn
            wbc.HeaderText = ""
            wbc.MappingName = "valid"
            wbc.AllowNull = False
            wbc.NullValue = False
            wbc.Width = 20
            ' AddHandler bc.BoolValueChanged, AddressOf disablerow

            Dim wcol2 As New FormattableTextBoxColumn
            wcol2.Width = 80
            wcol2.MappingName = "Time"
            wcol2.HeaderText = "Time"
            wcol2.ReadOnly = Not allowtimeedit
            AddHandler wcol2.SetCellFormat, AddressOf formatgridrow

            Dim wcol3 As New FormattableTextBoxColumn
            wcol3.ReadOnly = False
            wcol3.Width = 50
            wcol3.MappingName = "Bow Number"
            wcol3.HeaderText = "B No."
            wcol3.Alignment = HorizontalAlignment.Center
            AddHandler wcol3.SetCellFormat, AddressOf formatgridrow

            ' Dim wcol4 As New DataGridTextBoxColumn
            ' wcol4.Width = 180
            ' wcol4.MappingName = "Crew"
            'wcol4.HeaderText = "Crew"
            'wcol4.ReadOnly = True

            Dim wcol5 As New DataGridTextBoxColumn
            wcol5.Width = 74
            wcol5.MappingName = "Comments"
            wcol5.HeaderText = "Comments"
            wcol5.ReadOnly = False

            wts.RowHeadersVisible = False
            ' wts.RowHeaderWidth = 10
            wts.AllowSorting = False
            wts.PreferredRowHeight = 22

            wts.MappingName = dg.DataSource.TableName()
            '  wts.GridColumnStyles.Add(wcol1)
            wts.GridColumnStyles.Add(wbc)
            wts.GridColumnStyles.Add(wcol2)
            wts.GridColumnStyles.Add(wcol3)
            'wts.GridColumnStyles.Add(wcol4)
            wts.GridColumnStyles.Add(wcol5)

            dg.TableStyles.Clear()
            dg.TableStyles.Add(wts)

        Next
        'results table


        Dim col1 As New DataGridTextBoxColumn
        col1.ReadOnly = True
        col1.MappingName = "Bow Number"
        col1.HeaderText = "Bow No."
        col1.Width = "40"

        Dim col2 As New DataGridTextBoxColumn
        col2.ReadOnly = True
        col2.MappingName = "Club"
        col2.HeaderText = col2.MappingName
        col2.Width = "100"

        Dim col3 As New DataGridTextBoxColumn
        col3.ReadOnly = True
        col3.MappingName = "Category"
        col3.HeaderText = col3.MappingName
        col3.Width = "100"

        Dim col4 As New DataGridTextBoxColumn
        col4.ReadOnly = True
        col4.MappingName = "Stroke"
        col4.HeaderText = col4.MappingName
        col4.Width = "100"

        Dim col5 As New DataGridTextBoxColumn
        col5.ReadOnly = True
        col5.MappingName = "Time Started"
        col5.HeaderText = col5.MappingName
        col5.Width = "80"

        Dim col6 As New DataGridTextBoxColumn
        col6.ReadOnly = True
        col6.MappingName = "Split 1"
        col6.HeaderText = col6.MappingName
        col6.Width = "60"

        Dim col7 As New DataGridTextBoxColumn
        col7.ReadOnly = True
        col7.MappingName = "Split 2"
        col7.HeaderText = col7.MappingName
        col7.Width = "60"

        Dim col8 As New DataGridTextBoxColumn
        col8.ReadOnly = True
        col8.MappingName = "Time"
        col8.HeaderText = "Raw Time"
        col8.Width = "70"

        Dim col9 As New DataGridTextBoxColumn
        col9.ReadOnly = True
        col9.MappingName = "Pen"
        col9.HeaderText = col9.MappingName
        col9.Width = "60"

        Dim col10 As New DataGridTextBoxColumn
        col10.ReadOnly = True
        col10.MappingName = "Adj Time"
        col10.HeaderText = "Adj Time"
        col10.Width = "70"

        Dim col10a As New DataGridTextBoxColumn
        col10a.ReadOnly = True
        col10a.MappingName = "Hcp"
        col10a.HeaderText = col10a.MappingName
        col10a.Width = "60"

        Dim col10b As New DataGridTextBoxColumn
        col10b.ReadOnly = True
        col10b.MappingName = "Hcp Time"
        col10b.HeaderText = col10b.MappingName
        col10b.Width = "70"


        Dim col11 As New DataGridTextBoxColumn
        col11.MappingName = "Winners"
        col11.HeaderText = col11.MappingName
        col11.Width = "110"
        col11.ReadOnly = False

        Dim autocol As New DataGridTextBoxColumn
        autocol.Width = 110
        autocol.MappingName = "autowinner"
        autocol.HeaderText = "autowinner"

        Dim ts As New DataGridTableStyle
        ts.RowHeadersVisible = False
        ts.AllowSorting = True
        ts.AlternatingBackColor = Color.Wheat

        ts.MappingName = Me.resultsDataTable.TableName
        ts.GridColumnStyles.Add(col1)
        ts.GridColumnStyles.Add(col2)
        ts.GridColumnStyles.Add(col3)
        ts.GridColumnStyles.Add(col4)
        ts.GridColumnStyles.Add(col5)
        ts.GridColumnStyles.Add(col6)
        ts.GridColumnStyles.Add(col7)
        ts.GridColumnStyles.Add(col8)
        ts.GridColumnStyles.Add(col9)
        ts.GridColumnStyles.Add(col10)
        ts.GridColumnStyles.Add(col10a)
        ts.GridColumnStyles.Add(col10b)
        ts.GridColumnStyles.Add(col11)
        ts.GridColumnStyles.Add(autocol)

        resultsDataGrid.TableStyles.Clear()
        resultsDataGrid.TableStyles.Add(ts)


        'crew table


        Dim colu1 As New DataGridTextBoxColumn
        colu1.ReadOnly = False
        colu1.MappingName = "Bow Number"
        colu1.HeaderText = "Bow No."
        colu1.Width = 50

        Dim colu2 As New DataGridTextBoxColumn
        colu2.ReadOnly = False
        colu2.MappingName = "Club"
        colu2.HeaderText = colu2.MappingName
        colu2.Width = 130

        Dim colu3 As New DataGridTextBoxColumn
        colu3.ReadOnly = False
        colu3.MappingName = "Category"
        colu3.HeaderText = colu3.MappingName
        colu3.Width = 100

        Dim colu4 As New DataGridTextBoxColumn
        colu4.ReadOnly = False
        colu4.MappingName = "Stroke"
        colu4.HeaderText = colu4.MappingName
        colu4.Width = 100

        Dim colu5 As New DataGridTextBoxColumn
        colu5.ReadOnly = False
        colu5.MappingName = "Handicap"
        colu5.HeaderText = "HCP(secs)"
        colu5.Width = 60

        Dim pencol As New DataGridTextBoxColumn
        pencol.ReadOnly = False
        pencol.MappingName = "Penalty"
        pencol.HeaderText = "Pen(secs)"
        pencol.Width = 60

        Dim colu6 As New DataGridTextBoxColumn
        colu6.MappingName = "Winners"
        colu6.HeaderText = colu6.MappingName
        colu6.Width = 0
        colu6.ReadOnly = True

        Dim colu7 As New ClickableBooleanColumn
        colu7.MappingName = "Scratched"
        colu7.HeaderText = "Scratched"
        colu7.AllowNull = False
        colu7.NullValue = False
        colu7.Width = 70
        colu7.ReadOnly = False

        Dim colu8 As New ClickableBooleanColumn
        colu8.MappingName = "DQ"
        colu8.HeaderText = "DQ"
        colu8.AllowNull = False
        colu8.NullValue = False
        colu8.Width = 50
        colu8.ReadOnly = False

        Dim crewts As New DataGridTableStyle
        crewts.RowHeadersVisible = False
        crewts.AllowSorting = True
        crewts.AlternatingBackColor = Color.Wheat

        crewts.MappingName = Me.crewDataTable.TableName
        crewts.GridColumnStyles.Add(colu1)
        crewts.GridColumnStyles.Add(colu2)
        crewts.GridColumnStyles.Add(colu3)
        crewts.GridColumnStyles.Add(colu4)
        crewts.GridColumnStyles.Add(colu5)
        crewts.GridColumnStyles.Add(pencol)
        crewts.GridColumnStyles.Add(colu6)
        crewts.GridColumnStyles.Add(colu7)
        crewts.GridColumnStyles.Add(colu8)
        crewDataGrid.TableStyles.Clear()
        crewDataGrid.TableStyles.Add(crewts)


        'handicap table

        Dim mycolu1 As New DataGridTextBoxColumn
        mycolu1.ReadOnly = True
        mycolu1.MappingName = "Bow Number"
        mycolu1.HeaderText = "B No."
        mycolu1.Width = 40

        Dim mycolu2 As New DataGridTextBoxColumn
        mycolu2.ReadOnly = True
        mycolu2.MappingName = "Crew Information"
        mycolu2.HeaderText = mycolu2.MappingName
        mycolu2.Width = 280

        Dim mycolu3 As New DataGridTextBoxColumn
        mycolu3.ReadOnly = False
        mycolu3.MappingName = "Handicap (secs)"
        mycolu3.HeaderText = mycolu3.MappingName
        mycolu3.Width = 100

        Dim mycolu4 As New DataGridTextBoxColumn
        mycolu4.ReadOnly = True
        mycolu4.MappingName = "Handicap (mm:ss)"
        mycolu4.HeaderText = mycolu4.MappingName
        mycolu4.Width = 100

        Dim handts As New DataGridTableStyle
        handts.RowHeadersVisible = False
        handts.AllowSorting = True
        handts.AlternatingBackColor = Color.Wheat

        handts.MappingName = Me.handicapTable.TableName
        handts.GridColumnStyles.Add(mycolu1)
        handts.GridColumnStyles.Add(mycolu2)
        handts.GridColumnStyles.Add(mycolu3)
        handts.GridColumnStyles.Add(mycolu4)

        handicapDataGrid.TableStyles.Clear()
        handicapDataGrid.TableStyles.Add(handts)

    End Sub
    Private Sub datagridreadonlysetup()
        startDataGrid.ReadOnly = False
        split1DataGrid.ReadOnly = False
        split2DataGrid.ReadOnly = False
        finishDataGrid.ReadOnly = False
        crewDataGrid.ReadOnly = False
        resultsDataGrid.ReadOnly = False

        startDataGrid.AllowSorting = False
        split1DataGrid.AllowSorting = False
        split2DataGrid.AllowSorting = False
        finishDataGrid.AllowSorting = False
    End Sub

    Private Sub fulleditCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fulleditCheckBox.CheckedChanged
        If fulleditCheckBox.CheckState = CheckState.Unchecked Then
            datagridreadonlysetup()
            tablestyles(False)
        Else
            Dim i
            For i = 1 To 4
                Try
                    Dim dgdata As DataGrid
                    Select Case i
                        Case 1
                            dgdata = startDataGrid
                        Case 2
                            dgdata = split1DataGrid
                        Case 3
                            dgdata = split2DataGrid
                        Case 4
                            dgdata = finishDataGrid
                    End Select
                    dgdata.AllowSorting = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next i
            tablestyles(True)
        End If

    End Sub

    Private Sub AutoSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colwidthButton.Click

        '    Sub AutoSize(ByVal dgData As DataGrid, ByVal strMappingName As String, ByVal intPadding As Integer) Handles colwidthButton.Click
        Try
            Dim dgdata As DataGrid = resultsDataGrid
            Dim intpadding As Integer = 1

            'this sub is called by the resultstab
            Dim dr As DataRow
            Dim dcCol As DataColumn
            Dim gr As Graphics
            Dim sngGridNameWidth, sngDataWidth As Single
            Dim col, row As Integer, sngPadding As Single
            If resultsDataTable.Rows.Count > 0 Then       ' Don't change size if there are no rows.
                Try
                    dgdata.BeginInit()
                    dr = resultsDataTable.Rows(0)
                    Dim sz As SizeF 'Stores an ordered pair of floating-point numbers, typically the width and height of a rectangle.
                    gr = dgdata.CreateGraphics
                    sz = gr.MeasureString(New String("M", intpadding), dgdata.Font)   ' Pad "n" M-width characters
                    sngPadding = sz.Width

                    'headers
                    For col = 0 To 13              ' Loop through the column header
                        ' Measure the "width" of the text in each grid column header
                        sz = gr.MeasureString(dgdata.TableStyles(resultsDataTable.TableName).GridColumnStyles(col).HeaderText, dgdata.Font)
                        dgdata.TableStyles(0).GridColumnStyles(col).Width = sz.Width + sngPadding
                    Next      ' dcCol loop through each column in the bound DataTable

                    'now meaure the data
                    For row = 0 To resultsDataTable.Rows.Count - 1 ' Calculate width on all rows (header row counted)
                        For col = 0 To 13               ' Loop through each column
                            dr = resultsDataTable.Rows(row)       ' Navigate to visible rows
                            ' Measure the "width" of the txt in the first row of each bound DataTable column
                            sz = gr.MeasureString(dr(col + 1).ToString, dgdata.Font)       ' Measure "width" of data value
                            dgdata.TableStyles(0).GridColumnStyles(col).Width = Math.Max(sz.Width + sngPadding, dgdata.TableStyles(0).GridColumnStyles(col).Width)  ' Use larger width
                        Next    ' Next DataGrid Column
                    Next          ' Next DataRow
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dgdata.EndInit()   ' complete graphics edit
                    gr.Dispose() ' Release graphic object
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.tostring)
        End Try

    End Sub
#End Region 'tablestyles
#Region "which columns to output"
    Private Sub CheckBox_coldecide(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_col_decide.CheckStateChanged
        Dim mybool As Boolean
        mybool = CheckBox_col_decide.Checked
        If mybool Then whichcolumns()
        CheckBox_pos.Enabled = Not mybool
        CheckBox_handtime.Enabled = Not mybool
        CheckBox_winners.Enabled = Not mybool
        CheckBox_adjtime.Enabled = Not mybool
        CheckBox_start.Enabled = Not mybool
        CheckBox_split2.Enabled = Not mybool
        CheckBox_stroke.Enabled = Not mybool
        ' CheckBox_synopsis.Enabled = mybool
        CheckBox_time.Enabled = Not mybool
        CheckBox_pen.Enabled = Not mybool
        CheckBox_split1.Enabled = Not mybool
        CheckBox_hand.Enabled = Not mybool
        CheckBox_club.Enabled = Not mybool
        CheckBox_cat.Enabled = Not mybool
        CheckBox_Bow.Enabled = Not mybool

    End Sub
    Sub checkallcols(ByVal mybool As Boolean)
        CheckBox_pos.Checked = mybool
        CheckBox_handtime.Checked = mybool
        CheckBox_winners.Checked = mybool
        CheckBox_adjtime.Checked = mybool
        CheckBox_start.Checked = mybool
        CheckBox_split2.Checked = mybool
        CheckBox_stroke.Checked = mybool
        'CheckBox_synopsis.Checked = mybool
        CheckBox_time.Checked = mybool
        CheckBox_pen.Checked = mybool
        CheckBox_split1.Checked = mybool
        CheckBox_hand.Checked = mybool
        CheckBox_club.Checked = mybool
        CheckBox_cat.Checked = mybool
        CheckBox_Bow.Checked = mybool
    End Sub

    Sub whichcolumns()
        checkallcols(False)

        Dim dr As DataRow
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Bow Number")) > 0 Then
                Me.CheckBox_Bow.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Club")) > 0 Then
                Me.CheckBox_club.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Category")) > 0 Then
                Me.CheckBox_cat.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Stroke")) > 0 Then
                Me.CheckBox_stroke.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Time Started")) > 0 Then
                Me.CheckBox_start.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Split 1")) > 0 Then
                Me.CheckBox_split1.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Split 2")) > 0 Then
                Me.CheckBox_split2.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Time")) > 0 Then
                Me.CheckBox_time.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Pen")) > 0 Then
                Me.CheckBox_pen.Checked = True
                Me.CheckBox_time.Checked = False
                Me.CheckBox_adjtime.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Hcp")) > 0 Then
                Me.CheckBox_hand.Checked = True
                Me.CheckBox_handtime.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("Winners")) > 0 Then
                Me.CheckBox_winners.Checked = True
                Exit For
            End If
        Next
        For Each dr In resultsDataTable.Rows
            If Len(dr.Item("position")) > 0 Then
                Me.CheckBox_pos.Checked = True
                Exit For
            End If
        Next

    End Sub
    Sub getcolumnsforoutput()
        Try
            Dim i As Integer
            For i = 0 To 30
                printcolbool(i) = False
            Next
            'printcolbool.Clear(printcolbool, 0, 20)
            printcolbool(resultsDataTable.Columns.Item("Bow Number").Ordinal) = CheckBox_Bow.Checked
            printcolbool(resultsDataTable.Columns.Item("Club").Ordinal) = CheckBox_club.Checked
            printcolbool(resultsDataTable.Columns.Item("Category").Ordinal) = CheckBox_cat.Checked
            printcolbool(resultsDataTable.Columns.Item("Stroke").Ordinal) = CheckBox_stroke.Checked
            printcolbool(resultsDataTable.Columns.Item("Time Started").Ordinal) = CheckBox_start.Checked
            printcolbool(resultsDataTable.Columns.Item("Split 1").Ordinal) = CheckBox_split1.Checked
            printcolbool(resultsDataTable.Columns.Item("Split 2").Ordinal) = CheckBox_split2.Checked
            printcolbool(resultsDataTable.Columns.Item("Time").Ordinal) = CheckBox_time.Checked
            printcolbool(resultsDataTable.Columns.Item("Pen").Ordinal) = CheckBox_pen.Checked
            printcolbool(resultsDataTable.Columns.Item("Adj Time").Ordinal) = CheckBox_adjtime.Checked
            printcolbool(resultsDataTable.Columns.Item("Hcp").Ordinal) = CheckBox_hand.Checked
            printcolbool(resultsDataTable.Columns.Item("Hcp Time").Ordinal) = CheckBox_handtime.Checked
            printcolbool(resultsDataTable.Columns.Item("Winners").Ordinal) = CheckBox_winners.Checked
            printcolbool(resultsDataTable.Columns.Item("position").Ordinal) = CheckBox_pos.Checked
            tablecols = 0
            For i = 0 To 30
                If printcolbool(i) Then tablecols += 1
            Next
        Catch ex As Exception
            MsgBox("error in sub 'getprintcolbool'" & vbCrLf & ex.ToString)
        End Try
    End Sub
#End Region
#Region "HTML output and clipboard function"
    Private Sub htmlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles htmlButton.Click
        'this routine saves the results page as an HTML file (for web publishing)
        'SaveFileDialog1.Filter = "HTML Files (*.html)|*.html"
        ' Me.FolderBrowserDialog1.SelectedPath = "results"
        ' FolderBrowserDialog1.RootFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        FolderBrowserDialog1.Description = "Choose a destination to put your reults folder"
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK And Not FolderBrowserDialog1.SelectedPath = "" Then
            htmlfolderpath = FolderBrowserDialog1.SelectedPath & "\results"
        Else : MsgBox("no folder chosen") : Exit Sub
        End If
        If Directory.Exists(htmlfolderpath) Then
            If MsgBox("There is already a folder named 'results' in the destination you specified." & vbCrLf & "If you continue you will overwrite existing files." & vbCrLf & "Do you want to continue?", MsgBoxStyle.OKCancel) = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        Directory.CreateDirectory(htmlfolderpath)
        Me.getcolumnsforoutput()
        addauxfiles()
        makeindexpage()
        maketable("Overall Position", "finish")
        maketable("Bow Number", "start")
        maketable("Club Order", "club")
        maketable("Category", "cat")
        maketable("Boat Type", "boat")
        makecsv("Overall Position", "finish.csv") ' these filenames HAVE to be the same as the HTML filenames
        makecsv("Bow Number", "start.csv")
        makecsv("Club Order", "club.csv")
        makecsv("Category", "cat.csv")
        makecsv("Boat Type", "boat.csv")
        MsgBox("Results Webpage build was sucessful.")
    End Sub
    Private Sub addauxfiles()
        Try
            Dim auxfile, root As String
            root = Application.StartupPath
            auxfile = "\ruler.js"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\rt_style.css"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\print_style.css"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\printer.jpg"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\printit.js"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\index_style.css"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\index_print_style.css"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If
            auxfile = "\readme.txt"
            If File.Exists(root & auxfile) Then
                File.Copy(root & auxfile, htmlfolderpath & auxfile, True)
            Else : MsgBox(root & auxfile & " not found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub makeindexpage()
        Try
            Dim swr As StreamWriter = File.CreateText(htmlfolderpath & "\index.html")
            'file version
            'header
            swr.WriteLine("<!DOCTYPE HTML PUBLIC " & Chr(34) & "-//W3C//DTD HTML 4.01 Transitional//EN" & Chr(34) & ">")
            swr.WriteLine()
            swr.WriteLine("<head>")
            swr.WriteLine("<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "index_style.css" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & " media=" & Chr(34) & "screen" & Chr(34) & ">")
            swr.WriteLine("<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "index_print_style.css" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & " media=" & Chr(34) & "print" & Chr(34) & ">")
            swr.WriteLine("<title>" & Me.eventnameTextBox.Text & " results </title>")
            swr.WriteLine("<META http-equiv=Content-Type content=" & Chr(34) & "text/html; charset=windows-1252" & Chr(34) & ">")
            swr.WriteLine("</head>")
            swr.WriteLine()
            swr.WriteLine("<body>")
            swr.WriteLine("<Div id=" & Chr(34) & "printhide" & Chr(34) & ">")
            swr.WriteLine("<Div id=" & Chr(34) & "indexheading" & Chr(34) & ">")
            swr.WriteLine("<h2>" & Me.eventnameTextBox.Text & "</h2>")
            If Me.eventsponsorTextBox.TextLength > 0 Then
                swr.WriteLine("<h3> Sponsored by - " & Me.eventsponsorTextBox.Text & "</h3>")
            End If
            If Me.eventlocationTextBox.TextLength > 0 Then
                swr.WriteLine("<h3>" & Me.eventlocationTextBox.Text & "</h3>")
            End If
            swr.WriteLine("<h4>" & Me.eventDateTimePicker.Text & "</h4>")
            If Me.eventdivisionTextBox.TextLength > 0 Then
                swr.WriteLine("<h4>" & Me.eventdivisionTextBox.Text & "</h4>")
            End If
            swr.WriteLine("</div>")

            swr.WriteLine("<ul>")
            swr.WriteLine("<li>")
            swr.WriteLine("<a href=" & Chr(34) & "finish.html" & Chr(34) & " target=" & Chr(34) & "table_frame" & Chr(34) & ">Overall Position</a>")
            swr.WriteLine("</li>")
            swr.WriteLine("<li>")
            swr.WriteLine("<a href=" & Chr(34) & "start.html" & Chr(34) & " target=" & Chr(34) & "table_frame" & Chr(34) & ">Bow Number</a>")
            swr.WriteLine("</li>")
            swr.WriteLine("<li>")
            swr.WriteLine("<a href=" & Chr(34) & "club.html" & Chr(34) & " target=" & Chr(34) & "table_frame" & Chr(34) & ">Club Order</a>")
            swr.WriteLine("</li>")
            swr.WriteLine("<li>")
            swr.WriteLine("<a href=" & Chr(34) & "cat.html" & Chr(34) & " target=" & Chr(34) & "table_frame" & Chr(34) & ">Categories</a>")
            swr.WriteLine("</li>")
            swr.WriteLine("<li>")
            swr.WriteLine("<a href=" & Chr(34) & "boat.html" & Chr(34) & " target=" & Chr(34) & "table_frame" & Chr(34) & ">Boat Type</a>")
            swr.WriteLine("</li>")
            swr.WriteLine("</ul>")

            swr.WriteLine("<iframe name=" & Chr(34) & "table_frame" & Chr(34) & "src=" & Chr(34) & "finish.html" & Chr(34) & ">")
            swr.WriteLine("  Your browser does not support frames or is currently configured not to display frames. However, you may visit the related documents by clicking on these links.")
            swr.WriteLine("<a href=" & Chr(34) & "finish.html" & Chr(34) & ">Finish Order</a>")
            swr.WriteLine("<a href=" & Chr(34) & "start.html" & Chr(34) & ">Bow Number</a>")
            swr.WriteLine("<a href=" & Chr(34) & "club.html" & Chr(34) & ">Club</a>")
            swr.WriteLine("<a href=" & Chr(34) & "cat.html" & Chr(34) & ">Categories</a>")
            swr.WriteLine("<a href=" & Chr(34) & "boat.html" & Chr(34) & ">Boat Type</a>")
            swr.WriteLine("</iframe>")

            swr.WriteLine("<div id=" & Chr(34) & "link_to_inverness" & Chr(34) & ">")
            swr.WriteLine("Report produced by <a href=" & Chr(34) & " http://www.invernessrowingclub.co.uk/rowgolfsoftware/rowingtimer.html" & Chr(34) & "> Rowing Timer Software </a>")
            swr.WriteLine("</div>")
            swr.WriteLine("<div id=" & Chr(34) & "valid" & Chr(34) & ">")
            swr.WriteLine("<a href=" & Chr(34) & "http://validator.w3.org/check?uri=referer" & Chr(34) & "><img id=" & Chr(34) & "w3c" & Chr(34) & "src=" & Chr(34) & "http://www.w3.org/Icons/valid-html401" & Chr(34) & "alt=" & Chr(34) & "Valid HTML 4.01 Transitional" & Chr(34) & "></a>")
            swr.WriteLine("</div>")
            swr.WriteLine("</div>")
            swr.WriteLine("<div id=" & Chr(34) & "printshow" & Chr(34) & ">")
            swr.WriteLine("Please use the printer links on the pages to print these results.<br />")
            swr.WriteLine("If you are using some obscure web-browser, or have javascript disabled, the alternate method is to right click on the links, and open in new page (or tab, or window etc..). Then your browser's 'print preview' and 'print' buttons will work. ")
            swr.WriteLine("</div>")

            swr.WriteLine("</body>" & vbCrLf & "</html>")
            swr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub makecsv(ByVal orderstring, ByVal filenamestring)
        Try

            Dim swr As StreamWriter = File.CreateText(htmlfolderpath & "\" & filenamestring)
            Dim dr As DataRow

            Dim mystring, sep As String
            Dim numRows, numcols, row, col, tablecols As Integer
            numRows = Me.resultsDataTable.Rows.Count
            numcols = Me.resultsDataTable.Columns.Count - 5 'five hidden cols

            swr.WriteLine(Me.eventnameTextBox.Text)
            If Me.eventsponsorTextBox.TextLength > 0 Then
                swr.WriteLine("Sponsored by - " & Me.eventsponsorTextBox.Text)
            End If
            If Me.eventlocationTextBox.TextLength > 0 Then
                swr.WriteLine(Me.eventlocationTextBox.Text)
            End If
            swr.WriteLine(Me.eventDateTimePicker.Text)
            If Me.eventdivisionTextBox.TextLength > 0 Then
                swr.WriteLine(Me.eventdivisionTextBox.Text & " - " & "Results by " & orderstring)
            Else
                swr.WriteLine("Results by " & orderstring)
            End If
            col = 0
            mystring = ""
            Do While col < numcols
                If printcolbool(col) Then
                    mystring += resultsDataTable.Columns.Item(col).ToString & ","
                End If
                col += 1
            Loop
            swr.WriteLine(mystring)
            Select Case orderstring
                Case "Club Order"
                    Dim clubno As Integer
                    For clubno = 1 To no_clubs
                        For Each dr In resultsDataTable.Rows
                            If dr.Item("club_sort") = clubno Then
                                col = 0
                                mystring = ""
                                Do While col < numcols
                                    If printcolbool(col) Then
                                        mystring &= dr.Item(col) & ","
                                    End If
                                    col += 1

                                Loop
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next
                Case "Bow Number"
                    Dim bowno As Integer
                    For bowno = 1 To 999 ' check every BN
                        For Each dr In resultsDataTable.Rows
                            If dr.Item(1) = bowno Then
                                col = 0
                                mystring = ""
                                Do While col < numcols
                                    If printcolbool(col) Then
                                        mystring &= dr.Item(col) & ","
                                    End If
                                    col += 1

                                Loop
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next
                Case "Overall Position"
                    Dim pos As Integer
                    For pos = 1 To numRows ' potentially as many clubs as rows.
                        For Each dr In resultsDataTable.Rows
                            If dr.Item("adjpos_sort") = pos Then
                                col = 0
                                mystring = ""
                                Do While col < numcols
                                    If printcolbool(col) Then
                                        mystring &= dr.Item(col) & ","
                                    End If
                                    col += 1
                                Loop
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next
                Case "Category"

                    Dim rowno As Integer
                    Dim newcat As Integer
                    Dim catheadingsaved As Boolean
                    For newcat = 1 To no_cats 'how many categories do we have??
                        catheadingsaved = False
                        For rowno = 1 To numRows 'check every row
                            mystring = ""
                            For Each dr In resultsDataTable.Rows
                                If dr.Item("cat_sort") = newcat Then
                                    If Not catheadingsaved Then
                                        swr.WriteLine(dr.Item(2))
                                        catheadingsaved = True
                                    End If
                                    If dr.Item("cat_pos_sort") = rowno Then
                                        col = 0
                                        Do While col < numcols
                                            If printcolbool(col) Then
                                                mystring &= dr.Item(col) & ","
                                            End If
                                            col += 1
                                        Loop
                                        swr.WriteLine(mystring)
                                    End If
                                End If
                            Next
                        Next
                    Next

                Case "Boat Type"
                    Dim boat As Integer
                    For boat = 0 To resultsDataTable.Rows.Count
                        For Each dr In resultsDataTable.Rows
                            If dr.Item("boat_pos_sort") = boat Then
                                col = 0
                                mystring = ""
                                Do While col < numcols
                                    If printcolbool(col) Then
                                        mystring &= dr.Item(col) & ","
                                    End If
                                    col += 1

                                Loop
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next

            End Select
            swr.WriteLine()
            swr.WriteLine()
            swr.WriteLine()

            swr.WriteLine("End of CSV file")

            swr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub maketable(ByVal orderstring, ByVal filenamestring)
        Try
            Dim swr As StreamWriter = File.CreateText(htmlfolderpath & "\" & filenamestring & ".html")
            Dim dr As DataRow
            swr.WriteLine("<!DOCTYPE HTML PUBLIC " & Chr(34) & "-//W3C//DTD HTML 4.01 Transitional//EN" & Chr(34) & ">")
            swr.WriteLine()
            swr.WriteLine("<head>")
            swr.WriteLine("<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "rt_style.css" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & " media=" & Chr(34) & "screen" & Chr(34) & ">")
            swr.WriteLine("<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "print_style.css" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & " media=" & Chr(34) & "print" & Chr(34) & ">")
            swr.WriteLine("<title>" & Me.eventnameTextBox.Text & " Results by " & orderstring & " </title>")
            swr.WriteLine("<META http-equiv=Content-Type content=" & Chr(34) & "text/html; charset=windows-1252" & Chr(34) & ">")
            swr.WriteLine("<script src=" & Chr(34) & "ruler.js" & Chr(34) & " type=" & Chr(34) & "text/javascript" & Chr(34) & "></script>")
            swr.WriteLine("<script type=" & Chr(34) & "text/javascript" & Chr(34) & ">window.onload=function(){tableruler();} </script>")
            swr.WriteLine("</head>")
            swr.WriteLine()
            swr.WriteLine("<body>")
            swr.WriteLine("<ul>")
            swr.WriteLine("<li><a href=" & Chr(34) & "" & Chr(34) & " id=" & Chr(34) & "printlink" & Chr(34) & " onClick=" & Chr(34) & "printit()" & Chr(34) & ">Print Results by " & orderstring & "</a></li>")
            swr.WriteLine("<li><a href=" & Chr(34) & "" & Chr(34) & " target=" & Chr(34) & "new" & Chr(34) & ">Show this in a separate window</a></li>")
            swr.WriteLine("<li><a href=" & Chr(34) & filenamestring & ".csv" & Chr(34) & ">Download " & filenamestring & ".csv file for further analysis</a></li>")
            swr.WriteLine("</ul>")

            'header finished - now onto the data!
            Dim mystring, sep As String
            Dim numRows, numcols, row, col As Integer
            numRows = Me.resultsDataTable.Rows.Count
            numcols = Me.resultsDataTable.Columns.Count - 5 'five hidden cols

            swr.WriteLine("<table class=" & Chr(34) & "resultstable" & Chr(34) & " summary=" & Chr(34) & "Results by " & orderstring & Chr(34) & " width=" & Chr(34) & "90%" & Chr(34) & ">")
            swr.WriteLine("<thead>")

            swr.WriteLine("<tr class=" & Chr(34) & "header1" & Chr(34) & "><td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">")
            swr.WriteLine(Me.eventnameTextBox.Text)
            swr.WriteLine("</td>" & vbCrLf & "</tr>")
            If Me.eventsponsorTextBox.TextLength > 0 Then
                swr.WriteLine("<tr class=" & Chr(34) & "header2" & Chr(34) & "><td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">")
                swr.WriteLine("<h3> Sponsored by - " & Me.eventsponsorTextBox.Text & "</h3>")
                swr.WriteLine("</td>" & vbCrLf & "</tr>")
            End If
            If Me.eventlocationTextBox.TextLength > 0 Then
                swr.WriteLine("<tr class=" & Chr(34) & "header2" & Chr(34) & "><td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">")
                swr.WriteLine(Me.eventlocationTextBox.Text)
                swr.WriteLine("</td>" & vbCrLf & "</tr>")
            End If
            swr.WriteLine("<tr class=" & Chr(34) & "header2" & Chr(34) & "><td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">")
            swr.WriteLine(Me.eventDateTimePicker.Text)
            swr.WriteLine("</td>" & vbCrLf & "</tr>")
            swr.WriteLine("<tr class=" & Chr(34) & "header3" & Chr(34) & "><td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">")
            If Me.eventdivisionTextBox.TextLength > 0 Then
                swr.WriteLine(Me.eventdivisionTextBox.Text & " - " & "Results by " & orderstring)
            Else
                swr.WriteLine("Results by " & orderstring)
            End If
            swr.WriteLine("</td>" & vbCrLf & "</tr>")

            swr.WriteLine("<tr>")
            col = 1
            If printcolbool(0) Then
                swr.WriteLine(vbTab & "<th>Position</th>")
            End If
            Do While col < numcols
                If printcolbool(col) Then
                    swr.WriteLine(vbTab & "<th>" & Me.resultsDataTable.Columns.Item(col).ToString & "</th>")
                End If
                col += 1
            Loop
            swr.WriteLine("</tr>" & vbCrLf & "</thead>")

            swr.WriteLine("<tfoot>")
            swr.WriteLine("<tr>")
            swr.WriteLine("<td colspan=" & Chr(34) & tablecols.ToString & Chr(34) & ">Report produced by <a href=" & Chr(34) & "http://www.invernessrowingclub.co.uk/rowgolfsoftware/rowingtimer.html" & Chr(34) & "> Rowing Timer Software </a> </td>")
            swr.WriteLine("</tr>")
            swr.WriteLine("</tfoot>")

            swr.WriteLine("<tbody>")


            '/// this code finds out the handicap time column number for use in all the tables - we can then avoid printing this for non-handicapped crews
            Dim handicaptimecolno As Integer
            handicaptimecolno = resultsDataTable.Columns.IndexOf("Hcp Time")
            Dim skiphcp As Boolean

            Select Case orderstring
                Case "Bow Number"
                    Dim bowno As Integer
                    For bowno = 1 To 999 ' check every BN
                        For Each dr In resultsDataTable.Rows
                            If dr.Item("Hcp") = "" Then skiphcp = True Else skiphcp = False

                            If dr.Item(1) = bowno Then
                                col = 0
                                mystring = "<tr>" & vbCrLf
                                Do While col < numcols
                                    If col = 1 Then sep = "th>" Else sep = "td>"
                                    If printcolbool(col) Then
                                        If col <> handicaptimecolno Or skiphcp = False Then
                                            mystring &= vbTab & "<" & sep & dr.Item(col) & "</" & sep & vbCrLf
                                        Else
                                            mystring &= vbTab & "<" & sep & "</" & sep & vbCrLf
                                        End If
                                    End If
                                    col += 1
                                Loop
                                mystring &= "</tr>"
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next
                Case "Overall Position"
                    Dim pos As Integer
                    For pos = 1 To numRows ' potentially as many clubs as rows.
                        For Each dr In resultsDataTable.Rows
                            If dr.Item("Hcp") = "" Then skiphcp = True Else skiphcp = False

                            If dr.Item("adjpos_sort") = pos Then
                                col = 0
                                mystring = "<tr>" & vbCrLf
                                Do While col < numcols
                                    If col = 0 Then sep = "th>" Else sep = "td>"
                                    If printcolbool(col) Then
                                        If col <> handicaptimecolno Or skiphcp = False Then
                                            mystring &= vbTab & "<" & sep & dr.Item(col) & "</" & sep & vbCrLf
                                        Else
                                            mystring &= vbTab & "<" & sep & "</" & sep & vbCrLf
                                        End If
                                    End If
                                    col += 1
                                Loop
                                mystring &= "</tr>"
                                swr.WriteLine(mystring)
                            End If
                        Next
                    Next
                Case "Category"

                    Dim rowno As Integer
                    Dim newcat As Integer
                    Dim catheadingsaved As Boolean
                    For newcat = 1 To no_cats 'how many categories do we have??
                        catheadingsaved = False
                        For rowno = 1 To numRows 'check every row
                            For Each dr In resultsDataTable.Rows
                                If dr.Item("Hcp") = "" Then skiphcp = True Else skiphcp = False
                                If dr.Item("cat_sort") = newcat Then
                                    If Not catheadingsaved Then
                                        swr.WriteLine("<tr>" & vbCrLf & "<td class=" & Chr(34) & "cat" & Chr(34) & " colspan=" & Chr(34) & (tablecols).ToString & Chr(34) & ">" & dr.Item("Category") & "</td>" & vbCrLf & "</tr>")
                                        catheadingsaved = True
                                    End If
                                    If dr.Item("cat_pos_sort") = rowno Then
                                        col = 0
                                        mystring = "<tr>" & vbCrLf
                                        Do While col < numcols
                                            If col = 3 Then sep = "th>" Else sep = "td>"
                                            If printcolbool(col) Then
                                                If col <> handicaptimecolno Or skiphcp = False Then
                                                    mystring &= vbTab & "<" & sep & dr.Item(col) & "</" & sep & vbCrLf
                                                Else
                                                    mystring &= vbTab & "<" & sep & "</" & sep & vbCrLf
                                                End If
                                            End If
                                            col += 1
                                        Loop
                                        mystring &= "</tr>"
                                        swr.WriteLine(mystring)
                                    End If
                                End If
                            Next
                        Next
                    Next
                Case "Club Order"
                    Dim rowno As Integer
                    Dim clubheadingsaved As Boolean
                    Dim clubno As Integer
                    For clubno = 1 To no_clubs
                        clubheadingsaved = False
                        For rowno = 1 To numRows 'check every row
                            For Each dr In resultsDataTable.Rows
                                If dr.Item("Hcp") = "" Then skiphcp = True Else skiphcp = False
                                If dr.Item("club_sort") = clubno Then
                                    If Not clubheadingsaved Then
                                        swr.WriteLine("<tr>" & vbCrLf & "<td class=" & Chr(34) & "cat" & Chr(34) & " colspan=" & Chr(34) & (tablecols).ToString & Chr(34) & ">" & dr.Item("Club") & "</td>" & vbCrLf & "</tr>")
                                        clubheadingsaved = True
                                    End If
                                    If dr.Item("club_pos_sort") = rowno Then
                                        col = 0
                                        mystring = "<tr>" & vbCrLf
                                        Do While col < numcols
                                            If col = 2 Then sep = "th>" Else sep = "td>"
                                            If printcolbool(col) Then
                                                If col <> handicaptimecolno Or skiphcp = False Then
                                                    mystring &= vbTab & "<" & sep & dr.Item(col) & "</" & sep & vbCrLf
                                                Else
                                                    mystring &= vbTab & "<" & sep & "</" & sep & vbCrLf
                                                End If
                                            End If
                                            col += 1
                                        Loop
                                        mystring &= "</tr>"
                                        swr.WriteLine(mystring)
                                    End If
                                End If
                            Next
                        Next
                    Next
                Case "Boat Type"
                    Dim rowno As Integer
                    Dim boatheadingsaved As Boolean
                    Dim boat As Integer
                    Dim boatstr As String

                    sep = "td>"

                    For boat = 0 To 10
                        boatstr = getboatstr(boat)
                        boatheadingsaved = False
                        For rowno = 1 To numRows
                            mystring = ""
                            For Each dr In resultsDataTable.Rows
                                If dr.Item("boat_type") = boat Then
                                    If Not boatheadingsaved Then
                                        swr.WriteLine("<tr>" & vbCrLf & "<td class=" & Chr(34) & "cat" & Chr(34) & " colspan=" & Chr(34) & (tablecols).ToString & Chr(34) & ">" & boatstr & "</td>" & vbCrLf & "</tr>")
                                        boatheadingsaved = True
                                    End If
                                    If dr.Item("boat_pos_sort") = rowno Then
                                        If dr.Item("Hcp") = "" Then skiphcp = True Else skiphcp = False
                                        col = 0
                                        mystring = "<tr>" & vbCrLf
                                        Do While col < numcols
                                            If printcolbool(col) Then
                                                If col <> handicaptimecolno Or skiphcp = False Then
                                                    mystring &= vbTab & "<" & sep & dr.Item(col) & "</" & sep & vbCrLf
                                                Else
                                                    mystring &= vbTab & "<" & sep & "</" & sep & vbCrLf
                                                End If
                                            End If
                                            col += 1
                                        Loop
                                        mystring &= "</tr>"
                                        swr.WriteLine(mystring)
                                    End If
                                End If
                            Next
                        Next
                    Next




            End Select
            swr.WriteLine("</tbody>")
            swr.WriteLine("</table>")
            swr.WriteLine()

            swr.WriteLine("</body>")
            swr.WriteLine("</html>")


            'end of finish results table
            swr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function getboatstr(ByVal boat_type As Int16)
        Dim str As String
        Select Case boat_type
            Case 1
                str = "Eights"
            Case 2
                str = "Coxless Quads"
            Case 3
                str = "Coxed Quads"
            Case 4
                str = "Straight Fours"
            Case 5
                str = "Coxed Fours"
            Case 6
                str = "Double Scull"
            Case 7
                str = "Coxless Pair"
            Case 8
                str = "Coxed Pair"
            Case 9
                str = "Single Scull"
            Case Else
                str = "Other Boat Types"
        End Select
        Return (str)
    End Function


    'clipboard code
    Private Sub clipboardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clipboardButton.Click
        Try
            Clipboard.SetDataObject(getclipasstring(), True)
            MsgBox("The Results Table data is now on the Windows Cipboard." & vbCrLf & "Please paste into Excel or similar")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function getclipasstring()
        Dim clip As String
        'header
        clip = Me.eventnameTextBox.Text & vbCrLf
        If Me.eventsponsorTextBox.TextLength > 0 Then
            clip &= "Event sponsored by - " & Me.eventsponsorTextBox.Text & vbCrLf
        End If
        clip &= Me.eventlocationTextBox.Text & vbCrLf & Me.eventDateTimePicker.Text & vbCrLf
        clip &= Me.eventdivisionTextBox.Text & vbCrLf & "Results" & vbCrLf
        Dim numRows, numcols, row, col As Integer
        numRows = Me.resultsDataTable.Rows.Count
        numcols = Me.resultsDataTable.Columns.Count
        col = 0
        Do While col < numcols
            clip &= Me.resultsDataTable.Columns.Item(col).ToString & vbTab
            col += 1
        Loop
        clip &= vbCrLf
        Dim mystring As String
        row = 0
        Do While row < numRows
            col = 0
            mystring = ""
            Do While col < numcols
                mystring &= Me.resultsDataTable.Rows(row).Item(col)
                mystring &= vbTab
                col += 1
            Loop
            row += 1
            clip &= mystring & vbCrLf
        Loop
        Return clip
    End Function
#End Region
#Region "options"
    Private Sub defaultsettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultsettingsButton.Click
        Me.bigbuttonCheckBox.CheckState = CheckState.Checked
        Me.fulleditCheckBox.CheckState = CheckState.Unchecked
        Me.autowinnercheckbox.CheckState = CheckState.Checked
        Me.startinbatches_NumericUpDown.Value = 1
        Me.startinbatchesCheckbox.CheckState = CheckState.Unchecked
    End Sub
    Private Sub startinbatches_NumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startinbatches_NumericUpDown.ValueChanged
        batchstartLabel.Text = "Starting in batches of " & Me.startinbatches_NumericUpDown.Value.ToString
    End Sub

    Private Sub startinbatchesCheckbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startinbatchesCheckbox.CheckedChanged
        batchstartLabel.Visible = sender.checkstate
    End Sub

#End Region       ' options
#Region "new routines from 'bownumber check' project"
    Private Sub timegrid_ignorerow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startDataGrid.CurrentCellChanged, split1DataGrid.CurrentCellChanged, split2DataGrid.CurrentCellChanged, finishDataGrid.CurrentCellChanged
        'this sub gives the user only the "comment" column as focus in a discontinued row.
        'and sets the bownumber column as the one getting the focus normally.
        'allows this to happen when full edit checked
        If Me.fulleditCheckBox.Checked Then Exit Sub
        Dim timegrid As DataGrid
        timegrid = sender
        If timegrid.CurrentCell.ColumnNumber = 3 Then Exit Sub ' exit if you're in the comment column
        Dim val As Object = timegrid(timegrid.CurrentRowIndex, 0)  ' 0 is the boolean column
        Dim liverow As Boolean = CBool(val)
        If Not liverow Then
            timegrid.CurrentCell = New DataGridCell(timegrid.CurrentRowIndex, 3)
        Else
            timegrid.CurrentCell = New DataGridCell(timegrid.CurrentRowIndex, 2)
        End If
    End Sub 'timegrid_Currentcellchanged
    Private Sub timegrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startDataGrid.Click, split1DataGrid.Click, split2DataGrid.Click, finishDataGrid.Click
        'this function makes teh valid column only need clicking once.
        Dim timegrid As DataGrid
        timegrid = sender
        Dim timetable As DataTable
        timetable = timegrid.DataSource
        Dim validColumn As Integer = 0
        Dim pt As Point = timegrid.PointToClient(Control.MousePosition)
        Dim hti As DataGrid.HitTestInfo = timegrid.HitTest(pt)
        If hti.Row < timetable.Rows.Count AndAlso hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = validColumn Then
            timegrid(hti.Row, validColumn) = Not CBool(timegrid(hti.Row, validColumn))
            timegrid.CurrentCell = New DataGridCell(timegrid.CurrentRowIndex, 3)
            refreshrow(hti.Row, timegrid)
        End If
    End Sub 'timegrid_Click
    Private Sub refreshrow(ByVal row As Integer, ByVal dg As DataGrid)
        Dim rect As Rectangle = dg.GetCellBounds(row, 0)
        rect = New Rectangle(rect.Left, rect.Top, dg.Width, rect.Height)
        dg.Invalidate(rect)
    End Sub

    Private Sub formatgridrow(ByVal sender As System.Object, ByVal e As DataGridFormatCellEventArgs)
        'this sub changes the ext colour of a row which has been checked "Ignore"
        Try
            Dim dg As DataGrid
            If startTabPage.Visible Then dg = startDataGrid
            If split1TabPage.Visible Then dg = split1DataGrid
            If split2TabPage.Visible Then dg = split2DataGrid
            If finishTabPage.Visible Then dg = finishDataGrid
            If Not dg(e.Row, 0) Then
                e.ForeBrush = Me.disabledtextbrush
            Else
                e.ForeBrush = Me.importantcolumnbrush
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "settings"

    Private Sub loadsettings()
        'todo make this much more comprehensive
        Me.bigbuttonCheckBox.Checked = startform.settingsarray(0)
        Me.fulleditCheckBox.Checked = startform.settingsarray(1)
        Me.autowinnercheckbox.Checked = startform.settingsarray(2)
    End Sub
    Private Sub savesettings()
        'proceedure called on form disposing only
        'may make this sub public and call from elsewhere??
        Dim path As String
        path = Application.StartupPath
        path &= "\rowingtimer_settings.ini"
        Dim swr As StreamWriter = File.CreateText(path)
        Dim linestring As String
        'file version
        swr.WriteLine("ini file -  version 1.1")
        swr.WriteLine("rowing timer version " & versionstring)
        swr.WriteLine("last used " & Now.ToLongTimeString)
        swr.WriteLine("<<lastfilesaved>>")
        swr.WriteLine("")
        swr.WriteLine("")
        swr.WriteLine("")
        swr.WriteLine("<<options>>")
        swr.WriteLine(bigbuttonCheckBox.CheckState)
        swr.WriteLine(fulleditCheckBox.CheckState)
        swr.WriteLine(autowinnercheckbox.CheckState)
        swr.WriteLine("<</options>>")
        swr.Close()
    End Sub
#End Region 'settings
#Region "wizards"



#End Region 'wizards
#Region "misc"
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.startlockCheckBox.BackColor = startTabPage.BackColor
        Me.split1lockCheckBox.BackColor = split1TabPage.BackColor
        Me.split2lockCheckBox.BackColor = split2TabPage.BackColor
        Me.finishlockCheckBox.BackColor = finishTabPage.BackColor
        Timer2.Stop()
    End Sub

    Private Sub tablehandlers()
        'AddHandler crewDataTable.ColumnChanging, AddressOf alert ' handld elsewhere
        AddHandler startdataTable.ColumnChanging, AddressOf alert
        AddHandler split1DataTable.ColumnChanging, AddressOf alert
        AddHandler split2DataTable.ColumnChanging, AddressOf alert
        AddHandler finishDataTable.ColumnChanging, AddressOf alert
    End Sub
    Sub alert(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs)
        'If startdataTable.HasErrors Then MsgBox("start errors")
        Label_data.Visible = (crewDataTable.HasErrors Or startdataTable.HasErrors Or Me.split1DataTable.HasErrors Or Me.split2DataTable.HasErrors Or Me.finishDataTable.HasErrors)
        warningLabel.Visible = True
    End Sub
    Sub endalert()
        Label_data.Visible = (crewDataTable.HasErrors Or startdataTable.HasErrors Or Me.split1DataTable.HasErrors Or Me.split2DataTable.HasErrors Or Me.finishDataTable.HasErrors)
        warningLabel.Visible = False
        'MyBase.BackColor = System.Drawing.SystemColors.ControlLightLight
    End Sub

    Private Sub version_history(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_versionhistory.Click
        Try
            Help.ShowHelp(Me, HelpProvider2.HelpNamespace)
        Catch
            MsgBox("Version History not found")
        End Try
    End Sub


    Private Sub CheckBox_goldmedaloption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_goldmedaloption.CheckedChanged
        MsgBox("not yet available")
    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            startform = startupform.ActiveForm
            Dim helppath As String
            helppath = Application.StartupPath & "\helppages\index.html"
            Me.HelpProvider1.HelpNamespace = helppath
            Me.HelpProvider2.HelpNamespace = Application.StartupPath & "\version_history.txt"
            initiatemessagelabels()
            loadsettings()
            datagridreadonlysetup()
            tablestyles(fulleditCheckBox.Checked)
            Me.disabledtextbrush = New SolidBrush(SystemColors.InactiveCaptionText)
            Me.importantcolumnbrush = New SolidBrush(SystemColors.ControlText)
            loadoptions()
            register_f_keys() 'register f1,f2,f3 and f4 keys
            Timer1.Start()
            loading = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.warningLabel.Visible = False
        versionLabel.Text = version
        Me.uniformwatches()
        tablehandlers()
        'initiate_secretpanel() 'todo put this back in
        Me.startform.Hide()
    End Sub

    'todo sort out these bloody crewdata table errors
    Private Sub Label_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_data.Click
        Dim myRow As DataRow
        For Each myRow In crewDataTable.GetErrors()
            Console.WriteLine("Bow number = " & myRow("Bow Number").ToString())
            Console.WriteLine(" Error = " & myRow.RowError & vbCrLf)
        Next
    End Sub


    Private Sub MenuItem_importstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_importstart.Click
        Me.importwatch_data("Start")
    End Sub
    Private Sub importwatch_data(ByVal watch As String)
        If crewDataTable.Rows.Count = 0 Then
            watchdata(watch, True)
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Overwrite existing " & watch & " data?" & vbCrLf & "'click 'No' to add data to the end of existing items", MsgBoxStyle.YesNoCancel)
            If result = MsgBoxResult.Yes Then
                watchdata(watch, True)
            ElseIf result = MsgBoxResult.No Then
                watchdata(watch, False)
            End If
        End If
    End Sub

    Private Sub watchdata(ByVal watch As String, ByVal replace As Boolean)
        Dim filepath As String
        OpenFileDialog1.Filter = "Rowing Timer Files(*.rot)|*.rot"
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        If OpenFileDialog1.FileName <> "" Then
            filepath = OpenFileDialog1.FileName
        End If
        loading = True
        loadevent(filepath, watch, replace) ' true means we are importing
        loading = False
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        '/a click on the import split1 data
        Me.importwatch_data("Split1")
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Me.importwatch_data("Split2")
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Me.importwatch_data("Finish")
    End Sub

    Private Sub MenuItem_crews_displaypanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_crews_displaypanel.Click, Button_crewcheck.Click
        ' mysecretpanel.Location = New Point(MyBase.Location.X + MyBase.Width, MyBase.Location.Y)
        mysecretpanel.Show()
        mysecretpanel.BringToFront()
    End Sub

    Private Sub MenuItem_offset_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_offset_start.Click
        Dim mywiz As New offsettimesForm
        mywiz.watchstr = "Start"
        mywiz.Show()
    End Sub

    Private Sub MenuItem_offset_split1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_offset_split1.Click
        Dim mywiz As New offsettimesForm
        mywiz.watchstr = "Split1"
        mywiz.Show()
    End Sub

    Private Sub MenuItem_offset_split2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_offset_split2.Click
        Dim mywiz As New offsettimesForm
        mywiz.watchstr = "Split2"
        mywiz.Show()
    End Sub

    Private Sub MenuItem_offset_finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_offset_finish.Click
        Dim mywiz As New offsettimesForm
        mywiz.watchstr = "Finish"
        mywiz.Show()
    End Sub

    Private Sub Menuitem_backup_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menuitem_backup_start.Click
        manual("START TIMES", startdataTable)
    End Sub

    Sub manual(ByVal title As String, ByVal dttab As DataTable)
        Try
            Dim mybackup As New backupForm
            mybackup.Text = title & " - " & mybackup.Text
            mybackup.mydt = dttab
            If mybackup.ShowDialog(Me) = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                If dttab.Rows.Count > 0 Then dttab.Clear()
                Dim dr, sdr As DataRow
                Dim pn As timeinputpanel
                For Each dr In crewDataTable.Rows
                    For Each pn In mybackup.Panel1.Controls
                        If Val(dr.Item("Bow Number")) = pn.bow_number And Not pn.timestring = "" Then
                            sdr = dttab.NewRow
                            sdr.Item("valid") = True
                            sdr.Item("time") = pn.timestring
                            sdr.Item("Bow Number") = pn.bow_number
                            sdr.Item("Comments") = pn.comments
                            dttab.Rows.Add(sdr)
                        End If
                    Next
                Next
                Cursor = Cursors.Default
            Else
                MsgBox("no changes made")
            End If
            mybackup.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        manual("Split 1", split1DataTable)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        manual("Split 2", split2DataTable)
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        manual("Finish", finishDataTable)
    End Sub

End Class

    