namespace AoEProtoChanger
{
    partial class MainForm
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
            this.lblProto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtoPath = new System.Windows.Forms.TextBox();
            this.txtProtoyPath = new System.Windows.Forms.TextBox();
            this.btnBrowseProto = new System.Windows.Forms.Button();
            this.btnBrowseProtoy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPopCount = new System.Windows.Forms.TextBox();
            this.btnUpdateFiles = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openProtoFile = new System.Windows.Forms.OpenFileDialog();
            this.openProtoYFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblProto
            // 
            this.lblProto.AutoSize = true;
            this.lblProto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProto.Location = new System.Drawing.Point(42, 36);
            this.lblProto.Name = "lblProto";
            this.lblProto.Size = new System.Drawing.Size(140, 18);
            this.lblProto.TabIndex = 0;
            this.lblProto.Text = "Select proto.xml file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select protoy.xml file :";
            // 
            // txtProtoPath
            // 
            this.txtProtoPath.Location = new System.Drawing.Point(190, 34);
            this.txtProtoPath.Name = "txtProtoPath";
            this.txtProtoPath.ReadOnly = true;
            this.txtProtoPath.Size = new System.Drawing.Size(252, 20);
            this.txtProtoPath.TabIndex = 2;
            // 
            // txtProtoyPath
            // 
            this.txtProtoyPath.Location = new System.Drawing.Point(190, 68);
            this.txtProtoyPath.Name = "txtProtoyPath";
            this.txtProtoyPath.ReadOnly = true;
            this.txtProtoyPath.Size = new System.Drawing.Size(252, 20);
            this.txtProtoyPath.TabIndex = 3;
            // 
            // btnBrowseProto
            // 
            this.btnBrowseProto.Location = new System.Drawing.Point(448, 32);
            this.btnBrowseProto.Name = "btnBrowseProto";
            this.btnBrowseProto.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseProto.TabIndex = 4;
            this.btnBrowseProto.Text = "Browse";
            this.btnBrowseProto.UseVisualStyleBackColor = true;
            this.btnBrowseProto.Click += new System.EventHandler(this.btnBrowseProto_Click);
            // 
            // btnBrowseProtoy
            // 
            this.btnBrowseProtoy.Location = new System.Drawing.Point(448, 66);
            this.btnBrowseProtoy.Name = "btnBrowseProtoy";
            this.btnBrowseProtoy.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseProtoy.TabIndex = 5;
            this.btnBrowseProtoy.Text = "Browse";
            this.btnBrowseProtoy.UseVisualStyleBackColor = true;
            this.btnBrowseProtoy.Click += new System.EventHandler(this.btnBrowseProtoy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Population Count Multiplier :";
            // 
            // txtPopCount
            // 
            this.txtPopCount.Location = new System.Drawing.Point(233, 130);
            this.txtPopCount.Name = "txtPopCount";
            this.txtPopCount.Size = new System.Drawing.Size(95, 20);
            this.txtPopCount.TabIndex = 7;
            // 
            // btnUpdateFiles
            // 
            this.btnUpdateFiles.Location = new System.Drawing.Point(334, 128);
            this.btnUpdateFiles.Name = "btnUpdateFiles";
            this.btnUpdateFiles.Size = new System.Drawing.Size(108, 23);
            this.btnUpdateFiles.TabIndex = 8;
            this.btnUpdateFiles.Text = "Update Files";
            this.btnUpdateFiles.UseVisualStyleBackColor = true;
            this.btnUpdateFiles.Click += new System.EventHandler(this.btnUpdateFiles_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openProtoFile
            // 
            this.openProtoFile.FileName = "openProtoFile";
            this.openProtoFile.Filter = "Xml File|*.xml";
            // 
            // openProtoYFile
            // 
            this.openProtoYFile.FileName = "openProtoYFile";
            this.openProtoYFile.Filter = "Xml File|*.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 184);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateFiles);
            this.Controls.Add(this.txtPopCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseProtoy);
            this.Controls.Add(this.btnBrowseProto);
            this.Controls.Add(this.txtProtoyPath);
            this.Controls.Add(this.txtProtoPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AoE 3 Proto Changer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtoPath;
        private System.Windows.Forms.TextBox txtProtoyPath;
        private System.Windows.Forms.Button btnBrowseProto;
        private System.Windows.Forms.Button btnBrowseProtoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPopCount;
        private System.Windows.Forms.Button btnUpdateFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openProtoFile;
        private System.Windows.Forms.OpenFileDialog openProtoYFile;
    }
}

