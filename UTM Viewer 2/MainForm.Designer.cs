namespace UTM_Viewer_2
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
            this.txtIPUTM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetAllTTN = new System.Windows.Forms.Button();
            this.tableTicket = new System.Windows.Forms.DataGridView();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetFormBRegInfo = new System.Windows.Forms.Button();
            this.txtFormBRegInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIPUTM
            // 
            this.txtIPUTM.Location = new System.Drawing.Point(87, 16);
            this.txtIPUTM.Name = "txtIPUTM";
            this.txtIPUTM.Size = new System.Drawing.Size(118, 20);
            this.txtIPUTM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "UTM IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetAllTTN
            // 
            this.btnGetAllTTN.Location = new System.Drawing.Point(211, 16);
            this.btnGetAllTTN.Name = "btnGetAllTTN";
            this.btnGetAllTTN.Size = new System.Drawing.Size(75, 21);
            this.btnGetAllTTN.TabIndex = 2;
            this.btnGetAllTTN.Text = "GET";
            this.btnGetAllTTN.UseVisualStyleBackColor = true;
            // 
            // tableTicket
            // 
            this.tableTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIP,
            this.colNumberPP,
            this.colDate,
            this.colType,
            this.colTTN,
            this.colOperation,
            this.colOperationResult,
            this.colComment});
            this.tableTicket.Location = new System.Drawing.Point(12, 43);
            this.tableTicket.Name = "tableTicket";
            this.tableTicket.Size = new System.Drawing.Size(617, 412);
            this.tableTicket.TabIndex = 4;
            // 
            // colIP
            // 
            this.colIP.Frozen = true;
            this.colIP.HeaderText = "ip";
            this.colIP.Name = "colIP";
            this.colIP.ReadOnly = true;
            this.colIP.Visible = false;
            // 
            // colNumberPP
            // 
            this.colNumberPP.FillWeight = 35.533F;
            this.colNumberPP.HeaderText = "№";
            this.colNumberPP.MaxInputLength = 25;
            this.colNumberPP.Name = "colNumberPP";
            this.colNumberPP.ReadOnly = true;
            this.colNumberPP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 110.7445F;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.FillWeight = 110.7445F;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colTTN
            // 
            this.colTTN.FillWeight = 110.7445F;
            this.colTTN.HeaderText = "TTN";
            this.colTTN.Name = "colTTN";
            this.colTTN.ReadOnly = true;
            // 
            // colOperation
            // 
            this.colOperation.FillWeight = 110.7445F;
            this.colOperation.HeaderText = "Operation";
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            // 
            // colOperationResult
            // 
            this.colOperationResult.FillWeight = 110.7445F;
            this.colOperationResult.HeaderText = "Result";
            this.colOperationResult.Name = "colOperationResult";
            this.colOperationResult.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.FillWeight = 110.7445F;
            this.colComment.HeaderText = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // btnGetFormBRegInfo
            // 
            this.btnGetFormBRegInfo.Location = new System.Drawing.Point(635, 15);
            this.btnGetFormBRegInfo.Name = "btnGetFormBRegInfo";
            this.btnGetFormBRegInfo.Size = new System.Drawing.Size(75, 21);
            this.btnGetFormBRegInfo.TabIndex = 5;
            this.btnGetFormBRegInfo.Text = "GET";
            this.btnGetFormBRegInfo.UseVisualStyleBackColor = true;
            // 
            // txtFormBRegInfo
            // 
            this.txtFormBRegInfo.Location = new System.Drawing.Point(635, 43);
            this.txtFormBRegInfo.Name = "txtFormBRegInfo";
            this.txtFormBRegInfo.Size = new System.Drawing.Size(188, 412);
            this.txtFormBRegInfo.TabIndex = 6;
            this.txtFormBRegInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 467);
            this.Controls.Add(this.txtFormBRegInfo);
            this.Controls.Add(this.btnGetFormBRegInfo);
            this.Controls.Add(this.tableTicket);
            this.Controls.Add(this.btnGetAllTTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPUTM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "UTM Viewer 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tableTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPUTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetAllTTN;
        private System.Windows.Forms.DataGridView tableTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.Button btnGetFormBRegInfo;
        private System.Windows.Forms.RichTextBox txtFormBRegInfo;
    }
}

