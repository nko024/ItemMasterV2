<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevExpress.XtraBars.TabForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TabFormPage1 = New DevExpress.XtraBars.TabFormPage()
        Me.TabFormContentContainer1 = New DevExpress.XtraBars.TabFormContentContainer()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFormContentContainer1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.SkinBarSubItem1})
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Manager = Me.TabFormDefaultManager1
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.Pages.Add(Me.TabFormPage1)
        Me.TabFormControl1.SelectedPage = Me.TabFormPage1
        Me.TabFormControl1.Size = New System.Drawing.Size(762, 50)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 0
        Me.TabFormControl1.TabLeftItemLinks.Add(Me.SkinBarSubItem1)
        Me.TabFormControl1.TabLeftItemLinks.Add(Me.BarButtonItem1)
        Me.TabFormControl1.TabStop = False
        Me.TabFormControl1.Text = "Inventory Master"
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.DockingEnabled = False
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.SkinBarSubItem1})
        Me.TabFormDefaultManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 50)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(762, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 516)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(762, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 50)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 466)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(762, 50)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 466)
        '
        'TabFormPage1
        '
        Me.TabFormPage1.ContentContainer = Me.TabFormContentContainer1
        Me.TabFormPage1.Name = "TabFormPage1"
        Me.TabFormPage1.Text = "Details"
        '
        'TabFormContentContainer1
        '
        Me.TabFormContentContainer1.Controls.Add(Me.LayoutControl1)
        Me.TabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFormContentContainer1.Location = New System.Drawing.Point(0, 50)
        Me.TabFormContentContainer1.Name = "TabFormContentContainer1"
        Me.TabFormContentContainer1.Size = New System.Drawing.Size(762, 466)
        Me.TabFormContentContainer1.TabIndex = 1
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Home"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TextEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(762, 466)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(180, 120)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(110, 42)
        Me.TextEdit1.MenuManager = Me.TabFormDefaultManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(628, 20)
        Me.TextEdit1.StyleController = Me.LayoutControl1
        Me.TextEdit1.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(718, 404)
        Me.LayoutControlItem1.Text = "Item Description:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(742, 446)
        Me.LayoutControlGroup2.Text = "Details:"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Id = 1
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 516)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.TabFormContentContainer1)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Name = "Form1"
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "Form1"
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFormContentContainer1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TabFormContentContainer1 As DevExpress.XtraBars.TabFormContentContainer
    Friend WithEvents TabFormPage1 As DevExpress.XtraBars.TabFormPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
End Class
