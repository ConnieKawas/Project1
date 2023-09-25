<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentalHealthResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Snow
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.MentalHealthResourcesToolStripMenuItem, Me.QuestionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(998, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MentalHealthResourcesToolStripMenuItem
        '
        Me.MentalHealthResourcesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticlesToolStripMenuItem})
        Me.MentalHealthResourcesToolStripMenuItem.Name = "MentalHealthResourcesToolStripMenuItem"
        Me.MentalHealthResourcesToolStripMenuItem.Size = New System.Drawing.Size(232, 29)
        Me.MentalHealthResourcesToolStripMenuItem.Text = "Mental Health Resources"
        '
        'ArticlesToolStripMenuItem
        '
        Me.ArticlesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ArticlesToolStripMenuItem.Name = "ArticlesToolStripMenuItem"
        Me.ArticlesToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ArticlesToolStripMenuItem.Text = "Articles"
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SectionAToolStripMenuItem})
        Me.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem"
        Me.QuestionToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.QuestionToolStripMenuItem.Text = "Question"
        '
        'SectionAToolStripMenuItem
        '
        Me.SectionAToolStripMenuItem.Name = "SectionAToolStripMenuItem"
        Me.SectionAToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.SectionAToolStripMenuItem.Text = "Section A"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(596, 71)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Be aware that taking care of your mental health is just as important as physical " &
    "health."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 66)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Take a Mental Health Test."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(574, 70)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Online screening is one of the quickest and easiest ways to determine ehether you" &
    " are experiencing symtoms of a mental health condition."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 709)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents MentalHealthResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
