namespace FaceDetectionApp
{
    partial class FaceDetectionForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpFound = new System.Windows.Forms.TableLayoutPanel();
            this.pbDetect10 = new System.Windows.Forms.PictureBox();
            this.pbDetect7 = new System.Windows.Forms.PictureBox();
            this.pbDetect4 = new System.Windows.Forms.PictureBox();
            this.pbDetect3 = new System.Windows.Forms.PictureBox();
            this.pbDetect2 = new System.Windows.Forms.PictureBox();
            this.pbDetect1 = new System.Windows.Forms.PictureBox();
            this.pbDetect5 = new System.Windows.Forms.PictureBox();
            this.pbDetect6 = new System.Windows.Forms.PictureBox();
            this.pbDetect8 = new System.Windows.Forms.PictureBox();
            this.pbDetect9 = new System.Windows.Forms.PictureBox();
            this.pbDetect11 = new System.Windows.Forms.PictureBox();
            this.pbDetect12 = new System.Windows.Forms.PictureBox();
            this.btnDectect = new System.Windows.Forms.Button();
            this.tlpDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.nupMinNeighbour = new System.Windows.Forms.NumericUpDown();
            this.nupScale = new System.Windows.Forms.NumericUpDown();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpParameter = new System.Windows.Forms.TableLayoutPanel();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.pbDetect13 = new System.Windows.Forms.PictureBox();
            this.pbDetect14 = new System.Windows.Forms.PictureBox();
            this.pbDetect15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect12)).BeginInit();
            this.tlpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinNeighbour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupScale)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect15)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpDisplay.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.tlpDisplay.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(536, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tlpFound
            // 
            this.tlpFound.AutoScroll = true;
            this.tlpFound.ColumnCount = 3;
            this.tlpFound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFound.Controls.Add(this.pbDetect15, 2, 4);
            this.tlpFound.Controls.Add(this.pbDetect14, 1, 4);
            this.tlpFound.Controls.Add(this.pbDetect13, 0, 4);
            this.tlpFound.Controls.Add(this.pbDetect10, 0, 3);
            this.tlpFound.Controls.Add(this.pbDetect7, 0, 2);
            this.tlpFound.Controls.Add(this.pbDetect4, 0, 1);
            this.tlpFound.Controls.Add(this.pbDetect3, 2, 0);
            this.tlpFound.Controls.Add(this.pbDetect2, 1, 0);
            this.tlpFound.Controls.Add(this.pbDetect1, 0, 0);
            this.tlpFound.Controls.Add(this.pbDetect5, 1, 1);
            this.tlpFound.Controls.Add(this.pbDetect6, 2, 1);
            this.tlpFound.Controls.Add(this.pbDetect8, 1, 2);
            this.tlpFound.Controls.Add(this.pbDetect9, 2, 2);
            this.tlpFound.Controls.Add(this.pbDetect11, 1, 3);
            this.tlpFound.Controls.Add(this.pbDetect12, 2, 3);
            this.tlpFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFound.Location = new System.Drawing.Point(551, 3);
            this.tlpFound.Name = "tlpFound";
            this.tlpFound.RowCount = 5;
            this.tlpFound.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFound.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFound.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFound.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFound.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFound.Size = new System.Drawing.Size(644, 512);
            this.tlpFound.TabIndex = 9;
            // 
            // pbDetect10
            // 
            this.pbDetect10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect10.Location = new System.Drawing.Point(3, 621);
            this.pbDetect10.Name = "pbDetect10";
            this.pbDetect10.Size = new System.Drawing.Size(200, 200);
            this.pbDetect10.TabIndex = 11;
            this.pbDetect10.TabStop = false;
            // 
            // pbDetect7
            // 
            this.pbDetect7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect7.Location = new System.Drawing.Point(3, 415);
            this.pbDetect7.Name = "pbDetect7";
            this.pbDetect7.Size = new System.Drawing.Size(200, 200);
            this.pbDetect7.TabIndex = 8;
            this.pbDetect7.TabStop = false;
            // 
            // pbDetect4
            // 
            this.pbDetect4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect4.Location = new System.Drawing.Point(3, 209);
            this.pbDetect4.Name = "pbDetect4";
            this.pbDetect4.Size = new System.Drawing.Size(200, 200);
            this.pbDetect4.TabIndex = 5;
            this.pbDetect4.TabStop = false;
            // 
            // pbDetect3
            // 
            this.pbDetect3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect3.Location = new System.Drawing.Point(415, 3);
            this.pbDetect3.Name = "pbDetect3";
            this.pbDetect3.Size = new System.Drawing.Size(200, 200);
            this.pbDetect3.TabIndex = 4;
            this.pbDetect3.TabStop = false;
            // 
            // pbDetect2
            // 
            this.pbDetect2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect2.Location = new System.Drawing.Point(209, 3);
            this.pbDetect2.Name = "pbDetect2";
            this.pbDetect2.Size = new System.Drawing.Size(200, 200);
            this.pbDetect2.TabIndex = 3;
            this.pbDetect2.TabStop = false;
            // 
            // pbDetect1
            // 
            this.pbDetect1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect1.Location = new System.Drawing.Point(3, 3);
            this.pbDetect1.Name = "pbDetect1";
            this.pbDetect1.Size = new System.Drawing.Size(200, 200);
            this.pbDetect1.TabIndex = 2;
            this.pbDetect1.TabStop = false;
            // 
            // pbDetect5
            // 
            this.pbDetect5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect5.Location = new System.Drawing.Point(209, 209);
            this.pbDetect5.Name = "pbDetect5";
            this.pbDetect5.Size = new System.Drawing.Size(200, 200);
            this.pbDetect5.TabIndex = 6;
            this.pbDetect5.TabStop = false;
            // 
            // pbDetect6
            // 
            this.pbDetect6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect6.Location = new System.Drawing.Point(415, 209);
            this.pbDetect6.Name = "pbDetect6";
            this.pbDetect6.Size = new System.Drawing.Size(200, 200);
            this.pbDetect6.TabIndex = 7;
            this.pbDetect6.TabStop = false;
            // 
            // pbDetect8
            // 
            this.pbDetect8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect8.Location = new System.Drawing.Point(209, 415);
            this.pbDetect8.Name = "pbDetect8";
            this.pbDetect8.Size = new System.Drawing.Size(200, 200);
            this.pbDetect8.TabIndex = 9;
            this.pbDetect8.TabStop = false;
            // 
            // pbDetect9
            // 
            this.pbDetect9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect9.Location = new System.Drawing.Point(415, 415);
            this.pbDetect9.Name = "pbDetect9";
            this.pbDetect9.Size = new System.Drawing.Size(200, 200);
            this.pbDetect9.TabIndex = 10;
            this.pbDetect9.TabStop = false;
            // 
            // pbDetect11
            // 
            this.pbDetect11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect11.Location = new System.Drawing.Point(209, 621);
            this.pbDetect11.Name = "pbDetect11";
            this.pbDetect11.Size = new System.Drawing.Size(200, 200);
            this.pbDetect11.TabIndex = 12;
            this.pbDetect11.TabStop = false;
            // 
            // pbDetect12
            // 
            this.pbDetect12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect12.Location = new System.Drawing.Point(415, 621);
            this.pbDetect12.Name = "pbDetect12";
            this.pbDetect12.Size = new System.Drawing.Size(200, 200);
            this.pbDetect12.TabIndex = 13;
            this.pbDetect12.TabStop = false;
            // 
            // btnDectect
            // 
            this.btnDectect.Location = new System.Drawing.Point(551, 521);
            this.btnDectect.Name = "btnDectect";
            this.btnDectect.Size = new System.Drawing.Size(75, 41);
            this.btnDectect.TabIndex = 3;
            this.btnDectect.Text = "Detect";
            this.btnDectect.UseVisualStyleBackColor = true;
            this.btnDectect.Click += new System.EventHandler(this.btnDectect_Click);
            // 
            // tlpDisplay
            // 
            this.tlpDisplay.AutoScroll = true;
            this.tlpDisplay.AutoSize = true;
            this.tlpDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDisplay.ColumnCount = 2;
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDisplay.Controls.Add(this.pictureBox1, 0, 1);
            this.tlpDisplay.Controls.Add(this.txtImagePath, 0, 0);
            this.tlpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplay.Location = new System.Drawing.Point(3, 3);
            this.tlpDisplay.Name = "tlpDisplay";
            this.tlpDisplay.RowCount = 2;
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDisplay.Size = new System.Drawing.Size(542, 512);
            this.tlpDisplay.TabIndex = 12;
            // 
            // nupMinNeighbour
            // 
            this.nupMinNeighbour.Location = new System.Drawing.Point(273, 3);
            this.nupMinNeighbour.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupMinNeighbour.Name = "nupMinNeighbour";
            this.nupMinNeighbour.Size = new System.Drawing.Size(44, 20);
            this.nupMinNeighbour.TabIndex = 10;
            this.nupMinNeighbour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupMinNeighbour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nupScale
            // 
            this.nupScale.DecimalPlaces = 2;
            this.nupScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupScale.Location = new System.Drawing.Point(408, 3);
            this.nupScale.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.nupScale.Name = "nupScale";
            this.nupScale.Size = new System.Drawing.Size(44, 20);
            this.nupScale.TabIndex = 11;
            this.nupScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupScale.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tlpMain.Controls.Add(this.tlpParameter, 0, 1);
            this.tlpMain.Controls.Add(this.tlpFound, 1, 0);
            this.tlpMain.Controls.Add(this.btnDectect, 1, 1);
            this.tlpMain.Controls.Add(this.tlpDisplay, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1198, 588);
            this.tlpMain.TabIndex = 9;
            // 
            // tlpParameter
            // 
            this.tlpParameter.ColumnCount = 4;
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpParameter.Controls.Add(this.nupMinNeighbour, 2, 0);
            this.tlpParameter.Controls.Add(this.nupScale, 3, 0);
            this.tlpParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpParameter.Location = new System.Drawing.Point(3, 521);
            this.tlpParameter.Name = "tlpParameter";
            this.tlpParameter.RowCount = 1;
            this.tlpParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParameter.Size = new System.Drawing.Size(542, 44);
            this.tlpParameter.TabIndex = 14;
            // 
            // txtImagePath
            // 
            this.tlpDisplay.SetColumnSpan(this.txtImagePath, 2);
            this.txtImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImagePath.Location = new System.Drawing.Point(3, 3);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(536, 20);
            this.txtImagePath.TabIndex = 3;
            // 
            // pbDetect13
            // 
            this.pbDetect13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect13.Location = new System.Drawing.Point(3, 827);
            this.pbDetect13.Name = "pbDetect13";
            this.pbDetect13.Size = new System.Drawing.Size(200, 200);
            this.pbDetect13.TabIndex = 14;
            this.pbDetect13.TabStop = false;
            // 
            // pbDetect14
            // 
            this.pbDetect14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect14.Location = new System.Drawing.Point(209, 827);
            this.pbDetect14.Name = "pbDetect14";
            this.pbDetect14.Size = new System.Drawing.Size(200, 200);
            this.pbDetect14.TabIndex = 15;
            this.pbDetect14.TabStop = false;
            // 
            // pbDetect15
            // 
            this.pbDetect15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDetect15.Location = new System.Drawing.Point(415, 827);
            this.pbDetect15.Name = "pbDetect15";
            this.pbDetect15.Size = new System.Drawing.Size(200, 200);
            this.pbDetect15.TabIndex = 16;
            this.pbDetect15.TabStop = false;
            // 
            // FaceDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 588);
            this.Controls.Add(this.tlpMain);
            this.Name = "FaceDetectionForm";
            this.Text = "Face Detection App";
            this.Load += new System.EventHandler(this.FaceDetectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect12)).EndInit();
            this.tlpDisplay.ResumeLayout(false);
            this.tlpDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinNeighbour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupScale)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpParameter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetect15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tlpDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpFound;
        private System.Windows.Forms.PictureBox pbDetect10;
        private System.Windows.Forms.PictureBox pbDetect7;
        private System.Windows.Forms.PictureBox pbDetect4;
        private System.Windows.Forms.PictureBox pbDetect3;
        private System.Windows.Forms.PictureBox pbDetect2;
        private System.Windows.Forms.PictureBox pbDetect1;
        private System.Windows.Forms.PictureBox pbDetect5;
        private System.Windows.Forms.PictureBox pbDetect6;
        private System.Windows.Forms.PictureBox pbDetect8;
        private System.Windows.Forms.PictureBox pbDetect9;
        private System.Windows.Forms.PictureBox pbDetect11;
        private System.Windows.Forms.PictureBox pbDetect12;
        private System.Windows.Forms.Button btnDectect;
        private System.Windows.Forms.NumericUpDown nupMinNeighbour;
        private System.Windows.Forms.NumericUpDown nupScale;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpParameter;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.PictureBox pbDetect15;
        private System.Windows.Forms.PictureBox pbDetect14;
        private System.Windows.Forms.PictureBox pbDetect13;
    }
}

