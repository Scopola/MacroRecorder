﻿namespace MacroRecorder.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmMacro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordANewMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMacro.SuspendLayout();
            this.cmEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEvents.ContextMenuStrip = this.cmMacro;
            this.lvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.Location = new System.Drawing.Point(0, 0);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(405, 275);
            this.lvEvents.TabIndex = 0;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 165;
            // 
            // cmMacro
            // 
            this.cmMacro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMacroToolStripMenuItem,
            this.editToolStripMenuItem,
            this.recordANewMacroToolStripMenuItem,
            this.saveMacroToolStripMenuItem,
            this.loadAMacroToolStripMenuItem});
            this.cmMacro.Name = "cmMacro";
            this.cmMacro.Size = new System.Drawing.Size(153, 136);
            // 
            // playMacroToolStripMenuItem
            // 
            this.playMacroToolStripMenuItem.Name = "playMacroToolStripMenuItem";
            this.playMacroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playMacroToolStripMenuItem.Text = "Play";
            this.playMacroToolStripMenuItem.Click += new System.EventHandler(this.playMacroToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectItemsToolStripMenuItem,
            this.removeSelectedEventToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeSelectedEventToolStripMenuItem
            // 
            this.removeSelectedEventToolStripMenuItem.Name = "removeSelectedEventToolStripMenuItem";
            this.removeSelectedEventToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.removeSelectedEventToolStripMenuItem.Text = "Remove selected events";
            this.removeSelectedEventToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedEventToolStripMenuItem_Click);
            // 
            // recordANewMacroToolStripMenuItem
            // 
            this.recordANewMacroToolStripMenuItem.Name = "recordANewMacroToolStripMenuItem";
            this.recordANewMacroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordANewMacroToolStripMenuItem.Text = "Record New";
            this.recordANewMacroToolStripMenuItem.Click += new System.EventHandler(this.recordANewMacroToolStripMenuItem_Click);
            // 
            // saveMacroToolStripMenuItem
            // 
            this.saveMacroToolStripMenuItem.Name = "saveMacroToolStripMenuItem";
            this.saveMacroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMacroToolStripMenuItem.Text = "Save";
            this.saveMacroToolStripMenuItem.Click += new System.EventHandler(this.saveMacroToolStripMenuItem_Click);
            // 
            // loadAMacroToolStripMenuItem
            // 
            this.loadAMacroToolStripMenuItem.Name = "loadAMacroToolStripMenuItem";
            this.loadAMacroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadAMacroToolStripMenuItem.Text = "Load";
            this.loadAMacroToolStripMenuItem.Click += new System.EventHandler(this.loadAMacroToolStripMenuItem_Click);
            // 
            // cmEdit
            // 
            this.cmEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveHereToolStripMenuItem,
            this.deselectToolStripMenuItem});
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(133, 48);
            // 
            // moveHereToolStripMenuItem
            // 
            this.moveHereToolStripMenuItem.Name = "moveHereToolStripMenuItem";
            this.moveHereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveHereToolStripMenuItem.Text = "Move Here";
            this.moveHereToolStripMenuItem.Click += new System.EventHandler(this.moveHereToolStripMenuItem_Click);
            // 
            // deselectToolStripMenuItem
            // 
            this.deselectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.allToolStripMenuItem});
            this.deselectToolStripMenuItem.Name = "deselectToolStripMenuItem";
            this.deselectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deselectToolStripMenuItem.Text = "Deselect";
            this.deselectToolStripMenuItem.Click += new System.EventHandler(this.deselectToolStripMenuItem_Click);
            // 
            // selectItemsToolStripMenuItem
            // 
            this.selectItemsToolStripMenuItem.Name = "selectItemsToolStripMenuItem";
            this.selectItemsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectItemsToolStripMenuItem.Text = "Select Items";
            this.selectItemsToolStripMenuItem.Click += new System.EventHandler(this.selectItemsToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 275);
            this.Controls.Add(this.lvEvents);
            this.Name = "MainWindow";
            this.Text = "Macro Recorder - BahNahNah";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cmMacro.ResumeLayout(false);
            this.cmEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip cmMacro;
        private System.Windows.Forms.ToolStripMenuItem playMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordANewMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectItemsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmEdit;
        private System.Windows.Forms.ToolStripMenuItem moveHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;

    }
}