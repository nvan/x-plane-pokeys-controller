﻿
namespace nvan.PoKeysConnector
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.connectButton = new System.Windows.Forms.Button();
            this.poKeysIpTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.eventsList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pinHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRefHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.writeValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ioHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceLabel = new System.Windows.Forms.Label();
            this.xplaneIpLabel = new System.Windows.Forms.Label();
            this.xPlaneIpTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.cpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.reconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.logButton = new System.Windows.Forms.Button();
            this.autoDiscoveryCheckBox = new System.Windows.Forms.CheckBox();
            this.pokeysList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(180, 38);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(200, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // poKeysIpTextBox
            // 
            this.poKeysIpTextBox.Location = new System.Drawing.Point(74, 12);
            this.poKeysIpTextBox.Name = "poKeysIpTextBox";
            this.poKeysIpTextBox.Size = new System.Drawing.Size(100, 20);
            this.poKeysIpTextBox.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 60;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // eventsList
            // 
            this.eventsList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.eventsList.AllowColumnReorder = true;
            this.eventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.pinHeader,
            this.readValueHeader,
            this.dataRefHeader,
            this.writeValueHeader,
            this.ioHeader});
            this.eventsList.HideSelection = false;
            this.eventsList.Location = new System.Drawing.Point(15, 67);
            this.eventsList.MultiSelect = false;
            this.eventsList.Name = "eventsList";
            this.eventsList.ShowGroups = false;
            this.eventsList.Size = new System.Drawing.Size(707, 220);
            this.eventsList.TabIndex = 0;
            this.eventsList.UseCompatibleStateImageBehavior = false;
            this.eventsList.View = System.Windows.Forms.View.Details;
            this.eventsList.DoubleClick += new System.EventHandler(this.editButton_Click);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 146;
            // 
            // pinHeader
            // 
            this.pinHeader.Text = "Pin";
            this.pinHeader.Width = 41;
            // 
            // readValueHeader
            // 
            this.readValueHeader.Text = "Read Value";
            this.readValueHeader.Width = 71;
            // 
            // dataRefHeader
            // 
            this.dataRefHeader.Text = "DataRef";
            this.dataRefHeader.Width = 254;
            // 
            // writeValueHeader
            // 
            this.writeValueHeader.Text = "Write Value";
            this.writeValueHeader.Width = 67;
            // 
            // ioHeader
            // 
            this.ioHeader.Text = "I/O";
            this.ioHeader.Width = 28;
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(12, 15);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(56, 13);
            this.deviceLabel.TabIndex = 9;
            this.deviceLabel.Text = "PoKeys IP";
            // 
            // xplaneIpLabel
            // 
            this.xplaneIpLabel.AutoSize = true;
            this.xplaneIpLabel.Location = new System.Drawing.Point(12, 41);
            this.xplaneIpLabel.Name = "xplaneIpLabel";
            this.xplaneIpLabel.Size = new System.Drawing.Size(57, 13);
            this.xplaneIpLabel.TabIndex = 10;
            this.xplaneIpLabel.Text = "X-Plane IP";
            // 
            // xPlaneIpTextBox
            // 
            this.xPlaneIpTextBox.Location = new System.Drawing.Point(74, 38);
            this.xPlaneIpTextBox.Name = "xPlaneIpTextBox";
            this.xPlaneIpTextBox.Size = new System.Drawing.Size(100, 20);
            this.xPlaneIpTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(12, 293);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(93, 293);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(174, 293);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Delete";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(383, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(109, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Status: Disconnected";
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(264, 15);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(116, 17);
            this.autoStartCheckBox.TabIndex = 16;
            this.autoStartCheckBox.Text = "Connect at start up";
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // cpuProgressBar
            // 
            this.cpuProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuProgressBar.Location = new System.Drawing.Point(386, 38);
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.Size = new System.Drawing.Size(336, 23);
            this.cpuProgressBar.TabIndex = 17;
            // 
            // reconnectTimer
            // 
            this.reconnectTimer.Interval = 1000;
            this.reconnectTimer.Tick += new System.EventHandler(this.reconnectTimer_Tick);
            // 
            // logButton
            // 
            this.logButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logButton.Location = new System.Drawing.Point(255, 293);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(43, 23);
            this.logButton.TabIndex = 18;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // autoDiscoveryCheckBox
            // 
            this.autoDiscoveryCheckBox.AutoSize = true;
            this.autoDiscoveryCheckBox.Location = new System.Drawing.Point(180, 15);
            this.autoDiscoveryCheckBox.Name = "autoDiscoveryCheckBox";
            this.autoDiscoveryCheckBox.Size = new System.Drawing.Size(78, 17);
            this.autoDiscoveryCheckBox.TabIndex = 19;
            this.autoDiscoveryCheckBox.Text = "USB Mode";
            this.autoDiscoveryCheckBox.UseVisualStyleBackColor = true;
            this.autoDiscoveryCheckBox.CheckedChanged += new System.EventHandler(this.autoDiscoveryCheckBox_CheckedChanged);
            // 
            // pokeysList
            // 
            this.pokeysList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokeysList.FormattingEnabled = true;
            this.pokeysList.Location = new System.Drawing.Point(74, 11);
            this.pokeysList.Name = "pokeysList";
            this.pokeysList.Size = new System.Drawing.Size(100, 21);
            this.pokeysList.TabIndex = 20;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 328);
            this.Controls.Add(this.pokeysList);
            this.Controls.Add(this.autoDiscoveryCheckBox);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.cpuProgressBar);
            this.Controls.Add(this.autoStartCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.xPlaneIpTextBox);
            this.Controls.Add(this.xplaneIpLabel);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.poKeysIpTextBox);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 2000);
            this.MinimumSize = new System.Drawing.Size(650, 367);
            this.Name = "mainForm";
            this.Text = "NVAN PoKeys Connector for X-Plane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox poKeysIpTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView eventsList;
        private System.Windows.Forms.ColumnHeader pinHeader;
        private System.Windows.Forms.ColumnHeader readValueHeader;
        private System.Windows.Forms.ColumnHeader dataRefHeader;
        private System.Windows.Forms.ColumnHeader writeValueHeader;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Label xplaneIpLabel;
        private System.Windows.Forms.TextBox xPlaneIpTextBox;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ColumnHeader ioHeader;
        private System.Windows.Forms.CheckBox autoStartCheckBox;
        private System.Windows.Forms.ProgressBar cpuProgressBar;
        private System.Windows.Forms.Timer reconnectTimer;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.CheckBox autoDiscoveryCheckBox;
        private System.Windows.Forms.ComboBox pokeysList;
    }
}

