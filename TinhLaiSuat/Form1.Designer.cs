
namespace TinhLaiSuat
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttienbandau = new System.Windows.Forms.TextBox();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.nudnam = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttinh = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbketqua = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttienbandau, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtlaisuat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudnam, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(120, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 14, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tiền  ban đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 14, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lãi suất năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 14, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm";
            // 
            // txttienbandau
            // 
            this.txttienbandau.Location = new System.Drawing.Point(134, 10);
            this.txttienbandau.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.txttienbandau.Name = "txttienbandau";
            this.txttienbandau.Size = new System.Drawing.Size(120, 20);
            this.txttienbandau.TabIndex = 3;
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(134, 47);
            this.txtlaisuat.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(120, 20);
            this.txtlaisuat.TabIndex = 4;
            // 
            // nudnam
            // 
            this.nudnam.Location = new System.Drawing.Point(134, 84);
            this.nudnam.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.nudnam.Name = "nudnam";
            this.nudnam.Size = new System.Drawing.Size(120, 20);
            this.nudnam.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttinh);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Location = new System.Drawing.Point(389, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 112);
            this.panel1.TabIndex = 1;
            // 
            // bttinh
            // 
            this.bttinh.Location = new System.Drawing.Point(3, 47);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(107, 57);
            this.bttinh.TabIndex = 1;
            this.bttinh.Text = "Tính lãi suất";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(3, 10);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(107, 20);
            this.btxoa.TabIndex = 0;
            this.btxoa.Text = "Clear";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÍNH LÃI SUẤT";
            // 
            // rtbketqua
            // 
            this.rtbketqua.Location = new System.Drawing.Point(120, 213);
            this.rtbketqua.Name = "rtbketqua";
            this.rtbketqua.Size = new System.Drawing.Size(379, 110);
            this.rtbketqua.TabIndex = 3;
            this.rtbketqua.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 393);
            this.Controls.Add(this.rtbketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttienbandau;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.NumericUpDown nudnam;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.RichTextBox rtbketqua;
    }
}

