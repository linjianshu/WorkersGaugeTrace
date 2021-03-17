
namespace MachineryProcessingDemo
{
    partial class WorkerGauge
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
            this.ShelvesIdTxt = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ShelvesNameTxt = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.Label();
            this.BadReasonLbl = new System.Windows.Forms.Label();
            this.ToolingIdTxt = new System.Windows.Forms.TextBox();
            this.ToolingNameTxt = new System.Windows.Forms.TextBox();
            this.ucSplitLine_V2 = new HZH_Controls.Controls.UCSplitLine_V();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ToolingTypeTxt = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucSplitLine_V2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BadReasonLbl);
            this.panel3.Controls.Add(this.ProductType);
            this.panel3.Controls.Add(this.ToolingTypeTxt);
            this.panel3.Controls.Add(this.ToolingNameTxt);
            this.panel3.Controls.Add(this.ToolingIdTxt);
            this.panel3.Controls.Add(this.ShelvesIdTxt);
            this.panel3.Controls.Add(this.ProductIDLbl);
            this.panel3.Controls.Add(this.ShelvesNameTxt);
            this.panel3.Controls.Add(this.ProductNameLbl);
            this.panel3.Size = new System.Drawing.Size(553, 250);
            // 
            // ShelvesIdTxt
            // 
            this.ShelvesIdTxt.BackColor = System.Drawing.Color.White;
            this.ShelvesIdTxt.Location = new System.Drawing.Point(121, 170);
            this.ShelvesIdTxt.Name = "ShelvesIdTxt";
            this.ShelvesIdTxt.Size = new System.Drawing.Size(143, 32);
            this.ShelvesIdTxt.TabIndex = 6;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductIDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductIDLbl.Location = new System.Drawing.Point(12, 174);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(93, 26);
            this.ProductIDLbl.TabIndex = 4;
            this.ProductIDLbl.Text = "货架编号:";
            // 
            // ShelvesNameTxt
            // 
            this.ShelvesNameTxt.BackColor = System.Drawing.Color.White;
            this.ShelvesNameTxt.Location = new System.Drawing.Point(121, 97);
            this.ShelvesNameTxt.Name = "ShelvesNameTxt";
            this.ShelvesNameTxt.Size = new System.Drawing.Size(143, 32);
            this.ShelvesNameTxt.TabIndex = 7;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductNameLbl.Location = new System.Drawing.Point(12, 101);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(93, 26);
            this.ProductNameLbl.TabIndex = 5;
            this.ProductNameLbl.Text = "货架名称:";
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductType.Location = new System.Drawing.Point(281, 72);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(112, 26);
            this.ProductType.TabIndex = 8;
            this.ProductType.Text = "工量具编号:";
            // 
            // BadReasonLbl
            // 
            this.BadReasonLbl.AutoSize = true;
            this.BadReasonLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BadReasonLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BadReasonLbl.Location = new System.Drawing.Point(282, 133);
            this.BadReasonLbl.Name = "BadReasonLbl";
            this.BadReasonLbl.Size = new System.Drawing.Size(112, 26);
            this.BadReasonLbl.TabIndex = 8;
            this.BadReasonLbl.Text = "工量具名称:";
            // 
            // ToolingIdTxt
            // 
            this.ToolingIdTxt.BackColor = System.Drawing.Color.White;
            this.ToolingIdTxt.Location = new System.Drawing.Point(397, 69);
            this.ToolingIdTxt.Name = "ToolingIdTxt";
            this.ToolingIdTxt.Size = new System.Drawing.Size(143, 32);
            this.ToolingIdTxt.TabIndex = 6;
            // 
            // ToolingNameTxt
            // 
            this.ToolingNameTxt.BackColor = System.Drawing.Color.White;
            this.ToolingNameTxt.Location = new System.Drawing.Point(397, 130);
            this.ToolingNameTxt.Name = "ToolingNameTxt";
            this.ToolingNameTxt.Size = new System.Drawing.Size(143, 32);
            this.ToolingNameTxt.TabIndex = 6;
            // 
            // ucSplitLine_V2
            // 
            this.ucSplitLine_V2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_V2.Location = new System.Drawing.Point(276, -3);
            this.ucSplitLine_V2.Name = "ucSplitLine_V2";
            this.ucSplitLine_V2.Size = new System.Drawing.Size(1, 281);
            this.ucSplitLine_V2.TabIndex = 9;
            this.ucSplitLine_V2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(281, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "工量具类型:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ToolingTypeTxt
            // 
            this.ToolingTypeTxt.BackColor = System.Drawing.Color.White;
            this.ToolingTypeTxt.Location = new System.Drawing.Point(397, 189);
            this.ToolingTypeTxt.Name = "ToolingTypeTxt";
            this.ToolingTypeTxt.Size = new System.Drawing.Size(143, 32);
            this.ToolingTypeTxt.TabIndex = 6;
            // 
            // ScanOfflineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(553, 374);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ScanOfflineForm";
            this.Text = "ScanOfflineForm";
            this.Title = "工量具绑定";
            this.Load += new System.EventHandler(this.ScanOfflineForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ShelvesIdTxt;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.TextBox ShelvesNameTxt;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.Label BadReasonLbl;
        private System.Windows.Forms.TextBox ToolingNameTxt;
        private System.Windows.Forms.TextBox ToolingIdTxt;
        private HZH_Controls.Controls.UCSplitLine_V ucSplitLine_V2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox ToolingTypeTxt;
    }
}