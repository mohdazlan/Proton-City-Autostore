<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.pbClient = New System.Windows.Forms.PictureBox()
        Me.pbInvoice = New System.Windows.Forms.PictureBox()
        Me.pbOrders = New System.Windows.Forms.PictureBox()
        Me.pbUserProfile = New System.Windows.Forms.PictureBox()
        Me.pbNewUser = New System.Windows.Forms.PictureBox()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbClient
        '
        Me.pbClient.Image = Global.Proton_Auto_Store.My.Resources.Resources.clients
        Me.pbClient.Location = New System.Drawing.Point(28, 139)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(167, 88)
        Me.pbClient.TabIndex = 0
        Me.pbClient.TabStop = False
        '
        'pbInvoice
        '
        Me.pbInvoice.Image = Global.Proton_Auto_Store.My.Resources.Resources.invoice
        Me.pbInvoice.Location = New System.Drawing.Point(213, 139)
        Me.pbInvoice.Name = "pbInvoice"
        Me.pbInvoice.Size = New System.Drawing.Size(167, 88)
        Me.pbInvoice.TabIndex = 1
        Me.pbInvoice.TabStop = False
        '
        'pbOrders
        '
        Me.pbOrders.Image = CType(resources.GetObject("pbOrders.Image"), System.Drawing.Image)
        Me.pbOrders.Location = New System.Drawing.Point(396, 139)
        Me.pbOrders.Name = "pbOrders"
        Me.pbOrders.Size = New System.Drawing.Size(167, 88)
        Me.pbOrders.TabIndex = 2
        Me.pbOrders.TabStop = False
        '
        'pbUserProfile
        '
        Me.pbUserProfile.Image = CType(resources.GetObject("pbUserProfile.Image"), System.Drawing.Image)
        Me.pbUserProfile.Location = New System.Drawing.Point(28, 246)
        Me.pbUserProfile.Name = "pbUserProfile"
        Me.pbUserProfile.Size = New System.Drawing.Size(167, 88)
        Me.pbUserProfile.TabIndex = 3
        Me.pbUserProfile.TabStop = False
        '
        'pbNewUser
        '
        Me.pbNewUser.Image = CType(resources.GetObject("pbNewUser.Image"), System.Drawing.Image)
        Me.pbNewUser.Location = New System.Drawing.Point(213, 246)
        Me.pbNewUser.Name = "pbNewUser"
        Me.pbNewUser.Size = New System.Drawing.Size(167, 88)
        Me.pbNewUser.TabIndex = 4
        Me.pbNewUser.TabStop = False
        '
        'pbReport
        '
        Me.pbReport.Image = CType(resources.GetObject("pbReport.Image"), System.Drawing.Image)
        Me.pbReport.Location = New System.Drawing.Point(396, 246)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(167, 88)
        Me.pbReport.TabIndex = 5
        Me.pbReport.TabStop = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbReport)
        Me.Controls.Add(Me.pbNewUser)
        Me.Controls.Add(Me.pbUserProfile)
        Me.Controls.Add(Me.pbOrders)
        Me.Controls.Add(Me.pbInvoice)
        Me.Controls.Add(Me.pbClient)
        Me.Name = "frmConfig"
        Me.Text = "frmConfig"
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbClient As PictureBox
    Friend WithEvents pbInvoice As PictureBox
    Friend WithEvents pbOrders As PictureBox
    Friend WithEvents pbUserProfile As PictureBox
    Friend WithEvents pbNewUser As PictureBox
    Friend WithEvents pbReport As PictureBox
End Class
