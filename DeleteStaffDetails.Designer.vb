﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteStaffDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteStaffDetails))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.DeleteStaffDetailsPanel = New System.Windows.Forms.Panel()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.DeleteStaffDetailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(320, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Delete"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteStaffDetailsPanel
        '
        Me.DeleteStaffDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeleteStaffDetailsPanel.Controls.Add(Me.YesButton)
        Me.DeleteStaffDetailsPanel.Controls.Add(Me.NoButton)
        Me.DeleteStaffDetailsPanel.Controls.Add(Me.StatusLabel)
        Me.DeleteStaffDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteStaffDetailsPanel.Location = New System.Drawing.Point(0, 50)
        Me.DeleteStaffDetailsPanel.Name = "DeleteStaffDetailsPanel"
        Me.DeleteStaffDetailsPanel.Size = New System.Drawing.Size(320, 190)
        Me.DeleteStaffDetailsPanel.TabIndex = 0
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Green
        Me.NoButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoButton.ForeColor = System.Drawing.Color.White
        Me.NoButton.Location = New System.Drawing.Point(180, 140)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(60, 40)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(20, 20)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(280, 100)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Are you sure, You want to delete the selected staff record?"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Red
        Me.YesButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesButton.ForeColor = System.Drawing.Color.White
        Me.YesButton.Location = New System.Drawing.Point(80, 140)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(60, 40)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'DeleteStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 240)
        Me.Controls.Add(Me.DeleteStaffDetailsPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteStaffDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Staff Details"
        Me.DeleteStaffDetailsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents DeleteStaffDetailsPanel As Panel
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
    Friend WithEvents StatusLabel As Label
End Class
